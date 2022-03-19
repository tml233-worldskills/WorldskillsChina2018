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
	public partial class CompetitionSkillsB : Form {
		string id;
		public CompetitionSkillsB(string id) {
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

		List<object> eventIds=new List<object>();
		object eventId;

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			foreach(var r in Utils.ExecuteReader("SELECT EventId, EventName FROM [Event]")) {
				eventIds.Add(r["EventId"]);
				comboEvent.Items.Add(r["EventId"] + " - " + r["EventName"]);
			}
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		DataTable table;
		private void btnSearch_Click(object sender, EventArgs e) {
			if (comboEvent.SelectedIndex < 0) {
				return;
			}
			eventId = eventIds[comboEvent.SelectedIndex];
			UpdateData();
		}

		void UpdateData() {
			if (eventId == null) {
				return;
			}
			table = Utils.ExecuteQuery("SELECT SkillsField.FieldName as Field,Skills.SkillsId as [Skills Id],Skills.SkillsName as [Skills Name] FROM Skills,SkillsInEvent,SkillsField WHERE Skills.SkillsId=SkillsInEvent.SkillsId AND SkillsField.FieldId=Skills.FieldId AND SkillsInEvent.EventId=@0", eventId);
			dataGridView1.DataSource = table;
			lblTotal.Text = "Total Skills: " + table.Rows.Count;
		}

		private void button1_Click(object sender, EventArgs e) {
			if (eventId == null) {
				return;
			}
			var form = new AddSkills(id,eventId);
			form.ShowDialog();
			if (Login.LoggingOut) {
				Close();
			} else {
				UpdateData();
			}
		}
	}
}
