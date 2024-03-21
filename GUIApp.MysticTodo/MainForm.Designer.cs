namespace GUIApp.MysticTodo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TcMainTabControl = new System.Windows.Forms.TabControl();
            this.TpReminder = new System.Windows.Forms.TabPage();
            this.BSubmit = new System.Windows.Forms.Button();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.LDescription = new System.Windows.Forms.Label();
            this.CbPerodicAlarm = new System.Windows.Forms.ComboBox();
            this.DtpAlarmDate = new System.Windows.Forms.DateTimePicker();
            this.CheckbPeriodicAlarm = new System.Windows.Forms.CheckBox();
            this.CebSetAlarm = new System.Windows.Forms.CheckBox();
            this.LbTitleReminder = new System.Windows.Forms.Label();
            this.TbReminder = new System.Windows.Forms.TextBox();
            this.ScReminderPage = new System.Windows.Forms.SplitContainer();
            this.LbNewReminder = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reminder_HasAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reminder_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderFreqencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder_NextPeriodicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder_NextPeriodicTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.BSearch = new System.Windows.Forms.Button();
            this.LSearchReminders = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TpCalender = new System.Windows.Forms.TabPage();
            this.TpTimeTable = new System.Windows.Forms.TabPage();
            this.TpAlarm = new System.Windows.Forms.TabPage();
            this.TpStopWatch = new System.Windows.Forms.TabPage();
            this.TpTimer = new System.Windows.Forms.TabPage();
            this.timeframeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mysticToDoDBEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MsFileMenu = new System.Windows.Forms.MenuStrip();
            this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TpmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TpmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.TpmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderIsCompleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reminderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderIsPeriodicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reminderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TcMainTabControl.SuspendLayout();
            this.TpReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).BeginInit();
            this.ScReminderPage.Panel1.SuspendLayout();
            this.ScReminderPage.Panel2.SuspendLayout();
            this.ScReminderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeframeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysticToDoDBEntitiesBindingSource)).BeginInit();
            this.MsFileMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reminderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TcMainTabControl
            // 
            this.TcMainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TcMainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TcMainTabControl.Controls.Add(this.TpReminder);
            this.TcMainTabControl.Controls.Add(this.TpCalender);
            this.TcMainTabControl.Controls.Add(this.TpTimeTable);
            this.TcMainTabControl.Controls.Add(this.TpAlarm);
            this.TcMainTabControl.Controls.Add(this.TpStopWatch);
            this.TcMainTabControl.Controls.Add(this.TpTimer);
            this.TcMainTabControl.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcMainTabControl.Location = new System.Drawing.Point(0, 36);
            this.TcMainTabControl.Multiline = true;
            this.TcMainTabControl.Name = "TcMainTabControl";
            this.TcMainTabControl.SelectedIndex = 0;
            this.TcMainTabControl.ShowToolTips = true;
            this.TcMainTabControl.Size = new System.Drawing.Size(1572, 1034);
            this.TcMainTabControl.TabIndex = 0;
            // 
            // TpReminder
            // 
            this.TpReminder.Controls.Add(this.LDescription);
            this.TpReminder.Controls.Add(this.CbPerodicAlarm);
            this.TpReminder.Controls.Add(this.DtpAlarmDate);
            this.TpReminder.Controls.Add(this.CheckbPeriodicAlarm);
            this.TpReminder.Controls.Add(this.CebSetAlarm);
            this.TpReminder.Controls.Add(this.LbTitleReminder);
            this.TpReminder.Controls.Add(this.TbReminder);
            this.TpReminder.Controls.Add(this.ScReminderPage);
            this.TpReminder.Location = new System.Drawing.Point(31, 4);
            this.TpReminder.Name = "TpReminder";
            this.TpReminder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpReminder.Size = new System.Drawing.Size(1537, 1026);
            this.TpReminder.TabIndex = 0;
            this.TpReminder.Text = "Reminder";
            this.TpReminder.UseVisualStyleBackColor = true;
            // 
            // BSubmit
            // 
            this.BSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSubmit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSubmit.Location = new System.Drawing.Point(1263, 121);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(224, 52);
            this.BSubmit.TabIndex = 9;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = false;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // TbDescription
            // 
            this.TbDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TbDescription.Location = new System.Drawing.Point(919, 173);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(302, 104);
            this.TbDescription.TabIndex = 8;
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.BackColor = System.Drawing.Color.Silver;
            this.LDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LDescription.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescription.Location = new System.Drawing.Point(744, 176);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(156, 30);
            this.LDescription.TabIndex = 7;
            this.LDescription.Text = "Description";
            this.LDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CbPerodicAlarm
            // 
            this.CbPerodicAlarm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CbPerodicAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbPerodicAlarm.FormattingEnabled = true;
            this.CbPerodicAlarm.Location = new System.Drawing.Point(383, 227);
            this.CbPerodicAlarm.Name = "CbPerodicAlarm";
            this.CbPerodicAlarm.Size = new System.Drawing.Size(338, 30);
            this.CbPerodicAlarm.TabIndex = 6;
            // 
            // DtpAlarmDate
            // 
            this.DtpAlarmDate.Location = new System.Drawing.Point(383, 177);
            this.DtpAlarmDate.Name = "DtpAlarmDate";
            this.DtpAlarmDate.Size = new System.Drawing.Size(338, 29);
            this.DtpAlarmDate.TabIndex = 5;
            // 
            // CheckbPeriodicAlarm
            // 
            this.CheckbPeriodicAlarm.AutoSize = true;
            this.CheckbPeriodicAlarm.BackColor = System.Drawing.Color.Silver;
            this.CheckbPeriodicAlarm.Location = new System.Drawing.Point(170, 227);
            this.CheckbPeriodicAlarm.Name = "CheckbPeriodicAlarm";
            this.CheckbPeriodicAlarm.Size = new System.Drawing.Size(175, 26);
            this.CheckbPeriodicAlarm.TabIndex = 4;
            this.CheckbPeriodicAlarm.Text = "Periodic Alarm";
            this.CheckbPeriodicAlarm.UseVisualStyleBackColor = false;
            this.CheckbPeriodicAlarm.CheckedChanged += new System.EventHandler(this.CheckbPeriodicAlarm_CheckedChanged);
            // 
            // CebSetAlarm
            // 
            this.CebSetAlarm.AutoSize = true;
            this.CebSetAlarm.BackColor = System.Drawing.Color.Silver;
            this.CebSetAlarm.Location = new System.Drawing.Point(218, 181);
            this.CebSetAlarm.Name = "CebSetAlarm";
            this.CebSetAlarm.Size = new System.Drawing.Size(127, 26);
            this.CebSetAlarm.TabIndex = 3;
            this.CebSetAlarm.Text = "Set Alarm";
            this.CebSetAlarm.UseVisualStyleBackColor = false;
            this.CebSetAlarm.CheckedChanged += new System.EventHandler(this.CebSetAlarm_CheckedChanged);
            // 
            // LbTitleReminder
            // 
            this.LbTitleReminder.AutoSize = true;
            this.LbTitleReminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LbTitleReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbTitleReminder.Font = new System.Drawing.Font("Stencil BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleReminder.Location = new System.Drawing.Point(632, 30);
            this.LbTitleReminder.Name = "LbTitleReminder";
            this.LbTitleReminder.Size = new System.Drawing.Size(278, 57);
            this.LbTitleReminder.TabIndex = 1;
            this.LbTitleReminder.Text = "Reminder";
            this.LbTitleReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbReminder
            // 
            this.TbReminder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TbReminder.Location = new System.Drawing.Point(383, 124);
            this.TbReminder.Name = "TbReminder";
            this.TbReminder.Size = new System.Drawing.Size(841, 29);
            this.TbReminder.TabIndex = 0;
            // 
            // ScReminderPage
            // 
            this.ScReminderPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScReminderPage.Location = new System.Drawing.Point(3, 3);
            this.ScReminderPage.Name = "ScReminderPage";
            this.ScReminderPage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScReminderPage.Panel1
            // 
            this.ScReminderPage.Panel1.BackColor = System.Drawing.Color.Silver;
            this.ScReminderPage.Panel1.Controls.Add(this.TbDescription);
            this.ScReminderPage.Panel1.Controls.Add(this.BSubmit);
            this.ScReminderPage.Panel1.Controls.Add(this.LbNewReminder);
            this.ScReminderPage.Panel1.Controls.Add(this.BUpdate);
            this.ScReminderPage.Panel1.Controls.Add(this.BDelete);
            this.ScReminderPage.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ScReminderPage.Panel2
            // 
            this.ScReminderPage.Panel2.Controls.Add(this.vScrollBar1);
            this.ScReminderPage.Panel2.Controls.Add(this.hScrollBar1);
            this.ScReminderPage.Panel2.Controls.Add(this.dataGridView1);
            this.ScReminderPage.Panel2.Controls.Add(this.BSearch);
            this.ScReminderPage.Panel2.Controls.Add(this.LSearchReminders);
            this.ScReminderPage.Panel2.Controls.Add(this.textBox2);
            this.ScReminderPage.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScReminderPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScReminderPage.Size = new System.Drawing.Size(1531, 1020);
            this.ScReminderPage.SplitterDistance = 291;
            this.ScReminderPage.TabIndex = 10;
            // 
            // LbNewReminder
            // 
            this.LbNewReminder.AutoSize = true;
            this.LbNewReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbNewReminder.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNewReminder.Location = new System.Drawing.Point(38, 118);
            this.LbNewReminder.Name = "LbNewReminder";
            this.LbNewReminder.Size = new System.Drawing.Size(301, 37);
            this.LbNewReminder.TabIndex = 2;
            this.LbNewReminder.Text = "Add New Reminder";
            this.LbNewReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1505, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 704);
            this.vScrollBar1.TabIndex = 14;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 704);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1531, 21);
            this.hScrollBar1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reminderIsCompleteDataGridViewTextBoxColumn,
            this.reminderIdDataGridViewTextBoxColumn,
            this.reminderNameDataGridViewTextBoxColumn,
            this.reminderDescriptionDataGridViewTextBoxColumn,
            this.Reminder_HasAlarm,
            this.Reminder_Date,
            this.Reminder_Time,
            this.reminderIsPeriodicDataGridViewTextBoxColumn,
            this.reminderFreqencyDataGridViewTextBoxColumn,
            this.Reminder_NextPeriodicDate,
            this.Reminder_NextPeriodicTime});
            this.dataGridView1.DataSource = this.reminderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1534, 590);
            this.dataGridView1.TabIndex = 12;
            // 
            // Reminder_HasAlarm
            // 
            this.Reminder_HasAlarm.DataPropertyName = "Reminder_HasAlarm";
            this.Reminder_HasAlarm.HeaderText = "Alarm";
            this.Reminder_HasAlarm.MinimumWidth = 8;
            this.Reminder_HasAlarm.Name = "Reminder_HasAlarm";
            this.Reminder_HasAlarm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Reminder_HasAlarm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reminder_HasAlarm.Width = 150;
            // 
            // Reminder_Date
            // 
            this.Reminder_Date.DataPropertyName = "Reminder_Date";
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.Reminder_Date.DefaultCellStyle = dataGridViewCellStyle6;
            this.Reminder_Date.HeaderText = "Alarm Date";
            this.Reminder_Date.MinimumWidth = 8;
            this.Reminder_Date.Name = "Reminder_Date";
            this.Reminder_Date.Width = 200;
            // 
            // Reminder_Time
            // 
            this.Reminder_Time.DataPropertyName = "Reminder_Time";
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = null;
            this.Reminder_Time.DefaultCellStyle = dataGridViewCellStyle7;
            this.Reminder_Time.HeaderText = "Alarm Time";
            this.Reminder_Time.MinimumWidth = 8;
            this.Reminder_Time.Name = "Reminder_Time";
            this.Reminder_Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Reminder_Time.Width = 150;
            // 
            // reminderFreqencyDataGridViewTextBoxColumn
            // 
            this.reminderFreqencyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.reminderFreqencyDataGridViewTextBoxColumn.DataPropertyName = "Reminder_PeriodicIntervalLabel";
            this.reminderFreqencyDataGridViewTextBoxColumn.HeaderText = "Freqency";
            this.reminderFreqencyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reminderFreqencyDataGridViewTextBoxColumn.Name = "reminderFreqencyDataGridViewTextBoxColumn";
            this.reminderFreqencyDataGridViewTextBoxColumn.Width = 128;
            // 
            // Reminder_NextPeriodicDate
            // 
            this.Reminder_NextPeriodicDate.DataPropertyName = "Reminder_NextPeriodicDate";
            dataGridViewCellStyle8.Format = "D";
            dataGridViewCellStyle8.NullValue = null;
            this.Reminder_NextPeriodicDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.Reminder_NextPeriodicDate.HeaderText = "Periodic Date";
            this.Reminder_NextPeriodicDate.MinimumWidth = 8;
            this.Reminder_NextPeriodicDate.Name = "Reminder_NextPeriodicDate";
            this.Reminder_NextPeriodicDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Reminder_NextPeriodicDate.Width = 200;
            // 
            // Reminder_NextPeriodicTime
            // 
            this.Reminder_NextPeriodicTime.DataPropertyName = "Reminder_NextPeriodicTime";
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.Reminder_NextPeriodicTime.DefaultCellStyle = dataGridViewCellStyle9;
            this.Reminder_NextPeriodicTime.HeaderText = "Periodic Time";
            this.Reminder_NextPeriodicTime.MinimumWidth = 8;
            this.Reminder_NextPeriodicTime.Name = "Reminder_NextPeriodicTime";
            this.Reminder_NextPeriodicTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Reminder_NextPeriodicTime.Width = 150;
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.Color.LawnGreen;
            this.BUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUpdate.Location = new System.Drawing.Point(1263, 187);
            this.BUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(224, 42);
            this.BUpdate.TabIndex = 17;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BDelete
            // 
            this.BDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BDelete.Location = new System.Drawing.Point(1263, 233);
            this.BDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(224, 44);
            this.BDelete.TabIndex = 16;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = false;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.Color.LightBlue;
            this.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSearch.Location = new System.Drawing.Point(1166, 14);
            this.BSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(169, 38);
            this.BSearch.TabIndex = 15;
            this.BSearch.Text = "Search";
            this.BSearch.UseVisualStyleBackColor = false;
            // 
            // LSearchReminders
            // 
            this.LSearchReminders.AutoSize = true;
            this.LSearchReminders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LSearchReminders.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSearchReminders.Location = new System.Drawing.Point(38, 15);
            this.LSearchReminders.Name = "LSearchReminders";
            this.LSearchReminders.Size = new System.Drawing.Size(280, 37);
            this.LSearchReminders.TabIndex = 11;
            this.LSearchReminders.Text = "Search Reminders";
            this.LSearchReminders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(313, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(841, 29);
            this.textBox2.TabIndex = 11;
            // 
            // TpCalender
            // 
            this.TpCalender.Location = new System.Drawing.Point(31, 4);
            this.TpCalender.Name = "TpCalender";
            this.TpCalender.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpCalender.Size = new System.Drawing.Size(1537, 1026);
            this.TpCalender.TabIndex = 1;
            this.TpCalender.Text = "Calender";
            this.TpCalender.UseVisualStyleBackColor = true;
            // 
            // TpTimeTable
            // 
            this.TpTimeTable.Location = new System.Drawing.Point(31, 4);
            this.TpTimeTable.Name = "TpTimeTable";
            this.TpTimeTable.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpTimeTable.Size = new System.Drawing.Size(1537, 1026);
            this.TpTimeTable.TabIndex = 2;
            this.TpTimeTable.Text = "TimeTable";
            this.TpTimeTable.UseVisualStyleBackColor = true;
            // 
            // TpAlarm
            // 
            this.TpAlarm.Location = new System.Drawing.Point(31, 4);
            this.TpAlarm.Name = "TpAlarm";
            this.TpAlarm.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpAlarm.Size = new System.Drawing.Size(1537, 1026);
            this.TpAlarm.TabIndex = 3;
            this.TpAlarm.Text = "Alarm";
            this.TpAlarm.UseVisualStyleBackColor = true;
            // 
            // TpStopWatch
            // 
            this.TpStopWatch.Location = new System.Drawing.Point(31, 4);
            this.TpStopWatch.Name = "TpStopWatch";
            this.TpStopWatch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpStopWatch.Size = new System.Drawing.Size(1537, 1026);
            this.TpStopWatch.TabIndex = 4;
            this.TpStopWatch.Text = "StopWatch";
            this.TpStopWatch.UseVisualStyleBackColor = true;
            // 
            // TpTimer
            // 
            this.TpTimer.Location = new System.Drawing.Point(31, 4);
            this.TpTimer.Name = "TpTimer";
            this.TpTimer.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TpTimer.Size = new System.Drawing.Size(1537, 1026);
            this.TpTimer.TabIndex = 5;
            this.TpTimer.Text = "Timer";
            this.TpTimer.UseVisualStyleBackColor = true;
            // 
            // MsFileMenu
            // 
            this.MsFileMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MsFileMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MsFileMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MsFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.TpmiEdit,
            this.TpmiView,
            this.TpmiHelp});
            this.MsFileMenu.Location = new System.Drawing.Point(0, 0);
            this.MsFileMenu.Name = "MsFileMenu";
            this.MsFileMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.MsFileMenu.Size = new System.Drawing.Size(1567, 36);
            this.MsFileMenu.TabIndex = 1;
            this.MsFileMenu.Text = "File";
            // 
            // TsmiFile
            // 
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(54, 32);
            this.TsmiFile.Text = "File";
            // 
            // TpmiEdit
            // 
            this.TpmiEdit.Name = "TpmiEdit";
            this.TpmiEdit.Size = new System.Drawing.Size(58, 32);
            this.TpmiEdit.Text = "Edit";
            // 
            // TpmiView
            // 
            this.TpmiView.Name = "TpmiView";
            this.TpmiView.Size = new System.Drawing.Size(65, 32);
            this.TpmiView.Text = "View";
            // 
            // TpmiHelp
            // 
            this.TpmiHelp.Name = "TpmiHelp";
            this.TpmiHelp.Size = new System.Drawing.Size(65, 32);
            this.TpmiHelp.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1066);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1567, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(45, 29);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(89, 24);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Timeframe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Timeframe";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // reminderIsCompleteDataGridViewTextBoxColumn
            // 
            this.reminderIsCompleteDataGridViewTextBoxColumn.DataPropertyName = "Reminder_IsComplete";
            this.reminderIsCompleteDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reminderIsCompleteDataGridViewTextBoxColumn.Frozen = true;
            this.reminderIsCompleteDataGridViewTextBoxColumn.HeaderText = "Active";
            this.reminderIsCompleteDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.reminderIsCompleteDataGridViewTextBoxColumn.Name = "reminderIsCompleteDataGridViewTextBoxColumn";
            this.reminderIsCompleteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reminderIsCompleteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reminderIsCompleteDataGridViewTextBoxColumn.Width = 60;
            // 
            // reminderIdDataGridViewTextBoxColumn
            // 
            this.reminderIdDataGridViewTextBoxColumn.DataPropertyName = "Reminder_Id";
            this.reminderIdDataGridViewTextBoxColumn.FillWeight = 10F;
            this.reminderIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.reminderIdDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.reminderIdDataGridViewTextBoxColumn.Name = "reminderIdDataGridViewTextBoxColumn";
            this.reminderIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reminderIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // reminderNameDataGridViewTextBoxColumn
            // 
            this.reminderNameDataGridViewTextBoxColumn.DataPropertyName = "Reminder_Name";
            this.reminderNameDataGridViewTextBoxColumn.HeaderText = "Task";
            this.reminderNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reminderNameDataGridViewTextBoxColumn.Name = "reminderNameDataGridViewTextBoxColumn";
            this.reminderNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // reminderDescriptionDataGridViewTextBoxColumn
            // 
            this.reminderDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Reminder_Description";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reminderDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.reminderDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.reminderDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reminderDescriptionDataGridViewTextBoxColumn.Name = "reminderDescriptionDataGridViewTextBoxColumn";
            this.reminderDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // reminderIsPeriodicDataGridViewTextBoxColumn
            // 
            this.reminderIsPeriodicDataGridViewTextBoxColumn.DataPropertyName = "Reminder_IsPeriodic";
            this.reminderIsPeriodicDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reminderIsPeriodicDataGridViewTextBoxColumn.HeaderText = "Periodic";
            this.reminderIsPeriodicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reminderIsPeriodicDataGridViewTextBoxColumn.Name = "reminderIsPeriodicDataGridViewTextBoxColumn";
            this.reminderIsPeriodicDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reminderIsPeriodicDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reminderIsPeriodicDataGridViewTextBoxColumn.Width = 70;
            // 
            // reminderBindingSource
            // 
            this.reminderBindingSource.DataSource = typeof(GUIApp.MysticTodo.Data.Reminder);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 1098);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TcMainTabControl);
            this.Controls.Add(this.MsFileMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MsFileMenu;
            this.Name = "MainForm";
            this.Text = "MysticToDo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TcMainTabControl.ResumeLayout(false);
            this.TpReminder.ResumeLayout(false);
            this.TpReminder.PerformLayout();
            this.ScReminderPage.Panel1.ResumeLayout(false);
            this.ScReminderPage.Panel1.PerformLayout();
            this.ScReminderPage.Panel2.ResumeLayout(false);
            this.ScReminderPage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).EndInit();
            this.ScReminderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeframeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysticToDoDBEntitiesBindingSource)).EndInit();
            this.MsFileMenu.ResumeLayout(false);
            this.MsFileMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reminderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TcMainTabControl;
        private System.Windows.Forms.TabPage TpReminder;
        private System.Windows.Forms.TabPage TpCalender;
        private System.Windows.Forms.TabPage TpTimeTable;
        private System.Windows.Forms.TabPage TpAlarm;
        private System.Windows.Forms.TabPage TpStopWatch;
        private System.Windows.Forms.TabPage TpTimer;
        private System.Windows.Forms.MenuStrip MsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiFile;
        private System.Windows.Forms.ToolStripMenuItem TpmiEdit;
        private System.Windows.Forms.ToolStripMenuItem TpmiView;
        private System.Windows.Forms.ToolStripMenuItem TpmiHelp;
        private System.Windows.Forms.Label LbTitleReminder;
        private System.Windows.Forms.TextBox TbReminder;
        private System.Windows.Forms.Label LbNewReminder;
        private System.Windows.Forms.CheckBox CheckbPeriodicAlarm;
        private System.Windows.Forms.CheckBox CebSetAlarm;
        private System.Windows.Forms.ComboBox CbPerodicAlarm;
        private System.Windows.Forms.DateTimePicker DtpAlarmDate;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LDescription;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.SplitContainer ScReminderPage;
        private System.Windows.Forms.Label LSearchReminders;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource mysticToDoDBEntitiesBindingSource;
        private System.Windows.Forms.BindingSource timeframeBindingSource;
        private System.Windows.Forms.BindingSource reminderBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reminderHasAlarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reminderReminderActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderNextPeriodicDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reminderIsCompleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reminder_HasAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminder_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminder_Time;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reminderIsPeriodicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reminderFreqencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminder_NextPeriodicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminder_NextPeriodicTime;
    }
}

