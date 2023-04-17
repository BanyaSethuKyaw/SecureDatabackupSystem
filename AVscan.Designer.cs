namespace Secure_Backup_System
{
	partial class AVscan
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbMD5 = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pdfTextBox = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_browse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_logout = new System.Windows.Forms.Button();
			this.btn_upload = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pathtxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.pathtxt);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.tbMD5);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.pdfTextBox);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btn_browse);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_logout);
			this.panel1.Controls.Add(this.btn_upload);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(369, 182);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Location = new System.Drawing.Point(80, 110);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(265, 1);
			this.panel2.TabIndex = 30;
			// 
			// tbMD5
			// 
			this.tbMD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.tbMD5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbMD5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMD5.ForeColor = System.Drawing.SystemColors.Info;
			this.tbMD5.Location = new System.Drawing.Point(80, 93);
			this.tbMD5.Name = "tbMD5";
			this.tbMD5.ReadOnly = true;
			this.tbMD5.Size = new System.Drawing.Size(265, 15);
			this.tbMD5.TabIndex = 29;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel5.Location = new System.Drawing.Point(80, 43);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(265, 1);
			this.panel5.TabIndex = 28;
			// 
			// pdfTextBox
			// 
			this.pdfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pdfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pdfTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.pdfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pdfTextBox.ForeColor = System.Drawing.SystemColors.Info;
			this.pdfTextBox.Location = new System.Drawing.Point(80, 26);
			this.pdfTextBox.Name = "pdfTextBox";
			this.pdfTextBox.Size = new System.Drawing.Size(265, 15);
			this.pdfTextBox.TabIndex = 27;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
			this.lblStatus.Location = new System.Drawing.Point(59, 142);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(27, 13);
			this.lblStatus.TabIndex = 26;
			this.lblStatus.Text = "N/A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(25, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "MD5 :";
			// 
			// btn_browse
			// 
			this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_browse.ForeColor = System.Drawing.Color.Transparent;
			this.btn_browse.Location = new System.Drawing.Point(138, 135);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(65, 27);
			this.btn_browse.TabIndex = 24;
			this.btn_browse.Text = "Browse";
			this.btn_browse.UseVisualStyleBackColor = false;
			this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(25, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "File :";
			// 
			// btn_logout
			// 
			this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
			this.btn_logout.Location = new System.Drawing.Point(280, 135);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(65, 27);
			this.btn_logout.TabIndex = 20;
			this.btn_logout.Text = "Back";
			this.btn_logout.UseVisualStyleBackColor = false;
			this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
			// 
			// btn_upload
			// 
			this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_upload.ForeColor = System.Drawing.Color.Transparent;
			this.btn_upload.Location = new System.Drawing.Point(209, 135);
			this.btn_upload.Name = "btn_upload";
			this.btn_upload.Size = new System.Drawing.Size(65, 27);
			this.btn_upload.TabIndex = 19;
			this.btn_upload.Text = "Upload";
			this.btn_upload.UseVisualStyleBackColor = false;
			this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(15, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "Status :";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel3.Location = new System.Drawing.Point(80, 77);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(265, 1);
			this.panel3.TabIndex = 33;
			// 
			// pathtxt
			// 
			this.pathtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pathtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pathtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.pathtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pathtxt.ForeColor = System.Drawing.SystemColors.Info;
			this.pathtxt.Location = new System.Drawing.Point(80, 60);
			this.pathtxt.Name = "pathtxt";
			this.pathtxt.ReadOnly = true;
			this.pathtxt.Size = new System.Drawing.Size(265, 15);
			this.pathtxt.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(25, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 31;
			this.label4.Text = "Path :";
			// 
			// AVscan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 182);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AVscan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AVscan";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_upload;
		private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_browse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbMD5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox pdfTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox pathtxt;
		private System.Windows.Forms.Label label4;
	}
}