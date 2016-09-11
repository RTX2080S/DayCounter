using DayCounter.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayCounter.Controllers
{
    class FlashingLabelController : IFlashingLabelController
    {
        private const int minR = 0;
        private const int maxR = 255;
        private const int rInc = 5;
        private int r = minR;
        private bool forward = true;

        private Label myLabel;

        public Timer GetTimer(Label targetLabel)
        {
            myLabel = targetLabel;
            Timer myTimer = new Timer();
            myTimer.Tick += MyTimer_Tick;

            return myTimer;
        }

        private int getFlashingInterval(int r)
        {
            if (r <= 150) return (15);
            if ((r > 150) || (r <= 225)) return (25);
            if (r > 225) return (90);
            return (100);
        }

        private void refreshFlashingParams(ref int interval, ref Color itemColor)
        {
            if (forward) r += rInc; else r -= rInc;
            interval = getFlashingInterval(r);
            itemColor = Color.FromArgb(r, 0, 0);
            if (r == maxR) forward = false;
            if (r == minR) forward = true;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Timer myTimer = (Timer)sender;
            int tmpInterval = 0;
            Color tmpColor = Color.Red;
            refreshFlashingParams(ref tmpInterval, ref tmpColor);
            myTimer.Interval = tmpInterval;
            myLabel.ForeColor = tmpColor;
        }
    }
}
