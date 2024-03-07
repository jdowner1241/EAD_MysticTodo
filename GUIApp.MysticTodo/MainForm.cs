using GUIApp.MysticTodo.Data;
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

        private readonly MysticToDo_DBEntities1 mysticToDo_dbEntities1;
        private bool messageShown = false;


        public MainForm()
        {
            InitializeComponent();
            mysticToDo_dbEntities1 = new MysticToDo_DBEntities1();
            DtpAlarmDate.Hide();
            CbPerodicAlarm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var timeframe = mysticToDo_dbEntities1.Timeframes.ToList();
            CbPerodicAlarm.DisplayMember = "Timeframe_Name";
            CbPerodicAlarm.ValueMember = "Timeframe_Key";
            CbPerodicAlarm.DataSource = timeframe;

            var reminders = mysticToDo_dbEntities1.Reminders.ToList();
            dataGridView1.DataSource = reminders;

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
            string reminderName = TbReminder.Text;
            string reminderDescription = TbDescription.Text;

            if (CebSetAlarm.Checked)
            {
                DateTime reminderAlarm = DtpAlarmDate.Value;
                if (CheckbPeriodicAlarm.Checked)
                {
                    var reminderPerodicAlarm = CbPerodicAlarm.SelectedText;
                }
            }



                //var addReminder = mysticToDo_dbEntities1.Reminders
                //TbReminder.Text 
        }
    }
}
