namespace WebAppRedo.Data.Models
{
    public class EditReminderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public bool HasAlarms { get; set; }
        public DateTime AlarmDate { get; set; }
        public TimeSpan AlarmTime { get; set; }
        public bool Periodic { get; set; }
        public int TimeFramesId { get; set; }
        public DateTime PeriodicDate { get; set; }
        public TimeSpan PeriodicTime { get; set; }
    }
}
