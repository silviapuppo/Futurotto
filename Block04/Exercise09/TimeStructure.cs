using System;

namespace Exercise09
{
    public struct Time
    {
        private readonly int minutes;

        public int Hour
        {
            get
            {
                return minutes / 60;
            }
            private set
            {
            }
        }

        public int Minute
        {
            get
            {
                return minutes % 60;
            }
            private set
            {
            }
        }

        public Time(int hh, int mm)
        {
            minutes = 60 * hh + mm;
        }

        public override String ToString()
        {
            return Hour.ToString() + ':' + Minute.ToString();
        }

        public static Time operator +(Time a, Time b)
        {
            int sumMinutes = (a.minutes + b.minutes) % 1440;

            return new Time(sumMinutes / 60, sumMinutes % 60);
        }

        public static Time operator -(Time a, Time b)
        {
            int diffMinutes = (a.minutes > b.minutes ? a.minutes - b.minutes : 1440 + (a.minutes - b.minutes));

            return new Time(diffMinutes / 60, diffMinutes % 60);
        }

        public static implicit operator Time(int a)
        {
            return new Time(a / 60, a % 60);
        }

        public static explicit operator int(Time a)
        {
            return a.Hour * 60 + a.Hour + a.Minute;
        }

    }
    public class TimeStructure
    {
    }
}
