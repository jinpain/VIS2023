namespace SharedExtensions
{
    public static class DateTimeExtension
    {
        public static string ToShortDateStringOrEmpty(this DateTime? date) =>
               date.HasValue ? date.Value.ToShortDateString() : string.Empty;

        public static string ToShortTimeStringOrEmpty(this DateTime? date) =>
            date.HasValue ? date.Value.ToShortDateString() : string.Empty;

        public static string ToDateTimeFormatStringOrEmpty(this DateTime? date, string format) =>
            date.HasValue ? date.Value.ToString(format) : string.Empty;
    }
}
