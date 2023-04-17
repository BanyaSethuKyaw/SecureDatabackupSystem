namespace Secure_Backup_System
{
	partial class Upload
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.btn_setting = new System.Windows.Forms.Button();
			this.btn_logout = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btn_backup = new System.Windows.Forms.Button();
			this.btn_download = new System.Windows.Forms.Button();
			this.btn_upload = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.btn_setting);
			this.panel5.Controls.Add(this.btn_logout);
			this.panel5.Controls.Add(this.panel4);
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(496, 314);
			this.panel5.TabIndex = 17;
			// 
			// btn_setting
			// 
			this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_setting.ForeColor = System.Drawing.Color.Transparent;
			this.btn_setting.Location = new System.Drawing.Point(89, 273);
			this.btn_setting.Name = "btn_setting";
			this.btn_setting.Size = new System.Drawing.Size(78, 27);
			this.btn_setting.TabIndex = 35;
			this.btn_setting.Text = "Setting";
			this.btn_setting.UseVisualStyleBackColor = false;
			this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
			// 
			// btn_logout
			// 
			this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
			this.btn_logout.Location = new System.Drawing.Point(18, 273);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(65, 27);
			this.btn_logout.TabIndex = 14;
			this.btn_logout.Text = "Back";
			this.btn_logout.UseVisualStyleBackColor = false;
			this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Controls.Add(this.btn_backup);
			this.panel4.Controls.Add(this.btn_download);
			this.panel4.Controls.Add(this.btn_upload);
			this.panel4.Location = new System.Drawing.Point(368, 9);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(110, 259);
			this.panel4.TabIndex = 15;
			// 
			// btn_backup
			// 
			this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_backup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_backup.ForeColor = System.Drawing.Color.Transparent;
			this.btn_backup.Location = new System.Drawing.Point(21, 212);
			this.btn_backup.Name = "btn_backup";
			this.btn_backup.Size = new System.Drawing.Size(65, 27);
			this.btn_backup.TabIndex = 18;
			this.btn_backup.Text = "Backup";
			this.btn_backup.UseVisualStyleBackColor = false;
			this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
			// 
			// btn_download
			// 
			this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_download.ForeColor = System.Drawing.Color.Transparent;
			this.btn_download.Location = new System.Drawing.Point(21, 152);
			this.btn_download.Name = "btn_download";
			this.btn_download.Size = new System.Drawing.Size(65, 27);
			this.btn_download.TabIndex = 17;
			this.btn_download.Text = "Download";
			this.btn_download.UseVisualStyleBackColor = false;
			this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
			// 
			// btn_upload
			// 
			this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_upload.ForeColor = System.Drawing.Color.Transparent;
			this.btn_upload.Location = new System.Drawing.Point(21, 119);
			this.btn_upload.Name = "btn_upload";
			this.btn_upload.Size = new System.Drawing.Size(65, 27);
			this.btn_upload.TabIndex = 16;
			this.btn_upload.Text = "Browse";
			this.btn_upload.UseVisualStyleBackColor = false;
			this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Location = new System.Drawing.Point(16, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(343, 261);
			this.panel2.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(339, 257);
			this.dataGridView1.StandardTab = true;
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.VirtualMode = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::Secure_Backup_System.Properties.Resources.zyx2d79sjv761;
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 110);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// Upload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 314);
			this.Controls.Add(this.panel5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Upload";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Upload";
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn_backup;
		private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btn_download;
		private System.Windows.Forms.Button btn_upload;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_setting;
	}
}