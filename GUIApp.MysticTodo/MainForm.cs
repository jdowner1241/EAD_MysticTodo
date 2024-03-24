using GUIApp.MysticTodo.Data;
using GUIApp.MysticTodo.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp.MysticTodo
{
    public partial class MainForm : Form
    {

        //private readonly MysticToDo_DBEntities1 mysticToDo_dbEntities1;
        private readonly MysticToDoEntities1 mysticTodoDatabase;
        private bool messageShown = false;
        //private var gvRowselection; 


        public MainForm()
        {
            InitializeComponent();
            mysticTodoDatabase = new MysticToDoEntities1();
            dtpAlarmDate.Hide();
            comboboxPerodicAlarm.Hide();
            gvInactiveReminderTable.Visible = false;
            lGridViewTitleCompleted.Visible = false;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            gbReminderEditor.AutoSize = false;
            gbReminderSearch.AutoSize = false;
            //this.AutoScaleMode = AutoScaleMode.None;
            tbReminder.AutoSize = false;
            tbSearch.AutoSize = false;
            gvReminderTable.AutoSize = false;

            var timeframe = mysticTodoDatabase.Timeframes.ToList();
            comboboxPerodicAlarm.DisplayMember = "Timeframe_Name";
            comboboxPerodicAlarm.ValueMember = "Timeframe_Key";
            comboboxPerodicAlarm.DataSource = timeframe;

            var reminderList = mysticTodoDatabase.Reminders
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
            gvReminderTable.DataSource = reminderList;

            gvReminderTable.Columns["frequencyId"].Visible = false;
            gvReminderTable.Columns["periodicActive"].Visible = false;

           

/*           var filteredReminders = mysticTodoDatabase.Reminders.Select(q => q.Reminder_IsComplete == true);

            var completedRemindersList = mysticTodoDatabase.Reminders.Clone();

            foreach ()*/

            gvReminderTable.Refresh();
        }



        private void CebSetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkboxSetAlarm.Checked)
            {
                dtpAlarmDate.Hide();
            }
            else
            {
                dtpAlarmDate.Show();
            }
        }



        private void CheckbPeriodicAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSetAlarm.Checked)
            {
                if (checkboxPeriodicAlarm.Checked)
                {
                    comboboxPerodicAlarm.Show();
                }
                else
                {
                    comboboxPerodicAlarm.Hide();
                }
            }
            else
            {
                if (!messageShown)
                {
                    messageShown = true;
                    checkboxPeriodicAlarm.Checked = false;
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

            try
            {
                //Store variable data in the database using an object 
                /*Reminder addReminder = new Reminder();

                addReminder.Reminder_IsComplete = false;
                addReminder.Reminder_Name = tbReminder.Text;
                addReminder.Reminder_Description = tbDescription.Text;

                addReminder.Reminder_HasAlarm = Convert.ToBoolean(checkboxSetAlarm.Checked);


                if (addReminder.Reminder_HasAlarm == true)
                {
                    DateTime reminderAlarm = dtpAlarmDate.Value;
                    TimeSpan reminderAlarmTime = dtpAlarmDate.Value.TimeOfDay;

                    addReminder.Reminder_Date = reminderAlarm;
                    addReminder.Reminder_Time = reminderAlarmTime;
                    addReminder.Reminder_PeriodicActive = true;

                    addReminder.Reminder_IsPeriodic = Convert.ToBoolean(checkboxPeriodicAlarm.Checked);

                    if (addReminder.Reminder_IsPeriodic == true)
                    {
                        addReminder.Reminder_PeriodicActive = true;
                        int reminderPerodicAlarm = comboboxPerodicAlarm.SelectedIndex;
                        addReminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm + 1;

                        //Adds the required repeat date
                        switch (addReminder.Reminder_PeriodicIntervalLabel)
                        {
                            case 1:
                                addReminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(1));
                                addReminder.Reminder_NextPeriodicTime = reminderAlarmTime;
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
                }*/
                
                
                context.Reminders.Add(addReminderInfo());
                context.SaveChanges();
            }
            catch
            {

            };

            MessageBox.Show("Reminder Added!!!");
            refreshReminderTable();
            clearFields();
        }



        private void BDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDeleting = MessageBox.Show("Do you want to continue with deleting this record?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmDeleting == DialogResult.Yes)
            {
                // User clicked Yes
                // This will delete the record from the reminder list
                try
                {
                    if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
                    {
                        // Access the selected row and its cells
                        // Try to update this to allow mutiple rows to be deleted in the future.
                        int? id = (int)gvReminderTable.SelectedRows[0].Cells["gvId"].Value as int?;

                        if (id.HasValue)
                        {
                            //query database for record
                            var deleteReminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                            deleteReminder.Reminder_Id = id.Value;
                            mysticTodoDatabase.Reminders.Remove(deleteReminder);
                        }
                    }
                    mysticTodoDatabase.SaveChanges();
                    MessageBox.Show("Reminder Deleted!!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

                refreshReminderTable();
            }
            else if (confirmDeleting == DialogResult.No)
            {
                // User click no
                // This will cancel the process. 
                MessageBox.Show("Deletion Canceled!!!");
            }
        }



        private void BUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmUpdating = MessageBox.Show("Do you want to continue with updating this record?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmUpdating == DialogResult.Yes)
            {
                // User clicked Yes
                // This will update the record from the reminder list
                try
                {
                    if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
                    {
                        // Access the selected row and its cells
                        int? id = (int)gvReminderTable.SelectedRows[0].Cells["gvId"].Value as int?;

                        if (id.HasValue)
                        {
                            //query database for record
                            var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                            reminder.Reminder_Id = id.Value;

                            mysticTodoDatabase.Reminders.AddOrUpdate(useReminderInfo((int)id));
                        }
                    }
                    mysticTodoDatabase.SaveChanges();
                    MessageBox.Show("Reminder Updated!!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

                refreshReminderTable();
            }
            else if (confirmUpdating == DialogResult.No)
            {
                // User click no
                // This will cancel the process. 
                MessageBox.Show("Update Canceled!!!");
            }
        }



        private void refreshReminderTable()
        {
            var reminderList = mysticTodoDatabase.Reminders
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
            gvReminderTable.DataSource = reminderList;
            gvReminderTable.Refresh();
        }



        private void bActiveTaskTab_Click(object sender, EventArgs e)
        {
            if (!gvReminderTable.Visible)
            {
                gvReminderTable.Visible = true;
                lGridViewTitleActive.Visible = true;
                gvInactiveReminderTable.Visible = false;
                lGridViewTitleCompleted.Visible = false;
            }
        }



        private void bInActiveTaskTab_Click(object sender, EventArgs e)
        {
            if (!gvInactiveReminderTable.Visible)
            {
                gvInactiveReminderTable.Visible = true;
                lGridViewTitleCompleted.Visible = true;
                gvReminderTable.Visible = false;
                lGridViewTitleActive.Visible = false;
            }
        }



        private void gvReminderList_DoubleClick(object sender, EventArgs e)
        {

        }



        private void gvReminderTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
                {
                    // Access the selected row and its cells
                    var id = (int)gvReminderTable.SelectedRows[0].Cells["gvId"].Value as int?;

                    if (id.HasValue)
                    {
                        //query database for record
                        var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                        //display record in the entry section
                        populateFeilds(reminder);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }



        private void populateFeilds(Reminder reminder)
        {
            tbReminder.Text = reminder.Reminder_Name;
            tbDescription.Text = reminder.Reminder_Description;
            checkboxSetAlarm.Checked = reminder.Reminder_HasAlarm ?? false;

            if (checkboxSetAlarm.Checked == true)
            {
                DateTime? reminderAlarm = dtpAlarmDate.Value;
                TimeSpan? reminderAlarmTime = dtpAlarmDate.Value.TimeOfDay;

                DateTime? reminderAlarmDateTime = (DateTime)(reminder.Reminder_Date + reminder.Reminder_Time);

                checkboxPeriodicAlarm.Checked = reminder.Reminder_IsPeriodic ?? false;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    comboboxPerodicAlarm.SelectedIndex = (int)reminder.Reminder_PeriodicIntervalLabel;
                }
            }
        }



        private Reminder useReminderInfo(int id)
        {
            Reminder reminder = new Reminder();

            reminder.Reminder_Id = id;
            reminder.Reminder_Name = tbReminder.Text;
            reminder.Reminder_Description = tbDescription.Text;
            reminder.Reminder_HasAlarm = (Boolean)checkboxSetAlarm.Checked;

            if (checkboxSetAlarm.Checked == true)
            {
                DateTime reminderAlarm = dtpAlarmDate.Value;
                TimeSpan reminderAlarmTime = dtpAlarmDate.Value.TimeOfDay;

                reminder.Reminder_Date = reminderAlarm;
                reminder.Reminder_Time = reminderAlarmTime;

                reminder.Reminder_IsPeriodic = (Boolean)checkboxPeriodicAlarm.Checked;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    reminder.Reminder_PeriodicActive = true;
                    int reminderPerodicAlarm = comboboxPerodicAlarm.SelectedIndex;
                    reminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm + 1;

                    //Adds the required repeat date
                    switch (reminder.Reminder_PeriodicIntervalLabel)
                    {
                        case 1:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 2:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(7));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 3:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddMonths(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 4:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddYears(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        default:
                            break;
                    }
                }
            }

            return reminder;
        }



        private Reminder addReminderInfo()
        {
            Reminder reminder = new Reminder();

            reminder.Reminder_Name = tbReminder.Text;
            reminder.Reminder_Description = tbDescription.Text;
            reminder.Reminder_HasAlarm = (Boolean)checkboxSetAlarm.Checked;

            if (checkboxSetAlarm.Checked == true)
            {
                DateTime reminderAlarm = dtpAlarmDate.Value;
                TimeSpan reminderAlarmTime = dtpAlarmDate.Value.TimeOfDay;

                reminder.Reminder_Date = reminderAlarm;
                reminder.Reminder_Time = reminderAlarmTime;

                reminder.Reminder_IsPeriodic = (Boolean)checkboxPeriodicAlarm.Checked;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    reminder.Reminder_PeriodicActive = true;
                    int reminderPerodicAlarm = comboboxPerodicAlarm.SelectedIndex;
                    reminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm + 1;

                    //Adds the required repeat date
                    switch (reminder.Reminder_PeriodicIntervalLabel)
                    {
                        case 1:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 2:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(7));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 3:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddMonths(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case 4:
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddYears(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        default:
                            break;
                    }
                }
            }

            return reminder;
        }



        private void bClear_Click(object sender, EventArgs e)
        {
                tbReminder.Text = "";
                tbDescription.Text = "";
                checkboxSetAlarm.Checked = true;
                dtpAlarmDate.Value = DateTime.Now;
                dtpAlarmDate.Visible = false;
                checkboxPeriodicAlarm.Checked = false;
                comboboxPerodicAlarm.SelectedIndex = 0;
                checkboxSetAlarm.Checked = false;
        }



        private void gvReminderTable_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }



        private void clearFields()
        {
            tbReminder.Text = "";
            tbDescription.Text = "";
            checkboxSetAlarm.Checked = true;
            dtpAlarmDate.Value = DateTime.Now;
            dtpAlarmDate.Visible = false;
            checkboxPeriodicAlarm.Checked = false;
            comboboxPerodicAlarm.SelectedIndex = 0;
            checkboxSetAlarm.Checked = false;
        }
    }
}
