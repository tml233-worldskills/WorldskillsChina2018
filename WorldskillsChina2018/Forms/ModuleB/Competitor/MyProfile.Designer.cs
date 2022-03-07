namespace WorldskillsChina2018 {
	partial class MyProfile {
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
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblProvince = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.lblBirth = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.inputRepwd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.inputPwd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.inputModify = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.picAvatar = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
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
			this.label2.Text = "My Profile";
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
			this.panel2.Controls.Add(this.lblEmail);
			this.panel2.Controls.Add(this.lblPhone);
			this.panel2.Controls.Add(this.lblProvince);
			this.panel2.Controls.Add(this.lblId);
			this.panel2.Controls.Add(this.lblBirth);
			this.panel2.Controls.Add(this.lblGender);
			this.panel2.Controls.Add(this.lblName);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.inputModify);
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.picAvatar);
			this.panel2.Location = new System.Drawing.Point(12, 110);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(745, 358);
			this.panel2.TabIndex = 9;
			// 
			// lblEmail
			// 
			this.lblEmail.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
			this.lblEmail.Location = new System.Drawing.Point(144, 267);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(266, 30);
			this.lblEmail.TabIndex = 30;
			this.lblEmail.Text = "Email";
			// 
			// lblPhone
			// 
			this.lblPhone.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.ForeColor = System.Drawing.Color.DimGray;
			this.lblPhone.Location = new System.Drawing.Point(144, 232);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(266, 30);
			this.lblPhone.TabIndex = 29;
			this.lblPhone.Text = "Phone";
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
			// lblBirth
			// 
			this.lblBirth.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBirth.ForeColor = System.Drawing.Color.DimGray;
			this.lblBirth.Location = new System.Drawing.Point(144, 127);
			this.lblBirth.Name = "lblBirth";
			this.lblBirth.Size = new System.Drawing.Size(266, 30);
			this.lblBirth.TabIndex = 26;
			this.lblBirth.Text = "Date Of Birth";
			// 
			// lblGender
			// 
			this.lblGender.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGender.ForeColor = System.Drawing.Color.DimGray;
			this.lblGender.Location = new System.Drawing.Point(144, 92);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(266, 30);
			this.lblGender.TabIndex = 25;
			this.lblGender.Text = "Gender";
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.DimGray;
			this.lblName.Location = new System.Drawing.Point(144, 57);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(266, 30);
			this.lblName.TabIndex = 24;
			this.lblName.Text = "Name";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(135, 30);
			this.label10.TabIndex = 23;
			this.label10.Text = "Email:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(3, 232);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(135, 30);
			this.label11.TabIndex = 22;
			this.label11.Text = "Phone:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 127);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(135, 30);
			this.label9.TabIndex = 19;
			this.label9.Text = "Date Of Birth:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 30);
			this.label7.TabIndex = 18;
			this.label7.Text = "Gender:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 30);
			this.label6.TabIndex = 17;
			this.label6.Text = "Name:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.inputRepwd);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.inputPwd);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Location = new System.Drawing.Point(455, 239);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(285, 71);
			this.panel3.TabIndex = 16;
			// 
			// inputRepwd
			// 
			this.inputRepwd.Enabled = false;
			this.inputRepwd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputRepwd.Location = new System.Drawing.Point(110, 36);
			this.inputRepwd.Name = "inputRepwd";
			this.inputRepwd.PasswordChar = '*';
			this.inputRepwd.Size = new System.Drawing.Size(170, 27);
			this.inputRepwd.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 25);
			this.label5.TabIndex = 2;
			this.label5.Text = "RePassword:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputPwd
			// 
			this.inputPwd.Enabled = false;
			this.inputPwd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputPwd.Location = new System.Drawing.Point(110, 3);
			this.inputPwd.Name = "inputPwd";
			this.inputPwd.PasswordChar = '*';
			this.inputPwd.Size = new System.Drawing.Size(170, 27);
			this.inputPwd.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Password:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputModify
			// 
			this.inputModify.AutoSize = true;
			this.inputModify.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputModify.Location = new System.Drawing.Point(455, 210);
			this.inputModify.Name = "inputModify";
			this.inputModify.Size = new System.Drawing.Size(139, 23);
			this.inputModify.TabIndex = 15;
			this.inputModify.Text = "Modify Password";
			this.inputModify.UseVisualStyleBackColor = true;
			this.inputModify.CheckedChanged += new System.EventHandler(this.inputModify_CheckedChanged);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(650, 316);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 37);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(554, 316);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(90, 37);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// picAvatar
			// 
			this.picAvatar.Image = global::WorldskillsChina2018.Properties.Resources.NoPicture;
			this.picAvatar.Location = new System.Drawing.Point(455, 9);
			this.picAvatar.Name = "picAvatar";
			this.picAvatar.Size = new System.Drawing.Size(285, 195);
			this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAvatar.TabIndex = 0;
			this.picAvatar.TabStop = false;
			// 
			// MyProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 521);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MyProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Profile";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
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
		private System.Windows.Forms.PictureBox picAvatar;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox inputRepwd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox inputPwd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox inputModify;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblProvince;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblBirth;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
	}
}