using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event title is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Event date is required.")]
        public DateTime? Date { get; set; } = DateTime.Now.AddDays(7);

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = string.Empty;

        [Range(1, 1000, ErrorMessage = "Capacity must be between 1 and 1000.")]
        public int MaxCapacity { get; set; } = 50;

        public int CurrentAttendees { get; set; } = 0;

        public bool IsActive { get; set; } = true;

        public int AvailableSpots => MaxCapacity - CurrentAttendees;
    }
}
