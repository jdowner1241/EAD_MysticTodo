using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppRedo.Data.Models
{
    public enum TimeFrame
    {
        NotSet,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public class Reminder : BaseEntity
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public bool IsComplete { get; set; }

        public bool HasAlarms { get; set; } = false;

        public DateTime? Alarm { get; set; }

        public bool Periodic { get; set; } = false;

        public TimeFrame TimeFrameSelection {  get; set; }
  
        public DateTime? PeriodicAlarm { get; set; }

        public string? UserId { get; set; }

    }
}
