namespace Secure_Backup_System
{
	partial class RecoveryLogin
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
			this.label3 = new System.Windows.Forms.Label();
			this.btn_logout = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btn_logout);
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.passwordTextBox);
			this.panel1.Controls.Add(this.btn_login);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(367, 179);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(46, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 15);
			this.label3.TabIndex = 62;
			this.label3.Text = "Insert Key";
			// 
			// btn_logout
			// 
			this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
			this.btn_logout.Location = new System.Drawing.Point(239, 117);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(65, 27);
			this.btn_logout.TabIndex = 61;
			this.btn_logout.Text = "Back";
			this.btn_logout.UseVisualStyleBackColor = false;
			this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel8.Location = new System.Drawing.Point(49, 91);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(255, 1);
			this.panel8.TabIndex = 58;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.SystemColors.Info;
			this.passwordTextBox.Location = new System.Drawing.Point(49, 74);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(255, 15);
			this.passwordTextBox.TabIndex = 57;
			// 
			// btn_login
			// 
			this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_login.ForeColor = System.Drawing.Color.Transparent;
			this.btn_login.Location = new System.Drawing.Point(49, 117);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(78, 27);
			this.btn_login.TabIndex = 56;
			this.btn_login.Text = "Access";
			this.btn_login.UseVisualStyleBackColor = false;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// RecoveryLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 179);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RecoveryLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RecoveryLogin";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_logout;
	}
}