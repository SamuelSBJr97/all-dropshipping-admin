namespace DropshippingAdmin.Core.Shared.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime UtcNow() => DateTime.UtcNow;
        public static bool IsWeekend(DateTime date) => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}
