using System.ComponentModel.DataAnnotations;

namespace TechnicalAsignment.Domain.Requests
{
    public class InquiryCriteriaRequest
    {        
        [Range(0, 9999999999, ErrorMessage = "Invalid Customer ID")]
        public long? CustomerId { get; set; }

        [MaxLength(25, ErrorMessage = "Invalid Email")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
