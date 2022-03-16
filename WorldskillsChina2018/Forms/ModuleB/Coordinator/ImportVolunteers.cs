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
using System.Data.OleDb;

namespace WorldskillsChina2018 {
	public partial class ImportVolunteers : Form {
		string id;
		public ImportVolunteers(string id) {
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

			lblResult.Text = string.Empty;
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			if (!File.Exists(filePath)) {
				lblResult.Text = "File doesn't exist!";
				lblResult.ForeColor = Color.Red;
				return;
			}
			lblResult.ForeColor = Color.Black;
			lblResult.Text = "Importing...";

			string conn = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'", filePath);
			using (var da = new OleDbDataAdapter("SELECT * FROM [data$]", conn)) {
				using (var dt = new DataTable()) {
					try {
						da.Fill(dt);
						if (dt.Columns.Count != 9) {
							lblResult.Text = "Unexpected table format! Expected 9 columns.";
							lblResult.ForeColor = Color.Red;
							return;
						}

						int added = 0;
						int overridden = 0;
						foreach(DataRow row in dt.Rows) {
							var idNumber = row["IdNumber"].ToString();
							var name = row["Name"].ToString();
							var province = row["ProvinceCode"].ToString();
							var gender = row["Gender"].ToString();
							var organ = row["Organization"].ToString();
							var occ = row["Occupation"].ToString();
							var polit = row["PoliticalStatus"].ToString();
							var phone = row["Phone"].ToString();
							var skill = row["SkillsId"].ToString();
							if(Utils.ExecuteUpdate("DELETE FROM Volunteer WHERE IdNumber=@0", idNumber) > 0) {
								overridden += 1;
							}
							Utils.ExecuteUpdate(
								"INSERT INTO Volunteer VALUES(@0,@1,@2,@3,@4,@5,@6,@7,@8)",
								idNumber, name, province, gender, organ, occ, polit, phone, skill
							);
							added += 1;
						}
						int total = (int)Utils.ExecuteScalar("SELECT COUNT(IdNumber) FROM Volunteer");
						lblResult.ForeColor = Color.Black;
						lblResult.Text = String.Format("Import Successfully! Total Record: {0}; New Record: {1}; Overridden Record: {2}", total, added, overridden);

					} catch (Exception ex) {
						lblResult.Text = "Failed to import: " + ex.Message;
						lblResult.ForeColor = Color.Red;
						return;
					}
				}
			}
		}

		string filePath = string.Empty;
		private void button1_Click_1(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				filePath = openFileDialog1.FileName;
				textBox1.Text = Path.GetFileName(filePath);
			}
		}
	}
}
