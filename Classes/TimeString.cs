using System.Text.RegularExpressions;

namespace BerlinClock.Classes
{
    class TimeString : ITime
    {
        private string time { get; set; }
        public TimeString (string time)
        {
            this.time = time;
        }

        private sbyte getPartOfTime(string part)
        {
            string partStr = Regex.Replace(time, "([0-9]{2}):([0-9]{2}):([0-9]{2})", part);

            if (!sbyte.TryParse(partStr, out sbyte result))
            {
                return 0;
            }

            return result;
        }

        public sbyte getHours()
        {
            return getPartOfTime("$1");
        }

        public sbyte getMinutes()
        {
            return getPartOfTime("$2");
        }

        public sbyte getSeconds()
        {
            return getPartOfTime("$3");
        }
    }
}
