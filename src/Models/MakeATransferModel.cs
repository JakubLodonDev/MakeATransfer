using System.ComponentModel.DataAnnotations;

namespace WebApplicationForTests.Models
{
    public class MakeATransferModel
    {
        public string Title { get; set; }
        public string SenderAccountNumber { get; set; }
        public string RecipientAccountNumber { get; set; }
        
        [Required]
        public long Amount { get; set; }
    }
}