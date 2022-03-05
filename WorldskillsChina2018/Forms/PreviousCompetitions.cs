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
using System.Xml;

namespace WorldskillsChina2018 {
	public partial class PreviousCompetitions : Form {
		public PreviousCompetitions() {
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

			DataSet ds = new DataSet();
			var fs = File.OpenRead(Utils.ResourcePath + "PreviousCompetitions/Data.xml");
			XmlTextReader reader = new XmlTextReader(fs);
			ds.ReadXml(reader);
			var t = ds.Tables["Competition"];
			table.Columns.Add(new DataColumn("Ordinal No.", typeof(string)));
			table.Columns.Add(new DataColumn("Year", typeof(string)));
			table.Columns.Add(new DataColumn("City, Country", typeof(string)));
			table.Columns.Add(new DataColumn("Member Number", typeof(string)));
			foreach (DataRow row in t.Rows) {
				string mem = row.Field<string>("MemberNumber");
				string cc = row.Field<string>("City") + ", " + row.Field<string>("Country");
				string year = row.Field<string>("Year");
				string num = row.Field<string>("Number");
				char digit = num[num.Length - 1];
				string ord = "th";
				switch (digit) {
					case '1':
						ord = "st";
						break;
					case '2':
						ord = "nd";
						break;
					case '3':
						ord = "rd";
						break;
				}
				string ordinal = string.Format("{0}{1}", num, ord);
				table.Rows.Add(ordinal, year, cc, mem);
			}
			Search(null, null);
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}
		DataTable table = new DataTable();
		void Search(string no, string loc) {
			DataView view;
			if (no == null && loc == null) {
				view = table.DefaultView;
			} else {
				var q = from t in table.AsEnumerable()
						where (no == null || t.Field<string>("Ordinal No.").IndexOf(no, StringComparison.OrdinalIgnoreCase) >= 0)
						where (loc == null || t.Field<string>("City, Country").IndexOf(loc, StringComparison.OrdinalIgnoreCase) >= 0)
						select t;
				view = q.AsDataView();
			}
			dataView.DataSource = view;
			lblTotal.Text = String.Format("Total Records: {0}", view.Count);
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			Search(
				string.IsNullOrWhiteSpace(inputNo.Text) ? null : inputNo.Text,
				string.IsNullOrWhiteSpace(inputLoc.Text) ? null : inputLoc.Text
			);
		}
	}
}
