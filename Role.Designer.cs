namespace Secure_Backup_System
{
	partial class Role
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.btn_member = new System.Windows.Forms.Button();
			this.btn_admin = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.btn_member);
			this.panel1.Controls.Add(this.btn_admin);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(393, 186);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::Secure_Backup_System.Properties.Resources.go_back_icon_10;
			this.pictureBox5.Location = new System.Drawing.Point(342, 3);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(43, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 66;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.closebtn);
			// 
			// btn_member
			// 
			this.btn_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_member.ForeColor = System.Drawing.Color.Transparent;
			this.btn_member.Location = new System.Drawing.Point(240, 134);
			this.btn_member.Name = "btn_member";
			this.btn_member.Size = new System.Drawing.Size(78, 27);
			this.btn_member.TabIndex = 32;
			this.btn_member.Text = "Member";
			this.btn_member.UseVisualStyleBackColor = false;
			this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
			// 
			// btn_admin
			// 
			this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_admin.ForeColor = System.Drawing.Color.Transparent;
			this.btn_admin.Location = new System.Drawing.Point(61, 133);
			this.btn_admin.Name = "btn_admin";
			this.btn_admin.Size = new System.Drawing.Size(78, 27);
			this.btn_admin.TabIndex = 31;
			this.btn_admin.Text = "Admin";
			this.btn_admin.UseVisualStyleBackColor = false;
			this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = global::Secure_Backup_System.Properties.Resources._45373_grey_button_clipart;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Location = new System.Drawing.Point(217, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(119, 102);
			this.panel2.TabIndex = 30;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Secure_Backup_System.Properties.Resources.Staff;
			this.pictureBox2.Location = new System.Drawing.Point(11, 17);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(99, 74);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BackgroundImage = global::Secure_Backup_System.Properties.Resources._45373_grey_button_clipart;
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Location = new System.Drawing.Point(40, 25);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(119, 102);
			this.panel3.TabIndex = 29;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Secure_Backup_System.Properties.Resources.Admin;
			this.pictureBox1.Location = new System.Drawing.Point(11, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(99, 74);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Role
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 186);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Role";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Role";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_member;
		private System.Windows.Forms.Button btn_admin;
		private System.Windows.Forms.PictureBox pictureBox5;
	}
}