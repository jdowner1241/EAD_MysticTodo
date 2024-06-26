﻿using System.ComponentModel.DataAnnotations;

namespace WebAppRedo.Data.Models
{
    public class ReminderDeleteVM
    {

        public int Id { get; set; }

        [Display(Name = "Reminder Title")]
        public string Name { get; set; }


        public string? Description { get; set; }


        [Display(Name = "Alarm Active")]
        public bool HasAlarms { get; set; } = false;

        public DateTime? Alarm { get; set; }

        [Display(Name = "Alarm Repeats")]
        public bool Periodic { get; set; } = false;

        [Display(Name = "Frequency")]
        public TimeFrame TimeFrameSelection { get; set; }

        [Display(Name = "Next Alarm")]
        public DateTime? PeriodicAlarm { get; set; }
        
        [Display(Name = "User")]
        public string? UserId { get; set; }
    }
}
