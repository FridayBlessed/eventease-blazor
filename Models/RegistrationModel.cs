using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an event.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid event.")]
        public int EventId { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.Now;
    }
}
