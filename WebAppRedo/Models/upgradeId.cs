using System.ComponentModel.DataAnnotations;

namespace WebAppRedo.Models
{
    public class upgradeId
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter a Task Name")]
        public string name { get; set; }

        public string description { get; set; } = string.Empty;

        public Boolean isActived { get; set; }

        public Boolean hasAlarms { get; set; }

        public DateTime? alarmTime { get; set; } 
        public DateTime? alarmDate { get; set; } 

        public Boolean periodic { get; set; }

        public DateTime? periodicDate {  get; set; } 
        public DateTime? periodicTime { get;set; } 


        /*private Boolean hasAlarm = false;
        private DateTime? alarmTime;

        public void getAlarmTime() { }
        public void setAlarmTime()
        {
            if (hasAlarm == true)
            {
                
            }
                  
        }*/



    }
}