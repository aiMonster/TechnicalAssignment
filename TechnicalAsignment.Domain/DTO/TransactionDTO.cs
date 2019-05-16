using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using TechnicalAsignment.Data;
using TechnicalAsignment.Domain.Helpers;

namespace TechnicalAsignment.Domain.DTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StatusType Status { get; set; }
    }
}
