using System;
using TechnicalAsignment.Data;

namespace TechnicalAsignment.Domain.DTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public StatusType Status { get; set; }
    }
}
