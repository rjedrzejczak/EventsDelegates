using System;

namespace EventsDelegates
{
    public class Car
    {
        public event Action OnChange;
        
        private double speed;
        public double Speed {
            get
            {
                return speed;
            }
            set
            {
                speed = value;

                if (speed > 60)
                {
                    if (OnChange != null)
                    {
                        OnChange();
                    }
                }
            }
        }
    }
}