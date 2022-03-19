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
	public partial class CompetitionEvent : Form {
		string id;
		public CompetitionEvent(string id) {
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

			UpdateData();
		}

		private void btnBack_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogout_Click(object sender, EventArgs e) {
			Login.LoggingOut = true;
			Close();
		}

		DataTable table;
		const string sql = "SELECT EventId,CONCAT(EventId,' - ',EventName) as [Event], CONCAT(REPLACE(StartDate,'-','.'),'-',REPLACE(EndDate,'-','.')) as Duration,ProvinceName as Province FROM [Event],Province WHERE [Event].HeldProvince=Province.ProvinceCode";
		string sql2 = string.Format("SELECT * FROM ({0}) AS t WHERE Event LIKE @0 OR Province LIKE @0", sql);
		void UpdateData(string text=null) {
			if (string.IsNullOrWhiteSpace(text)) {
				table = Utils.ExecuteQuery(sql);
			} else {
				text = text.Trim();
				var arg = "%" + text + "%";
				table = Utils.ExecuteQuery(sql2, arg);
			}
			dataGridView1.DataSource = table;
			lblTotal.Text = "Total Events: " + table.Rows.Count;
		}
		private void btnSearch_Click(object sender, EventArgs e) {
			UpdateData(inputSearch.Text);
		}

		private void button3_Click(object sender, EventArgs e) {
			if (dataGridView1.SelectedCells.Count <= 0) {
				return;
			}
			var row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem as DataRowView;
			var eventId = row.Row["EventId"];

			var form = new ViewRegisteration(id, eventId);
			form.ShowDialog();
			if (Login.LoggingOut) {
				Close();
			}
		}
	}
}
