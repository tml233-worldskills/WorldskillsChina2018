namespace WorldskillsChina2018 {
	partial class VolunteerManagement {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.timerBottom = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboSkill = new System.Windows.Forms.ComboBox();
			this.comboSort = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnAdjust = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblPage = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.inputPage = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 486);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(769, 35);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusTime
			// 
			this.toolStripStatusTime.AutoSize = false;
			this.toolStripStatusTime.Font = new System.Drawing.Font("Calibri", 12F);
			this.toolStripStatusTime.ForeColor = System.Drawing.Color.White;
			this.toolStripStatusTime.Name = "toolStripStatusTime";
			this.toolStripStatusTime.Size = new System.Drawing.Size(754, 30);
			this.toolStripStatusTime.Spring = true;
			this.toolStripStatusTime.Text = "toolStripStatusLabel1";
			// 
			// timerBottom
			// 
			this.timerBottom.Enabled = true;
			this.timerBottom.Interval = 1000;
			this.timerBottom.Tick += new System.EventHandler(this.timerBottom_Tick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(769, 66);
			this.panel1.TabIndex = 1;
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnLogout.ForeColor = System.Drawing.Color.Black;
			this.btnLogout.Location = new System.Drawing.Point(658, 9);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(99, 47);
			this.btnLogout.TabIndex = 7;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WorldskillsChina2018.Properties.Resources.logo_color_bg_white;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(79, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnBack.ForeColor = System.Drawing.Color.Black;
			this.btnBack.Location = new System.Drawing.Point(95, 9);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(89, 47);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(200, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(402, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Worldskills China Cometition 2018";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Calibri", 20F);
			this.label2.Location = new System.Drawing.Point(0, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(769, 38);
			this.label2.TabIndex = 7;
			this.label2.Text = "Volunteer Management";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 14F);
			this.label3.Location = new System.Drawing.Point(9, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Skills of Service:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// comboSkill
			// 
			this.comboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSkill.Font = new System.Drawing.Font("Calibri", 12F);
			this.comboSkill.FormattingEnabled = true;
			this.comboSkill.Location = new System.Drawing.Point(147, 110);
			this.comboSkill.Name = "comboSkill";
			this.comboSkill.Size = new System.Drawing.Size(357, 27);
			this.comboSkill.TabIndex = 9;
			// 
			// comboSort
			// 
			this.comboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSort.Font = new System.Drawing.Font("Calibri", 12F);
			this.comboSort.FormattingEnabled = true;
			this.comboSort.Items.AddRange(new object[] {
            "IdNumber",
            "Name",
            "Gender",
            "Occupation",
            "Province",
            "Skills of Service"});
			this.comboSort.Location = new System.Drawing.Point(147, 143);
			this.comboSort.Name = "comboSort";
			this.comboSort.Size = new System.Drawing.Size(159, 27);
			this.comboSort.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 14F);
			this.label4.Location = new System.Drawing.Point(9, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Sort by:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(147, 176);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(84, 36);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnImport
			// 
			this.btnImport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImport.Location = new System.Drawing.Point(510, 103);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(247, 36);
			this.btnImport.TabIndex = 13;
			this.btnImport.Text = "Import Volunteers";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnAdjust
			// 
			this.btnAdjust.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdjust.Location = new System.Drawing.Point(510, 141);
			this.btnAdjust.Name = "btnAdjust";
			this.btnAdjust.Size = new System.Drawing.Size(247, 36);
			this.btnAdjust.TabIndex = 14;
			this.btnAdjust.Text = "Adjust Volunteers Between Skills";
			this.btnAdjust.UseVisualStyleBackColor = true;
			this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 241);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(744, 200);
			this.dataGridView1.TabIndex = 15;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Calibri", 14F);
			this.lblTotal.Location = new System.Drawing.Point(12, 215);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(745, 23);
			this.lblTotal.TabIndex = 16;
			this.lblTotal.Text = "Total Volunteers: 0";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblPage
			// 
			this.lblPage.Font = new System.Drawing.Font("Calibri", 14F);
			this.lblPage.Location = new System.Drawing.Point(12, 447);
			this.lblPage.Name = "lblPage";
			this.lblPage.Size = new System.Drawing.Size(86, 32);
			this.lblPage.TabIndex = 17;
			this.lblPage.Text = "99 / 99";
			this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(99, 447);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 32);
			this.button1.TabIndex = 18;
			this.button1.Text = "First";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(189, 447);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 19;
			this.button2.Text = "Previous";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(279, 447);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(84, 32);
			this.button3.TabIndex = 20;
			this.button3.Text = "Next";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(369, 447);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 21;
			this.button4.Text = "Last";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 14F);
			this.label7.Location = new System.Drawing.Point(459, 452);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Go to Page:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputPage
			// 
			this.inputPage.Font = new System.Drawing.Font("Calibri", 14F);
			this.inputPage.Location = new System.Drawing.Point(580, 448);
			this.inputPage.Name = "inputPage";
			this.inputPage.Size = new System.Drawing.Size(87, 30);
			this.inputPage.TabIndex = 23;
			this.inputPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(673, 448);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(84, 32);
			this.button5.TabIndex = 24;
			this.button5.Text = "Go";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// VolunteerManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 521);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.inputPage);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblPage);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnAdjust);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.comboSort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboSkill);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lblTotal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "VolunteerManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Profile";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
		private System.Windows.Forms.Timer timerBottom;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboSkill;
		private System.Windows.Forms.ComboBox comboSort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnAdjust;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblPage;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox inputPage;
		private System.Windows.Forms.Button button5;
	}
}