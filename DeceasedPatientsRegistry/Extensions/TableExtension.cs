using static DeceasedPatientsRegistry.Domain.Enums;

namespace DeceasedPatientsRegistry.Extensions
{
    public static class TableExtension
    {
        private static readonly DateTime _datetime = DateTime.Now;
        public static string GetRowColor(AutopsyType value)
        {
            if (value == AutopsyType.ПАО)
                return "table-success";
            if (value == AutopsyType.СМЭ)
                return "table-primary";
            return "table-light";
        }
        public static string GetArchiveCellColor(AutopsyType type, DateTime? dateTime, DateTime? archivedDate)
        {
            if ((archivedDate == null) && (dateTime != null))
                if (((type == AutopsyType.ПАО) && ((_datetime - dateTime)?.TotalDays > 30))
                    || ((type == AutopsyType.Нет) && ((_datetime - dateTime)?.TotalDays > 3)))
                    return "table-danger";
            return "";
        }
    }
}
