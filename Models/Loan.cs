using System.ComponentModel.DataAnnotations;

namespace LoanManagementAPI.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public string Status { get; set; } // e.g., "Pending", "Approved", "Rejected"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
