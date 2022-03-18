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
	public partial class VolunteerManagement : Form {
		string id;
		public VolunteerManagement(string id) {
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
		List<object> skillsIds = new List<object>();

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			eventId = Utils.ExecuteScalar("SELECT MAX(EventId) FROM Event");

			skillsIds.Add(null);
			comboSkill.Items.Add("All Skills");

			foreach (var r in Utils.ExecuteReader("SELECT SkillsInEvent.SkillsId as Id,Skills.SkillsName as Name FROM SkillsInEvent,Skills WHERE SkillsInEvent.SkillsId=Skills.SkillsId AND EventId=@0 ORDER BY SkillsInEvent.SkillsId", eventId)) {
				skillsIds.Add(r["Id"]);
				comboSkill.Items.Add(r["Id"].ToString() + " - " + r["Name"].ToString());
			}

			comboSkill.SelectedIndex = 0;
			comboSort.SelectedIndex = 0;

			UpdateData();
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		DataTable table;
		StringBuilder sb = new StringBuilder();
		void UpdateData() {
			sb.Clear();

			sb.Append("SELECT IdNumber,Name, (CASE WHEN Gender='M' THEN 'Male' ELSE 'Female' END) as Gender,Occupation,Province.ProvinceName as Province, CONCAT(Volunteer.SkillsId,' - ',SkillsName) as [Skills Of Service] FROM Volunteer,Province,Skills WHERE Volunteer.ProvinceCode=Province.ProvinceCode AND Volunteer.SkillsId=Skills.SkillsId");

			object[] args;
			if (comboSkill.SelectedIndex != 0) {
				sb.Append(" AND Volunteer.SkillsId=@0");
				args = new object[] { skillsIds[comboSkill.SelectedIndex] };
			} else {
				args = Array.Empty<object>();
			}
			sb.Append(" ORDER BY [");
			sb.Append(comboSort.Text);
			sb.Append(']');

			table = Utils.ExecuteQuery(sb.ToString(), args);
			
			curPage = 0;
			rowCount=table.Rows.Count;
			pageCount = (int)Math.Ceiling(rowCount / (double)PageSize);
			
			lblTotal.Text = "Total Volunteers: " + rowCount;
			
			UpdatePage();
		}
		int curPage = 0;
		int pageCount = 0;
		int rowCount = 0;
		const int PageSize = 7;
		void UpdatePage() {
			if (curPage < 0) curPage = 0;
			if (curPage >= pageCount) curPage = pageCount - 1;

			if (rowCount <= 0) {
				dataGridView1.DataSource = table.DefaultView;
				lblPage.Text = "N/A";
			} else {
				dataGridView1.DataSource = table.AsEnumerable().Skip(curPage * PageSize).Take(PageSize).CopyToDataTable().DefaultView;
				lblPage.Text = curPage + 1 + " / " + pageCount;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			curPage = 0;
			UpdatePage();
		}

		private void button2_Click(object sender, EventArgs e) {
			curPage -= 1;
			UpdatePage();
		}

		private void button3_Click(object sender, EventArgs e) {
			curPage += 1;
			UpdatePage();
		}

		private void button4_Click(object sender, EventArgs e) {
			curPage = pageCount - 1;
			UpdatePage();
		}

		private void button5_Click(object sender, EventArgs e) {
			if(!int.TryParse(inputPage.Text,out int page)) {
				MessageBox.Show("Please input a number!");
				return;
			}
			page -= 1;
			if (page < 0 || page >= pageCount) {
				MessageBox.Show("Page number out of bound!");
			}
			curPage = page;
			UpdatePage();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			UpdateData();
		}

		private void btnImport_Click(object sender, EventArgs e) {
			var form = new ImportVolunteers(id);
			form.ShowDialog();
			if (Login.LoggingOut) {
				Close();
			}
		}

		private void btnAdjust_Click(object sender, EventArgs e) {
			var form = new AdjustVolunteers(id);
			form.ShowDialog();
			if (Login.LoggingOut) {
				Close();
			}
		}
	}
}
