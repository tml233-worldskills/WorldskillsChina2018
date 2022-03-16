namespace WorldskillsChina2018 {
	partial class MyResults {
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
			this.lblOrganization = new System.Windows.Forms.Label();
			this.lblProvince = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblNumber = new System.Windows.Forms.Label();
			this.lblSkills = new System.Windows.Forms.Label();
			this.lblEvent = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.lblM1 = new System.Windows.Forms.TextBox();
			this.lblM2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblM3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblMn = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.label2.Text = "My Results";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(39, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(384, 38);
			this.label3.TabIndex = 8;
			this.label3.Text = "Competitor Menu";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblOrganization);
			this.panel2.Controls.Add(this.lblProvince);
			this.panel2.Controls.Add(this.lblId);
			this.panel2.Controls.Add(this.lblGender);
			this.panel2.Controls.Add(this.lblName);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(12, 110);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(374, 358);
			this.panel2.TabIndex = 9;
			// 
			// lblOrganization
			// 
			this.lblOrganization.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrganization.ForeColor = System.Drawing.Color.DimGray;
			this.lblOrganization.Location = new System.Drawing.Point(144, 232);
			this.lblOrganization.Name = "lblOrganization";
			this.lblOrganization.Size = new System.Drawing.Size(225, 89);
			this.lblOrganization.TabIndex = 30;
			this.lblOrganization.Text = "Organization";
			// 
			// lblProvince
			// 
			this.lblProvince.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProvince.ForeColor = System.Drawing.Color.DimGray;
			this.lblProvince.Location = new System.Drawing.Point(144, 197);
			this.lblProvince.Name = "lblProvince";
			this.lblProvince.Size = new System.Drawing.Size(266, 30);
			this.lblProvince.TabIndex = 28;
			this.lblProvince.Text = "Province";
			// 
			// lblId
			// 
			this.lblId.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblId.ForeColor = System.Drawing.Color.DimGray;
			this.lblId.Location = new System.Drawing.Point(144, 162);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(266, 30);
			this.lblId.TabIndex = 27;
			this.lblId.Text = "IdNumber";
			// 
			// lblGender
			// 
			this.lblGender.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.ForeColor = System.Drawing.Color.DimGray;
			this.lblGender.Location = new System.Drawing.Point(144, 127);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(224, 30);
			this.lblGender.TabIndex = 25;
			this.lblGender.Text = "Gender";
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.DimGray;
			this.lblName.Location = new System.Drawing.Point(144, 92);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(224, 30);
			this.lblName.TabIndex = 24;
			this.lblName.Text = "Name";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 232);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(135, 30);
			this.label10.TabIndex = 23;
			this.label10.Text = "Organization:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(3, 197);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(135, 30);
			this.label12.TabIndex = 21;
			this.label12.Text = "Province:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 162);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 30);
			this.label8.TabIndex = 20;
			this.label8.Text = "IdNumber:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 127);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 30);
			this.label7.TabIndex = 18;
			this.label7.Text = "Gender:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 30);
			this.label6.TabIndex = 17;
			this.label6.Text = "Name:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.lblScore);
			this.panel3.Controls.Add(this.lblMn);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.lblM3);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.lblM2);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.lblM1);
			this.panel3.Controls.Add(this.lblNumber);
			this.panel3.Controls.Add(this.lblSkills);
			this.panel3.Controls.Add(this.lblEvent);
			this.panel3.Controls.Add(this.label15);
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.label17);
			this.panel3.Controls.Add(this.label18);
			this.panel3.Location = new System.Drawing.Point(392, 110);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(365, 358);
			this.panel3.TabIndex = 31;
			// 
			// lblNumber
			// 
			this.lblNumber.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber.ForeColor = System.Drawing.Color.DimGray;
			this.lblNumber.Location = new System.Drawing.Point(124, 130);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(236, 30);
			this.lblNumber.TabIndex = 27;
			this.lblNumber.Text = "IdNumber";
			// 
			// lblSkills
			// 
			this.lblSkills.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSkills.ForeColor = System.Drawing.Color.DimGray;
			this.lblSkills.Location = new System.Drawing.Point(124, 85);
			this.lblSkills.Name = "lblSkills";
			this.lblSkills.Size = new System.Drawing.Size(236, 30);
			this.lblSkills.TabIndex = 25;
			this.lblSkills.Text = "Skills";
			// 
			// lblEvent
			// 
			this.lblEvent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEvent.ForeColor = System.Drawing.Color.DimGray;
			this.lblEvent.Location = new System.Drawing.Point(124, 5);
			this.lblEvent.Name = "lblEvent";
			this.lblEvent.Size = new System.Drawing.Size(236, 69);
			this.lblEvent.TabIndex = 24;
			this.lblEvent.Text = "Name\r\nName\r\nName";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(8, 177);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(114, 30);
			this.label15.TabIndex = 21;
			this.label15.Text = "Module 1:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(7, 120);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(114, 47);
			this.label16.TabIndex = 20;
			this.label16.Text = "Competitor\r\nNumber:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(7, 85);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(114, 30);
			this.label17.TabIndex = 18;
			this.label17.Text = "Skills:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(7, 28);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(114, 30);
			this.label18.TabIndex = 17;
			this.label18.Text = "Event:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblM1
			// 
			this.lblM1.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblM1.Location = new System.Drawing.Point(128, 178);
			this.lblM1.Name = "lblM1";
			this.lblM1.ReadOnly = true;
			this.lblM1.Size = new System.Drawing.Size(143, 27);
			this.lblM1.TabIndex = 28;
			// 
			// lblM2
			// 
			this.lblM2.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblM2.Location = new System.Drawing.Point(128, 211);
			this.lblM2.Name = "lblM2";
			this.lblM2.ReadOnly = true;
			this.lblM2.Size = new System.Drawing.Size(143, 27);
			this.lblM2.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 30);
			this.label4.TabIndex = 29;
			this.label4.Text = "Module 2:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblM3
			// 
			this.lblM3.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblM3.Location = new System.Drawing.Point(128, 244);
			this.lblM3.Name = "lblM3";
			this.lblM3.ReadOnly = true;
			this.lblM3.Size = new System.Drawing.Size(143, 27);
			this.lblM3.TabIndex = 32;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 243);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 30);
			this.label5.TabIndex = 31;
			this.label5.Text = "Module 3:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblMn
			// 
			this.lblMn.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblMn.Location = new System.Drawing.Point(128, 277);
			this.lblMn.Name = "lblMn";
			this.lblMn.ReadOnly = true;
			this.lblMn.Size = new System.Drawing.Size(143, 27);
			this.lblMn.TabIndex = 34;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 276);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 30);
			this.label9.TabIndex = 33;
			this.label9.Text = "Module 4:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblScore
			// 
			this.lblScore.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(64, 307);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(207, 49);
			this.lblScore.TabIndex = 36;
			this.lblScore.Text = "100.00";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MyResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 521);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MyResults";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Profile";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
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
		private System.Windows.Forms.Label lblOrganization;
		private System.Windows.Forms.Label lblProvince;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Label lblSkills;
		private System.Windows.Forms.Label lblEvent;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.TextBox lblMn;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox lblM3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox lblM2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox lblM1;
	}
}