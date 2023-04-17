using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Backup_System
{
	public partial class Role : Form
	{
		public Role()
		{
			InitializeComponent();
		}
	
		private void btn_admin_Click(object sender, EventArgs e)
		{
			AdminLogin f1 = new AdminLogin();
			f1.Show();
			this.Hide();
		}

		private void btn_member_Click(object sender, EventArgs e)
		{
			StaffLogin f1 = new StaffLogin();
			f1.Show();
			this.Hide();
		}

		private void closebtn(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
