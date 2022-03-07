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
	public partial class CompetitionSkills : Form {
		public CompetitionSkills() {
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
		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		Dictionary<string, TreeNode> fieldNodes = new Dictionary<string, TreeNode>();

		string Path => Utils.ResourcePath + "Skills/";
		private void MainScreen_Load(object sender, EventArgs e) {
			DoTime(toolStripStatusTime);
			var rootNode=treeView1.Nodes.Add("All Fields");
			rootNode.Tag = "All Fields.txt";
			{
				var lines = File.ReadAllLines(Path + "All Fields.txt");
				foreach(var line in lines) {
					var text = line.Trim();
					var node=rootNode.Nodes.Add(text);
					node.Tag = text + ".txt";
					fieldNodes.Add(text, node);
				}
			}
			{
				var lines = File.ReadAllLines(Path + "Skills.csv");
				for (int i = 1; i < lines.Length; i += 1) {
					string[] split = lines[i].Split(',');
					var id = split[0];
					var name = split[1];
					var field = split[2];
					var file = split[3];
					var node = fieldNodes[field].Nodes.Add(string.Format("{0}: {1}", id, name));
					node.Tag = file;
				}
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
			var path = Path + (e.Node.Tag as string);
			if (!File.Exists(path)) {
				return;
			}
			var text = File.ReadAllText(path);
			textBox1.Text = text;
		}
	}
}
