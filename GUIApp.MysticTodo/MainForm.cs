using GUIApp.MysticTodo.Data;
using GUIApp.MysticTodo.Properties;
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
    public partial class MainForm : Form
    {

        //private readonly MysticToDo_DBEntities1 mysticToDo_dbEntities1;
        private readonly MysticToDoEntities1 mysticToDoEntities1; 
        private bool messageShown = false;


        public MainForm()
        {
            InitializeComponent();
            mysticToDoEntities1 = new MysticToDoEntities1();
            DtpAlarmDate.Hide();
            CbPerodicAlarm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var timeframe = mysticToDoEntities1.Timeframes.ToList();
            CbPerodicAlarm.DisplayMember = "Timeframe_Name";
            CbPerodicAlarm.ValueMember = "Timeframe_Key";
            CbPerodicAlarm.DataSource = timeframe;

            var reminders = mysticToDoEntities1.Reminders.ToList();
            dataGridView1.DataSource = reminders;
            dataGridView1.Refresh();

        }

        private void CebSetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (!CebSetAlarm.Checked)
            {
                DtpAlarmDate.Hide();
            }
            else
            {   
                DtpAlarmDate.Show();
      
            }
        }

        private void CheckbPeriodicAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if(CebSetAlarm.Checked)
            {
                if (CheckbPeriodicAlarm.Checked)
                {
                    CbPerodicAlarm.Show();
                }
                else
                {
                    CbPerodicAlarm.Hide();
                    
                }
            }
            else
            {
                if (!messageShown)
                {
                    messageShown = true;
                    CheckbPeriodicAlarm.Checked = false;
                    MessageBox.Show("Alarm must first be set.");
                    messageShown = false;
                } 
             
            }

            
        }

        private void ShowDialog(string v)
        {
            throw new NotImplementedException();
        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            MysticToDoEntities1 context = new MysticToDoEntities1();
            string reminderName;
            string reminderDescription;
            DateTime reminderAlarm = DateTime.MinValue;
            TimeSpan reminderAlarmTime = TimeSpan.Zero;
            int reminderPerodicAlarm = 0;

            //Store form data in variables
            reminderName = TbReminder.Text;
            reminderDescription = TbDescription.Text;

            if (CebSetAlarm.Checked)
            {
                reminderAlarm = DtpAlarmDate.Value;
                reminderAlarmTime = DtpAlarmDate.Value.TimeOfDay;
                if (CheckbPeriodicAlarm.Checked)
                {
                    reminderPerodicAlarm = CbPerodicAlarm.SelectedIndex;
                }
            }

            //Store variable data in the database using an object 
            Reminder addReminder = new Reminder();
            addReminder.Reminder_IsComplete = false;
            addReminder.Reminder_Name = reminderName;
            addReminder.Reminder_Description = reminderDescription;
            addReminder.Reminder_HasAlarm = Convert.ToBoolean(CebSetAlarm.Checked);
            addReminder.Reminder_IsPeriodic = Convert.ToBoolean(CheckbPeriodicAlarm.Checked);
            addReminder.Reminder_PeriodicActive = false;

            if (addReminder.Reminder_HasAlarm == true )
            {
                addReminder.Reminder_Date = reminderAlarm;
                addReminder.Reminder_Time = reminderAlarmTime;
                addReminder.Reminder_IsPeriodic = Convert.ToBoolean(CheckbPeriodicAlarm.Checked);

                if (addReminder.Reminder_IsPeriodic == true ) 
                {
                    addReminder.Reminder_PeriodicActive = true;
                    addReminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm;


                    //Timeframe timeFrameSelection = new Timeframe();
                    //timeFrameSelection.Timeframe_Key = reminderPerodicAlarm;
                    //addReminder.Reminder_PeriodicIntervalLabel;
                }

            }

            context.Reminders.Add(addReminder);
            context.SaveChanges();

            //Rebind data
            var reminders = mysticToDoEntities1.Reminders.ToList();
            dataGridView1.DataSource = reminders;
            dataGridView1.Refresh();
        }
    }
}
