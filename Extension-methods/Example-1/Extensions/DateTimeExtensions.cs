
namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime dt)
        {
            TimeSpan duration = DateTime.Now.Subtract(dt);
            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1") + " hours.";
            }
            return duration.Days.ToString("F1") + " days."; 
        }
    }
}
