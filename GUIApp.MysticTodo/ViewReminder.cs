using GUIApp.MysticTodo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp.MysticTodo
{
    public partial class formViewReminder : Form
    {
        private readonly MysticToDoEntities1 mysticTodoDatabase;

        public formViewReminder()
        {
            InitializeComponent();
            mysticTodoDatabase = new MysticToDoEntities1();
        }

        public formViewReminder(int Id)
        {
            InitializeComponent();
            mysticTodoDatabase = new MysticToDoEntities1();
            Form form = Application.OpenForms["formViewReminder"];

            if (form != null)
            {
               form.Close();
               //refreshViewer(Id);
            }
            refreshViewer(Id);


        }

        private void formViewReminder_Load(object sender, EventArgs e)
        {

        }

        private void refreshViewer(int Id)
        {
            //
            var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == Id);
            if (reminder != null)
            {
                populateViewer(reminder);
            }
        }


        private void populateViewer(Reminder reminder)
        {

            lIdViewer.Text = reminder.Reminder_Id.ToString();
            tbReminderViewer.Text = reminder.Reminder_Name.ToString();
            if(reminder.Reminder_Description != null)
            {
                tbDescriptionViewer.Text = reminder.Reminder_Description.ToString();
            }else
            {
                lDescriptionViewer.Hide();
                tbDescriptionViewer.Hide();
            }

            if(reminder.Reminder_HasAlarm == true)
            {
                DateTime alarmDate = reminder.Reminder_Date.Value;
                tbAlarmDateViewer.Text = alarmDate.ToString("dddd, dd MMMM yyyy");
                tbAlarmDateViewer.ReadOnly = true;

                DateTime alarmTime = (DateTime)reminder.Reminder_Time;
                string formatedAlarmTime = alarmTime.ToString("hh:mm tt");
                tbAlarmTimeViewer.Text = formatedAlarmTime;
                tbAlarmTimeViewer.ReadOnly = true;

                if (reminder.Reminder_IsPeriodic == true)
                {
                    DateTime periodDate = reminder.Reminder_NextPeriodicDate.Value;
                    tbPeriodicDateViewer.Text = periodDate.ToString("dddd, dd MMMM yyyy");
                    tbPeriodicDateViewer.ReadOnly = true;

                    DateTime periodicTime = (DateTime)reminder.Reminder_Time;
                    string formatedPeriodicTime = periodicTime.ToString("hh:mm tt");
                    tbPeriodicTimeViewer.Text = formatedPeriodicTime;
                    tbPeriodicTimeViewer.ReadOnly = true;

                    tbPeriodicViewer.Text = reminder.Timeframe.Timeframe_Name;
                    tbPeriodicViewer.ReadOnly = true;
                }
                else
                {
                    lPeriodicViewer.Hide();
                    lNextAlarmViewer.Hide();
                    tbPeriodicDateViewer.Hide();
                    //dtpPeriodicTimeViewer.Hide();
                    tbPeriodicTimeViewer.Hide();
                    tbPeriodicViewer.Hide();
                }
            }else
            {
                lAlarmViewer.Hide();
                tbAlarmDateViewer.Hide();
                //dtpAlarmTimeViewer.Hide();
                tbAlarmTimeViewer.Hide();

                lPeriodicViewer.Hide();
                lNextAlarmViewer.Hide();
                tbPeriodicDateViewer.Hide();
                //dtpPeriodicTimeViewer.Hide();
                tbPeriodicTimeViewer.Hide();
                tbPeriodicViewer.Hide();
            }

        }

    }
}
