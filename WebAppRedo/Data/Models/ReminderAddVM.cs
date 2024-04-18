using System.ComponentModel.DataAnnotations;

namespace WebAppRedo.Data.Models
{
    public class ReminderAddVM
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Reminder Title")]
        public string Name { get; set; }


        public string? Description { get; set; }

        [Display(Name = "Alarm Active")]
        public bool HasAlarms { get; set; }

        /* public DateTime? Alarm 
         {
             get
             {
                 return Alarm;
             } 
             set
             {
                *//* if (!HasAlarms)
                 {
                     throw new InvalidOperationException("Alarm must be active (HasAlarms set to true) before setting PeriodicAlarm.");
                 }*//*
             }
         }*/

        public DateTime? Alarm {  get; set; }


        [Display(Name = "Alarm Repeats")]
        public bool Periodic { get; set; }

        [Display(Name = "Frequency")]
        public TimeFrame TimeFrameSelection { get; set; }

        [Display(Name = "Next Alarm")]
        public DateTime? PeriodicAlarm
        {
            get
            {
                switch (TimeFrameSelection)
                {
                    case TimeFrame.Daily:
                        return Alarm?.AddDays(1);
                    case TimeFrame.Weekly:
                        return Alarm?.AddDays(7);
                    case TimeFrame.Monthly:
                        return Alarm?.AddMonths(1);
                    case TimeFrame.Yearly:
                        return Alarm?.AddYears(1);
                    default:
                        return null;
                }
            }
            /*set
            {
                *//*if (Periodic && value != null)
                {
                    // Additional validation logic if needed
                    if (!HasAlarms)
                    {
                        throw new InvalidOperationException("Alarm must be active first.");
                    }
                    // Set the PeriodicAlarm value
                    // ...
                }
                else
                {
                    throw new InvalidOperationException("PeriodicAlarm requires Periodic to be true.");
                }*//*
            }*/
        }
    }

}
