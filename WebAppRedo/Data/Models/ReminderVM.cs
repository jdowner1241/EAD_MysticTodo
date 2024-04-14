using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppRedo.Data.Models
{

    public class ReminderVM
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Active")]
        public bool IsComplete { get; set; }

        [Display(Name = "Alarm Active")]
        public bool? HasAlarms { get; set; }

        public DateTime? Alarm { get; set; }

        [Display(Name = "Alarm Repeated")]
        public bool? Periodic { get; set; }

        [Display(Name = "Frequency")]
        public TimeFrame TimeFrameSelection { get; set; }

        [Display(Name = "Next Alarm")]
        public DateTime? PeriodicTime { get; set; }

        public string? UserId { get; set; }

    }
}
