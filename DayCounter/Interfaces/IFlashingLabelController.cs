using System.Windows.Forms;

namespace DayCounter.Interfaces
{
    interface IFlashingLabelController
    {
        Timer GetTimer(Label targetLabel);
    }
}
