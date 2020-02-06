using BerlinClock.Classes;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            ITime time = new TimeString(aTime);

            IBerlinClock berlinClock = new BerlinClock.Classes.BerlinClock(time);
            
            string result = berlinClock.getSeconds() + "\r\n"
                + berlinClock.getHoursTimes5() + "\r\n"
                + berlinClock.GetHoursTimes1() + "\r\n"
                + berlinClock.getMinutesTimes5() + "\r\n"
                + berlinClock.GetMinutsTimes1();

            return result;
        }
    }
}
