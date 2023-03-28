using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
         Clock c = new Clock();
            AnalogClockcs ac = new AnalogClockcs();
            DigitalClock dc = new DigitalClock();
            c.OnSecondChange += new Clock.SecondHandler(ac.ShowAC);
            c.OnSecondChange += new Clock.SecondHandler(dc.ShowDC);
            c.Run();
        }
    }
}
