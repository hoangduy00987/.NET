using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class DigitalClock
    {
        public void ShowDC(object o,TimeEvemtArgs e)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("DC: {0}:{1}:{2}:{3}",
                d.Hour,d.Minute,d.Second,d.Millisecond);

        }
    }
}
