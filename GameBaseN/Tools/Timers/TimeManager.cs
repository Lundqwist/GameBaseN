using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tools
{
    class TimeManager
    {
        static Timers firstTimer;
        

        public TimeManager()
        {
            firstTimer = null;
        }

        public static bool AddTimer(string nameOfTimer, int startValue)
        {
            Timers tmpTimer = new Timers(nameOfTimer, startValue);
            Timers stepTimer = firstTimer;

            if (firstTimer != null)
            {
                while (stepTimer.NextTimer != null)
                {
                    if(stepTimer.TimerName != nameOfTimer)
                    {
                        stepTimer = stepTimer.NextTimer;
                    }
                    else
                    {
                        return false;
                    }
                }
                stepTimer.NextTimer = tmpTimer;
            }
            else
            {
                firstTimer = tmpTimer;
            }
            return true;
        }

        public static int GetTime(string nameOfTimer)
        {
            Timers stepTimer = firstTimer;

            while(stepTimer.TimerName != nameOfTimer && stepTimer != null)
            {
                stepTimer = stepTimer.NextTimer;
            }

            if(stepTimer != null)
            {
                return stepTimer.TimerValue;
            }
            else
            {
                return 0;
            }
        }

        public static void UpdateTimers(GameTime gameTime)
        {
            Timers stepTimer = firstTimer;

            while(stepTimer != null)
            {
                stepTimer.TimerValue += gameTime.ElapsedGameTime.Milliseconds;
                stepTimer = stepTimer.NextTimer;
            }
        }

        public static bool SetTimer(string nameOfTimer, int value)
        {
            Timers stepTimer = firstTimer;
            while(stepTimer.TimerName != nameOfTimer && stepTimer != null)
            {
                stepTimer = stepTimer.NextTimer;
            }

            if(stepTimer != null)
            {
                stepTimer.TimerValue = value;
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
