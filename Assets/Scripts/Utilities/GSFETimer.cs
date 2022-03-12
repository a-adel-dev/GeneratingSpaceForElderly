using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSFE.Utilities
{
    public class GSFETimer
    {
        public float TimerValue { get; private set; }

        public GSFETimer(float time)
        {
            TimerValue = time;
        }

        public void SetTimer(float value)
        {
            TimerValue = value;
        }

        public void CountDown(float value)
        {
            if (TimerValue > 0)
            {
                TimerValue -= value;
            }
        }

        public bool Finished()
        {
            return  TimerValue <= 0;
        }
    }
}
