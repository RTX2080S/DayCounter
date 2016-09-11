using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayCounter.Interfaces
{
    interface IFlashingLabelController
    {
        Timer GetTimer(Label targetLabel);
    }
}
