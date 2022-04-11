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
	public partial class AdjustVolunteers : Form {
		string id;
		public AdjustVolunteers(string id) {
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
		Dictionary<object, string> skillsToName = new Dictionary<object, string>();
		HashSet<object> skillsIds = new HashSet<object>();

		List<object> skillsIdsL = new List<object>();
		List<object> skillsIdsR = new List<object>();
		int avg = 0;

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			eventId = Utils.ExecuteScalar("SELECT MAX(EventId) FROM Event");
			avg = (int)Utils.ExecuteScalar("SELECT (SELECT COUNT(IdNumber) FROM Volunteer)/(SELECT COUNT(DISTINCT Skills.SkillsId) FROM Skills,SkillsInEvent,Volunteer WHERE Skills.SkillsId=SkillsInEvent.SkillsId AND Volunteer.SkillsId=Skills.SkillsId)");


			foreach (var r in Utils.ExecuteReader("SELECT SkillsInEvent.SkillsId as Id,Skills.SkillsName as Name FROM SkillsInEvent,Skills WHERE SkillsInEvent.SkillsId=Skills.SkillsId AND EventId=@0 ORDER BY SkillsInEvent.SkillsId", eventId)) {
				skillsToName.Add(r["Id"], r["Name"].ToString());
				skillsIds.Add(r["Id"]);
			}

			foreach (var r in Utils.ExecuteReader("SELECT SkillsInEvent.SkillsId as Id FROM SkillsInEvent,Volunteer WHERE SkillsInEvent.SkillsId=Volunteer.SkillsId AND EventId=@0 GROUP BY SkillsInEvent.SkillsId HAVING COUNT(IdNumber)>=@1", eventId, avg)) {
				var id = r["Id"];
				skillsIdsL.Add(id);
				skillsIds.Remove(id);
				comboL.Items.Add(id.ToString() + " - " + skillsToName[id]);
			}

			foreach (var id in skillsIds) {
				skillsIdsR.Add(id);
				comboR.Items.Add(id.ToString() + " - " + skillsToName[id]);
			}
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		object skillsL = null;
		object skillsR = null;
		DataTable tableL = null;
		DataTable tableR = null;
		List<DataRow> transferringRows = new List<DataRow>();
		private void btnLR_Click(object sender, EventArgs e) {
			if (skillsL == null || skillsR == null) {
				return;
			}
			for (int i = tableL.Rows.Count - 1; i >= 0; i -= 1) {
				var dgvRow = dataL.Rows[i];
				if (!(bool)(dgvRow.Cells[0].Value ?? false)) {
					continue;
				}
				var row = (dataL.Rows[i].DataBoundItem as DataRowView).Row;
				transferringRows.Add(row);
			}
			foreach (var row in transferringRows) {
				var newRow = tableR.NewRow();
				newRow["IdNumber"] = row["IdNumber"];
				newRow["Name"] = row["Name"];
				newRow["Gender"] = row["Gender"];
				newRow["Age"] = row["Age"];
				newRow["Occupation"] = row["Occupation"];
				tableL.Rows.Remove(row);
				tableR.Rows.Add(newRow);
			}
			transferringRows.Clear();
			UpdateCountText();
		}

		private void btnRL_Click(object sender, EventArgs e) {
			if (skillsL == null || skillsR == null) {
				return;
			}
			for (int i = tableR.Rows.Count - 1; i >= 0; i -= 1) {
				var dgvRow = dataR.Rows[i];
				if (!(bool)(dgvRow.Cells[0].Value ?? false)) {
					continue;
				}
				var row = (dataR.Rows[i].DataBoundItem as DataRowView).Row;
				transferringRows.Add(row);
			}
			foreach (var row in transferringRows) {
				var newRow = tableL.NewRow();
				newRow["IdNumber"] = row["IdNumber"];
				newRow["Name"] = row["Name"];
				newRow["Gender"] = row["Gender"];
				newRow["Age"] = row["Age"];
				newRow["Occupation"] = row["Occupation"];
				tableR.Rows.Remove(row);
				tableL.Rows.Add(newRow);
			}
			transferringRows.Clear();
			UpdateCountText();
		}

		private void btnL_Click(object sender, EventArgs e) {
			var index = comboL.SelectedIndex;
			if (index < 0) {
				return;
			}
			skillsL = skillsIdsL[index];
			RefreshL();
			RefreshR();
			UpdateCountText();
		}
		private void btnR_Click(object sender, EventArgs e) {
			var index = comboR.SelectedIndex;
			if (index < 0) {
				return;
			}
			skillsR = skillsIdsR[index];
			RefreshR();
			RefreshL();
			UpdateCountText();
		}
		void RefreshL() {
			if (skillsL == null) {
				return;
			}
			tableL = Utils.ExecuteQuery("SELECT IdNumber,Name,Gender,YEAR(SYSDATETIME())-SUBSTRING(IdNumber,7,4) as Age,Occupation FROM Volunteer WHERE Volunteer.SkillsId=@0", skillsL);
			dataL.DataSource = tableL;
		}
		void RefreshR() {
			if (skillsR == null) {
				return;
			}
			tableR = Utils.ExecuteQuery("SELECT IdNumber,Name,Gender,YEAR(SYSDATETIME())-SUBSTRING(IdNumber,7,4) as Age,Occupation FROM Volunteer WHERE Volunteer.SkillsId=@0", skillsR);
			dataR.DataSource = tableR;
		}
		void UpdateCountText() {
			lblL.Text = "Total Volunteers: " + (tableL?.Rows.Count??0);
			lblR.Text = "Total Volunteers: " + (tableR?.Rows.Count??0);
		}

		private void dataL_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex < 0|| e.ColumnIndex < 0) {
				return;
			}
			if (e.ColumnIndex==0) {
				var cell = dataL.Rows[e.RowIndex].Cells[0];// as Datagrid;
				cell.Value = !(bool)(cell.Value ?? false);
			}
		}

		private void dataR_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex < 0 || e.ColumnIndex < 0) {
				return;
			}
			if (e.ColumnIndex==0) {
				var cell = dataR.Rows[e.RowIndex].Cells[0];// as Datagrid;
				cell.Value = !(bool)(cell.Value ?? false);
			}
		}

		private void btnSave_Click(object sender, EventArgs e) {
			if (skillsL == null || skillsR == null) {
				MessageBox.Show("Please select 2 tables first!");
				return;
			}

			foreach (DataRow row in tableL.Rows) {
				Utils.ExecuteUpdate("UPDATE Volunteer SET SkillsId=@1 WHERE IdNumber=@0", row["IdNumber"], skillsL);
			}
			foreach (DataRow row in tableR.Rows) {
				Utils.ExecuteUpdate("UPDATE Volunteer SET SkillsId=@1 WHERE IdNumber=@0", row["IdNumber"], skillsR);
			}
			MessageBox.Show("Adjustment complete!");
			RefreshR();
			RefreshL();
			UpdateCountText();
		}
	}
}
