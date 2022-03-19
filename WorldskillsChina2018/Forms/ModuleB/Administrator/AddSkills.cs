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
	public partial class AddSkills : Form {
		string id;
		object eventId;
		public AddSkills(string id,object eventId) {
			InitializeComponent();
			this.id = id;
			this.eventId = eventId;
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

			lblEvent.Text = Utils.ExecuteScalar("SELECT CONCAT(EventId,' - ',EventName) FROM [Event] WHERE EventId=@0", eventId) as string;
			UpdateData();
		}
		public void UpdateData() {
			table = Utils.ExecuteQuery("SELECT SkillsId as Id, CONCAT(SkillsId,' - ',SkillsName) as Name FROM Skills WHERE SkillsId NOT IN (SELECT SkillsId FROM SkillsInEvent WHERE EventId=@0)", eventId);
			dataGridView1.DataSource = table;
			lblTotal.Text = "Total Skills: " + table.Rows.Count;
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		DataTable table;

		private void button1_Click(object sender, EventArgs e) {
			foreach(DataGridViewRow dgvr in dataGridView1.Rows) {
				if (!(bool)(dgvr.Cells[0].Value ?? false)) {
					continue;
				}
				var row = (dgvr.DataBoundItem as DataRowView).Row;
				var skillsId = row["Id"];
				Utils.ExecuteUpdate("INSERT INTO SkillsInEvent(EventId,SkillsId,ZoneId) VALUES(@0,@1,'A')", eventId, skillsId);
			}

			MessageBox.Show("Save complete!");
			UpdateData();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex < 0) {
				return;
			}
			if (e.ColumnIndex == 0) {
				var cell=dataGridView1.Rows[e.RowIndex].Cells[0];
				cell.Value = !(bool)(cell.Value ?? false);
			}
		}
	}
}
