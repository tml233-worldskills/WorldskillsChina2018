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
	public partial class ViewRegisteration : Form {
		string id;
		object eventId;
		public ViewRegisteration(string id,object eventId) {
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

		DataTable skillTable = new DataTable();
		DataTable provinceTable = new DataTable();
		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			skillTable.Columns.Add("Skills", typeof(string));
			skillTable.Columns.Add("Competitors' Provinces", typeof(string));
			skillTable.Columns.Add("Number of Competitors", typeof(int));
			skillTable.Columns.Add("Judgers' Provinces", typeof(string));
			skillTable.Columns.Add("Number of Judgers", typeof(int));

			provinceTable.Columns.Add("Province", typeof(string));
			provinceTable.Columns.Add("Competitors' Skills", typeof(string));
			provinceTable.Columns.Add("Number of Competitors", typeof(int));
			provinceTable.Columns.Add("Judgers' Skills", typeof(string));
			provinceTable.Columns.Add("Number of Judgers", typeof(int));

			UpdateBySkill();
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}
		StringBuilder sb = new StringBuilder();
		void UpdateBySkill() {
			skillTable.Rows.Clear();

			int competitorCount = 0;
			int judgerCount = 0;
			foreach(var rSkill in Utils.ExecuteReader("SELECT DISTINCT Skills.SkillsId as Id, Skills.SkillsName as Name FROM Competition, Skills WHERE Competition.SkillsId=Skills.SkillsId AND Competition.EventId=@0", eventId)) {
				var row = skillTable.NewRow();
				var skillId = rSkill["Id"];
				var skillName = rSkill["Name"];
				row["Skills"] = string.Format("{0} - {1}", skillId, skillName);

				sb.Clear();
				foreach(var rProvinceC in Utils.ExecuteReader("SELECT DISTINCT ProvinceName FROM Competition,Competitor,Province WHERE Competition.CompetitorId=Competitor.CompetitorId AND Competitor.ProvinceCode=Province.ProvinceCode AND EventId=@0 AND SkillsId=@1", eventId, skillId)) {
					var name = rProvinceC["ProvinceName"];
					if (sb.Length > 0) {
						sb.Append(", ");
					}
					sb.Append(name);
				}
				row["Competitors' Provinces"] = sb.ToString();

				sb.Clear();
				foreach (var rProvinceJ in Utils.ExecuteReader("SELECT DISTINCT ProvinceName FROM Judge,Judger,Province WHERE Judge.JudgerId=Judger.JudgerId AND Judger.ProvinceCode=Province.ProvinceCode AND EventId=@0 AND SkillsId=@1", eventId, skillId)) {
					var name = rProvinceJ["ProvinceName"];
					if (sb.Length > 0) {
						sb.Append(", ");
					}
					sb.Append(name);
				}
				row["Judgers' Provinces"] = sb.ToString();

				var cc = (int)Utils.ExecuteScalar("SELECT COUNT(DISTINCT CompetitionId) FROM Competition WHERE EventId=@0 AND SkillsId=@1", eventId, skillId);
				competitorCount += cc;
				row["Number of Competitors"] = cc;

				var cj = (int)Utils.ExecuteScalar("SELECT COUNT(DISTINCT JudgerId) FROM Judge WHERE EventId=@0 AND SkillsId=@1", eventId, skillId);
				judgerCount += cj;
				row["Number of Judgers"] = cj;

				skillTable.Rows.Add(row);
			}

			{
				var row = skillTable.NewRow();
				row["Skills"] = "Sub Total";
				row["Number of Competitors"] = competitorCount;
				row["Number of Judgers"] = judgerCount;
				skillTable.Rows.Add(row);
			}
			dataGridView1.DataSource = skillTable;
		}
		void UpdateByProvince() {
			provinceTable.Rows.Clear();

			int competitorCount = 0;
			int judgerCount = 0;
			foreach (var rSkill in Utils.ExecuteReader("SELECT DISTINCT Competitor.ProvinceCode as ProvinceCode,ProvinceName FROM Competitor, Competition, Province WHERE Competition.CompetitorId=Competitor.CompetitorId AND Competitor.ProvinceCode=Province.ProvinceCode AND Competition.EventId=@0", eventId)) {
				var row = provinceTable.NewRow();
				var provinceCode = rSkill["ProvinceCode"];
				var provinceName = rSkill["ProvinceName"];
				row["Province"] = provinceName;

				sb.Clear();
				foreach (var rSkillC in Utils.ExecuteReader("SELECT DISTINCT Skills.SkillsId,Skills.SkillsName FROM Competitor, Competition, Skills WHERE Competition.CompetitorId=Competitor.CompetitorId AND Competition.SkillsId=Skills.SkillsId AND Competition.EventId=@0 AND Competitor.ProvinceCode=@1", eventId, provinceCode)) {
					var name = rSkillC["SkillsId"] + " - " + rSkillC["SkillsName"];
					if (sb.Length > 0) {
						sb.Append("\r\n");
					}
					sb.Append(name);
				}
				row["Competitors' Skills"] = sb.ToString();

				sb.Clear();
				foreach (var rSkillJ in Utils.ExecuteReader("SELECT DISTINCT Skills.SkillsId,Skills.SkillsName FROM Judge, Judger, Skills WHERE Judge.JudgerId=Judger.JudgerId AND Judge.SkillsId=Skills.SkillsId AND Judge.EventId=@0 AND Judger.ProvinceCode=@1", eventId, provinceCode)) {
					var name = rSkillJ["SkillsId"] + " - " + rSkillJ["SkillsName"];
					if (sb.Length > 0) {
						sb.Append("\r\n");
					}
					sb.Append(name);
				}
				row["Judgers' Skills"] = sb.ToString();

				var cc = (int)Utils.ExecuteScalar("SELECT COUNT(DISTINCT Competitor.CompetitorId) FROM Competition,Competitor WHERE Competitor.CompetitorId=Competition.CompetitorId AND EventId=@0 AND ProvinceCode=@1", eventId, provinceCode);
				competitorCount += cc;
				row["Number of Competitors"] = cc;

				var cj = (int)Utils.ExecuteScalar("SELECT COUNT(DISTINCT Judger.JudgerId) FROM Judge,Judger WHERE Judge.JudgerId=Judger.JudgerId AND EventId=@0 AND ProvinceCode=@1", eventId, provinceCode);
				judgerCount += cj;
				row["Number of Judgers"] = cj;

				provinceTable.Rows.Add(row);
			}

			{
				var row = provinceTable.NewRow();
				row["Province"] = "Sub Total";
				row["Number of Competitors"] = competitorCount;
				row["Number of Judgers"] = judgerCount;
				provinceTable.Rows.Add(row);
			}
			dataGridView2.DataSource = provinceTable;
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			switch (tabControl1.SelectedIndex) {
				case 0:
					UpdateBySkill();
					break;
				case 1:
					UpdateByProvince();
					break;
			}
		}
	}
}
