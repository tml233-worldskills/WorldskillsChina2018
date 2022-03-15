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
using WorldskillsChina2018.Properties;

namespace WorldskillsChina2018 {
	public partial class MySkills : Form {
		string id;
		public MySkills(string id) {
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
		object skillsId;

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
			
			var name = Utils.ExecuteScalar("SELECT SkillsName FROM Skills WHERE SkillsId=@0", skillsId);

			lblSkill.Text = skillsId + " - " + name;

			var size = new Size(75, 100);
			list0.LargeImageList = new ImageList {
				ImageSize = size
			};
			list1.LargeImageList = new ImageList {
				ImageSize = size
			};

			LoadCompetitors();
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		MemoryStream picStream = new MemoryStream();
		void LoadCompetitors() {
			list0.Clear();
			list0.LargeImageList.Images.Clear();

			var enumer = Utils.ExecuteReader(
				"SELECT Name,Photo,ProvinceName FROM [User],Competition, Competitor, Province WHERE " +
				"Competition.CompetitorId = Competitor.CompetitorId AND " +
				"Competitor.ProvinceCode = Province.ProvinceCode AND " +
				"[User].IdNumber = Competitor.IdNumber AND " +
				"EventId = @0 AND SkillsId = @1",
				eventId, skillsId);

			var index = 0;
			list0.BeginUpdate();
			foreach (var r in enumer) {
				var name = r["Name"] as string;
				var province = r["ProvinceName"] as string;
				var photo = r["Photo"] as byte[];
				Image img;
				if (photo == null) {
					img = Resources.NoPicture;
				} else {
					picStream.SetLength(0);
					picStream.Seek(0, SeekOrigin.Begin);
					picStream.Write(photo, 0, photo.Length);
					img = Image.FromStream(picStream);
				}
				list0.LargeImageList.Images.Add(img);
				var item = new ListViewItem {
					Text = String.Format("{0}\n({1})", name, province),
					ImageIndex = index
				};
				index += 1;
				list0.Items.Add(item);
			}
			list0.EndUpdate();
		}
		void LoadJudgers() {
			list1.Clear();
			list1.LargeImageList.Images.Clear();

			var enumer = Utils.ExecuteReader(
				"SELECT Name,ProvinceName, Photo FROM Judge, Judger, [User], Province " +
				"WHERE Judge.JudgerId = Judger.JudgerId AND " +
				"Judge.SkillsId = @0 AND " +
				"Judge.EventId=@1 AND " +
				"[User].IdNumber = Judger.IdNumber AND " +
				"Province.ProvinceCode = Judger.ProvinceCode",
				skillsId, eventId);

			var index = 0;
			list1.BeginUpdate();
			foreach (var r in enumer) {
				var name = r["Name"] as string;
				var province = r["ProvinceName"] as string;
				var photo = r["Photo"] as byte[];
				Image img;
				if (photo == null) {
					img = Resources.NoPicture;
				} else {
					picStream.SetLength(0);
					picStream.Seek(0, SeekOrigin.Begin);
					picStream.Write(photo, 0, photo.Length);
					img = Image.FromStream(picStream);
				}
				list1.LargeImageList.Images.Add(img);
				var item = new ListViewItem {
					Text = String.Format("{0}\n({1})", name, province),
					ImageIndex = index
				};
				index += 1;
				list1.Items.Add(item);
			}
			list1.EndUpdate();
		}
		void LoadWorkshop() {
			var photo = Utils.ExecuteScalar("SELECT SkillsWorkshopLayout FROM SkillsInEvent WHERE SkillsId=@0 AND EventId=@1", skillsId, eventId) as byte[];
			Image img;
			if (photo == null) {
				img = Resources.NoPicture;
			} else {
				picStream.SetLength(0);
				picStream.Seek(0, SeekOrigin.Begin);
				picStream.Write(photo, 0, photo.Length);
				img = Image.FromStream(picStream);
			}
			pictureBox2.Image = img;
		}
		void LoadInfrastructure() {
			var photo = Utils.ExecuteScalar("SELECT Infrastructure FROM SkillsInEvent WHERE SkillsId=@0 AND EventId=@1", skillsId, eventId) as byte[];
			Image img;
			if (photo == null) {
				img = Resources.NoPicture;
			} else {
				picStream.SetLength(0);
				picStream.Seek(0, SeekOrigin.Begin);
				picStream.Write(photo, 0, photo.Length);
				img = Image.FromStream(picStream);
			}
			pictureBox3.Image = img;
		}
		void LoadSchedule() {
			var text = Utils.ExecuteScalar("SELECT Schedule FROM SkillsInEvent WHERE SkillsId=@0 AND EventId=@1", skillsId, eventId) as string;
			textBox1.Lines = (text ?? string.Empty).Split('\n');
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			switch (tabControl1.SelectedIndex) {
				case 0:
					LoadCompetitors();
					break;
				case 1:
					LoadJudgers();
					break;
				case 2:
					LoadWorkshop();
					break;
				case 3:
					LoadInfrastructure();
					break;
				case 4:
					LoadSchedule();
					break;
			}
		}
	}
}
