using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppRedo.Data;
using WebAppRedo.Data.Models;

namespace WebAppRedo.Controllers
{
    public class RemindersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IMapper mapper;

        public RemindersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Reminders
        public async Task<IActionResult> Index()
        {
            var reminders = mapper.Map<List<ReminderVM>>(await _context.Reminders.ToListAsync());
            return View(reminders);
        }

        // GET: Reminders/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reminder == null)
            {
                return NotFound();
            }

            var reminderDetailsVM = mapper.Map<ReminderDetailsVM>(reminder);
            return View(reminderDetailsVM);
        }

        // GET: Reminders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reminders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReminderAddVM reminderAddVM)
        {
            if (ModelState.IsValid)
            {

                if (reminderAddVM.HasAlarms == true)
                {
                    if (reminderAddVM.Periodic == true)
                    {
                        switch (reminderAddVM.TimeFrameSelection)
                        {
                            case TimeFrame.Daily:
                               reminderAddVM.PeriodicAlarm = reminderAddVM.Alarm?.AddDays(1);
                                break;
                            case TimeFrame.Weekly:
                                reminderAddVM.PeriodicAlarm = reminderAddVM.Alarm?.AddDays(7);
                                break;
                            case TimeFrame.Monthly:
                                reminderAddVM.PeriodicAlarm = reminderAddVM.Alarm?.AddMonths(1);
                                break;
                            case TimeFrame.Yearly:
                                reminderAddVM.PeriodicAlarm = reminderAddVM.Alarm?.AddYears(1);
                                break;
                            default:
                                reminderAddVM.PeriodicAlarm =  null;
                                break;
                        }
                    }
                    else
                    {
                        reminderAddVM.TimeFrameSelection = TimeFrame.NotSet;
                        reminderAddVM.PeriodicAlarm = null;
                        reminderAddVM.Periodic = false;
                    }
                }
                else
                {
                    reminderAddVM.Alarm = null;
                    reminderAddVM.Periodic = false;
                    reminderAddVM.PeriodicAlarm = null;
                    reminderAddVM.TimeFrameSelection = TimeFrame.NotSet;
                }


                var reminder = mapper.Map<Reminder>(reminderAddVM);
                _context.Add(reminder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reminderAddVM);
        }

        // GET: Reminders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminders.FindAsync(id);
            if (reminder == null)
            {
                return NotFound();
            }

            var reminderEditVM = mapper.Map<ReminderEditVM>(reminder);
            return View(reminderEditVM);
        }

        // POST: Reminders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ReminderEditVM reminderEditVM)
        {
            if (id != reminderEditVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {


                    if (reminderEditVM.HasAlarms == true)
                    {
                        if (reminderEditVM.Periodic == true)
                        {
                            switch (reminderEditVM.TimeFrameSelection)
                            {
                                case TimeFrame.Daily:
                                    reminderEditVM.PeriodicAlarm = reminderEditVM.Alarm?.AddDays(1);
                                    break;
                                case TimeFrame.Weekly:
                                    reminderEditVM.PeriodicAlarm = reminderEditVM.Alarm?.AddDays(7);
                                    break;
                                case TimeFrame.Monthly:
                                    reminderEditVM.PeriodicAlarm = reminderEditVM.Alarm?.AddMonths(1);
                                    break;
                                case TimeFrame.Yearly:
                                    reminderEditVM.PeriodicAlarm = reminderEditVM.Alarm?.AddYears(1);
                                    break;
                                default:
                                    reminderEditVM.PeriodicAlarm = null;
                                    break;
                            }
                        }
                        else
                        {
                            reminderEditVM.TimeFrameSelection = TimeFrame.NotSet;
                            reminderEditVM.PeriodicAlarm = null;
                            reminderEditVM.Periodic = false;
                        }
                    }
                    else
                    {
                        reminderEditVM.Alarm = null;
                        reminderEditVM.Periodic = false;
                        reminderEditVM.PeriodicAlarm = null;
                        reminderEditVM.TimeFrameSelection = TimeFrame.NotSet;
                    }




                    var reminder = mapper.Map<Reminder>(reminderEditVM);
                    _context.Update(reminder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReminderExists(reminderEditVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reminderEditVM);
        }

        // GET: Reminders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reminder == null)
            {
                return NotFound();
            }

            return View(reminder);
        }

        // POST: Reminders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reminder = await _context.Reminders.FindAsync(id);
            if (reminder != null)
            {
                _context.Reminders.Remove(reminder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReminderExists(int id)
        {
            return _context.Reminders.Any(e => e.Id == id);
        }

    }
}

    //public async Task<IActionResult> Edit(int? id)
    //{
    //    if (id == null)
    //    {
    //        return NotFoundResult();
    //    }

    //    var reminder = await _context.Reminders.FindAsync(id);
    //    if (reminder == null)
    //    {
    //        return NotFound();
    //    }

    //    var editViewModel = new EditReminderViewModel
    //    {
    //        Id = reminder.Id,
    //        Name = reminder.Name,
    //        Description = reminder.Description,
    //        IsComplete = reminder.IsComplete,
    //        HasAlarms = reminder.HasAlarms,
    //        AlarmDate = reminder.AlarmDate,
    //        AlarmTime = reminder.AlarmTime,
    //        Periodic = reminder.Periodic,
    //        TimeFramesId = reminder.TimeFramesId,
    //        PeriodicDate = reminder.PeriodicDate,
    //        PeriodicTime = reminder.PeriodicTime
    //    };

    //    return View(editViewModel);
    //}

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Edit(int id, EditReminderViewModel model)
    //{
    //    if (id != model.Id)
    //    {
    //        return NotFound();
    //    }

    //    if (ModelState.IsValid)
    //    {
    //        try
    //        {
    //            var reminder = await _context.Reminders.FindAsync(id);
    //            if (reminder == null)
    //            {
    //                return NotFound();
    //            }

    //            // Update the reminder entity with data from the view model
    //            reminder.Name = model.Name;
    //            reminder.Description = model.Description;
    //            reminder.IsComplete = model.IsComplete;
    //            reminder.HasAlarms = model.HasAlarms;
    //            reminder.AlarmDate = model.AlarmDate;
    //            reminder.AlarmTime = model.AlarmTime;
    //            reminder.Periodic = model.Periodic;
    //            reminder.TimeFramesId = model.TimeFramesId;
    //            reminder.PeriodicDate = model.PeriodicDate;
    //            reminder.PeriodicTime = model.PeriodicTime;

    //            _context.Update(reminder);
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!ReminderExists(model.Id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }
    //        return RedirectToAction(nameof(Index));
    //    }







    //}

   