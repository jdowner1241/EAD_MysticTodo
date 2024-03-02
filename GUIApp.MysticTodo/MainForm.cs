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
        public MainForm()
        {
            InitializeComponent();
            mysticToDo_dbEntities1 = new MysticToDo_DBEntities1();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var timeframe = mysticToDo_dbEntities1.Timeframes.ToList();
            CbPerodicAlarm.DisplayMember = "Timeframe_Name";
            CbPerodicAlarm.ValueMember = "Timeframe_Key";
            CbPerodicAlarm.DataSource = timeframe;
        }
    }
}
