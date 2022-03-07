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
	public partial class AboutWorldskillsChina : Form {
		public AboutWorldskillsChina() {
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

		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);

			downloadLabels[0] = lbl0;
			downloadLabels[1] = lbl1;
			downloadLabels[2] = lbl2;
			downloadPanels[0] = pnl0;
			downloadPanels[1] = pnl1;
			downloadPanels[2] = pnl2;

			btn0_Click_1(null, null);
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		Panel[] downloadPanels = {
			null,null,null
		};
		Label[] downloadLabels = {
			null,null,null
		};
		bool[] downloadShow = {
			false,false,false
		};
		string[] downloadFiles = {
			string.Empty,
			string.Empty,
			string.Empty
		};
		void UpdateDownloadPanels() {
			for (int i = 0; i < downloadPanels.Length; i += 1) {
				downloadPanels[i].Enabled = downloadShow[i];
				downloadPanels[i].Visible = downloadShow[i];
				downloadLabels[i].Text = string.Format("{0}. {1}", i+1, downloadFiles[i]);
			}
		}
		private void download0_Click(object sender, EventArgs e) {
			DownloadFile(0);
		}
		void DownloadFile(int index) {
			var currentDownloadFile= downloadFiles[index];
			saveFileDialog.FileName = currentDownloadFile;
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				File.Copy(Utils.ResourcePath + "AboutWorldskillsChina/" + currentDownloadFile, saveFileDialog.FileName,true);
				MessageBox.Show(String.Format("File has been downloaded to: {0}", saveFileDialog.FileName));
			}
		}

		private void download1_Click(object sender, EventArgs e) {
			DownloadFile(1);
		}

		private void download2_Click(object sender, EventArgs e) {
			DownloadFile(2);
		}

		private void btn0_Click_1(object sender, EventArgs e) {
			downloadShow[0] = true;
			downloadShow[1] = false;
			downloadShow[2] = false;
			downloadFiles[0] = "China in the Worldskills.pdf";
			UpdateDownloadPanels();
		}

		private void btn1_Click_1(object sender, EventArgs e) {
			downloadShow[0] = true;
			downloadShow[1] = false;
			downloadShow[2] = false;
			downloadFiles[0] = "Committee of Worldskills China.pdf";
			UpdateDownloadPanels();
		}

		private void btn2_Click_1(object sender, EventArgs e) {
			downloadShow[0] = true;
			downloadShow[1] = true;
			downloadShow[2] = true;
			downloadFiles[0] = "the 41st Competition.pdf";
			downloadFiles[1] = "the 42nd Competition.pdf";
			downloadFiles[2] = "the 43rd Competition.pdf";
			UpdateDownloadPanels();
		}
	}
}
