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
using System.Runtime.Serialization;

namespace WorldskillsChina2018 {
	public partial class MyResults : Form {
		string id;
		object eventId;
		object skillsId;

		public MyResults(string id) {
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

		[DataContract]
		public struct Score {
			[DataMember(IsRequired = false)]
			public string Module1 { get; set; }
			[DataMember(IsRequired = false)]
			public string Module2 { get; set; }
			[DataMember(IsRequired = false)]
			public string Module3 { get; set; }
			[DataMember(IsRequired = false)]
			public string Module4 { get; set; }
		}

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			eventId = Utils.ExecuteScalar("SELECT MAX(EventId) FROM Event");
			skillsId = Utils.ExecuteScalar(
				"SELECT Competition.SkillsId FROM Competitor, Competition WHERE " +
				"Competitor.CompetitorId=Competition.CompetitorId AND " +
				"Competitor.IdNumber=@0 AND Competition.EventId=@1",
				id, eventId);
			if (skillsId == null) {
				MessageBox.Show("You don't have any competition currently!");
				Close();
				return;
			}

			var ev = Utils.ExecuteScalar("SELECT EventName FROM Event WHERE EventId=@0", eventId) as string;
			lblEvent.Text = eventId + " - " + ev;

			var skills = Utils.ExecuteScalar("SELECT SkillsName FROM Skills WHERE SkillsId=@0", skillsId) as string;
			lblSkills.Text = skillsId + " - " + skills;

			foreach (var r in Utils.ExecuteReader(
				"SELECT Name,Gender,Competitor.ProvinceCode as ProvinceCode, ProvinceName, Organization,CompetitorNumber,Result " +
				"FROM [User],Competitor,Province,Competition " +
				"WHERE [User].IdNumber=[Competitor].IdNumber " +
				"AND Competitor.ProvinceCode = Province.ProvinceCode " +
				"AND Competitor.CompetitorId = Competition.CompetitorId " +
				"AND[User].IdNumber = @0 " +
				"AND Competition.EventId = @1 " +
				"AND Competition.SkillsId = @2",
				id,eventId,skillsId)
			) {
				lblName.Text = r["Name"].ToString();
				lblGender.Text = r["Gender"].ToString() == "M" ? "Male" : "Female";
				lblId.Text = id;
				lblProvince.Text = string.Format("{0} ({1})", r["ProvinceName"], r["ProvinceCode"]);
				lblOrganization.Text = r["Organization"].ToString();
				lblNumber.Text = r["CompetitorNumber"].ToString();

				var resultJson = r["Result"].ToString();
				var result = Utils.DeserializeFromJson<Score>(resultJson);
				
				if(!int.TryParse(result.Module1,out int m1)) {
					m1 = 0;
				}
				if (!int.TryParse(result.Module2, out int m2)) {
					m2 = 0;
				}
				if (!int.TryParse(result.Module3, out int m3)) {
					m3 = 0;
				}
				if (!int.TryParse(result.Module4, out int m4)) {
					m4 = 0;
				}

				lblM1.Text = result.Module1 ?? "N/A";
				lblM2.Text = result.Module2 ?? "N/A";
				lblM3.Text = result.Module3 ?? "N/A";
				lblMn.Text = result.Module4 ?? "N/A";
				lblScore.Text = (m1 + m2 + m3 + m4).ToString();
			}
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}
	}
}
