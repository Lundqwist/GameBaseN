using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class Timers
    {

        string timerName;
        int timerValue;

        Timers nextTimer;

        public Timers NextTimer
        {
            get
            {
                return nextTimer;
            }

            set
            {
                nextTimer = value;
            }
        }

        public string TimerName
        {
            get
            {
                return timerName;
            }

            set
            {
                timerName = value;
            }
        }

        public int TimerValue
        {
            get
            {
                return timerValue;
            }

            set
            {
                timerValue = value;
            }
        }

        public Timers(string name, int value)
        {
            nextTimer = null;
            timerName = name;
            timerValue = value;
        }





    }
}
