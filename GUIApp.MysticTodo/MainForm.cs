using GUIApp.MysticTodo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIApp.MysticTodo
{
    public partial class MainForm : Form
    {

        //private readonly MysticToDo_DBEntities1 mysticToDo_dbEntities1;
        private readonly MysticToDoEntities1 mysticTodoDatabase;
        private bool messageShown = false;
        private enum tableStatus {activeTable, completedTable, searchtable}
        private int currentTable;
        //private var gvRowselection; 


        public MainForm()
        {
            InitializeComponent();
            mysticTodoDatabase = new MysticToDoEntities1();
            dtpAlarmDate.Hide();
            dtpAlarmTime.Hide();
            comboboxPerodicAlarm.Hide();
            gvInactiveReminderTable.Visible = false;
            lGridViewTitleCompleted.Visible = false;
            gvSearchReminderTable.Visible = false;
            lGridViewTitleSearch.Visible = false;
            lGridViewTitleAllReminders.Visible = false;
            currentTable = (int)tableStatus.activeTable;
        }
        // 
        // Event: FormLoad
        // 
        private void MainForm_Load(object sender, EventArgs e)
        {
            //gbReminderEditor.AutoSize = false;
            //gbReminderSearch.AutoSize = false;
            //this.AutoScaleMode = AutoScaleMode.None;
            //tbReminder.AutoSize = false;
            //tbSearch.AutoSize = false;
            //gvReminderTable.AutoSize = false;

            var timeframe = mysticTodoDatabase.Timeframes.ToList();
            comboboxPerodicAlarm.DisplayMember = "Timeframe_Name";
            comboboxPerodicAlarm.ValueMember = "Timeframe_Key";
            comboboxPerodicAlarm.DataSource = timeframe;

            refreshActiveReminderTable();
            refreshInActiveReminderTable();
            refreshSearchReminderTable();

            gvReminderTable.Columns["frequencyId"].Visible = false;
            gvReminderTable.Columns["periodicActive"].Visible = false;

        }
        // 
        // Events: GridView
        // 
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
        //
        //
        private void gvInactiveReminderTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                {
                    // Access the selected row and its cells
                    var id = (int)gvInactiveReminderTable.SelectedRows[0].Cells["gvinactiveId"].Value as int?;

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
        //
        //
        private void gvSearchReminderTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (gvSearchReminderTable.SelectedRows.Count > 0 && gvSearchReminderTable.SelectedRows[0].Cells.Count > 0)
                {
                    // Access the selected row and its cells
                    var id = (int)gvSearchReminderTable.SelectedRows[0].Cells["gvSearchId"].Value as int?;

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
        //
        //
        private void gvReminderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                if (gvReminderTable.Columns[e.ColumnIndex].Name == "gvActive")
                {
                    var idCell = gvReminderTable.Rows[e.RowIndex].Cells["gvId"];
                    if (idCell.Value != null && int.TryParse(idCell.Value.ToString(), out int id))
                    {
                        // Query database for record
                        var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                        if (reminder != null)
                        {
                            // Update the active status to true
                            reminder.Reminder_IsComplete = true;

                            // Update the database using the id
                            mysticTodoDatabase.Reminders.AddOrUpdate(reminder);
                            mysticTodoDatabase.SaveChanges();
                            MessageBox.Show("Task added to complete list!!!");
                        }
                    }

                    // Commit the edit to update the underlying data source
                    gvReminderTable.EndEdit();
                    refreshActiveReminderTable(); // You can refresh the table after saving changes
                    refreshInActiveReminderTable();
                    refreshSearchReminderTable();
                }
            }
          
        }
        //
        //
        private void gvInactiveReminderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                if (gvInactiveReminderTable.Columns[e.ColumnIndex].Name == "gvinactiveActive")
                {
                    var idCell = gvInactiveReminderTable.Rows[e.RowIndex].Cells["gvinactiveId"];
                    if (idCell.Value != null && int.TryParse(idCell.Value.ToString(), out int id))
                    {
                        // Query database for record
                        var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                        if (reminder != null)
                        {
                            // Update the active status to true
                            reminder.Reminder_IsComplete = false;

                            // Update the database using the id
                            mysticTodoDatabase.Reminders.AddOrUpdate(reminder);
                            mysticTodoDatabase.SaveChanges();
                            MessageBox.Show("Task added to active list!!!");
                        }
                    }

                    // Commit the edit to update the underlying data source
                    gvInactiveReminderTable.EndEdit();
                    // You can refresh the table after saving changes
                    refreshInActiveReminderTable();
                    refreshActiveReminderTable();
                    refreshSearchReminderTable();
                }
            }
        }
        //
        //
        private void gvSearchReminderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                if (gvSearchReminderTable.Columns[e.ColumnIndex].Name == "gvSearchActive")
                {
                    var idCell = gvSearchReminderTable.Rows[e.RowIndex].Cells["gvSearchId"];
                    if (idCell.Value != null && int.TryParse(idCell.Value.ToString(), out int id))
                    {
                        // Query database for record
                        var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                        if (reminder != null)
                        {
                            // Update the active status to true
                            if(reminder.Reminder_IsComplete == true)
                            {
                                reminder.Reminder_IsComplete = false;
                                MessageBox.Show("Task added to active list!!!");
                            }
                            else
                            {
                                reminder.Reminder_IsComplete = true;
                                MessageBox.Show("Task added to complete list!!!");
                            }
                            // Update the database using the id
                            mysticTodoDatabase.Reminders.AddOrUpdate(reminder);
                            mysticTodoDatabase.SaveChanges();
                           
                        }
                    }

                    // Commit the edit to update the underlying data source
                    gvSearchReminderTable.EndEdit();
                    // You can refresh the table after saving changes
                    refreshSearchReminderTable();
                    refreshInActiveReminderTable();
                    refreshActiveReminderTable();
                    
                }
            }
        }
        //
        //
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                selectSearchTaskTab();
                refreshSearchReminderTable(tbSearch.Text.ToString());
            }
            else
            {
                refreshSearchReminderTable();
            }
        }
        //
        //
        private void gvReminderList_DoubleClick(object sender, EventArgs e)
        {
            int viewerID = 0;
            try
            {
                if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
                {
                    // Access the selected row and its cells
                    int? id = (int)gvReminderTable.SelectedRows[0].Cells["gvId"].Value as int?;

                    if (id.HasValue)
                    {
                        viewerID = id.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            var viewReminder = new formViewReminder(viewerID);
            if (!viewReminder.Visible) 
            {
                viewReminder.Show();
            }
        }
        //
        //
        private void gvInactiveReminderTable_DoubleClick(object sender, EventArgs e)
        {
            int viewerID = 0;

            try
            {
                  if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                  {
                      int? inactiveId = (int)gvInactiveReminderTable.SelectedRows[0].Cells["gvinactiveId"].Value as int?;

                      if (inactiveId.HasValue)
                      {
                          viewerID = inactiveId.Value;
                      }
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            var viewReminder = new formViewReminder(viewerID);
            if (!viewReminder.Visible)
            {
                viewReminder.Show();
            }
        }
        //
        //
        private void gvSearchReminderTable_DoubleClick(object sender, EventArgs e)
        {
            int viewerID = 0;

            try
            {
                if (gvSearchReminderTable.SelectedRows.Count > 0 && gvSearchReminderTable.SelectedRows[0].Cells.Count > 0)
                {
                    var searchId = (int)gvSearchReminderTable.SelectedRows[0].Cells["gvSearchId"].Value as int?;

                    if (searchId.HasValue)
                    {
                        viewerID = searchId.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            var viewReminder = new formViewReminder(viewerID);
            if (!viewReminder.Visible)
            {
                viewReminder.Show();
            }
        }
        // 
        // Events: Input fields
        // 
        private void CebSetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkboxSetAlarm.Checked)
            {
                dtpAlarmDate.Hide();
                dtpAlarmTime.Hide();
                if (checkboxPeriodicAlarm.Checked)
                {
                    checkboxSetAlarm.Checked = true;
                    checkboxPeriodicAlarm.Checked = false;
                    checkboxSetAlarm.Checked = false;
                }
            }
            else
            {
                dtpAlarmDate.Show();
                dtpAlarmTime.Show();
                dtpAlarmTime.Format = DateTimePickerFormat.Custom;
                dtpAlarmTime.CustomFormat = "HH:mm";
                dtpAlarmTime.ShowUpDown = true;
            }
        }
        // 
        //
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
        // 
        //
        private void BSubmit_Click(object sender, EventArgs e)
        {
            MysticToDoEntities1 context = new MysticToDoEntities1();

            try
            {
                switch (currentTable)
                {
                    case (int)tableStatus.activeTable:
                        context.Reminders.Add(addReminderInfo());
                        context.SaveChanges();
                        MessageBox.Show("Reminder Added!!!");
                        refreshActiveReminderTable();
                        refreshInActiveReminderTable();
                        clearFields();
                        break;

                    case (int)tableStatus.completedTable:
                        MessageBox.Show("This button cannot be used from the completed table!!!");
                        break;

                    case (int)tableStatus.searchtable:
                        MessageBox.Show("This button cannot be used from the search results table!!!");
                        break;

                    default:
                        MessageBox.Show("Invalid selection!!!");
                        break;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        // 
        //
        private void BUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmUpdating = MessageBox.Show("Do you want to continue with updating this record?", "Confirmation", MessageBoxButtons.YesNo);

            if (confirmUpdating == DialogResult.Yes)
            {

                // User clicked Yes
                // This will update the record from the reminder list
                try
                {
                    switch (currentTable)
                    {
                        case (int)tableStatus.activeTable:
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
                                MessageBox.Show("Reminder Updated!!!");
                            }
                            mysticTodoDatabase.SaveChanges();
                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            clearFields();
                            break;

                        case (int)tableStatus.completedTable:
                            if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                MessageBox.Show("You can only edit active Reminders!!!");
                            }
                            break;

                        case (int)tableStatus.searchtable:
                            MessageBox.Show("This button cannot be used from the search results table!!!");
                            break;

                        default:
                            MessageBox.Show("Invalid selection!!!");
                            break;
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            else if (confirmUpdating == DialogResult.No)
            {
                // User click no
                // This will cancel the process. 
                MessageBox.Show("Update Canceled!!!");
            }
        }
        // 
        //
        private void BDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDeleting = MessageBox.Show("Do you want to continue with deleting this record?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmDeleting == DialogResult.Yes)
            {
                // User clicked Yes
                // This will delete the record from the reminder list
                try
                {
                    switch (currentTable)
                    {
                        case (int)tableStatus.activeTable:
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
                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            break;

                        case (int)tableStatus.completedTable:
                            if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                //update code to delete items
                                int? inactiveId = (int)gvInactiveReminderTable.SelectedRows[0].Cells["gvinactiveId"].Value as int?;

                                if (inactiveId.HasValue)
                                {
                                    //query database for record
                                    var deleteInactiveReminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == inactiveId);

                                    deleteInactiveReminder.Reminder_Id = inactiveId.Value;
                                    mysticTodoDatabase.Reminders.Remove(deleteInactiveReminder);
                                }
                            }
                            mysticTodoDatabase.SaveChanges();
                            MessageBox.Show("Reminder Deleted!!!");
                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            break;

                        case (int)tableStatus.searchtable:
                            MessageBox.Show("This button cannot be used from the search results table!!!");
                            break;

                        default:
                            MessageBox.Show("Invalid selection!!!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            else if (confirmDeleting == DialogResult.No)
            {
                // User click no
                // This will cancel the process. 
                MessageBox.Show("Deletion Canceled!!!");
            }
        }
        // 
        //
        private void bClear_Click(object sender, EventArgs e)
        {
            tbReminder.Text = "";
            tbDescription.Text = "";
            checkboxSetAlarm.Checked = true;
            dtpAlarmDate.Value = DateTime.Now;
            dtpAlarmDate.Visible = false;
            dtpAlarmTime.Value = DateTime.Now;
            dtpAlarmTime.Visible = false;
            checkboxPeriodicAlarm.Checked = false;
            comboboxPerodicAlarm.SelectedIndex = 0;
            checkboxSetAlarm.Checked = false;
        }
        //
        //
        private void BSearch_Click(object sender, EventArgs e)
        {
            selectSearchTaskTab();
            refreshSearchReminderTable(tbSearch.Text.ToString());
        }
        //
        //
        private void bActiveTaskTab_Click(object sender, EventArgs e)
        {
            if (!gvReminderTable.Visible)
            {
                gvReminderTable.Visible = true;
                lGridViewTitleActive.Visible = true;
                gvInactiveReminderTable.Visible = false;
                lGridViewTitleCompleted.Visible = false;
                gvSearchReminderTable.Visible = false;
                lGridViewTitleSearch.Visible = false;

                currentTable = (int)tableStatus.activeTable;
            }
        }
        //
        //
        private void bInActiveTaskTab_Click(object sender, EventArgs e)
        {
            if (!gvInactiveReminderTable.Visible)
            {
                gvInactiveReminderTable.Visible = true;
                lGridViewTitleCompleted.Visible = true;
                gvReminderTable.Visible = false;
                lGridViewTitleActive.Visible = false;
                gvSearchReminderTable.Visible = false;
                lGridViewTitleSearch.Visible = false;

                currentTable = (int)tableStatus.completedTable;
            }
        }
        //
        //
        private void bAllTaskTab_Click(object sender, EventArgs e)
        {
            if (!gvSearchReminderTable.Visible)
            {
                gvSearchReminderTable.Visible = true;
                lGridViewTitleSearch.Visible = false;
                lGridViewTitleAllReminders.Visible = true;
                gvReminderTable.Visible = false;
                lGridViewTitleActive.Visible = false;
                gvInactiveReminderTable.Visible = false;
                lGridViewTitleCompleted.Visible = false;
 

                currentTable = (int)tableStatus.searchtable;
            }
        }
        // 
        // Custom methods: GridView
        // 
        private void refreshActiveReminderTable()
        {
            var activeReminderList = mysticTodoDatabase.Reminders
            .Where(r => r.Reminder_IsComplete == false) // Filter by Reminder_IsComplete
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
            gvReminderTable.DataSource = activeReminderList;
            gvReminderTable.Refresh();
        }
        //
        //
        private void refreshInActiveReminderTable()
        {
            var inactiveReminderList = mysticTodoDatabase.Reminders
            .Where(r => r.Reminder_IsComplete == true) // Filter by Reminder_IsComplete
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
            gvInactiveReminderTable.DataSource = inactiveReminderList;
            gvInactiveReminderTable.Refresh();
        }
        //
        //
        private void refreshSearchReminderTable()
        {
            var searchReminderList = mysticTodoDatabase.Reminders
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
            gvSearchReminderTable.DataSource = searchReminderList;
            gvSearchReminderTable.Refresh();
        }
        //
        //
        private void refreshSearchReminderTable(String searchTerm)
        {

            var searchReminderList = mysticTodoDatabase.Reminders
            .Where(r => r.Reminder_Name.Contains(searchTerm)) // Filter by Reminder_IsComplete
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
            gvSearchReminderTable.DataSource = searchReminderList;
            gvSearchReminderTable.Refresh();
        }
        //
        //
        private void selectSearchTaskTab()
        {
            if (!gvSearchReminderTable.Visible)
            {
                gvSearchReminderTable.Visible = true;
                lGridViewTitleSearch.Visible = true;
                gvReminderTable.Visible = false;
                lGridViewTitleActive.Visible = false;
                gvInactiveReminderTable.Visible = false;
                lGridViewTitleCompleted.Visible = false;


                currentTable = (int)tableStatus.searchtable;
            }
        }
        // 
        // Custom methods: Feilds
        // 
        private void populateFeilds(Reminder reminder)
        {
            tbReminder.Text = reminder.Reminder_Name;
            tbDescription.Text = reminder.Reminder_Description;
            checkboxSetAlarm.Checked = reminder.Reminder_HasAlarm ?? false;

            if (checkboxSetAlarm.Checked == true)
            {
                DateTime reminderAlarm = dtpAlarmDate.Value;
                dtpAlarmDate.Value = reminderAlarm;
                DateTime alarmDateTime = reminderAlarm.Add((TimeSpan)reminder.Reminder_Time);
                dtpAlarmTime.Format = DateTimePickerFormat.Custom;
                dtpAlarmTime.CustomFormat = "HH:mm";
                dtpAlarmTime.Value = alarmDateTime;


                checkboxPeriodicAlarm.Checked = reminder.Reminder_IsPeriodic ?? false;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    comboboxPerodicAlarm.SelectedIndex = (int)reminder.Reminder_PeriodicIntervalLabel - 1;
                }
                else
                {
                    comboboxPerodicAlarm.Hide();
                    checkboxPeriodicAlarm.Checked = false;
                    
                }
            }
            else
            {
                dtpAlarmDate.Hide();
                dtpAlarmTime.Hide();
                comboboxPerodicAlarm.Hide();
                checkboxSetAlarm.Checked = true;
                checkboxPeriodicAlarm.Checked = false;
                checkboxSetAlarm.Checked = false;
            }

        }
        //
        //
        private Reminder useReminderInfo(int id)
        {
            Reminder reminder = new Reminder();

            reminder.Reminder_Id = id;
            reminder.Reminder_IsComplete = false;
            reminder.Reminder_Name = tbReminder.Text;
            reminder.Reminder_Description = tbDescription.Text;
            reminder.Reminder_HasAlarm = (Boolean)checkboxSetAlarm.Checked;

            if (checkboxSetAlarm.Checked == true)
            {
                DateTime reminderAlarm = dtpAlarmDate.Value;
                TimeSpan reminderAlarmTime = dtpAlarmTime.Value.TimeOfDay;

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
        //
        //
        private Reminder addReminderInfo()
        {
            Reminder reminder = new Reminder();

            reminder.Reminder_Name = tbReminder.Text;
            reminder.Reminder_IsComplete = false;
            reminder.Reminder_Description = tbDescription.Text;
            reminder.Reminder_HasAlarm = (Boolean)checkboxSetAlarm.Checked;

            if (checkboxSetAlarm.Checked == true)
            {
                DateTime reminderAlarm = dtpAlarmDate.Value;
                TimeSpan reminderAlarmTime = dtpAlarmTime.Value.TimeOfDay;

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
        //
        //
        private void clearFields()
        {
            tbReminder.Text = "";
            tbDescription.Text = "";
            checkboxSetAlarm.Checked = true;
            dtpAlarmDate.Value = DateTime.Now;
            dtpAlarmDate.Visible = false;
            dtpAlarmTime.Value = DateTime.Now;
            dtpAlarmTime.Visible = false;
            checkboxPeriodicAlarm.Checked = false;
            comboboxPerodicAlarm.SelectedIndex = 0;
            checkboxSetAlarm.Checked = false;
        }
        // 
        // Custom methods: others
        // 
        private void ShowDialog(string v)
        {
            throw new NotImplementedException();
        }

        private void gvInactiveReminderTable_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gvInactiveReminderTable_MouseLeave(object sender, EventArgs e)
        {

        }

        private void gvSearchReminderTable_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gvSearchReminderTable_MouseLeave(object sender, EventArgs e)
        {

        }

        private void gvReminderTable_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gvReminderTable_MouseLeave(object sender, EventArgs e)
        {

        }
        //
        //


    }
}
