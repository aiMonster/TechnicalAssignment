using Newtonsoft.Json.Converters;

namespace TechnicalAsignment.Domain.Helpers
{
    public class DateTimeConverter : IsoDateTimeConverter
    {
        public DateTimeConverter() 
        {
            DateTimeFormat = "dd/mm/yyyy hh:mm";
        }
    }
}
