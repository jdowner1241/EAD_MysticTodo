using AutoMapper;
using WebAppRedo.Data.Models;

namespace WebAppRedo.Configuration
{
    public class Mapperconfig : Profile
    {

        public Mapperconfig()
        {
            CreateMap<Reminder, ReminderVM>().ReverseMap();
            CreateMap<Reminder, ReminderAddVM>().ReverseMap();
            CreateMap<Reminder, ReminderEditVM>().ReverseMap();
            CreateMap<Reminder, ReminderDetailsVM>().ReverseMap();
        }
    }
}
