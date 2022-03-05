namespace WorldskillsChina2018 {
	partial class MainScreen {
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
			this.lblDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
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
			this.toolStripStatusTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lblDate);
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(769, 181);
			this.panel1.TabIndex = 1;
			// 
			// lblDate
			// 
			this.lblDate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblDate.ForeColor = System.Drawing.Color.Silver;
			this.lblDate.Location = new System.Drawing.Point(223, 111);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(399, 50);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "Shang Hai, China\r\nSaturday March 24 2018";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(220, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(407, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "Skills Cometition\r\nManagement System 2018";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn0.Location = new System.Drawing.Point(262, 204);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(280, 75);
			this.btn0.TabIndex = 2;
			this.btn0.Text = "About Worldskills";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn1.Location = new System.Drawing.Point(262, 295);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(280, 75);
			this.btn1.TabIndex = 3;
			this.btn1.Text = "About Worldskills China";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn2.Location = new System.Drawing.Point(262, 386);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(280, 75);
			this.btn2.TabIndex = 4;
			this.btn2.Text = "About Shang Hai";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnLogin.Location = new System.Drawing.Point(616, 438);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(141, 39);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WorldskillsChina2018.Properties.Resources.logo_color_bg_white;
			this.pictureBox1.Location = new System.Drawing.Point(55, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 119);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 521);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainScreen";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
		private System.Windows.Forms.Timer timerBottom;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}