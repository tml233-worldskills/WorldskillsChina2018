using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldskillsChina2018 {
	public partial class HistoryOfWorldskills : Form {
		public HistoryOfWorldskills() {
			InitializeComponent();
		}

		static void DoTime(ToolStripLabel target) {
			var now = DateTime.Now;
			var to = new DateTime(2019, 10, 14, 0, 0, 0);
			var diff = to - now;
			var str = string.Format("{0} days {1} hour {2} minutes and {3} seconds until the 2019 Russia Worldskills Competition starts",
				diff.Days, diff.Hours, diff.Minutes, diff.Seconds);
			target.Text = str;
		}
		private void timerBottom_Tick(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);
		}

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e) {
			textBox1.Text = File.ReadAllText(Utils.ResourcePath + "HistoryOfWorldskills/A.txt");
		}

		private void pictureBox4_Click(object sender, EventArgs e) {
			textBox1.Text = File.ReadAllText(Utils.ResourcePath + "HistoryOfWorldskills/B.txt");
		}

		private void pictureBox5_Click(object sender, EventArgs e) {
			textBox1.Text = File.ReadAllText(Utils.ResourcePath + "HistoryOfWorldskills/C.txt");
		}
	}
}
