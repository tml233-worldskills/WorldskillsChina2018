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

namespace WorldskillsChina2018 {
	public partial class CoordinatorMenu : Form {
		string id;
		public CoordinatorMenu(string id) {
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

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);
			string time = "Morning";
			int hour = DateTime.Now.Hour;
			if (hour >= 6 && hour < 12) {
				time = "Morning";
			} else if (hour >= 12 && hour < 18) {
				time = "Afternoon";
			} else if (hour >= 18 && hour < 6) {
				time = "Evening";
			}
			string gender = "Mr.";
			string name = "Null";
			foreach (var r in Utils.ExecuteReader("SELECT Name,Gender FROM [User] WHERE IdNumber=@0", id)) {
				gender = (r["Gender"] as string) == "M" ? "Mr." : "Mrs.";
				name = (r["Name"] as string);
			}
			lblName.Text = string.Format("Good {0}!\n{1} {2}", time, gender, name);
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		private void btn0_Click(object sender, EventArgs e) {
			var form = new VolunteerManagement(id);
			form.ShowDialog();
			if (Login.LoggingOut) {
				Close();
			}
		}
	}
}
