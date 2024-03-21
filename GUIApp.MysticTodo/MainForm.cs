using GUIApp.MysticTodo.Data;
using GUIApp.MysticTodo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            gbReminderEditor.AutoSize = false;
            gbReminderSearch.AutoSize = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var timeframe = mysticToDoEntities1.Timeframes.ToList();
            CbPerodicAlarm.DisplayMember = "Timeframe_Name";
            CbPerodicAlarm.ValueMember = "Timeframe_Key";
            CbPerodicAlarm.DataSource = timeframe;

          /*  var reminders = mysticToDoEntities1.Reminders.ToList();
            gvReminderList.DataSource = reminders;
            gvReminderList.Refresh();*/

            var reminderTable = mysticToDoEntities1.Reminders
                .Select(r => new
                {
                    id = r.Reminder_Id,
                    active = r.Reminder_IsComplete,
                    name = r.Reminder_Name,
                    description = r.Reminder_Description,
                    alarm = r.Reminder_HasAlarm,
                    alarmDate = r.Reminder_Date,
                    alarmTime = r.Reminder_Time,
                    periodic = r.Reminder_IsPeriodic,
                    periodicActive = r.Reminder_PeriodicActive,
                    frequencyId = r.Reminder_PeriodicIntervalLabel,
                    frequency = r.Timeframe.Timeframe_Name,
                    periodicDate = r.Reminder_NextPeriodicDate,
                    periodicTime = r.Reminder_NextPeriodicTime
                }).ToList();
            gvReminderList.DataSource = reminderTable;
            

            gvReminderList.Columns["frequencyId"].Visible = false;
            gvReminderList.Columns["periodicActive"].Visible = false;

            
            gvReminderList.Refresh();


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
            Timeframe setTimeframe = new Timeframe();


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
                    addReminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm + 1;
                   


                    var frequency = mysticToDoEntities1.Timeframes.Select(q => new { tkey = q.Timeframe_Key, tName = q.Timeframe_Name });
                    gvReminderList.ReadOnly = false;
                    gvReminderList.Columns[8].DataPropertyName = "Frequency";
                    gvReminderList.Columns[8].HeaderText = "Changed";


                    switch (addReminder.Reminder_PeriodicIntervalLabel)
                    {
                        case 1:
                            addReminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(1));
                            addReminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            //dataGridView1.Columns[8].DataPropertyName = setTimeframe.Timeframe_Name;


                            break;
                        case 2:
                            addReminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(7));
                            addReminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 3:
                            addReminder.Reminder_NextPeriodicDate = (reminderAlarm.AddMonths(1));
                            addReminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 4:
                            addReminder.Reminder_NextPeriodicDate = (reminderAlarm.AddYears(1));
                            addReminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        default:
                            break;
                    }

                }

            }

            context.Reminders.Add(addReminder);
            context.SaveChanges();

            //Rebind data
            /*   var reminders = mysticToDoEntities1.Reminders.ToList();
               gvReminderList.DataSource = reminders;
               gvReminderList.Refresh();*/

            gvReminderList.DataSource = context.Reminders;
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDeleting = MessageBox.Show("Do you want to continue with deleting this record?", "Confirmation", MessageBoxButtons.YesNo);
            
            if (confirmDeleting == DialogResult.Yes)
            {
                // User clicked Yes
                // This will delete the record from the reminder list
            }
            else if (confirmDeleting == DialogResult.No)
            {
                // User click no
                // This will cancel the process. 
  
            }

        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmUpdating = MessageBox.Show("Do you want to continue with updating this record?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmUpdating == DialogResult.Yes)
            {
                // User clicked Yes
                // This will update the record from the reminder list
            }
            else if (confirmUpdating == DialogResult.No)
            {
                // User click no
                // This will cancel the process. 

            }
        }

        private void ScReminderPage_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
