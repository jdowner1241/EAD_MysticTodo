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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TcMainTabControl = new System.Windows.Forms.TabControl();
            this.TpReminder = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar3 = new System.Windows.Forms.ToolStripProgressBar();
            this.ScReminderPage = new System.Windows.Forms.SplitContainer();
            this.gbReminderEditor = new System.Windows.Forms.GroupBox();
            this.LbTitleReminder = new System.Windows.Forms.Label();
            this.TbReminder = new System.Windows.Forms.TextBox();
            this.LbNewReminder = new System.Windows.Forms.Label();
            this.CheckbPeriodicAlarm = new System.Windows.Forms.CheckBox();
            this.CebSetAlarm = new System.Windows.Forms.CheckBox();
            this.DtpAlarmDate = new System.Windows.Forms.DateTimePicker();
            this.CbPerodicAlarm = new System.Windows.Forms.ComboBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.LDescription = new System.Windows.Forms.Label();
            this.BSubmit = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.gvReminderList = new System.Windows.Forms.DataGridView();
            this.gbReminderSearch = new System.Windows.Forms.GroupBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.LSearchReminders = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
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
            this.gvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvAlarmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvAlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPeriodic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvPeriodicFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPeriodicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPeriodicTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TcMainTabControl.SuspendLayout();
            this.TpReminder.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).BeginInit();
            this.ScReminderPage.Panel1.SuspendLayout();
            this.ScReminderPage.Panel2.SuspendLayout();
            this.ScReminderPage.SuspendLayout();
            this.gbReminderEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReminderList)).BeginInit();
            this.gbReminderSearch.SuspendLayout();
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
            this.TcMainTabControl.Controls.Add(this.TpReminder);
            this.TcMainTabControl.Controls.Add(this.TpCalender);
            this.TcMainTabControl.Controls.Add(this.TpTimeTable);
            this.TcMainTabControl.Controls.Add(this.TpAlarm);
            this.TcMainTabControl.Controls.Add(this.TpStopWatch);
            this.TcMainTabControl.Controls.Add(this.TpTimer);
            this.TcMainTabControl.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcMainTabControl.Location = new System.Drawing.Point(0, 29);
            this.TcMainTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TcMainTabControl.Multiline = true;
            this.TcMainTabControl.Name = "TcMainTabControl";
            this.TcMainTabControl.SelectedIndex = 0;
            this.TcMainTabControl.ShowToolTips = true;
            this.TcMainTabControl.Size = new System.Drawing.Size(1181, 916);
            this.TcMainTabControl.TabIndex = 0;
            // 
            // TpReminder
            // 
            this.TpReminder.Controls.Add(this.statusStrip2);
            this.TpReminder.Controls.Add(this.ScReminderPage);
            this.TpReminder.Location = new System.Drawing.Point(23, 4);
            this.TpReminder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpReminder.Name = "TpReminder";
            this.TpReminder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpReminder.Size = new System.Drawing.Size(1154, 908);
            this.TpReminder.TabIndex = 0;
            this.TpReminder.Text = "Reminder";
            this.TpReminder.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar2,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar3});
            this.statusStrip2.Location = new System.Drawing.Point(2, 880);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1150, 26);
            this.statusStrip2.TabIndex = 17;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(75, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 21);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripProgressBar3
            // 
            this.toolStripProgressBar3.Name = "toolStripProgressBar3";
            this.toolStripProgressBar3.Size = new System.Drawing.Size(75, 20);
            // 
            // ScReminderPage
            // 
            this.ScReminderPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScReminderPage.Location = new System.Drawing.Point(-35, 5);
            this.ScReminderPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScReminderPage.Name = "ScReminderPage";
            this.ScReminderPage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScReminderPage.Panel1
            // 
            this.ScReminderPage.Panel1.BackColor = System.Drawing.Color.Silver;
            this.ScReminderPage.Panel1.Controls.Add(this.gbReminderEditor);
            this.ScReminderPage.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScReminderPage.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ScReminderPage_Panel1_Paint);
            // 
            // ScReminderPage.Panel2
            // 
            this.ScReminderPage.Panel2.AutoScroll = true;
            this.ScReminderPage.Panel2.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.ScReminderPage.Panel2.Controls.Add(this.gvReminderList);
            this.ScReminderPage.Panel2.Controls.Add(this.gbReminderSearch);
            this.ScReminderPage.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScReminderPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScReminderPage.Size = new System.Drawing.Size(1230, 888);
            this.ScReminderPage.SplitterDistance = 318;
            this.ScReminderPage.SplitterWidth = 3;
            this.ScReminderPage.TabIndex = 10;
            // 
            // gbReminderEditor
            // 
            this.gbReminderEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReminderEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbReminderEditor.Controls.Add(this.LbTitleReminder);
            this.gbReminderEditor.Controls.Add(this.TbReminder);
            this.gbReminderEditor.Controls.Add(this.LbNewReminder);
            this.gbReminderEditor.Controls.Add(this.CheckbPeriodicAlarm);
            this.gbReminderEditor.Controls.Add(this.CebSetAlarm);
            this.gbReminderEditor.Controls.Add(this.DtpAlarmDate);
            this.gbReminderEditor.Controls.Add(this.CbPerodicAlarm);
            this.gbReminderEditor.Controls.Add(this.TbDescription);
            this.gbReminderEditor.Controls.Add(this.LDescription);
            this.gbReminderEditor.Controls.Add(this.BSubmit);
            this.gbReminderEditor.Controls.Add(this.BUpdate);
            this.gbReminderEditor.Controls.Add(this.BDelete);
            this.gbReminderEditor.Location = new System.Drawing.Point(52, 49);
            this.gbReminderEditor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReminderEditor.MaximumSize = new System.Drawing.Size(1088, 217);
            this.gbReminderEditor.Name = "gbReminderEditor";
            this.gbReminderEditor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReminderEditor.Size = new System.Drawing.Size(1085, 217);
            this.gbReminderEditor.TabIndex = 18;
            this.gbReminderEditor.TabStop = false;
            // 
            // LbTitleReminder
            // 
            this.LbTitleReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitleReminder.AutoSize = true;
            this.LbTitleReminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LbTitleReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbTitleReminder.Font = new System.Drawing.Font("Stencil BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleReminder.Location = new System.Drawing.Point(445, 8);
            this.LbTitleReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTitleReminder.Name = "LbTitleReminder";
            this.LbTitleReminder.Size = new System.Drawing.Size(185, 39);
            this.LbTitleReminder.TabIndex = 19;
            this.LbTitleReminder.Text = "Reminder";
            this.LbTitleReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbReminder
            // 
            this.TbReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbReminder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TbReminder.Location = new System.Drawing.Point(255, 78);
            this.TbReminder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbReminder.MaximumSize = new System.Drawing.Size(632, 29);
            this.TbReminder.MaxLength = 842;
            this.TbReminder.Name = "TbReminder";
            this.TbReminder.Size = new System.Drawing.Size(632, 22);
            this.TbReminder.TabIndex = 18;
            this.TbReminder.WordWrap = false;
            // 
            // LbNewReminder
            // 
            this.LbNewReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNewReminder.AutoSize = true;
            this.LbNewReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbNewReminder.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNewReminder.Location = new System.Drawing.Point(2, 78);
            this.LbNewReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbNewReminder.Name = "LbNewReminder";
            this.LbNewReminder.Size = new System.Drawing.Size(207, 25);
            this.LbNewReminder.TabIndex = 20;
            this.LbNewReminder.Text = "Add New Reminder";
            this.LbNewReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckbPeriodicAlarm
            // 
            this.CheckbPeriodicAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckbPeriodicAlarm.AutoSize = true;
            this.CheckbPeriodicAlarm.BackColor = System.Drawing.Color.Silver;
            this.CheckbPeriodicAlarm.Location = new System.Drawing.Point(97, 176);
            this.CheckbPeriodicAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckbPeriodicAlarm.Name = "CheckbPeriodicAlarm";
            this.CheckbPeriodicAlarm.Size = new System.Drawing.Size(126, 20);
            this.CheckbPeriodicAlarm.TabIndex = 22;
            this.CheckbPeriodicAlarm.Text = "Periodic Alarm";
            this.CheckbPeriodicAlarm.UseVisualStyleBackColor = false;
            this.CheckbPeriodicAlarm.CheckedChanged += new System.EventHandler(this.CheckbPeriodicAlarm_CheckedChanged);
            // 
            // CebSetAlarm
            // 
            this.CebSetAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CebSetAlarm.AutoSize = true;
            this.CebSetAlarm.BackColor = System.Drawing.Color.Silver;
            this.CebSetAlarm.Location = new System.Drawing.Point(133, 128);
            this.CebSetAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CebSetAlarm.Name = "CebSetAlarm";
            this.CebSetAlarm.Size = new System.Drawing.Size(91, 20);
            this.CebSetAlarm.TabIndex = 21;
            this.CebSetAlarm.Text = "Set Alarm";
            this.CebSetAlarm.UseVisualStyleBackColor = false;
            this.CebSetAlarm.CheckedChanged += new System.EventHandler(this.CebSetAlarm_CheckedChanged);
            // 
            // DtpAlarmDate
            // 
            this.DtpAlarmDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpAlarmDate.Location = new System.Drawing.Point(255, 132);
            this.DtpAlarmDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpAlarmDate.MaximumSize = new System.Drawing.Size(258, 29);
            this.DtpAlarmDate.Name = "DtpAlarmDate";
            this.DtpAlarmDate.Size = new System.Drawing.Size(258, 22);
            this.DtpAlarmDate.TabIndex = 23;
            // 
            // CbPerodicAlarm
            // 
            this.CbPerodicAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbPerodicAlarm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CbPerodicAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbPerodicAlarm.FormattingEnabled = true;
            this.CbPerodicAlarm.Location = new System.Drawing.Point(256, 176);
            this.CbPerodicAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbPerodicAlarm.Name = "CbPerodicAlarm";
            this.CbPerodicAlarm.Size = new System.Drawing.Size(254, 23);
            this.CbPerodicAlarm.TabIndex = 24;
            // 
            // TbDescription
            // 
            this.TbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TbDescription.Location = new System.Drawing.Point(660, 128);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(228, 85);
            this.TbDescription.TabIndex = 26;
            // 
            // LDescription
            // 
            this.LDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LDescription.AutoSize = true;
            this.LDescription.BackColor = System.Drawing.Color.Silver;
            this.LDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LDescription.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescription.Location = new System.Drawing.Point(536, 128);
            this.LDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(111, 21);
            this.LDescription.TabIndex = 25;
            this.LDescription.Text = "Description";
            this.LDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BSubmit
            // 
            this.BSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSubmit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSubmit.Location = new System.Drawing.Point(919, 78);
            this.BSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(168, 42);
            this.BSubmit.TabIndex = 27;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = false;
            // 
            // BUpdate
            // 
            this.BUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUpdate.BackColor = System.Drawing.Color.LawnGreen;
            this.BUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUpdate.Location = new System.Drawing.Point(918, 128);
            this.BUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(168, 34);
            this.BUpdate.TabIndex = 29;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = false;
            // 
            // BDelete
            // 
            this.BDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BDelete.Location = new System.Drawing.Point(917, 176);
            this.BDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(168, 36);
            this.BDelete.TabIndex = 28;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = false;
            // 
            // gvReminderList
            // 
            this.gvReminderList.AllowUserToOrderColumns = true;
            this.gvReminderList.AllowUserToResizeColumns = false;
            this.gvReminderList.AllowUserToResizeRows = false;
            this.gvReminderList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvReminderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gvReminderList.ColumnHeadersHeight = 34;
            this.gvReminderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvId,
            this.gvActive,
            this.gvName,
            this.gvDescription,
            this.gvAlarm,
            this.gvAlarmDate,
            this.gvAlarmTime,
            this.gvPeriodic,
            this.gvPeriodicFrequency,
            this.gvPeriodicDate,
            this.gvPeriodicTime});
            this.gvReminderList.Location = new System.Drawing.Point(66, 136);
            this.gvReminderList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvReminderList.MaximumSize = new System.Drawing.Size(1070, 434);
            this.gvReminderList.Name = "gvReminderList";
            this.gvReminderList.RowHeadersWidth = 62;
            this.gvReminderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvReminderList.RowTemplate.Height = 28;
            this.gvReminderList.Size = new System.Drawing.Size(1070, 417);
            this.gvReminderList.TabIndex = 19;
            // 
            // gbReminderSearch
            // 
            this.gbReminderSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbReminderSearch.Controls.Add(this.BSearch);
            this.gbReminderSearch.Controls.Add(this.LSearchReminders);
            this.gbReminderSearch.Controls.Add(this.tbSearch);
            this.gbReminderSearch.Location = new System.Drawing.Point(59, 12);
            this.gbReminderSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReminderSearch.MaximumSize = new System.Drawing.Size(1085, 111);
            this.gbReminderSearch.Name = "gbReminderSearch";
            this.gbReminderSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReminderSearch.Size = new System.Drawing.Size(1085, 111);
            this.gbReminderSearch.TabIndex = 18;
            this.gbReminderSearch.TabStop = false;
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.Color.LightBlue;
            this.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSearch.Location = new System.Drawing.Point(915, 24);
            this.BSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(170, 31);
            this.BSearch.TabIndex = 18;
            this.BSearch.Text = "Search";
            this.BSearch.UseVisualStyleBackColor = false;
            // 
            // LSearchReminders
            // 
            this.LSearchReminders.AutoSize = true;
            this.LSearchReminders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LSearchReminders.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSearchReminders.Location = new System.Drawing.Point(10, 23);
            this.LSearchReminders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LSearchReminders.Name = "LSearchReminders";
            this.LSearchReminders.Size = new System.Drawing.Size(190, 25);
            this.LSearchReminders.TabIndex = 16;
            this.LSearchReminders.Text = "Search Reminders";
            this.LSearchReminders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbSearch.HideSelection = false;
            this.tbSearch.Location = new System.Drawing.Point(251, 24);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearch.MaximumSize = new System.Drawing.Size(630, 29);
            this.tbSearch.MaxLength = 838;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(630, 22);
            this.tbSearch.TabIndex = 17;
            this.tbSearch.WordWrap = false;
            // 
            // TpCalender
            // 
            this.TpCalender.Location = new System.Drawing.Point(23, 4);
            this.TpCalender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpCalender.Name = "TpCalender";
            this.TpCalender.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpCalender.Size = new System.Drawing.Size(1154, 908);
            this.TpCalender.TabIndex = 1;
            this.TpCalender.Text = "Calender";
            this.TpCalender.UseVisualStyleBackColor = true;
            // 
            // TpTimeTable
            // 
            this.TpTimeTable.Location = new System.Drawing.Point(23, 4);
            this.TpTimeTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpTimeTable.Name = "TpTimeTable";
            this.TpTimeTable.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpTimeTable.Size = new System.Drawing.Size(1154, 908);
            this.TpTimeTable.TabIndex = 2;
            this.TpTimeTable.Text = "TimeTable";
            this.TpTimeTable.UseVisualStyleBackColor = true;
            // 
            // TpAlarm
            // 
            this.TpAlarm.Location = new System.Drawing.Point(23, 4);
            this.TpAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpAlarm.Name = "TpAlarm";
            this.TpAlarm.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpAlarm.Size = new System.Drawing.Size(1154, 908);
            this.TpAlarm.TabIndex = 3;
            this.TpAlarm.Text = "Alarm";
            this.TpAlarm.UseVisualStyleBackColor = true;
            // 
            // TpStopWatch
            // 
            this.TpStopWatch.Location = new System.Drawing.Point(23, 4);
            this.TpStopWatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpStopWatch.Name = "TpStopWatch";
            this.TpStopWatch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpStopWatch.Size = new System.Drawing.Size(1154, 908);
            this.TpStopWatch.TabIndex = 4;
            this.TpStopWatch.Text = "StopWatch";
            this.TpStopWatch.UseVisualStyleBackColor = true;
            // 
            // TpTimer
            // 
            this.TpTimer.Location = new System.Drawing.Point(23, 4);
            this.TpTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpTimer.Name = "TpTimer";
            this.TpTimer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TpTimer.Size = new System.Drawing.Size(1154, 908);
            this.TpTimer.TabIndex = 5;
            this.TpTimer.Text = "Timer";
            this.TpTimer.UseVisualStyleBackColor = true;
            // 
            // MsFileMenu
            // 
            this.MsFileMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MsFileMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MsFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.TpmiEdit,
            this.TpmiView,
            this.TpmiHelp});
            this.MsFileMenu.Location = new System.Drawing.Point(0, 0);
            this.MsFileMenu.Name = "MsFileMenu";
            this.MsFileMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MsFileMenu.Size = new System.Drawing.Size(1177, 24);
            this.MsFileMenu.TabIndex = 1;
            this.MsFileMenu.Text = "File";
            // 
            // TsmiFile
            // 
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(37, 20);
            this.TsmiFile.Text = "File";
            // 
            // TpmiEdit
            // 
            this.TpmiEdit.Name = "TpmiEdit";
            this.TpmiEdit.Size = new System.Drawing.Size(39, 20);
            this.TpmiEdit.Text = "Edit";
            // 
            // TpmiView
            // 
            this.TpmiView.Name = "TpmiView";
            this.TpmiView.Size = new System.Drawing.Size(44, 20);
            this.TpmiView.Text = "View";
            // 
            // TpmiHelp
            // 
            this.TpmiHelp.Name = "TpmiHelp";
            this.TpmiHelp.Size = new System.Drawing.Size(44, 20);
            this.TpmiHelp.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(239, 89);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 84);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(40, 87);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(67, 83);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Timeframe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Timeframe";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // gvId
            // 
            this.gvId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvId.DataPropertyName = "id";
            this.gvId.HeaderText = "ID";
            this.gvId.MaxInputLength = 150;
            this.gvId.MinimumWidth = 8;
            this.gvId.Name = "gvId";
            this.gvId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvId.Width = 50;
            // 
            // gvActive
            // 
            this.gvActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvActive.DataPropertyName = "active";
            this.gvActive.HeaderText = "Active";
            this.gvActive.MinimumWidth = 8;
            this.gvActive.Name = "gvActive";
            this.gvActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvActive.Width = 55;
            // 
            // gvName
            // 
            this.gvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvName.DataPropertyName = "name";
            this.gvName.HeaderText = "Name";
            this.gvName.MaxInputLength = 200;
            this.gvName.MinimumWidth = 8;
            this.gvName.Name = "gvName";
            this.gvName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvName.Width = 69;
            // 
            // gvDescription
            // 
            this.gvDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvDescription.DataPropertyName = "description";
            this.gvDescription.HeaderText = "Description";
            this.gvDescription.MaxInputLength = 200;
            this.gvDescription.MinimumWidth = 8;
            this.gvDescription.Name = "gvDescription";
            this.gvDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDescription.Width = 108;
            // 
            // gvAlarm
            // 
            this.gvAlarm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvAlarm.DataPropertyName = "alarm";
            this.gvAlarm.HeaderText = "Alarm";
            this.gvAlarm.MinimumWidth = 8;
            this.gvAlarm.Name = "gvAlarm";
            this.gvAlarm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAlarm.Width = 54;
            // 
            // gvAlarmDate
            // 
            this.gvAlarmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvAlarmDate.DataPropertyName = "alarmDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.gvAlarmDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvAlarmDate.HeaderText = "Alarm Date";
            this.gvAlarmDate.MaxInputLength = 200;
            this.gvAlarmDate.MinimumWidth = 8;
            this.gvAlarmDate.Name = "gvAlarmDate";
            this.gvAlarmDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAlarmDate.Width = 107;
            // 
            // gvAlarmTime
            // 
            this.gvAlarmTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvAlarmTime.DataPropertyName = "alarmTime";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.gvAlarmTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvAlarmTime.HeaderText = "Alarm Time";
            this.gvAlarmTime.MaxInputLength = 150;
            this.gvAlarmTime.MinimumWidth = 8;
            this.gvAlarmTime.Name = "gvAlarmTime";
            this.gvAlarmTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAlarmTime.Width = 111;
            // 
            // gvPeriodic
            // 
            this.gvPeriodic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvPeriodic.DataPropertyName = "periodic";
            this.gvPeriodic.HeaderText = "Periodic";
            this.gvPeriodic.MinimumWidth = 8;
            this.gvPeriodic.Name = "gvPeriodic";
            this.gvPeriodic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPeriodic.Width = 68;
            // 
            // gvPeriodicFrequency
            // 
            this.gvPeriodicFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvPeriodicFrequency.DataPropertyName = "frequency";
            this.gvPeriodicFrequency.HeaderText = "Frequency";
            this.gvPeriodicFrequency.MaxInputLength = 150;
            this.gvPeriodicFrequency.MinimumWidth = 8;
            this.gvPeriodicFrequency.Name = "gvPeriodicFrequency";
            this.gvPeriodicFrequency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPeriodicFrequency.Width = 101;
            // 
            // gvPeriodicDate
            // 
            this.gvPeriodicDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvPeriodicDate.DataPropertyName = "periodicDate";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.gvPeriodicDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvPeriodicDate.HeaderText = "Periodic Date";
            this.gvPeriodicDate.MaxInputLength = 200;
            this.gvPeriodicDate.MinimumWidth = 8;
            this.gvPeriodicDate.Name = "gvPeriodicDate";
            this.gvPeriodicDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPeriodicDate.Width = 121;
            // 
            // gvPeriodicTime
            // 
            this.gvPeriodicTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvPeriodicTime.DataPropertyName = "periodicTime";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.gvPeriodicTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvPeriodicTime.HeaderText = "Periodic Time";
            this.gvPeriodicTime.MaxInputLength = 150;
            this.gvPeriodicTime.MinimumWidth = 8;
            this.gvPeriodicTime.Name = "gvPeriodicTime";
            this.gvPeriodicTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPeriodicTime.Width = 125;
            // 
            // reminderBindingSource
            // 
            this.reminderBindingSource.DataSource = typeof(GUIApp.MysticTodo.Data.Reminder);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1177, 942);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TcMainTabControl);
            this.Controls.Add(this.MsFileMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MsFileMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MysticToDo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TcMainTabControl.ResumeLayout(false);
            this.TpReminder.ResumeLayout(false);
            this.TpReminder.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ScReminderPage.Panel1.ResumeLayout(false);
            this.ScReminderPage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).EndInit();
            this.ScReminderPage.ResumeLayout(false);
            this.gbReminderEditor.ResumeLayout(false);
            this.gbReminderEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReminderList)).EndInit();
            this.gbReminderSearch.ResumeLayout(false);
            this.gbReminderSearch.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage TpReminder;
        private System.Windows.Forms.SplitContainer ScReminderPage;
        private System.Windows.Forms.GroupBox gbReminderEditor;
        private System.Windows.Forms.Label LbTitleReminder;
        private System.Windows.Forms.TextBox TbReminder;
        private System.Windows.Forms.Label LbNewReminder;
        private System.Windows.Forms.CheckBox CheckbPeriodicAlarm;
        private System.Windows.Forms.CheckBox CebSetAlarm;
        private System.Windows.Forms.DateTimePicker DtpAlarmDate;
        private System.Windows.Forms.ComboBox CbPerodicAlarm;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LDescription;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar3;
        private System.Windows.Forms.GroupBox gbReminderSearch;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Label LSearchReminders;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView gvReminderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAlarmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvAlarmTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvPeriodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPeriodicFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPeriodicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvPeriodicTime;
    }
}

