namespace GUIApp.MysticTodo
{
    partial class formViewReminder
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
            this.lDescriptionViewer = new System.Windows.Forms.Label();
            this.tbDescriptionViewer = new System.Windows.Forms.TextBox();
            this.lReminderViewer = new System.Windows.Forms.Label();
            this.tbReminderViewer = new System.Windows.Forms.TextBox();
            this.lbTitleReminderViewer = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.lNextAlarmViewer = new System.Windows.Forms.Label();
            this.lAlarmViewer = new System.Windows.Forms.Label();
            this.lPeriodicViewer = new System.Windows.Forms.Label();
            this.gbReminderViewer = new System.Windows.Forms.GroupBox();
            this.tbAlarmTimeViewer = new System.Windows.Forms.TextBox();
            this.tbPeriodicTimeViewer = new System.Windows.Forms.TextBox();
            this.lIdViewer = new System.Windows.Forms.Label();
            this.tbPeriodicViewer = new System.Windows.Forms.TextBox();
            this.tbAlarmDateViewer = new System.Windows.Forms.TextBox();
            this.tbPeriodicDateViewer = new System.Windows.Forms.TextBox();
            this.gbReminderViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDescriptionViewer
            // 
            this.lDescriptionViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDescriptionViewer.AutoSize = true;
            this.lDescriptionViewer.BackColor = System.Drawing.Color.Silver;
            this.lDescriptionViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lDescriptionViewer.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescriptionViewer.Location = new System.Drawing.Point(29, 359);
            this.lDescriptionViewer.Name = "lDescriptionViewer";
            this.lDescriptionViewer.Size = new System.Drawing.Size(156, 30);
            this.lDescriptionViewer.TabIndex = 25;
            this.lDescriptionViewer.Text = "Description";
            this.lDescriptionViewer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDescriptionViewer
            // 
            this.tbDescriptionViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescriptionViewer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDescriptionViewer.Location = new System.Drawing.Point(232, 359);
            this.tbDescriptionViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescriptionViewer.Multiline = true;
            this.tbDescriptionViewer.Name = "tbDescriptionViewer";
            this.tbDescriptionViewer.Size = new System.Drawing.Size(738, 200);
            this.tbDescriptionViewer.TabIndex = 26;
            // 
            // lReminderViewer
            // 
            this.lReminderViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lReminderViewer.AutoSize = true;
            this.lReminderViewer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lReminderViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lReminderViewer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReminderViewer.Location = new System.Drawing.Point(32, 133);
            this.lReminderViewer.Name = "lReminderViewer";
            this.lReminderViewer.Size = new System.Drawing.Size(160, 37);
            this.lReminderViewer.TabIndex = 20;
            this.lReminderViewer.Text = "Reminder";
            this.lReminderViewer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbReminderViewer
            // 
            this.tbReminderViewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReminderViewer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbReminderViewer.Font = new System.Drawing.Font("Modern No. 20", 11F);
            this.tbReminderViewer.Location = new System.Drawing.Point(232, 137);
            this.tbReminderViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbReminderViewer.MaximumSize = new System.Drawing.Size(841, 29);
            this.tbReminderViewer.MaxLength = 842;
            this.tbReminderViewer.Name = "tbReminderViewer";
            this.tbReminderViewer.Size = new System.Drawing.Size(738, 31);
            this.tbReminderViewer.TabIndex = 18;
            this.tbReminderViewer.WordWrap = false;
            // 
            // lbTitleReminderViewer
            // 
            this.lbTitleReminderViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitleReminderViewer.AutoSize = true;
            this.lbTitleReminderViewer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbTitleReminderViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTitleReminderViewer.Font = new System.Drawing.Font("Stencil BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleReminderViewer.Location = new System.Drawing.Point(349, 0);
            this.lbTitleReminderViewer.Name = "lbTitleReminderViewer";
            this.lbTitleReminderViewer.Size = new System.Drawing.Size(417, 57);
            this.lbTitleReminderViewer.TabIndex = 19;
            this.lbTitleReminderViewer.Text = "Reminder View";
            this.lbTitleReminderViewer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(720, 230);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(0, 358);
            this.bClear.TabIndex = 31;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            // 
            // lNextAlarmViewer
            // 
            this.lNextAlarmViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNextAlarmViewer.AutoSize = true;
            this.lNextAlarmViewer.BackColor = System.Drawing.Color.Silver;
            this.lNextAlarmViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lNextAlarmViewer.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNextAlarmViewer.Location = new System.Drawing.Point(771, 209);
            this.lNextAlarmViewer.Name = "lNextAlarmViewer";
            this.lNextAlarmViewer.Size = new System.Drawing.Size(155, 30);
            this.lNextAlarmViewer.TabIndex = 34;
            this.lNextAlarmViewer.Text = "Next Alarm";
            this.lNextAlarmViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lAlarmViewer
            // 
            this.lAlarmViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lAlarmViewer.AutoSize = true;
            this.lAlarmViewer.BackColor = System.Drawing.Color.Silver;
            this.lAlarmViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lAlarmViewer.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlarmViewer.Location = new System.Drawing.Point(92, 215);
            this.lAlarmViewer.Name = "lAlarmViewer";
            this.lAlarmViewer.Size = new System.Drawing.Size(91, 30);
            this.lAlarmViewer.TabIndex = 37;
            this.lAlarmViewer.Text = "Alarm";
            this.lAlarmViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPeriodicViewer
            // 
            this.lPeriodicViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lPeriodicViewer.AutoSize = true;
            this.lPeriodicViewer.BackColor = System.Drawing.Color.Silver;
            this.lPeriodicViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lPeriodicViewer.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeriodicViewer.Location = new System.Drawing.Point(67, 293);
            this.lPeriodicViewer.Name = "lPeriodicViewer";
            this.lPeriodicViewer.Size = new System.Drawing.Size(117, 30);
            this.lPeriodicViewer.TabIndex = 38;
            this.lPeriodicViewer.Text = "Periodic";
            this.lPeriodicViewer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbReminderViewer
            // 
            this.gbReminderViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReminderViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbReminderViewer.Controls.Add(this.tbPeriodicDateViewer);
            this.gbReminderViewer.Controls.Add(this.tbAlarmDateViewer);
            this.gbReminderViewer.Controls.Add(this.tbAlarmTimeViewer);
            this.gbReminderViewer.Controls.Add(this.tbPeriodicTimeViewer);
            this.gbReminderViewer.Controls.Add(this.lIdViewer);
            this.gbReminderViewer.Controls.Add(this.tbPeriodicViewer);
            this.gbReminderViewer.Controls.Add(this.lPeriodicViewer);
            this.gbReminderViewer.Controls.Add(this.lAlarmViewer);
            this.gbReminderViewer.Controls.Add(this.lNextAlarmViewer);
            this.gbReminderViewer.Controls.Add(this.bClear);
            this.gbReminderViewer.Controls.Add(this.lbTitleReminderViewer);
            this.gbReminderViewer.Controls.Add(this.tbReminderViewer);
            this.gbReminderViewer.Controls.Add(this.lReminderViewer);
            this.gbReminderViewer.Controls.Add(this.tbDescriptionViewer);
            this.gbReminderViewer.Controls.Add(this.lDescriptionViewer);
            this.gbReminderViewer.Location = new System.Drawing.Point(73, 73);
            this.gbReminderViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbReminderViewer.Name = "gbReminderViewer";
            this.gbReminderViewer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbReminderViewer.Size = new System.Drawing.Size(1063, 588);
            this.gbReminderViewer.TabIndex = 19;
            this.gbReminderViewer.TabStop = false;
            // 
            // tbAlarmTimeViewer
            // 
            this.tbAlarmTimeViewer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAlarmTimeViewer.Location = new System.Drawing.Point(478, 217);
            this.tbAlarmTimeViewer.Name = "tbAlarmTimeViewer";
            this.tbAlarmTimeViewer.Size = new System.Drawing.Size(139, 22);
            this.tbAlarmTimeViewer.TabIndex = 42;
            // 
            // tbPeriodicTimeViewer
            // 
            this.tbPeriodicTimeViewer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbPeriodicTimeViewer.Location = new System.Drawing.Point(776, 301);
            this.tbPeriodicTimeViewer.Name = "tbPeriodicTimeViewer";
            this.tbPeriodicTimeViewer.Size = new System.Drawing.Size(139, 22);
            this.tbPeriodicTimeViewer.TabIndex = 41;
            // 
            // lIdViewer
            // 
            this.lIdViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdViewer.AutoSize = true;
            this.lIdViewer.BackColor = System.Drawing.Color.Silver;
            this.lIdViewer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lIdViewer.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdViewer.Location = new System.Drawing.Point(53, 66);
            this.lIdViewer.Name = "lIdViewer";
            this.lIdViewer.Size = new System.Drawing.Size(47, 30);
            this.lIdViewer.TabIndex = 40;
            this.lIdViewer.Text = "ID";
            this.lIdViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lIdViewer.Visible = false;
            // 
            // tbPeriodicViewer
            // 
            this.tbPeriodicViewer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPeriodicViewer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPeriodicViewer.Location = new System.Drawing.Point(232, 293);
            this.tbPeriodicViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPeriodicViewer.MaximumSize = new System.Drawing.Size(841, 29);
            this.tbPeriodicViewer.MaxLength = 842;
            this.tbPeriodicViewer.Name = "tbPeriodicViewer";
            this.tbPeriodicViewer.Size = new System.Drawing.Size(240, 22);
            this.tbPeriodicViewer.TabIndex = 39;
            this.tbPeriodicViewer.WordWrap = false;
            // 
            // tbAlarmDateViewer
            // 
            this.tbAlarmDateViewer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAlarmDateViewer.Location = new System.Drawing.Point(232, 217);
            this.tbAlarmDateViewer.Name = "tbAlarmDateViewer";
            this.tbAlarmDateViewer.Size = new System.Drawing.Size(240, 22);
            this.tbAlarmDateViewer.TabIndex = 43;
            // 
            // tbPeriodicDateViewer
            // 
            this.tbPeriodicDateViewer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbPeriodicDateViewer.Location = new System.Drawing.Point(719, 257);
            this.tbPeriodicDateViewer.Name = "tbPeriodicDateViewer";
            this.tbPeriodicDateViewer.Size = new System.Drawing.Size(240, 22);
            this.tbPeriodicDateViewer.TabIndex = 44;
            // 
            // formViewReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 726);
            this.Controls.Add(this.gbReminderViewer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formViewReminder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Viewer";
            this.Load += new System.EventHandler(this.formViewReminder_Load);
            this.gbReminderViewer.ResumeLayout(false);
            this.gbReminderViewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lDescriptionViewer;
        private System.Windows.Forms.TextBox tbDescriptionViewer;
        private System.Windows.Forms.Label lReminderViewer;
        private System.Windows.Forms.TextBox tbReminderViewer;
        private System.Windows.Forms.Label lbTitleReminderViewer;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lNextAlarmViewer;
        private System.Windows.Forms.Label lAlarmViewer;
        private System.Windows.Forms.Label lPeriodicViewer;
        private System.Windows.Forms.GroupBox gbReminderViewer;
        private System.Windows.Forms.TextBox tbPeriodicViewer;
        private System.Windows.Forms.Label lIdViewer;
        private System.Windows.Forms.TextBox tbPeriodicTimeViewer;
        private System.Windows.Forms.TextBox tbAlarmTimeViewer;
        private System.Windows.Forms.TextBox tbPeriodicDateViewer;
        private System.Windows.Forms.TextBox tbAlarmDateViewer;
    }
}