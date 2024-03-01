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
            this.TcMainTabControl = new System.Windows.Forms.TabControl();
            this.TpReminder = new System.Windows.Forms.TabPage();
            this.BSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LDescription = new System.Windows.Forms.Label();
            this.CbPerodicAlarm = new System.Windows.Forms.ComboBox();
            this.mysticToDoDBEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtpAlarmDate = new System.Windows.Forms.DateTimePicker();
            this.CbPeriodicAlarm = new System.Windows.Forms.CheckBox();
            this.CebSetAlarm = new System.Windows.Forms.CheckBox();
            this.LbTitleReminder = new System.Windows.Forms.Label();
            this.TbReminder = new System.Windows.Forms.TextBox();
            this.ScReminderPage = new System.Windows.Forms.SplitContainer();
            this.LbNewReminder = new System.Windows.Forms.Label();
            this.LSearchReminders = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listbReminderList = new System.Windows.Forms.ListBox();
            this.TpCalender = new System.Windows.Forms.TabPage();
            this.TpTimeTable = new System.Windows.Forms.TabPage();
            this.TpAlarm = new System.Windows.Forms.TabPage();
            this.TpStopWatch = new System.Windows.Forms.TabPage();
            this.TpTimer = new System.Windows.Forms.TabPage();
            this.timeframeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MsFileMenu = new System.Windows.Forms.MenuStrip();
            this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TpmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TpmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.TpmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TcMainTabControl.SuspendLayout();
            this.TpReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mysticToDoDBEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).BeginInit();
            this.ScReminderPage.Panel1.SuspendLayout();
            this.ScReminderPage.Panel2.SuspendLayout();
            this.ScReminderPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeframeBindingSource)).BeginInit();
            this.MsFileMenu.SuspendLayout();
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
            this.TcMainTabControl.Location = new System.Drawing.Point(0, 45);
            this.TcMainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TcMainTabControl.Multiline = true;
            this.TcMainTabControl.Name = "TcMainTabControl";
            this.TcMainTabControl.SelectedIndex = 0;
            this.TcMainTabControl.ShowToolTips = true;
            this.TcMainTabControl.Size = new System.Drawing.Size(1774, 1239);
            this.TcMainTabControl.TabIndex = 0;
            // 
            // TpReminder
            // 
            this.TpReminder.Controls.Add(this.BSubmit);
            this.TpReminder.Controls.Add(this.textBox1);
            this.TpReminder.Controls.Add(this.LDescription);
            this.TpReminder.Controls.Add(this.CbPerodicAlarm);
            this.TpReminder.Controls.Add(this.DtpAlarmDate);
            this.TpReminder.Controls.Add(this.CbPeriodicAlarm);
            this.TpReminder.Controls.Add(this.CebSetAlarm);
            this.TpReminder.Controls.Add(this.LbTitleReminder);
            this.TpReminder.Controls.Add(this.TbReminder);
            this.TpReminder.Controls.Add(this.ScReminderPage);
            this.TpReminder.Location = new System.Drawing.Point(31, 4);
            this.TpReminder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpReminder.Name = "TpReminder";
            this.TpReminder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpReminder.Size = new System.Drawing.Size(1739, 1231);
            this.TpReminder.TabIndex = 0;
            this.TpReminder.Text = "Reminder";
            this.TpReminder.UseVisualStyleBackColor = true;
            // 
            // BSubmit
            // 
            this.BSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSubmit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSubmit.Location = new System.Drawing.Point(1424, 161);
            this.BSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(252, 58);
            this.BSubmit.TabIndex = 9;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(1037, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 94);
            this.textBox1.TabIndex = 8;
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.BackColor = System.Drawing.Color.Silver;
            this.LDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LDescription.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescription.Location = new System.Drawing.Point(837, 220);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(156, 30);
            this.LDescription.TabIndex = 7;
            this.LDescription.Text = "Description";
            this.LDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CbPerodicAlarm
            // 
            this.CbPerodicAlarm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CbPerodicAlarm.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.timeframeBindingSource, "Timeframe_Name", true));
            this.CbPerodicAlarm.DataSource = this.mysticToDoDBEntitiesBindingSource;
            this.CbPerodicAlarm.DisplayMember = "Timeframes";
            this.CbPerodicAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbPerodicAlarm.FormattingEnabled = true;
            this.CbPerodicAlarm.Location = new System.Drawing.Point(431, 284);
            this.CbPerodicAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbPerodicAlarm.Name = "CbPerodicAlarm";
            this.CbPerodicAlarm.Size = new System.Drawing.Size(380, 30);
            this.CbPerodicAlarm.TabIndex = 6;
            this.CbPerodicAlarm.ValueMember = "Timeframes";
            // 
            // mysticToDoDBEntitiesBindingSource
            // 
            this.mysticToDoDBEntitiesBindingSource.DataSource = typeof(GUIApp.MysticTodo.Data.MysticToDo_DBEntities);
            // 
            // DtpAlarmDate
            // 
            this.DtpAlarmDate.Location = new System.Drawing.Point(431, 221);
            this.DtpAlarmDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpAlarmDate.Name = "DtpAlarmDate";
            this.DtpAlarmDate.Size = new System.Drawing.Size(380, 29);
            this.DtpAlarmDate.TabIndex = 5;
            // 
            // CbPeriodicAlarm
            // 
            this.CbPeriodicAlarm.AutoSize = true;
            this.CbPeriodicAlarm.BackColor = System.Drawing.Color.Silver;
            this.CbPeriodicAlarm.Location = new System.Drawing.Point(191, 284);
            this.CbPeriodicAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbPeriodicAlarm.Name = "CbPeriodicAlarm";
            this.CbPeriodicAlarm.Size = new System.Drawing.Size(175, 26);
            this.CbPeriodicAlarm.TabIndex = 4;
            this.CbPeriodicAlarm.Text = "Periodic Alarm";
            this.CbPeriodicAlarm.UseVisualStyleBackColor = false;
            // 
            // CebSetAlarm
            // 
            this.CebSetAlarm.AutoSize = true;
            this.CebSetAlarm.BackColor = System.Drawing.Color.Silver;
            this.CebSetAlarm.Location = new System.Drawing.Point(245, 226);
            this.CebSetAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CebSetAlarm.Name = "CebSetAlarm";
            this.CebSetAlarm.Size = new System.Drawing.Size(127, 26);
            this.CebSetAlarm.TabIndex = 3;
            this.CebSetAlarm.Text = "Set Alarm";
            this.CebSetAlarm.UseVisualStyleBackColor = false;
            // 
            // LbTitleReminder
            // 
            this.LbTitleReminder.AutoSize = true;
            this.LbTitleReminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LbTitleReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbTitleReminder.Font = new System.Drawing.Font("Stencil BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitleReminder.Location = new System.Drawing.Point(711, 38);
            this.LbTitleReminder.Name = "LbTitleReminder";
            this.LbTitleReminder.Size = new System.Drawing.Size(278, 57);
            this.LbTitleReminder.TabIndex = 1;
            this.LbTitleReminder.Text = "Reminder";
            this.LbTitleReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbReminder
            // 
            this.TbReminder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TbReminder.Location = new System.Drawing.Point(431, 155);
            this.TbReminder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbReminder.Name = "TbReminder";
            this.TbReminder.Size = new System.Drawing.Size(946, 29);
            this.TbReminder.TabIndex = 0;
            // 
            // ScReminderPage
            // 
            this.ScReminderPage.Location = new System.Drawing.Point(7, 8);
            this.ScReminderPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScReminderPage.Name = "ScReminderPage";
            this.ScReminderPage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScReminderPage.Panel1
            // 
            this.ScReminderPage.Panel1.BackColor = System.Drawing.Color.Silver;
            this.ScReminderPage.Panel1.Controls.Add(this.LbNewReminder);
            // 
            // ScReminderPage.Panel2
            // 
            this.ScReminderPage.Panel2.Controls.Add(this.LSearchReminders);
            this.ScReminderPage.Panel2.Controls.Add(this.textBox2);
            this.ScReminderPage.Panel2.Controls.Add(this.listbReminderList);
            this.ScReminderPage.Size = new System.Drawing.Size(1725, 1214);
            this.ScReminderPage.SplitterDistance = 350;
            this.ScReminderPage.SplitterWidth = 5;
            this.ScReminderPage.TabIndex = 10;
            // 
            // LbNewReminder
            // 
            this.LbNewReminder.AutoSize = true;
            this.LbNewReminder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbNewReminder.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNewReminder.Location = new System.Drawing.Point(43, 148);
            this.LbNewReminder.Name = "LbNewReminder";
            this.LbNewReminder.Size = new System.Drawing.Size(301, 37);
            this.LbNewReminder.TabIndex = 2;
            this.LbNewReminder.Text = "Add New Reminder";
            this.LbNewReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LSearchReminders
            // 
            this.LSearchReminders.AutoSize = true;
            this.LSearchReminders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LSearchReminders.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSearchReminders.Location = new System.Drawing.Point(43, 19);
            this.LSearchReminders.Name = "LSearchReminders";
            this.LSearchReminders.Size = new System.Drawing.Size(280, 37);
            this.LSearchReminders.TabIndex = 11;
            this.LSearchReminders.Text = "Search Reminders";
            this.LSearchReminders.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(424, 19);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(946, 29);
            this.textBox2.TabIndex = 11;
            // 
            // listbReminderList
            // 
            this.listbReminderList.DataSource = this.mysticToDoDBEntitiesBindingSource;
            this.listbReminderList.FormattingEnabled = true;
            this.listbReminderList.ItemHeight = 22;
            this.listbReminderList.Location = new System.Drawing.Point(46, 86);
            this.listbReminderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbReminderList.MultiColumn = true;
            this.listbReminderList.Name = "listbReminderList";
            this.listbReminderList.Size = new System.Drawing.Size(1672, 774);
            this.listbReminderList.TabIndex = 0;
            this.listbReminderList.UseTabStops = false;
            // 
            // TpCalender
            // 
            this.TpCalender.Location = new System.Drawing.Point(31, 4);
            this.TpCalender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpCalender.Name = "TpCalender";
            this.TpCalender.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpCalender.Size = new System.Drawing.Size(1739, 1231);
            this.TpCalender.TabIndex = 1;
            this.TpCalender.Text = "Calender";
            this.TpCalender.UseVisualStyleBackColor = true;
            // 
            // TpTimeTable
            // 
            this.TpTimeTable.Location = new System.Drawing.Point(31, 4);
            this.TpTimeTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpTimeTable.Name = "TpTimeTable";
            this.TpTimeTable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpTimeTable.Size = new System.Drawing.Size(1739, 1231);
            this.TpTimeTable.TabIndex = 2;
            this.TpTimeTable.Text = "TimeTable";
            this.TpTimeTable.UseVisualStyleBackColor = true;
            // 
            // TpAlarm
            // 
            this.TpAlarm.Location = new System.Drawing.Point(31, 4);
            this.TpAlarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpAlarm.Name = "TpAlarm";
            this.TpAlarm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpAlarm.Size = new System.Drawing.Size(1739, 1231);
            this.TpAlarm.TabIndex = 3;
            this.TpAlarm.Text = "Alarm";
            this.TpAlarm.UseVisualStyleBackColor = true;
            // 
            // TpStopWatch
            // 
            this.TpStopWatch.Location = new System.Drawing.Point(31, 4);
            this.TpStopWatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpStopWatch.Name = "TpStopWatch";
            this.TpStopWatch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpStopWatch.Size = new System.Drawing.Size(1739, 1231);
            this.TpStopWatch.TabIndex = 4;
            this.TpStopWatch.Text = "StopWatch";
            this.TpStopWatch.UseVisualStyleBackColor = true;
            // 
            // TpTimer
            // 
            this.TpTimer.Location = new System.Drawing.Point(31, 4);
            this.TpTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpTimer.Name = "TpTimer";
            this.TpTimer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TpTimer.Size = new System.Drawing.Size(1739, 1231);
            this.TpTimer.TabIndex = 5;
            this.TpTimer.Text = "Timer";
            this.TpTimer.UseVisualStyleBackColor = true;
            // 
            // timeframeBindingSource
            // 
            this.timeframeBindingSource.DataSource = typeof(GUIApp.MysticTodo.Data.Timeframe);
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
            this.MsFileMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MsFileMenu.Size = new System.Drawing.Size(1768, 33);
            this.MsFileMenu.TabIndex = 1;
            this.MsFileMenu.Text = "File";
            // 
            // TsmiFile
            // 
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(54, 29);
            this.TsmiFile.Text = "File";
            // 
            // TpmiEdit
            // 
            this.TpmiEdit.Name = "TpmiEdit";
            this.TpmiEdit.Size = new System.Drawing.Size(58, 29);
            this.TpmiEdit.Text = "Edit";
            // 
            // TpmiView
            // 
            this.TpmiView.Name = "TpmiView";
            this.TpmiView.Size = new System.Drawing.Size(65, 29);
            this.TpmiView.Text = "View";
            // 
            // TpmiHelp
            // 
            this.TpmiHelp.Name = "TpmiHelp";
            this.TpmiHelp.Size = new System.Drawing.Size(65, 29);
            this.TpmiHelp.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1320);
            this.Controls.Add(this.TcMainTabControl);
            this.Controls.Add(this.MsFileMenu);
            this.MainMenuStrip = this.MsFileMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MysticToDo";
            this.TcMainTabControl.ResumeLayout(false);
            this.TpReminder.ResumeLayout(false);
            this.TpReminder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mysticToDoDBEntitiesBindingSource)).EndInit();
            this.ScReminderPage.Panel1.ResumeLayout(false);
            this.ScReminderPage.Panel1.PerformLayout();
            this.ScReminderPage.Panel2.ResumeLayout(false);
            this.ScReminderPage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScReminderPage)).EndInit();
            this.ScReminderPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeframeBindingSource)).EndInit();
            this.MsFileMenu.ResumeLayout(false);
            this.MsFileMenu.PerformLayout();
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
        private System.Windows.Forms.CheckBox CbPeriodicAlarm;
        private System.Windows.Forms.CheckBox CebSetAlarm;
        private System.Windows.Forms.ComboBox CbPerodicAlarm;
        private System.Windows.Forms.DateTimePicker DtpAlarmDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LDescription;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.SplitContainer ScReminderPage;
        private System.Windows.Forms.ListBox listbReminderList;
        private System.Windows.Forms.Label LSearchReminders;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource mysticToDoDBEntitiesBindingSource;
        private System.Windows.Forms.BindingSource timeframeBindingSource;
    }
}

