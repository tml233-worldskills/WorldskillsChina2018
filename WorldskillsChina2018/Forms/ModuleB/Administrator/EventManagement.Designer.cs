namespace WorldskillsChina2018 {
	partial class EventManagement {
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
			this.btn1 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.label2.Location = new System.Drawing.Point(0, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(769, 38);
			this.label2.TabIndex = 7;
			this.label2.Text = "Event Management";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(247, 305);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(275, 67);
			this.btn1.TabIndex = 14;
			this.btn1.Text = "Competition Skills";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(247, 214);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(275, 67);
			this.btn0.TabIndex = 13;
			this.btn0.Text = "Competition Event";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			// 
			// EventManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 521);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EventManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrator Menu";
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
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn0;
	}
}