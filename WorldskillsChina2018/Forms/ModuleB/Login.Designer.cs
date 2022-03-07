namespace WorldskillsChina2018 {
	partial class Login {
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblCap = new System.Windows.Forms.Label();
			this.inputCap = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.inputRemember = new System.Windows.Forms.CheckBox();
			this.lblName = new System.Windows.Forms.Label();
			this.inputPwd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.inputId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
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
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(769, 66);
			this.panel1.TabIndex = 1;
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
			this.label1.Font = new System.Drawing.Font("Calibri", 20F);
			this.label1.Location = new System.Drawing.Point(200, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(389, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Worldskills China Cometition 2018";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Calibri", 20F);
			this.label2.Location = new System.Drawing.Point(0, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(769, 38);
			this.label2.TabIndex = 7;
			this.label2.Text = "Login";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblCap);
			this.panel2.Controls.Add(this.inputCap);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.inputRemember);
			this.panel2.Controls.Add(this.lblName);
			this.panel2.Controls.Add(this.inputPwd);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.inputId);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(150, 174);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(472, 252);
			this.panel2.TabIndex = 8;
			// 
			// lblCap
			// 
			this.lblCap.BackColor = System.Drawing.Color.Black;
			this.lblCap.Font = new System.Drawing.Font("华文新魏", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblCap.ForeColor = System.Drawing.Color.White;
			this.lblCap.Location = new System.Drawing.Point(328, 103);
			this.lblCap.Name = "lblCap";
			this.lblCap.Size = new System.Drawing.Size(129, 44);
			this.lblCap.TabIndex = 10;
			this.lblCap.Text = "1919";
			this.lblCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCap.Click += new System.EventHandler(this.label6_Click);
			// 
			// inputCap
			// 
			this.inputCap.Font = new System.Drawing.Font("Calibri", 12F);
			this.inputCap.Location = new System.Drawing.Point(133, 112);
			this.inputCap.Name = "inputCap";
			this.inputCap.Size = new System.Drawing.Size(189, 27);
			this.inputCap.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 12F);
			this.label5.Location = new System.Drawing.Point(27, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Captcha:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Calibri", 12F);
			this.button2.Location = new System.Drawing.Point(256, 187);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 49);
			this.button2.TabIndex = 7;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnLogin.Location = new System.Drawing.Point(133, 187);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(101, 49);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// inputRemember
			// 
			this.inputRemember.AutoSize = true;
			this.inputRemember.Checked = true;
			this.inputRemember.CheckState = System.Windows.Forms.CheckState.Checked;
			this.inputRemember.Font = new System.Drawing.Font("Calibri", 12F);
			this.inputRemember.Location = new System.Drawing.Point(133, 153);
			this.inputRemember.Name = "inputRemember";
			this.inputRemember.Size = new System.Drawing.Size(122, 23);
			this.inputRemember.TabIndex = 5;
			this.inputRemember.Text = "Remember me";
			this.inputRemember.UseVisualStyleBackColor = true;
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Calibri", 12F);
			this.lblName.Location = new System.Drawing.Point(328, 22);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(129, 70);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Mr. Shabi";
			// 
			// inputPwd
			// 
			this.inputPwd.Font = new System.Drawing.Font("Calibri", 12F);
			this.inputPwd.Location = new System.Drawing.Point(133, 67);
			this.inputPwd.Name = "inputPwd";
			this.inputPwd.PasswordChar = '*';
			this.inputPwd.Size = new System.Drawing.Size(189, 27);
			this.inputPwd.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 12F);
			this.label4.Location = new System.Drawing.Point(27, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Password:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// inputId
			// 
			this.inputId.Font = new System.Drawing.Font("Calibri", 12F);
			this.inputId.Location = new System.Drawing.Point(133, 20);
			this.inputId.Name = "inputId";
			this.inputId.Size = new System.Drawing.Size(189, 27);
			this.inputId.TabIndex = 1;
			this.inputId.TextChanged += new System.EventHandler(this.inputId_TextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 12F);
			this.label3.Location = new System.Drawing.Point(27, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Idnumber:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 521);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox inputRemember;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox inputPwd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox inputId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCap;
		private System.Windows.Forms.TextBox inputCap;
		private System.Windows.Forms.Label label5;
	}
}