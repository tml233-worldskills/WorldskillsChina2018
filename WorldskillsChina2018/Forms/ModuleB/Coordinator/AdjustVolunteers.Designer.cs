namespace WorldskillsChina2018 {
	partial class AdjustVolunteers {
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblL = new System.Windows.Forms.Label();
			this.dataL = new System.Windows.Forms.DataGridView();
			this.btnL = new System.Windows.Forms.Button();
			this.comboL = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnLR = new System.Windows.Forms.Button();
			this.btnRL = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataR = new System.Windows.Forms.DataGridView();
			this.lblR = new System.Windows.Forms.Label();
			this.btnR = new System.Windows.Forms.Button();
			this.comboR = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.colLCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colRId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataL)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataR)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 486);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(956, 35);
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
			this.toolStripStatusTime.Size = new System.Drawing.Size(941, 30);
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
			this.panel1.Size = new System.Drawing.Size(956, 66);
			this.panel1.TabIndex = 1;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnLogout.ForeColor = System.Drawing.Color.Black;
			this.btnLogout.Location = new System.Drawing.Point(845, 9);
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
			this.label1.Location = new System.Drawing.Point(274, 17);
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
			this.label2.Size = new System.Drawing.Size(956, 38);
			this.label2.TabIndex = 7;
			this.label2.Text = "Adjust Volunteers Between Skills";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 14F);
			this.label3.Location = new System.Drawing.Point(15, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(364, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "No less than the average volunteers number";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblL);
			this.panel2.Controls.Add(this.dataL);
			this.panel2.Controls.Add(this.btnL);
			this.panel2.Controls.Add(this.comboL);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(12, 141);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(430, 298);
			this.panel2.TabIndex = 9;
			// 
			// lblL
			// 
			this.lblL.Font = new System.Drawing.Font("Calibri", 14F);
			this.lblL.Location = new System.Drawing.Point(6, 270);
			this.lblL.Name = "lblL";
			this.lblL.Size = new System.Drawing.Size(364, 23);
			this.lblL.TabIndex = 12;
			this.lblL.Text = "Total Volunteers: 0";
			// 
			// dataL
			// 
			this.dataL.AllowUserToAddRows = false;
			this.dataL.AllowUserToDeleteRows = false;
			this.dataL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLCheckbox,
            this.colLId,
            this.colLName,
            this.colLGender,
            this.colLAge,
            this.colLOccupation});
			this.dataL.Location = new System.Drawing.Point(4, 69);
			this.dataL.Name = "dataL";
			this.dataL.ReadOnly = true;
			this.dataL.RowTemplate.Height = 23;
			this.dataL.Size = new System.Drawing.Size(423, 198);
			this.dataL.TabIndex = 15;
			this.dataL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataL_CellContentClick);
			// 
			// btnL
			// 
			this.btnL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnL.Location = new System.Drawing.Point(352, 30);
			this.btnL.Name = "btnL";
			this.btnL.Size = new System.Drawing.Size(75, 35);
			this.btnL.TabIndex = 14;
			this.btnL.Text = "Search";
			this.btnL.UseVisualStyleBackColor = true;
			this.btnL.Click += new System.EventHandler(this.btnL_Click);
			// 
			// comboL
			// 
			this.comboL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboL.Font = new System.Drawing.Font("Calibri", 14F);
			this.comboL.FormattingEnabled = true;
			this.comboL.Location = new System.Drawing.Point(7, 32);
			this.comboL.Name = "comboL";
			this.comboL.Size = new System.Drawing.Size(339, 31);
			this.comboL.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 14F);
			this.label4.Location = new System.Drawing.Point(6, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(421, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Skills";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnLR
			// 
			this.btnLR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLR.Location = new System.Drawing.Point(448, 236);
			this.btnLR.Name = "btnLR";
			this.btnLR.Size = new System.Drawing.Size(60, 44);
			this.btnLR.TabIndex = 10;
			this.btnLR.Text = ">";
			this.btnLR.UseVisualStyleBackColor = true;
			this.btnLR.Click += new System.EventHandler(this.btnLR_Click);
			// 
			// btnRL
			// 
			this.btnRL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRL.Location = new System.Drawing.Point(448, 300);
			this.btnRL.Name = "btnRL";
			this.btnRL.Size = new System.Drawing.Size(60, 44);
			this.btnRL.TabIndex = 11;
			this.btnRL.Text = "<";
			this.btnRL.UseVisualStyleBackColor = true;
			this.btnRL.Click += new System.EventHandler(this.btnRL_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataR);
			this.panel3.Controls.Add(this.lblR);
			this.panel3.Controls.Add(this.btnR);
			this.panel3.Controls.Add(this.comboR);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Location = new System.Drawing.Point(514, 141);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(430, 298);
			this.panel3.TabIndex = 17;
			// 
			// dataR
			// 
			this.dataR.AllowUserToAddRows = false;
			this.dataR.AllowUserToDeleteRows = false;
			this.dataR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRCheckbox,
            this.colRId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataR.Location = new System.Drawing.Point(4, 69);
			this.dataR.Name = "dataR";
			this.dataR.ReadOnly = true;
			this.dataR.RowTemplate.Height = 23;
			this.dataR.Size = new System.Drawing.Size(423, 198);
			this.dataR.TabIndex = 16;
			this.dataR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataR_CellContentClick);
			// 
			// lblR
			// 
			this.lblR.Font = new System.Drawing.Font("Calibri", 14F);
			this.lblR.Location = new System.Drawing.Point(6, 270);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(364, 23);
			this.lblR.TabIndex = 12;
			this.lblR.Text = "Total Volunteers: 0";
			// 
			// btnR
			// 
			this.btnR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnR.Location = new System.Drawing.Point(352, 30);
			this.btnR.Name = "btnR";
			this.btnR.Size = new System.Drawing.Size(75, 35);
			this.btnR.TabIndex = 14;
			this.btnR.Text = "Search";
			this.btnR.UseVisualStyleBackColor = true;
			this.btnR.Click += new System.EventHandler(this.btnR_Click);
			// 
			// comboR
			// 
			this.comboR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboR.Font = new System.Drawing.Font("Calibri", 14F);
			this.comboR.FormattingEnabled = true;
			this.comboR.Location = new System.Drawing.Point(7, 32);
			this.comboR.Name = "comboR";
			this.comboR.Size = new System.Drawing.Size(339, 31);
			this.comboR.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 14F);
			this.label7.Location = new System.Drawing.Point(6, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(421, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Skills";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Calibri", 14F);
			this.label8.Location = new System.Drawing.Point(517, 114);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(364, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Less than the average volunteers number";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(798, 445);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(146, 35);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Save Adjustment";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// colLCheckbox
			// 
			this.colLCheckbox.HeaderText = "";
			this.colLCheckbox.Name = "colLCheckbox";
			this.colLCheckbox.ReadOnly = true;
			// 
			// colLId
			// 
			this.colLId.DataPropertyName = "IdNumber";
			this.colLId.HeaderText = "IdNumber";
			this.colLId.Name = "colLId";
			this.colLId.ReadOnly = true;
			this.colLId.Visible = false;
			// 
			// colLName
			// 
			this.colLName.DataPropertyName = "Name";
			this.colLName.HeaderText = "Name";
			this.colLName.Name = "colLName";
			this.colLName.ReadOnly = true;
			// 
			// colLGender
			// 
			this.colLGender.DataPropertyName = "Gender";
			this.colLGender.HeaderText = "Gender";
			this.colLGender.Name = "colLGender";
			this.colLGender.ReadOnly = true;
			// 
			// colLAge
			// 
			this.colLAge.DataPropertyName = "Age";
			this.colLAge.HeaderText = "Age";
			this.colLAge.Name = "colLAge";
			this.colLAge.ReadOnly = true;
			// 
			// colLOccupation
			// 
			this.colLOccupation.DataPropertyName = "Occupation";
			this.colLOccupation.HeaderText = "Occupation";
			this.colLOccupation.Name = "colLOccupation";
			this.colLOccupation.ReadOnly = true;
			// 
			// colRCheckbox
			// 
			this.colRCheckbox.HeaderText = "";
			this.colRCheckbox.Name = "colRCheckbox";
			this.colRCheckbox.ReadOnly = true;
			// 
			// colRId
			// 
			this.colRId.DataPropertyName = "IdNumber";
			this.colRId.HeaderText = "IdNumber";
			this.colRId.Name = "colRId";
			this.colRId.ReadOnly = true;
			this.colRId.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Gender";
			this.dataGridViewTextBoxColumn3.HeaderText = "Gender";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
			this.dataGridViewTextBoxColumn4.HeaderText = "Age";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Occupation";
			this.dataGridViewTextBoxColumn5.HeaderText = "Occupation";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// AdjustVolunteers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 521);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnRL);
			this.Controls.Add(this.btnLR);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AdjustVolunteers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdjustVolunteers";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataL)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataR)).EndInit();
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblL;
		private System.Windows.Forms.DataGridView dataL;
		private System.Windows.Forms.Button btnL;
		private System.Windows.Forms.ComboBox comboL;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLR;
		private System.Windows.Forms.Button btnRL;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblR;
		private System.Windows.Forms.Button btnR;
		private System.Windows.Forms.ComboBox comboR;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataR;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colLCheckbox;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLGender;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLOccupation;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colRCheckbox;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}