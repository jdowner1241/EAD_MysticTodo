using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppRedo.Data
{
    public class Reminder : BaseEntity
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public Boolean IsComplete { get; set; }

        public Boolean? HasAlarms { get; set; }

        public DateOnly? AlarmTime { get; set; }
        public TimeOnly? AlarmDate { get; set; }

        public Boolean? Periodic { get; set; }

        [ForeignKey("TimeFrameId")]
        public TimeFrame? TimeFrame { get; set; }
        public int? TimeFramesId { get; set; }

        public DateOnly? PeriodicDate { get; set; }
        public TimeOnly? PeriodicTime { get; set; }

        public string? UserId { get; set; }

    }
}
