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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.bClear = new System.Windows.Forms.Button();
            this.LbTitleReminder = new System.Windows.Forms.Label();
            this.tbReminder = new System.Windows.Forms.TextBox();
            this.LbNewReminder = new System.Windows.Forms.Label();
            this.checkboxPeriodicAlarm = new System.Windows.Forms.CheckBox();
            this.checkboxSetAlarm = new System.Windows.Forms.CheckBox();
            this.dtpAlarmDate = new System.Windows.Forms.DateTimePicker();
            this.comboboxPerodicAlarm = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.LDescription = new System.Windows.Forms.Label();
            this.BSubmit = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.lGridViewTitleCompleted = new System.Windows.Forms.Label();
            this.gvReminderTable = new System.Windows.Forms.DataGridView();
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
            this.lGridViewTitleActive = new System.Windows.Forms.Label();
            this.gvInactiveReminderTable = new System.Windows.Forms.DataGridView();
            this.gvinactiveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactiveActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvinactiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactiveDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactiveAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvinactiveAlarmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactiveAlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactivePeriodic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvinactivePeriodicFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactivePeriodicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvinactivePeriodicTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbReminderSearch = new System.Windows.Forms.GroupBox();
            this.bInActiveTaskTab = new System.Windows.Forms.Button();
            this.bActiveTaskTab = new System.Windows.Forms.Button();
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
            this.bSearchTaskTab = new System.Windows.Forms.Button();
            this.lGridViewTitleSearch = new System.Windows.Forms.Label();
            this.gvSearchReminderTable = new System.Windows.Forms.DataGridView();
            this.gvSearchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSearchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchAlarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSearchAlarmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchAlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchPeriodic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gvSearchPeriodicFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchPeriodicDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSearchPeriodicTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reminderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TcMainTabControl.SuspendLayout();
            this.TpReminder.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).BeginInit();
            this.ScReminderPage.Panel1.SuspendLayout();
            this.ScReminderPage.Panel2.SuspendLayout();
            this.ScReminderPage.SuspendLayout();
            this.gbReminderEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReminderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInactiveReminderTable)).BeginInit();
            this.gbReminderSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeframeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysticToDoDBEntitiesBindingSource)).BeginInit();
            this.MsFileMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchReminderTable)).BeginInit();
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
            this.TcMainTabControl.Margin = new System.Windows.Forms.Padding(2);
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
            this.TpReminder.Margin = new System.Windows.Forms.Padding(2);
            this.TpReminder.Name = "TpReminder";
            this.TpReminder.Padding = new System.Windows.Forms.Padding(2);
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
            this.ScReminderPage.Margin = new System.Windows.Forms.Padding(2);
            this.ScReminderPage.Name = "ScReminderPage";
            this.ScReminderPage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScReminderPage.Panel1
            // 
            this.ScReminderPage.Panel1.BackColor = System.Drawing.Color.Silver;
            this.ScReminderPage.Panel1.Controls.Add(this.gbReminderEditor);
            this.ScReminderPage.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ScReminderPage.Panel2
            // 
            this.ScReminderPage.Panel2.AutoScroll = true;
            this.ScReminderPage.Panel2.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.ScReminderPage.Panel2.Controls.Add(this.gvSearchReminderTable);
            this.ScReminderPage.Panel2.Controls.Add(this.lGridViewTitleSearch);
            this.ScReminderPage.Panel2.Controls.Add(this.lGridViewTitleCompleted);
            this.ScReminderPage.Panel2.Controls.Add(this.gvReminderTable);
            this.ScReminderPage.Panel2.Controls.Add(this.lGridViewTitleActive);
            this.ScReminderPage.Panel2.Controls.Add(this.gvInactiveReminderTable);
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
            this.gbReminderEditor.Controls.Add(this.bClear);
            this.gbReminderEditor.Controls.Add(this.LbTitleReminder);
            this.gbReminderEditor.Controls.Add(this.tbReminder);
            this.gbReminderEditor.Controls.Add(this.LbNewReminder);
            this.gbReminderEditor.Controls.Add(this.checkboxPeriodicAlarm);
            this.gbReminderEditor.Controls.Add(this.checkboxSetAlarm);
            this.gbReminderEditor.Controls.Add(this.dtpAlarmDate);
            this.gbReminderEditor.Controls.Add(this.comboboxPerodicAlarm);
            this.gbReminderEditor.Controls.Add(this.tbDescription);
            this.gbReminderEditor.Controls.Add(this.LDescription);
            this.gbReminderEditor.Controls.Add(this.BSubmit);
            this.gbReminderEditor.Controls.Add(this.BUpdate);
            this.gbReminderEditor.Controls.Add(this.BDelete);
            this.gbReminderEditor.Location = new System.Drawing.Point(52, 49);
            this.gbReminderEditor.Margin = new System.Windows.Forms.Padding(2);
            this.gbReminderEditor.MaximumSize = new System.Drawing.Size(1088, 217);
            this.gbReminderEditor.Name = "gbReminderEditor";
            this.gbReminderEditor.Padding = new System.Windows.Forms.Padding(2);
            this.gbReminderEditor.Size = new System.Drawing.Size(1085, 217);
            this.gbReminderEditor.TabIndex = 18;
            this.gbReminderEditor.TabStop = false;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(540, 187);
            this.bClear.Margin = new System.Windows.Forms.Padding(2);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(107, 30);
            this.bClear.TabIndex = 31;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
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
            // tbReminder
            // 
            this.tbReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReminder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbReminder.Location = new System.Drawing.Point(255, 78);
            this.tbReminder.Margin = new System.Windows.Forms.Padding(2);
            this.tbReminder.MaximumSize = new System.Drawing.Size(632, 29);
            this.tbReminder.MaxLength = 842;
            this.tbReminder.Name = "tbReminder";
            this.tbReminder.Size = new System.Drawing.Size(632, 22);
            this.tbReminder.TabIndex = 18;
            this.tbReminder.WordWrap = false;
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
            // checkboxPeriodicAlarm
            // 
            this.checkboxPeriodicAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxPeriodicAlarm.AutoSize = true;
            this.checkboxPeriodicAlarm.BackColor = System.Drawing.Color.Silver;
            this.checkboxPeriodicAlarm.Location = new System.Drawing.Point(98, 192);
            this.checkboxPeriodicAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxPeriodicAlarm.Name = "checkboxPeriodicAlarm";
            this.checkboxPeriodicAlarm.Size = new System.Drawing.Size(126, 20);
            this.checkboxPeriodicAlarm.TabIndex = 22;
            this.checkboxPeriodicAlarm.Text = "Periodic Alarm";
            this.checkboxPeriodicAlarm.UseVisualStyleBackColor = false;
            this.checkboxPeriodicAlarm.CheckedChanged += new System.EventHandler(this.CheckbPeriodicAlarm_CheckedChanged);
            // 
            // checkboxSetAlarm
            // 
            this.checkboxSetAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxSetAlarm.AutoSize = true;
            this.checkboxSetAlarm.BackColor = System.Drawing.Color.Silver;
            this.checkboxSetAlarm.Location = new System.Drawing.Point(133, 144);
            this.checkboxSetAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxSetAlarm.Name = "checkboxSetAlarm";
            this.checkboxSetAlarm.Size = new System.Drawing.Size(91, 20);
            this.checkboxSetAlarm.TabIndex = 21;
            this.checkboxSetAlarm.Text = "Set Alarm";
            this.checkboxSetAlarm.UseVisualStyleBackColor = false;
            this.checkboxSetAlarm.CheckedChanged += new System.EventHandler(this.CebSetAlarm_CheckedChanged);
            // 
            // dtpAlarmDate
            // 
            this.dtpAlarmDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAlarmDate.Location = new System.Drawing.Point(255, 140);
            this.dtpAlarmDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAlarmDate.MaximumSize = new System.Drawing.Size(258, 29);
            this.dtpAlarmDate.Name = "dtpAlarmDate";
            this.dtpAlarmDate.Size = new System.Drawing.Size(258, 22);
            this.dtpAlarmDate.TabIndex = 23;
            // 
            // comboboxPerodicAlarm
            // 
            this.comboboxPerodicAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxPerodicAlarm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboboxPerodicAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboboxPerodicAlarm.FormattingEnabled = true;
            this.comboboxPerodicAlarm.Location = new System.Drawing.Point(258, 189);
            this.comboboxPerodicAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxPerodicAlarm.Name = "comboboxPerodicAlarm";
            this.comboboxPerodicAlarm.Size = new System.Drawing.Size(254, 23);
            this.comboboxPerodicAlarm.TabIndex = 24;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDescription.Location = new System.Drawing.Point(660, 128);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(228, 89);
            this.tbDescription.TabIndex = 26;
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
            this.LDescription.Location = new System.Drawing.Point(536, 140);
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
            this.BSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(168, 42);
            this.BSubmit.TabIndex = 27;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = false;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUpdate.BackColor = System.Drawing.Color.LawnGreen;
            this.BUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUpdate.Location = new System.Drawing.Point(919, 136);
            this.BUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(168, 34);
            this.BUpdate.TabIndex = 29;
            this.BUpdate.Text = "Update";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BDelete
            // 
            this.BDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BDelete.Location = new System.Drawing.Point(919, 184);
            this.BDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(168, 36);
            this.BDelete.TabIndex = 28;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = false;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // lGridViewTitleCompleted
            // 
            this.lGridViewTitleCompleted.AutoSize = true;
            this.lGridViewTitleCompleted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lGridViewTitleCompleted.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lGridViewTitleCompleted.Font = new System.Drawing.Font("CaslonOpnface BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGridViewTitleCompleted.ForeColor = System.Drawing.Color.OrangeRed;
            this.lGridViewTitleCompleted.Location = new System.Drawing.Point(63, 109);
            this.lGridViewTitleCompleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGridViewTitleCompleted.Name = "lGridViewTitleCompleted";
            this.lGridViewTitleCompleted.Size = new System.Drawing.Size(216, 29);
            this.lGridViewTitleCompleted.TabIndex = 33;
            this.lGridViewTitleCompleted.Text = "Completed Reminders";
            this.lGridViewTitleCompleted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvReminderTable
            // 
            this.gvReminderTable.AllowUserToOrderColumns = true;
            this.gvReminderTable.AllowUserToResizeColumns = false;
            this.gvReminderTable.AllowUserToResizeRows = false;
            this.gvReminderTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvReminderTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gvReminderTable.ColumnHeadersHeight = 34;
            this.gvReminderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.gvReminderTable.Location = new System.Drawing.Point(67, 135);
            this.gvReminderTable.Margin = new System.Windows.Forms.Padding(2);
            this.gvReminderTable.MaximumSize = new System.Drawing.Size(1070, 434);
            this.gvReminderTable.Name = "gvReminderTable";
            this.gvReminderTable.RowHeadersWidth = 62;
            this.gvReminderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvReminderTable.RowTemplate.Height = 28;
            this.gvReminderTable.Size = new System.Drawing.Size(1070, 417);
            this.gvReminderTable.TabIndex = 19;
            this.gvReminderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReminderTable_CellContentClick);
            this.gvReminderTable.SelectionChanged += new System.EventHandler(this.gvReminderTable_SelectionChanged);
            this.gvReminderTable.DoubleClick += new System.EventHandler(this.gvReminderList_DoubleClick);
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
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.gvAlarmDate.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.gvAlarmTime.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Format = "D";
            dataGridViewCellStyle7.NullValue = null;
            this.gvPeriodicDate.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            this.gvPeriodicTime.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvPeriodicTime.HeaderText = "Periodic Time";
            this.gvPeriodicTime.MaxInputLength = 150;
            this.gvPeriodicTime.MinimumWidth = 8;
            this.gvPeriodicTime.Name = "gvPeriodicTime";
            this.gvPeriodicTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPeriodicTime.Width = 125;
            // 
            // lGridViewTitleActive
            // 
            this.lGridViewTitleActive.AutoSize = true;
            this.lGridViewTitleActive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lGridViewTitleActive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lGridViewTitleActive.Font = new System.Drawing.Font("CaslonOpnface BT", 18F, System.Drawing.FontStyle.Italic);
            this.lGridViewTitleActive.ForeColor = System.Drawing.Color.OrangeRed;
            this.lGridViewTitleActive.Location = new System.Drawing.Point(63, 109);
            this.lGridViewTitleActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGridViewTitleActive.Name = "lGridViewTitleActive";
            this.lGridViewTitleActive.Size = new System.Drawing.Size(179, 29);
            this.lGridViewTitleActive.TabIndex = 32;
            this.lGridViewTitleActive.Text = "Active Reminders";
            this.lGridViewTitleActive.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvInactiveReminderTable
            // 
            this.gvInactiveReminderTable.AllowUserToOrderColumns = true;
            this.gvInactiveReminderTable.AllowUserToResizeColumns = false;
            this.gvInactiveReminderTable.AllowUserToResizeRows = false;
            this.gvInactiveReminderTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvInactiveReminderTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gvInactiveReminderTable.ColumnHeadersHeight = 34;
            this.gvInactiveReminderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvinactiveId,
            this.gvinactiveActive,
            this.gvinactiveName,
            this.gvinactiveDescription,
            this.gvinactiveAlarm,
            this.gvinactiveAlarmDate,
            this.gvinactiveAlarmTime,
            this.gvinactivePeriodic,
            this.gvinactivePeriodicFrequency,
            this.gvinactivePeriodicDate,
            this.gvinactivePeriodicTime});
            this.gvInactiveReminderTable.Location = new System.Drawing.Point(67, 136);
            this.gvInactiveReminderTable.Margin = new System.Windows.Forms.Padding(2);
            this.gvInactiveReminderTable.MaximumSize = new System.Drawing.Size(1070, 434);
            this.gvInactiveReminderTable.Name = "gvInactiveReminderTable";
            this.gvInactiveReminderTable.RowHeadersWidth = 62;
            this.gvInactiveReminderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvInactiveReminderTable.RowTemplate.Height = 28;
            this.gvInactiveReminderTable.Size = new System.Drawing.Size(1070, 417);
            this.gvInactiveReminderTable.TabIndex = 20;
            this.gvInactiveReminderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvInactiveReminderTable_CellContentClick);
            this.gvInactiveReminderTable.SelectionChanged += new System.EventHandler(this.gvInactiveReminderTable_SelectionChanged);
            // 
            // gvinactiveId
            // 
            this.gvinactiveId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactiveId.DataPropertyName = "id";
            this.gvinactiveId.HeaderText = "ID";
            this.gvinactiveId.MaxInputLength = 150;
            this.gvinactiveId.MinimumWidth = 8;
            this.gvinactiveId.Name = "gvinactiveId";
            this.gvinactiveId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactiveId.Width = 50;
            // 
            // gvinactiveActive
            // 
            this.gvinactiveActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactiveActive.DataPropertyName = "active";
            this.gvinactiveActive.HeaderText = "Active";
            this.gvinactiveActive.MinimumWidth = 8;
            this.gvinactiveActive.Name = "gvinactiveActive";
            this.gvinactiveActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactiveActive.Width = 55;
            // 
            // gvinactiveName
            // 
            this.gvinactiveName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvinactiveName.DataPropertyName = "name";
            this.gvinactiveName.HeaderText = "Name";
            this.gvinactiveName.MaxInputLength = 200;
            this.gvinactiveName.MinimumWidth = 8;
            this.gvinactiveName.Name = "gvinactiveName";
            this.gvinactiveName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvinactiveName.Width = 69;
            // 
            // gvinactiveDescription
            // 
            this.gvinactiveDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvinactiveDescription.DataPropertyName = "description";
            this.gvinactiveDescription.HeaderText = "Description";
            this.gvinactiveDescription.MaxInputLength = 200;
            this.gvinactiveDescription.MinimumWidth = 8;
            this.gvinactiveDescription.Name = "gvinactiveDescription";
            this.gvinactiveDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvinactiveDescription.Width = 108;
            // 
            // gvinactiveAlarm
            // 
            this.gvinactiveAlarm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactiveAlarm.DataPropertyName = "alarm";
            this.gvinactiveAlarm.HeaderText = "Alarm";
            this.gvinactiveAlarm.MinimumWidth = 8;
            this.gvinactiveAlarm.Name = "gvinactiveAlarm";
            this.gvinactiveAlarm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactiveAlarm.Width = 54;
            // 
            // gvinactiveAlarmDate
            // 
            this.gvinactiveAlarmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvinactiveAlarmDate.DataPropertyName = "alarmDate";
            dataGridViewCellStyle9.Format = "D";
            dataGridViewCellStyle9.NullValue = null;
            this.gvinactiveAlarmDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvinactiveAlarmDate.HeaderText = "Alarm Date";
            this.gvinactiveAlarmDate.MaxInputLength = 200;
            this.gvinactiveAlarmDate.MinimumWidth = 8;
            this.gvinactiveAlarmDate.Name = "gvinactiveAlarmDate";
            this.gvinactiveAlarmDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvinactiveAlarmDate.Width = 107;
            // 
            // gvinactiveAlarmTime
            // 
            this.gvinactiveAlarmTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactiveAlarmTime.DataPropertyName = "alarmTime";
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.gvinactiveAlarmTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.gvinactiveAlarmTime.HeaderText = "Alarm Time";
            this.gvinactiveAlarmTime.MaxInputLength = 150;
            this.gvinactiveAlarmTime.MinimumWidth = 8;
            this.gvinactiveAlarmTime.Name = "gvinactiveAlarmTime";
            this.gvinactiveAlarmTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactiveAlarmTime.Width = 111;
            // 
            // gvinactivePeriodic
            // 
            this.gvinactivePeriodic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactivePeriodic.DataPropertyName = "periodic";
            this.gvinactivePeriodic.HeaderText = "Periodic";
            this.gvinactivePeriodic.MinimumWidth = 8;
            this.gvinactivePeriodic.Name = "gvinactivePeriodic";
            this.gvinactivePeriodic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactivePeriodic.Width = 68;
            // 
            // gvinactivePeriodicFrequency
            // 
            this.gvinactivePeriodicFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactivePeriodicFrequency.DataPropertyName = "frequency";
            this.gvinactivePeriodicFrequency.HeaderText = "Frequency";
            this.gvinactivePeriodicFrequency.MaxInputLength = 150;
            this.gvinactivePeriodicFrequency.MinimumWidth = 8;
            this.gvinactivePeriodicFrequency.Name = "gvinactivePeriodicFrequency";
            this.gvinactivePeriodicFrequency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactivePeriodicFrequency.Width = 101;
            // 
            // gvinactivePeriodicDate
            // 
            this.gvinactivePeriodicDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvinactivePeriodicDate.DataPropertyName = "periodicDate";
            dataGridViewCellStyle11.Format = "D";
            dataGridViewCellStyle11.NullValue = null;
            this.gvinactivePeriodicDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvinactivePeriodicDate.HeaderText = "Periodic Date";
            this.gvinactivePeriodicDate.MaxInputLength = 200;
            this.gvinactivePeriodicDate.MinimumWidth = 8;
            this.gvinactivePeriodicDate.Name = "gvinactivePeriodicDate";
            this.gvinactivePeriodicDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvinactivePeriodicDate.Width = 121;
            // 
            // gvinactivePeriodicTime
            // 
            this.gvinactivePeriodicTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvinactivePeriodicTime.DataPropertyName = "periodicTime";
            dataGridViewCellStyle12.Format = "t";
            dataGridViewCellStyle12.NullValue = null;
            this.gvinactivePeriodicTime.DefaultCellStyle = dataGridViewCellStyle12;
            this.gvinactivePeriodicTime.HeaderText = "Periodic Time";
            this.gvinactivePeriodicTime.MaxInputLength = 150;
            this.gvinactivePeriodicTime.MinimumWidth = 8;
            this.gvinactivePeriodicTime.Name = "gvinactivePeriodicTime";
            this.gvinactivePeriodicTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvinactivePeriodicTime.Width = 125;
            // 
            // gbReminderSearch
            // 
            this.gbReminderSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbReminderSearch.Controls.Add(this.bSearchTaskTab);
            this.gbReminderSearch.Controls.Add(this.bInActiveTaskTab);
            this.gbReminderSearch.Controls.Add(this.bActiveTaskTab);
            this.gbReminderSearch.Controls.Add(this.BSearch);
            this.gbReminderSearch.Controls.Add(this.LSearchReminders);
            this.gbReminderSearch.Controls.Add(this.tbSearch);
            this.gbReminderSearch.Location = new System.Drawing.Point(59, 12);
            this.gbReminderSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbReminderSearch.MaximumSize = new System.Drawing.Size(1085, 111);
            this.gbReminderSearch.Name = "gbReminderSearch";
            this.gbReminderSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbReminderSearch.Size = new System.Drawing.Size(1085, 111);
            this.gbReminderSearch.TabIndex = 18;
            this.gbReminderSearch.TabStop = false;
            // 
            // bInActiveTaskTab
            // 
            this.bInActiveTaskTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bInActiveTaskTab.BackColor = System.Drawing.Color.PeachPuff;
            this.bInActiveTaskTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bInActiveTaskTab.Location = new System.Drawing.Point(495, 73);
            this.bInActiveTaskTab.Margin = new System.Windows.Forms.Padding(2);
            this.bInActiveTaskTab.Name = "bInActiveTaskTab";
            this.bInActiveTaskTab.Size = new System.Drawing.Size(164, 34);
            this.bInActiveTaskTab.TabIndex = 31;
            this.bInActiveTaskTab.Text = "Completed Task";
            this.bInActiveTaskTab.UseVisualStyleBackColor = false;
            this.bInActiveTaskTab.Click += new System.EventHandler(this.bInActiveTaskTab_Click);
            // 
            // bActiveTaskTab
            // 
            this.bActiveTaskTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bActiveTaskTab.BackColor = System.Drawing.Color.PeachPuff;
            this.bActiveTaskTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bActiveTaskTab.Location = new System.Drawing.Point(311, 73);
            this.bActiveTaskTab.Margin = new System.Windows.Forms.Padding(2);
            this.bActiveTaskTab.Name = "bActiveTaskTab";
            this.bActiveTaskTab.Size = new System.Drawing.Size(164, 34);
            this.bActiveTaskTab.TabIndex = 30;
            this.bActiveTaskTab.Text = "Active Task";
            this.bActiveTaskTab.UseVisualStyleBackColor = false;
            this.bActiveTaskTab.Click += new System.EventHandler(this.bActiveTaskTab_Click);
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.Color.LightBlue;
            this.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSearch.Location = new System.Drawing.Point(915, 24);
            this.BSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(170, 31);
            this.BSearch.TabIndex = 18;
            this.BSearch.Text = "Search";
            this.BSearch.UseVisualStyleBackColor = false;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
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
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
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
            this.TpCalender.Margin = new System.Windows.Forms.Padding(2);
            this.TpCalender.Name = "TpCalender";
            this.TpCalender.Padding = new System.Windows.Forms.Padding(2);
            this.TpCalender.Size = new System.Drawing.Size(1154, 908);
            this.TpCalender.TabIndex = 1;
            this.TpCalender.Text = "Calender";
            this.TpCalender.UseVisualStyleBackColor = true;
            // 
            // TpTimeTable
            // 
            this.TpTimeTable.Location = new System.Drawing.Point(23, 4);
            this.TpTimeTable.Margin = new System.Windows.Forms.Padding(2);
            this.TpTimeTable.Name = "TpTimeTable";
            this.TpTimeTable.Padding = new System.Windows.Forms.Padding(2);
            this.TpTimeTable.Size = new System.Drawing.Size(1154, 908);
            this.TpTimeTable.TabIndex = 2;
            this.TpTimeTable.Text = "TimeTable";
            this.TpTimeTable.UseVisualStyleBackColor = true;
            // 
            // TpAlarm
            // 
            this.TpAlarm.Location = new System.Drawing.Point(23, 4);
            this.TpAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.TpAlarm.Name = "TpAlarm";
            this.TpAlarm.Padding = new System.Windows.Forms.Padding(2);
            this.TpAlarm.Size = new System.Drawing.Size(1154, 908);
            this.TpAlarm.TabIndex = 3;
            this.TpAlarm.Text = "Alarm";
            this.TpAlarm.UseVisualStyleBackColor = true;
            // 
            // TpStopWatch
            // 
            this.TpStopWatch.Location = new System.Drawing.Point(23, 4);
            this.TpStopWatch.Margin = new System.Windows.Forms.Padding(2);
            this.TpStopWatch.Name = "TpStopWatch";
            this.TpStopWatch.Padding = new System.Windows.Forms.Padding(2);
            this.TpStopWatch.Size = new System.Drawing.Size(1154, 908);
            this.TpStopWatch.TabIndex = 4;
            this.TpStopWatch.Text = "StopWatch";
            this.TpStopWatch.UseVisualStyleBackColor = true;
            // 
            // TpTimer
            // 
            this.TpTimer.Location = new System.Drawing.Point(23, 4);
            this.TpTimer.Margin = new System.Windows.Forms.Padding(2);
            this.TpTimer.Name = "TpTimer";
            this.TpTimer.Padding = new System.Windows.Forms.Padding(2);
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
            // bSearchTaskTab
            // 
            this.bSearchTaskTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearchTaskTab.BackColor = System.Drawing.Color.PeachPuff;
            this.bSearchTaskTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSearchTaskTab.Location = new System.Drawing.Point(678, 73);
            this.bSearchTaskTab.Margin = new System.Windows.Forms.Padding(2);
            this.bSearchTaskTab.Name = "bSearchTaskTab";
            this.bSearchTaskTab.Size = new System.Drawing.Size(164, 34);
            this.bSearchTaskTab.TabIndex = 32;
            this.bSearchTaskTab.Text = "Search Task";
            this.bSearchTaskTab.UseVisualStyleBackColor = false;
            this.bSearchTaskTab.Click += new System.EventHandler(this.bSearchTaskTab_Click);
            // 
            // lGridViewTitleSearch
            // 
            this.lGridViewTitleSearch.AutoSize = true;
            this.lGridViewTitleSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lGridViewTitleSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lGridViewTitleSearch.Font = new System.Drawing.Font("CaslonOpnface BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGridViewTitleSearch.ForeColor = System.Drawing.Color.OrangeRed;
            this.lGridViewTitleSearch.Location = new System.Drawing.Point(63, 109);
            this.lGridViewTitleSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGridViewTitleSearch.Name = "lGridViewTitleSearch";
            this.lGridViewTitleSearch.Size = new System.Drawing.Size(182, 29);
            this.lGridViewTitleSearch.TabIndex = 34;
            this.lGridViewTitleSearch.Text = "Search Reminders";
            this.lGridViewTitleSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvSearchReminderTable
            // 
            this.gvSearchReminderTable.AllowUserToOrderColumns = true;
            this.gvSearchReminderTable.AllowUserToResizeColumns = false;
            this.gvSearchReminderTable.AllowUserToResizeRows = false;
            this.gvSearchReminderTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvSearchReminderTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gvSearchReminderTable.ColumnHeadersHeight = 34;
            this.gvSearchReminderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvSearchId,
            this.gvSearchActive,
            this.gvSearchName,
            this.gvSearchDescription,
            this.gvSearchAlarm,
            this.gvSearchAlarmDate,
            this.gvSearchAlarmTime,
            this.gvSearchPeriodic,
            this.gvSearchPeriodicFrequency,
            this.gvSearchPeriodicDate,
            this.gvSearchPeriodicTime});
            this.gvSearchReminderTable.Location = new System.Drawing.Point(69, 136);
            this.gvSearchReminderTable.Margin = new System.Windows.Forms.Padding(2);
            this.gvSearchReminderTable.MaximumSize = new System.Drawing.Size(1070, 434);
            this.gvSearchReminderTable.Name = "gvSearchReminderTable";
            this.gvSearchReminderTable.RowHeadersWidth = 62;
            this.gvSearchReminderTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvSearchReminderTable.RowTemplate.Height = 28;
            this.gvSearchReminderTable.Size = new System.Drawing.Size(1070, 417);
            this.gvSearchReminderTable.TabIndex = 35;
            // 
            // gvSearchId
            // 
            this.gvSearchId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchId.DataPropertyName = "id";
            this.gvSearchId.HeaderText = "ID";
            this.gvSearchId.MaxInputLength = 150;
            this.gvSearchId.MinimumWidth = 8;
            this.gvSearchId.Name = "gvSearchId";
            this.gvSearchId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchId.Width = 50;
            // 
            // gvSearchActive
            // 
            this.gvSearchActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchActive.DataPropertyName = "active";
            this.gvSearchActive.HeaderText = "Active";
            this.gvSearchActive.MinimumWidth = 8;
            this.gvSearchActive.Name = "gvSearchActive";
            this.gvSearchActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchActive.Width = 55;
            // 
            // gvSearchName
            // 
            this.gvSearchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSearchName.DataPropertyName = "name";
            this.gvSearchName.HeaderText = "Name";
            this.gvSearchName.MaxInputLength = 200;
            this.gvSearchName.MinimumWidth = 8;
            this.gvSearchName.Name = "gvSearchName";
            this.gvSearchName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearchName.Width = 69;
            // 
            // gvSearchDescription
            // 
            this.gvSearchDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSearchDescription.DataPropertyName = "description";
            this.gvSearchDescription.HeaderText = "Description";
            this.gvSearchDescription.MaxInputLength = 200;
            this.gvSearchDescription.MinimumWidth = 8;
            this.gvSearchDescription.Name = "gvSearchDescription";
            this.gvSearchDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearchDescription.Width = 108;
            // 
            // gvSearchAlarm
            // 
            this.gvSearchAlarm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchAlarm.DataPropertyName = "alarm";
            this.gvSearchAlarm.HeaderText = "Alarm";
            this.gvSearchAlarm.MinimumWidth = 8;
            this.gvSearchAlarm.Name = "gvSearchAlarm";
            this.gvSearchAlarm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchAlarm.Width = 54;
            // 
            // gvSearchAlarmDate
            // 
            this.gvSearchAlarmDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSearchAlarmDate.DataPropertyName = "alarmDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.gvSearchAlarmDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvSearchAlarmDate.HeaderText = "Alarm Date";
            this.gvSearchAlarmDate.MaxInputLength = 200;
            this.gvSearchAlarmDate.MinimumWidth = 8;
            this.gvSearchAlarmDate.Name = "gvSearchAlarmDate";
            this.gvSearchAlarmDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearchAlarmDate.Width = 107;
            // 
            // gvSearchAlarmTime
            // 
            this.gvSearchAlarmTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchAlarmTime.DataPropertyName = "alarmTime";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.gvSearchAlarmTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSearchAlarmTime.HeaderText = "Alarm Time";
            this.gvSearchAlarmTime.MaxInputLength = 150;
            this.gvSearchAlarmTime.MinimumWidth = 8;
            this.gvSearchAlarmTime.Name = "gvSearchAlarmTime";
            this.gvSearchAlarmTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchAlarmTime.Width = 111;
            // 
            // gvSearchPeriodic
            // 
            this.gvSearchPeriodic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchPeriodic.DataPropertyName = "periodic";
            this.gvSearchPeriodic.HeaderText = "Periodic";
            this.gvSearchPeriodic.MinimumWidth = 8;
            this.gvSearchPeriodic.Name = "gvSearchPeriodic";
            this.gvSearchPeriodic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchPeriodic.Width = 68;
            // 
            // gvSearchPeriodicFrequency
            // 
            this.gvSearchPeriodicFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchPeriodicFrequency.DataPropertyName = "frequency";
            this.gvSearchPeriodicFrequency.HeaderText = "Frequency";
            this.gvSearchPeriodicFrequency.MaxInputLength = 150;
            this.gvSearchPeriodicFrequency.MinimumWidth = 8;
            this.gvSearchPeriodicFrequency.Name = "gvSearchPeriodicFrequency";
            this.gvSearchPeriodicFrequency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchPeriodicFrequency.Width = 101;
            // 
            // gvSearchPeriodicDate
            // 
            this.gvSearchPeriodicDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSearchPeriodicDate.DataPropertyName = "periodicDate";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.gvSearchPeriodicDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvSearchPeriodicDate.HeaderText = "Periodic Date";
            this.gvSearchPeriodicDate.MaxInputLength = 200;
            this.gvSearchPeriodicDate.MinimumWidth = 8;
            this.gvSearchPeriodicDate.Name = "gvSearchPeriodicDate";
            this.gvSearchPeriodicDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearchPeriodicDate.Width = 121;
            // 
            // gvSearchPeriodicTime
            // 
            this.gvSearchPeriodicTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gvSearchPeriodicTime.DataPropertyName = "periodicTime";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.gvSearchPeriodicTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvSearchPeriodicTime.HeaderText = "Periodic Time";
            this.gvSearchPeriodicTime.MaxInputLength = 150;
            this.gvSearchPeriodicTime.MinimumWidth = 8;
            this.gvSearchPeriodicTime.Name = "gvSearchPeriodicTime";
            this.gvSearchPeriodicTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearchPeriodicTime.Width = 125;
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.ScReminderPage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).EndInit();
            this.ScReminderPage.ResumeLayout(false);
            this.gbReminderEditor.ResumeLayout(false);
            this.gbReminderEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReminderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInactiveReminderTable)).EndInit();
            this.gbReminderSearch.ResumeLayout(false);
            this.gbReminderSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeframeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysticToDoDBEntitiesBindingSource)).EndInit();
            this.MsFileMenu.ResumeLayout(false);
            this.MsFileMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchReminderTable)).EndInit();
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
        private System.Windows.Forms.TextBox tbReminder;
        private System.Windows.Forms.Label LbNewReminder;
        private System.Windows.Forms.CheckBox checkboxPeriodicAlarm;
        private System.Windows.Forms.CheckBox checkboxSetAlarm;
        private System.Windows.Forms.DateTimePicker dtpAlarmDate;
        private System.Windows.Forms.ComboBox comboboxPerodicAlarm;
        private System.Windows.Forms.TextBox tbDescription;
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
        private System.Windows.Forms.DataGridView gvReminderTable;
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
        private System.Windows.Forms.Button bActiveTaskTab;
        private System.Windows.Forms.Button bInActiveTaskTab;
        private System.Windows.Forms.DataGridView gvInactiveReminderTable;
        private System.Windows.Forms.Label lGridViewTitleActive;
        private System.Windows.Forms.Label lGridViewTitleCompleted;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactiveId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvinactiveActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactiveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactiveDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvinactiveAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactiveAlarmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactiveAlarmTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvinactivePeriodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactivePeriodicFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactivePeriodicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvinactivePeriodicTime;
        private System.Windows.Forms.Button bSearchTaskTab;
        private System.Windows.Forms.Label lGridViewTitleSearch;
        private System.Windows.Forms.DataGridView gvSearchReminderTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvSearchActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvSearchAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchAlarmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchAlarmTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvSearchPeriodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchPeriodicFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchPeriodicDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSearchPeriodicTime;
    }
}

