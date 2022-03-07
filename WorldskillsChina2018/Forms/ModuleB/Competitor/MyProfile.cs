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
	public partial class MyProfile : Form {
		string id;
		public MyProfile(string id) {
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

			byte[] photo = null;
			foreach (var r in Utils.ExecuteReader("SELECT Name,Gender,DateOfBirth,Competitor.ProvinceCode AS ProvinceCode,ProvinceName,Phone,Email,Photo FROM [User],Competitor,Province WHERE [User].IdNumber=Competitor.IdNumber AND Competitor.ProvinceCode=Province.ProvinceCode AND [User].IdNumber=@0", id)) {
				lblName.Text = r["Name"] as string;
				lblGender.Text = (r["Gender"] as string) == "M" ? "Male" : "Female";
				lblBirth.Text = ((DateTime)r["DateOfBirth"]).ToString("yyyy-MM-dd");
				lblProvince.Text = string.Format("{0} ({1})", r["ProvinceName"] as string, r["ProvinceCode"] as string);
				lblId.Text = id;
				lblPhone.Text = r["Phone"] as string;
				lblEmail.Text = r["Email"] as string;
				photo = r["Photo"] as byte[];
			}
			if (photo != null) {
				using (var stream = new MemoryStream(photo)) {
					var img = Image.FromStream(stream);
					picAvatar.Image = img;
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		private void inputModify_CheckedChanged(object sender, EventArgs e) {
			var state = inputModify.Checked;
			inputPwd.Enabled = state;
			inputRepwd.Enabled = state;
			btnSave.Enabled = state;
		}

		private void btnSave_Click(object sender, EventArgs e) {
			var pwd = inputPwd.Text.Trim();
			var repwd=inputRepwd.Text.Trim();

			if (string.IsNullOrWhiteSpace(pwd)) {
				MessageBox.Show("Please input the new password!");
				return;
			}
			if (pwd != repwd) {
				MessageBox.Show("Password and RePassword doesn't match!");
				return;
			}

			var aff=Utils.ExecuteUpdate("UPDATE [User] SET Passwords=@0 WHERE IdNumber=@1", pwd, id);
			if (aff <= 0) {
				MessageBox.Show("Failed to modify your password!");
				return;
			}

			MessageBox.Show("Successfully modified your password.");
			inputModify.Checked = false;
		}
	}
}
