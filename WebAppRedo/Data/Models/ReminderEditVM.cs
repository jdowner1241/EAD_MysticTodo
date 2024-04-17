using System.ComponentModel.DataAnnotations;

namespace WebAppRedo.Data.Models
{
    public class ReminderEditVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        [Display(Name = "Alarm Active")]
        public bool HasAlarms { get; set; }

        /*[Display(Name = "Alarm Active")]
        public bool HasAlarms 
        {
            get
            {
              *//*  if (HasAlarms == true)
                {
                    return true;
                }
                else if (HasAlarms == false)
                {
                    Alarm = null;
                    return false;
                }*//*
                // Add a default case (e.g., return false) if needed
                Alarm = null;
                return true;
            }
    
        }*/


        public DateTime? Alarm { get; set; }

       /* public DateTime? Alarm
        {
            get
            {
                if (HasAlarms == true)
                {
                    return Alarm;
                }
                else
                {
                    return null;
                }
            }
          
        }*/
       


                [Display(Name = "Alarm Repeats")]
        public bool Periodic { get; set; }


        /*[Display(Name = "Alarm Repeats")]
        public bool Periodic
        {
            get
            {
                if (!Periodic)
                {
                    TimeFrameSelection = TimeFrame.NotSet;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            set 
            { 
            
            }
        }*/


        [Display(Name = "Frequency")]
        public TimeFrame TimeFrameSelection {get; set; }

        [Display(Name = "Next Alarm")]
        public DateTime? PeriodicAlarm { get; set; }

    }
}
