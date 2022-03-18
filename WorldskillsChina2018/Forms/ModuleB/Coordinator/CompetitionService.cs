using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.IO;

namespace WorldskillsChina2018 {
	public partial class CompetitionService : Form {
		string id;
		public CompetitionService(string id) {
			InitializeComponent();
			this.id = id;
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

		object eventId;

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			eventId = Utils.ExecuteScalar("SELECT MAX(EventId) FROM Event");

			LoadA();
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		void LoadA() {
			flowA.Controls.Clear();
			
		}
		void LoadB() {

		}
		void LoadC() {

		}
		void LoadD() {

		}
		void LoadE() {

		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			switch (tabControl1.SelectedIndex) {
				case 0:
					LoadA();
					break;
				case 1:
					LoadB();
					break;
				case 2:
					LoadC();
					break;
				case 3:
					LoadD();
					break;
				case 4:
					LoadE();
					break;
			}
		}
	}
}
