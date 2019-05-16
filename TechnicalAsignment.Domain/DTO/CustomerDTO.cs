using System.Collections.Generic;

namespace TechnicalAsignment.Domain.DTO
{
    public class CustomerDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long? Mobile { get; set; }
        
        public virtual ICollection<TransactionDTO> Transactions { get; set; }
    }
}
