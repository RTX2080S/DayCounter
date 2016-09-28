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
        private int forward = 1;

        private Label myLabel;

        public Timer GetTimer(Label targetLabel)
        {
            myLabel = targetLabel;
            Timer myTimer = new Timer();
            myTimer.Tick += MyTimer_Tick;

            return myTimer;
        }

        private int getInterval(int r)
        {
            if (r <= 150)
                return 15;
            if ((r > 150) || (r <= 225))
                return 25;
            if (r > 225)
                return 90;
            return 100;
        }

        private void getParams(out int interval, out Color itemColor)
        {
            r += (rInc * forward);
            interval = getInterval(r);
            itemColor = Color.FromArgb(r, 0, 0);

            if ((r == maxR) || (r == minR))
                forward *= -1;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            int tmpInterval;
            Color tmpColor;
            getParams(out tmpInterval, out tmpColor);
            Timer myTimer = (Timer)sender;
            myTimer.Interval = tmpInterval;
            myLabel.ForeColor = tmpColor;
        }
    }
}
