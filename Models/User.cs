using System.ComponentModel.DataAnnotations;

namespace LoanManagementAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(20)]
        public string Username { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Range(0, double.MaxValue)]
        public double MonthlyIncome { get; set; }

        public bool IsBlocked { get; set; } = false;

        [Required]
        public string Password { get; set; } // Password will be hashed.
    }
}
