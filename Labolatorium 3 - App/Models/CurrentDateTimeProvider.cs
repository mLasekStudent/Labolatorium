namespace Labolatorium_3___App.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime() => DateTime.Now;
    }
}
