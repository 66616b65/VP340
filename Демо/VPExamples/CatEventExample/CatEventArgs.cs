using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatEventExample
{
    public class CatWokeUpEventArgs : EventArgs
    {
        public int HoursCount { get; }

        public CatWokeUpEventArgs(int hoursCount)
        {
            HoursCount = hoursCount;
        }
    }

    public class CatAteEventArgs : EventArgs
    {
        public DateTime Time { get; }

        public CatAteEventArgs(DateTime time)
        {
            Time = time;
        }
    }
}
