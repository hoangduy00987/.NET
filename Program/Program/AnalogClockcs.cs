using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class AnalogClockcs
    {
        public void ShowAC(object o,TimeEvemtArgs e)
        {
           
            Console.WriteLine("AC:{0}:{1}:{2}:{3}",
                e.Timer.Hour,e.Timer.Minute,e.Timer.Second,e.Timer.Millisecond);

        }
    }
}
