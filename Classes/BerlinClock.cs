using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    class BerlinClock : IBerlinClock
    {
        private ITime time { get; set; }
        public BerlinClock(ITime time)
        {
            this.time = time;
        }

        public string getSeconds()
        {
            bool isSecondEven = time.getSeconds() % 2 == 0;

            if (isSecondEven) return "Y";
            return "O";
        }

        public string getHoursTimes5()
        {
            string hourTimeBerlin = "OOOO";

            int hoursTimes5 = time.getHours() / 5;

            for(int i = 0; i < hoursTimes5; ++i) {
                hourTimeBerlin = "R" + hourTimeBerlin;
            }

            hourTimeBerlin = hourTimeBerlin.Substring(0, 4);

            return hourTimeBerlin;
        }

        public string GetHoursTimes1()
        {
            string hourTimeBerlin = "OOOO";

            int hoursTimes1 = time.getHours() % 5;

            for (int i = 0; i < hoursTimes1; ++i)
            {
                hourTimeBerlin = "R" + hourTimeBerlin;
            }

            hourTimeBerlin = hourTimeBerlin.Substring(0, 4);

            return hourTimeBerlin;
        }

        public string getMinutesTimes5()
        {
            string minuteTimeBerlin = "OOOOOOOOOOO";

            int minutesTimes5 = time.getMinutes() / 5;

            string minuteTimeBerlinAuxiliar = "";
            for (int i = 0; i < minutesTimes5; ++i)
            {
                string color = "Y";
                if ((i + 1) % 3 == 0) color = "R";

                minuteTimeBerlinAuxiliar += color;
            }

            minuteTimeBerlin = minuteTimeBerlinAuxiliar + minuteTimeBerlin;
            minuteTimeBerlin = minuteTimeBerlin.Substring(0, 11);

            return minuteTimeBerlin;
        }

        public string GetMinutsTimes1()
        {
            string minuteTimeBerlin = "OOOO";

            int minutesTimes1 = time.getMinutes() % 5;

            for (int i = 0; i < minutesTimes1; ++i)
            {
                minuteTimeBerlin = "Y" + minuteTimeBerlin;
            }

            minuteTimeBerlin = minuteTimeBerlin.Substring(0, 4);

            return minuteTimeBerlin;
        }
    }
}
