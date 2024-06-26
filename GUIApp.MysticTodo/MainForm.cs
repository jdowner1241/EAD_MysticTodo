﻿using GUIApp.MysticTodo;
using GUIApp.MysticTodo.Data;
using GUIApp.MysticTodo.Properties;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public enum Timeframe
        {
            Daily,
            Weekly,
            Monthly,
            Yearly
        };


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
            BSearch.Visible = false;
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


            /*var timeframe = mysticTodoDatabase.Timeframes.ToList();
            comboboxPerodicAlarm.DisplayMember = "Timeframe_Name";
            comboboxPerodicAlarm.ValueMember = "Timeframe_Key";
            comboboxPerodicAlarm.DataSource = timeframe;*/

            comboboxPerodicAlarm.DataSource = Enum.GetValues(typeof(Timeframe));
            comboboxPerodicAlarm.DisplayMember = "ToString";
            //comboboxPerodicAlarm.ValueMember = "ToString";

            refreshActiveReminderTable();
            refreshInActiveReminderTable();
            refreshSearchReminderTable();

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
   
        }
        //
        //
        private void gvInactiveReminderTable_DoubleClick(object sender, EventArgs e)
        {

        }
        //
        //
        private void gvSearchReminderTable_DoubleClick(object sender, EventArgs e)
        {

        }
        //
        //
        private void gvReminderTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int viewerID = 0;

            try
            {
                if (e.RowIndex > -1)
                {
                    gvReminderTable.Rows[e.RowIndex].Selected = true;

                    if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
                    {
                        var Id = gvReminderTable.SelectedRows[0].Cells["gvId"].Value as int?;

                        if (Id.HasValue)
                        {
                            viewerID = Id.Value;
                        }
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
        private void gvSearchReminderTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int viewerID = 0;

            try
            {
                if (e.RowIndex > -1)
                {
                    gvSearchReminderTable.Rows[e.RowIndex].Selected = true;

                    if (gvSearchReminderTable.SelectedRows.Count > 0 && gvSearchReminderTable.SelectedRows[0].Cells.Count > 0)
                    {
                        var searchId = gvSearchReminderTable.SelectedRows[0].Cells["gvSearchId"].Value as int?;

                        if (searchId.HasValue)
                        {
                            viewerID = searchId.Value;
                        }
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
        private void gvInactiveReminderTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int viewerID = 0;

            try
            {
                if (e.RowIndex > -1)
                {
                    gvInactiveReminderTable.Rows[e.RowIndex].Selected = true;

                    if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                    {
                        var inactiveId = gvInactiveReminderTable.SelectedRows[0].Cells["gvInactiveId"].Value as int?;

                        if (inactiveId.HasValue)
                        {
                            viewerID = inactiveId.Value;
                        }
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
                dtpAlarmTime.CustomFormat = "hh:mm tt";
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
                        refreshSearchReminderTable();
                        clearFields();
                        break;

                    case (int)tableStatus.completedTable:
                        selectActiveTaskTab();
                        context.Reminders.Add(addReminderInfo());
                        context.SaveChanges();
                        MessageBox.Show("Reminder Added!!!");
                        refreshActiveReminderTable();
                        refreshInActiveReminderTable();
                        refreshSearchReminderTable();
                        clearFields();
                        break;

                    case (int)tableStatus.searchtable:
                        selectActiveTaskTab();
                        context.Reminders.Add(addReminderInfo());
                        context.SaveChanges();
                        MessageBox.Show("Reminder Added!!!");
                        refreshActiveReminderTable();
                        refreshInActiveReminderTable();
                        refreshSearchReminderTable();
                        clearFields();
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
                                MessageBox.Show($"Reminder ID: {id.Value} Updated!!!");
                            }
                            mysticTodoDatabase.SaveChanges();
                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            refreshSearchReminderTable();
                            clearFields();
                            break;

                        case (int)tableStatus.completedTable:
                            if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                                {
                                    // Access the selected row and its cells
                                    int? inactiveid = (int)gvInactiveReminderTable.SelectedRows[0].Cells["gvinactive"].Value as int?;

                                    if (inactiveid.HasValue)
                                    {
                                        //query database for record
                                        var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == inactiveid);

                                        reminder.Reminder_Id = inactiveid.Value;

                                        mysticTodoDatabase.Reminders.AddOrUpdate(useReminderInfo((int)inactiveid));
                                    }
                                    MessageBox.Show($"Reminder ID: {inactiveid.Value} Updated!!!");
                                }
                                mysticTodoDatabase.SaveChanges();
                                refreshActiveReminderTable();
                                refreshInActiveReminderTable();
                                refreshSearchReminderTable();
                                clearFields();
                            }
                            break;

                        case (int)tableStatus.searchtable:
                            if (gvSearchReminderTable.SelectedRows.Count > 0 && gvSearchReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                // Access the selected row and its cells
                                int? searchid = (int)gvSearchReminderTable.SelectedRows[0].Cells["gvSearchId"].Value as int?;

                                if (searchid.HasValue)
                                {
                                    //query database for record
                                    var reminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == searchid);

                                    reminder.Reminder_Id = searchid.Value;

                                    mysticTodoDatabase.Reminders.AddOrUpdate(useReminderInfo((int)searchid));
                                }
                                MessageBox.Show($"Reminder ID: {searchid.Value} Updated!!!");
                            }
                            mysticTodoDatabase.SaveChanges();
                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            refreshSearchReminderTable();
                            clearFields();
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
            List<int> idRemoveList = new List<int>();
            DialogResult confirmDeleting = MessageBox.Show("Do you want to continue with deleting this/these records?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmDeleting == DialogResult.Yes)
                {
                // Records will be deleted
                try
                {
                    switch (currentTable)
                    {
                        case (int)tableStatus.activeTable:
                            if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                // Select mutiple rows from the gvReminderTable
                                foreach (DataGridViewRow selectedRow in gvReminderTable.SelectedRows)
                                {
                                    int? id = selectedRow.Cells["gvId"].Value as int?;

                                    if (id.HasValue)
                                    {
                                        // Add ud ti a array to be deplayed 
                                        idRemoveList.Add(id.Value);

                                        // Query database for record
                                        var deleteReminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == id);

                                        if (deleteReminder != null)
                                        {
                                            mysticTodoDatabase.Reminders.Remove(deleteReminder);
                                        }
                                    }
                                }
                            }
                            mysticTodoDatabase.SaveChanges();
                           
                            string deletedIDs = "Deleted Reminders :\n";

                            foreach (int id in idRemoveList)
                            {
                                deletedIDs += ($"\nID : {id}");
                            }
                            MessageBox.Show(deletedIDs);

                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            refreshSearchReminderTable();
                            break;

                        case (int)tableStatus.completedTable:
                            if (gvInactiveReminderTable.SelectedRows.Count > 0 && gvInactiveReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                // Select mutiple rows from the gvInactiveReminderTable
                                foreach (DataGridViewRow selectedRow in gvInactiveReminderTable.SelectedRows)
                                {
                                    int? inactiveId = selectedRow.Cells["gvinactiveId"].Value as int?;

                                    if (inactiveId.HasValue)
                                    {
                                        // Add ud ti a array to be deplayed 
                                        idRemoveList.Add(inactiveId.Value);

                                        // Query database for record
                                        var deleteReminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == inactiveId);

                                        if (deleteReminder != null)
                                        {
                                            mysticTodoDatabase.Reminders.Remove(deleteReminder);
                                        }
                                    }
                                }
                            }
                            mysticTodoDatabase.SaveChanges();
    
                            string inactiveDeletedIDs = "Deleted Reminders :\n";

                            foreach (int id in idRemoveList)
                            {
                                inactiveDeletedIDs += ($"\nID : {id}");
                            }
                            MessageBox.Show(inactiveDeletedIDs);


                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            refreshSearchReminderTable();
                            break;

                        case (int)tableStatus.searchtable:
                            if (gvSearchReminderTable.SelectedRows.Count > 0 && gvSearchReminderTable.SelectedRows[0].Cells.Count > 0)
                            {
                                // Select mutiple rows from the gvInactiveReminderTable
                                foreach (DataGridViewRow selectedRow in gvSearchReminderTable.SelectedRows)
                                {
                                    int? searchId = selectedRow.Cells["gvSearchId"].Value as int?;

                                    if (searchId.HasValue)
                                    {
                                        // Add ud ti a array to be deplayed 
                                        idRemoveList.Add(searchId.Value);

                                        // Query database for record
                                        var deleteReminder = mysticTodoDatabase.Reminders.FirstOrDefault(q => q.Reminder_Id == searchId);

                                        if (deleteReminder != null)
                                        {
                                            mysticTodoDatabase.Reminders.Remove(deleteReminder);
                                        }
                                    }
                                }
                            }
                            mysticTodoDatabase.SaveChanges();

                            string searchDeletedIDs = "Deleted Reminders :\n";

                            foreach (int id in idRemoveList)
                            {
                                searchDeletedIDs += ($"\nID : {id}");
                            }
                            MessageBox.Show(searchDeletedIDs);


                            refreshActiveReminderTable();
                            refreshInActiveReminderTable();
                            refreshSearchReminderTable();
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
                lGridViewTitleAllReminders.Visible = false;

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
                lGridViewTitleAllReminders.Visible = false;

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

            gvReminderTable.Columns["gvDescription"].Visible = false;
            gvReminderTable.Columns["gvPeriodicDate"].Visible = false;
            gvReminderTable.Columns["gvPeriodicTime"].Visible = false;
            gvReminderTable.Columns["gvPeriodicTime"].Visible = false;
            gvReminderTable.Columns["frequencyId"].Visible = false;
            gvReminderTable.Columns["periodicActive"].Visible = false;

            gvReminderTable.Columns["gvAlarmDate"].DefaultCellStyle.Format = "dd MMMM yyyy";
            gvReminderTable.Columns["gvAlarmTime"].DefaultCellStyle.Format = "hh:mm tt";

            gvReminderTable.Refresh();
            refreshSearchReminderTable();
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

            gvInactiveReminderTable.Columns["gvinactiveDescription"].Visible = false;
            gvInactiveReminderTable.Columns["gvinactivePeriodicDate"].Visible = false;
            gvInactiveReminderTable.Columns["gvinactivePeriodicTime"].Visible = false;
            gvInactiveReminderTable.Columns["frequencyId"].Visible = false;
            gvInactiveReminderTable.Columns["periodicActive"].Visible = false;

            gvInactiveReminderTable.Columns["gvinactiveAlarmDate"].DefaultCellStyle.Format = "dd MMMM yyyy";
            gvInactiveReminderTable.Columns["gvinactiveAlarmTime"].DefaultCellStyle.Format = "hh:mm tt";

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

            gvSearchReminderTable.Columns["gvSearchDescription"].Visible = false;
            gvSearchReminderTable.Columns["gvSearchPeriodicDate"].Visible = false;
            gvSearchReminderTable.Columns["gvSearchPeriodicTime"].Visible = false;
            gvSearchReminderTable.Columns["frequencyId"].Visible = false;
            gvSearchReminderTable.Columns["periodicActive"].Visible = false;

            gvSearchReminderTable.Columns["gvSearchAlarmDate"].DefaultCellStyle.Format = "dd MMMM yyyy";
            gvSearchReminderTable.Columns["gvSearchAlarmTime"].DefaultCellStyle.Format = "hh:mm tt";

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

            gvSearchReminderTable.Columns["gvSearchDescription"].Visible = false;
            gvSearchReminderTable.Columns["gvSearchPeriodicDate"].Visible = false;
            gvSearchReminderTable.Columns["gvSearchPeriodicTime"].Visible = false;
            gvSearchReminderTable.Columns["frequencyId"].Visible = false;
            gvSearchReminderTable.Columns["periodicActive"].Visible = false;

            gvSearchReminderTable.Columns["gvSearchAlarmDate"].DefaultCellStyle.Format = "dd MMMM yyyy";
            gvSearchReminderTable.Columns["gvSearchAlarmTime"].DefaultCellStyle.Format = "hh:mm tt";


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
                lGridViewTitleAllReminders.Visible = false;

                currentTable = (int)tableStatus.searchtable;
            }
        }
        //
        //
        private void selectActiveTaskTab()
        {
            if (!gvSearchReminderTable.Visible)
            {
                gvSearchReminderTable.Visible = false;
                lGridViewTitleSearch.Visible = false;
                gvReminderTable.Visible = true;
                lGridViewTitleActive.Visible = true;
                gvInactiveReminderTable.Visible = false;
                lGridViewTitleCompleted.Visible = false;
                lGridViewTitleAllReminders.Visible = false;

                currentTable = (int)tableStatus.activeTable;
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
                DateTime reminderAlarm = reminder.Reminder_Date.Value;
                dtpAlarmDate.Format = DateTimePickerFormat.Custom;
                dtpAlarmDate.CustomFormat = "dd MMMM yyyy";
                dtpAlarmDate.Value = reminderAlarm;
                DateTime alarmDateTime = (DateTime)reminder.Reminder_Time;
                dtpAlarmTime.Format = DateTimePickerFormat.Custom;
                dtpAlarmTime.CustomFormat = "hh:mm tt";
                dtpAlarmTime.Value = alarmDateTime;


                checkboxPeriodicAlarm.Checked = reminder.Reminder_IsPeriodic ?? false;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    comboboxPerodicAlarm.SelectedIndex = (int)reminder.Reminder_PeriodicIntervalLabel -1;
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
                DateTime reminderAlarmTime = (DateTime)dtpAlarmTime.Value;

                reminder.Reminder_Date = reminderAlarm;
                reminder.Reminder_Time = reminderAlarmTime;

                reminder.Reminder_IsPeriodic = (Boolean)checkboxPeriodicAlarm.Checked;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    reminder.Reminder_PeriodicActive = true;
                    //int reminderPerodicAlarm = comboboxPerodicAlarm.SelectedIndex;
                    //reminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm + 1;

                    //Adds the required repeat date
                    switch (comboboxPerodicAlarm.SelectedIndex)
                    {
                        case (int)Timeframe.Daily:
                            reminder.Reminder_PeriodicIntervalLabel = 1;
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case (int)Timeframe.Weekly:
                            reminder.Reminder_PeriodicIntervalLabel = 2;
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(7));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case (int)Timeframe.Monthly:
                            reminder.Reminder_PeriodicIntervalLabel = 3;
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddMonths(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case (int)Timeframe.Yearly:
                            reminder.Reminder_PeriodicIntervalLabel = 4;
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
                DateTime reminderAlarmTime = dtpAlarmTime.Value;

                reminder.Reminder_Date = reminderAlarm;
                reminder.Reminder_Time = reminderAlarmTime;

                reminder.Reminder_IsPeriodic = (Boolean)checkboxPeriodicAlarm.Checked;
                if (checkboxPeriodicAlarm.Checked == true)
                {
                    reminder.Reminder_PeriodicActive = true;
                    //int reminderPerodicAlarm = comboboxPerodicAlarm.SelectedIndex;
                    //reminder.Reminder_PeriodicIntervalLabel = reminderPerodicAlarm + 1;

                    //Adds the required repeat date
                    switch (comboboxPerodicAlarm.SelectedIndex)
                    {
                        case (int)Timeframe.Daily:
                            reminder.Reminder_PeriodicIntervalLabel = 1;
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case (int)Timeframe.Weekly:
                            reminder.Reminder_PeriodicIntervalLabel = 2;
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddDays(7));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case (int)Timeframe.Monthly:
                            reminder.Reminder_PeriodicIntervalLabel = 3;
                            reminder.Reminder_NextPeriodicDate = (reminderAlarm.AddMonths(1));
                            reminder.Reminder_NextPeriodicTime = reminderAlarmTime;
                            break;
                        case (int)Timeframe.Yearly:
                            reminder.Reminder_PeriodicIntervalLabel = 4;
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
   /*         gvInactiveReminderTable.DefaultCellStyle.SelectionBackColor = Color.Blue;
            gvInactiveReminderTable.DefaultCellStyle.SelectionForeColor = Color.Red;*/
        }

        private void gvInactiveReminderTable_MouseLeave(object sender, EventArgs e)
        {
           /* gvInactiveReminderTable.DefaultCellStyle.SelectionBackColor = Color.Red;
            gvInactiveReminderTable.DefaultCellStyle.SelectionForeColor = Color.Blue;*/
        }

        private void gvSearchReminderTable_MouseEnter(object sender, EventArgs e)
        {
            /*gvSearchReminderTable.DefaultCellStyle.SelectionBackColor = Color.Blue;
            gvSearchReminderTable.DefaultCellStyle.SelectionForeColor = Color.Red;*/
        }

        private void gvSearchReminderTable_MouseLeave(object sender, EventArgs e)
        {
            /*gvSearchReminderTable.DefaultCellStyle.SelectionBackColor = Color.Red;
            gvSearchReminderTable.DefaultCellStyle.SelectionForeColor = Color.Blue;*/
        }

        private void gvReminderTable_MouseEnter(object sender, EventArgs e)
        {
          

            /*if (gvReminderTable.SelectedRows.Count > 0 && gvReminderTable.SelectedRows[0].Cells.Count > 0)
            {
                gvReminderTable.DefaultCellStyle.SelectionBackColor = Color.Blue;
                gvReminderTable.DefaultCellStyle.SelectionForeColor = Color.Red;
            }*/

        }

        private void gvReminderTable_MouseLeave(object sender, EventArgs e)
        {

/*
            gvReminderTable.DefaultCellStyle.SelectionBackColor = Color.Red;
            gvReminderTable.DefaultCellStyle.SelectionForeColor = Color.Blue;*/
        }

        private void gvReminderTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           /* gvReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            if (e.RowIndex > -1)
            {
                gvReminderTable.Rows[e.RowIndex].Selected = true;
            }*/
        }

        private void gvReminderTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
        /*    gvReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            if (e.RowIndex > -1)
            {
                gvReminderTable.Rows[e.RowIndex].Selected = false;
            }*/
        }

        private void gvSearchReminderTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           /* gvSearchReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            if (e.RowIndex > -1)
            {
                gvSearchReminderTable.Rows[e.RowIndex].Selected = true;
            }*/
        }

        private void gvSearchReminderTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
         /*   gvSearchReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            if (e.RowIndex > -1)
            {
                gvSearchReminderTable.Rows[e.RowIndex].Selected = false;
            }*/
        }

        private void gvInactiveReminderTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
          /*  gvInactiveReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            if (e.RowIndex > -1)
            {
                gvInactiveReminderTable.Rows[e.RowIndex].Selected = true;
            }*/

        }

        private void gvInactiveReminderTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           /* gvInactiveReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.LightBlue;
            if (e.RowIndex > -1)
            {
                gvInactiveReminderTable.Rows[e.RowIndex].Selected = false;
            }*/
        }

        private void gvInactiveReminderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gvInactiveReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            if (e.RowIndex > -1)
            {
                gvInactiveReminderTable.Rows[e.RowIndex].Selected = true;
            }
        }

        private void gvSearchReminderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gvSearchReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            if (e.RowIndex > -1)
            {
                gvSearchReminderTable.Rows[e.RowIndex].Selected = true;
            }
        }

        private void gvReminderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gvReminderTable.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            if (e.RowIndex > -1)
            {
                gvReminderTable.Rows[e.RowIndex].Selected = true;
            }
        }

      




        //
        //


    }
}
