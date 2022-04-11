using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldskillsChina2018 {
	public partial class AboutShanghai : Form {
		public AboutShanghai() {
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


		List<Tuple<DateTime, string>> events = new List<Tuple<DateTime, string>>();
		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);
			var lines = File.ReadAllLines(Utils.ResourcePath + "AboutShanghai/Event.csv");
			for(int i = 1; i < lines.Length; i += 1) {
				var split = lines[i].Split(',');
				events.Add(new Tuple<DateTime, string>(DateTime.Parse(split[0]), split[1]));
			}
			StringBuilder sb = new StringBuilder();
			foreach(var item in events.OrderByDescending(o => o.Item1)) {
				sb.AppendLine(string.Format("{0}-{1:D2}-{2:D2}\t{3}", item.Item1.Year, item.Item1.Month, item.Item1.Day, item.Item2));
			}
			textEvent.Text = sb.ToString();
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void pictureBox2_Click(object sender, EventArgs e) {
			MessageBox.Show("The China Pavilion of China 2010 Shanghai World Expo is one of the most important venues projects in China’s exhibition area on the Expo site. It is a permanently retained pavilion for Shanghai World Expo.");
		}

		private void pictureBox7_Click(object sender, EventArgs e) {
			MessageBox.Show("Shanghai Museum is one of the four famous Chinese museums with Beijing, Nanjing and Xi’an. It collects bronze wares from Baoji—“Home of Bronze Wares”, Henan, Hunan etc. Shanghai Museum gains the honored name “Half of the Whole Territory in Historical Relics World” at home and abroad for its abundant collections and high quality");
		}

		private void pictureBox10_Click(object sender, EventArgs e) {
			MessageBox.Show("The Bund is located at the bank of Huangpu River and is Shanghai city’s most vivid symbol. Its essence lies in the various styles of multinational architectures and night views of Pujiang.");
		}

		private void pictureBox3_Click(object sender, EventArgs e) {
			MessageBox.Show("Shanghai Garden Hotel of the Bund. Hotel rooms in the Hotel are abundant in various styles with nobleness and elegance. ");
		}

		private void pictureBox6_Click(object sender, EventArgs e) {
			MessageBox.Show("Shangri-La Hotel of Shanghai is located in the business center of Shanghai and even the whole country. ");
		}

		private void pictureBox9_Click(object sender, EventArgs e) {
			MessageBox.Show("The Ritz-Carlton Hotel of Shanghai Pudong is the first integrated hotel in Pudong District with luxurious office, accommodation and shopping facilities. ");
		}

		private void pictureBox4_Click(object sender, EventArgs e) {
			MessageBox.Show("“Baojiaobu” is a classical snack in the Shanghai Street. ");
		}

		private void pictureBox5_Click(object sender, EventArgs e) {
			MessageBox.Show("“Noodles in a simple sauce” is a kind of noodles in Su style.");
		}

		private void pictureBox8_Click(object sender, EventArgs e) {
			MessageBox.Show("“Shanghai Steamed buns” is a Shanghai featured snack. ");
		}
	}
}
