using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldskillsChina2018 {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
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
		struct SessionData {
			[DataMember]
			public string id;
			[DataMember]
			public string password;
		}

		const string sessionFilePath = "./session.json";

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);
			
			lblName.Text = String.Empty;
			ResetCaptcha();

			if (remainTimes == 0) {
				inputId.Enabled = false;
				inputPwd.Enabled = false;
				inputCap.Enabled = false;
				btnLogin.Enabled = false;
				lblCap.Enabled = false;
				inputRemember.Enabled = false;
				MessageBox.Show("You have used up all of your login tries.");
				return;
			}

			if (File.Exists(sessionFilePath)) {
				var json = File.ReadAllText(sessionFilePath);
				var obj = Utils.DeserializeFromJson<SessionData>(json);
				inputId.Text = obj.id;
				inputPwd.Text = obj.password;
			}
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void inputId_TextChanged(object sender, EventArgs e) {
			var id=inputId.Text.Trim();
			foreach (var r in Utils.ExecuteReader("SELECT Name,Gender FROM [User] WHERE IdNumber=@0", id)) {
				var name = r["Name"] as string;
				var gender = r["Gender"] as string;
				var prefix = gender == "M" ? "Mr. " : "Mrs. ";
				lblName.Text = prefix + name;
				return;
			}
			lblName.Text = String.Empty;
		}

		static int remainTimes = 3;
		private void btnLogin_Click(object sender, EventArgs e) {
			var id = inputId.Text.Trim();
			if (string.IsNullOrWhiteSpace(id)) {
				MessageBox.Show("Please input your ID number!");
				return;
			}
			var password = inputPwd.Text.Trim();
			if (string.IsNullOrWhiteSpace(password)) {
				MessageBox.Show("Please input your password!");
				return;
			}
			if (!Utils.Debug) {
				var captcha = inputCap.Text.Trim();
				if (captcha != lblCap.Text) {
					MessageBox.Show("Captcha doesn't match!");
					ResetCaptcha();
					return;
				}
			}
			var role = Utils.ExecuteScalar("SELECT RoleId FROM [User] WHERE IdNumber=@0 AND Passwords=@1",id,password) as string;
			if (role == null) {
				remainTimes -= 1;
				var hint = remainTimes > 0 ? string.Format("You have {0} tries left.", remainTimes) : "You have used up all of your login tries.";
				MessageBox.Show("Cannot verify your identity!\n" + hint);
				ResetCaptcha();
				if (remainTimes == 0) {
					inputId.Clear();
					inputPwd.Clear();
					inputId.Enabled = false;
					inputPwd.Enabled = false;
					inputCap.Enabled = false;
					btnLogin.Enabled = false;
					lblCap.Enabled = false;
					inputRemember.Enabled = false;
				}
				return;
			}

			if (inputRemember.Checked) {
				var obj = new SessionData {
					id = id,
					password = password
				};
				var json = Utils.SerializeToJson(obj);
				File.WriteAllText(sessionFilePath, json);
			}

			ResetCaptcha();

			Form form = null;
			switch (role) {
				case "2":
					form=new CoordinatorMenu(id);
					break;
				case "3":
					form=new AdministratorMenu(id);
					break;
				case "4":
					form=new JudgerMenu(id);
					break;
				default:
					form=new CompetitorMenu(id);
					break;
			}
			LoggingOut = false;
			form.ShowDialog();
			if (Login.LoggingOut) {
				Close();
			}
		}

		public static bool LoggingOut { get; set; } = false;

		Random rand = new Random();
		void ResetCaptcha() {
			inputCap.Clear();
			lblCap.Text = rand.Next(1000, 10000).ToString();
		}

		private void label6_Click(object sender, EventArgs e) {
			ResetCaptcha();
		}
	}
}
