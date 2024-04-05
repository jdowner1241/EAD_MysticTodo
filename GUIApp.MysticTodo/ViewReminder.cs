using GUIApp.MysticTodo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
               refreshViewer(Id);
            }
            //form.Show();
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
                dtpAlarmTimeViewer.Format = DateTimePickerFormat.Custom;
                dtpAlarmTimeViewer.CustomFormat = "HH:mm";
                dtpAlarmTimeViewer.ShowUpDown = true;

                dtpAlarmDateViewer.Value = (DateTime)reminder.Reminder_Date;
                dtpAlarmTimeViewer.Value = (DateTime)(reminder.Reminder_Date + reminder.Reminder_Time);

                if(reminder.Reminder_IsPeriodic == true)
                {
                    dtpPeriodicTimeViewer.Format = DateTimePickerFormat.Custom;
                    dtpPeriodicTimeViewer.CustomFormat = "HH:mm";
                    dtpPeriodicTimeViewer.ShowUpDown = true;

                    dtpPeriodicDateViewer.Value = (DateTime)reminder.Reminder_NextPeriodicDate;
                    dtpPeriodicTimeViewer.Value = (DateTime)(reminder.Reminder_NextPeriodicDate + reminder.Reminder_NextPeriodicTime);
                    tbPeriodicViewer.Text = reminder.Timeframe.Timeframe_Name.ToString();

                }
                else
                {
                    lPeriodicViewer.Hide();
                    lNextAlarmViewer.Hide();
                    dtpPeriodicDateViewer.Hide();
                    dtpPeriodicTimeViewer.Hide();
                    tbPeriodicViewer.Hide();
                }
            }else
            {
                lAlarmViewer.Hide();
                dtpAlarmDateViewer.Hide();
                dtpAlarmTimeViewer.Hide();

                lPeriodicViewer.Hide();
                lNextAlarmViewer.Hide();
                dtpPeriodicDateViewer.Hide();
                dtpPeriodicTimeViewer.Hide();
                tbPeriodicViewer.Hide();
            }

        }

    }
}
