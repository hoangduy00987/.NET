using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
  public class Clock
    {
        public delegate void SecondHandler(object o, TimeEvemtArgs e);
        public event SecondHandler OnSecondChange;
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if(OnSecondChange!= null)
                {
                    OnSecondChange(this, new TimeEvemtArgs());
                    Timer = DateTime.Now;
                }
            }
        }
    }
}
