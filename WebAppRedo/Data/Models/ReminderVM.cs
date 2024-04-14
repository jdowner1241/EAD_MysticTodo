using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppRedo.Data.Models
{

    public class ReminderVM
    {
        [Display(Name = "Active")]
        public bool IsComplete { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? Alarm { get; set; }

        [Display(Name = "Frequency")]
        public TimeFrame TimeFrameSelection { get; set; }

        [Display(Name = "Next Alarm")]
        public DateTime? PeriodicAlarm { get; set; }

    }
}
