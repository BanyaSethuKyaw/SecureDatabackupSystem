using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Secure_Backup_System
{
	public partial class RecoveryLogin : Form
	{
		public RecoveryLogin()
		{
			InitializeComponent();
			passwordTextBox.UseSystemPasswordChar = true;
		}

		private void btn_logout_Click(object sender, EventArgs e)
		{
			AdminHome f1 = new AdminHome();
			f1.Show();
			this.Hide();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			if (isValid())
			{
				using (SqlConnection conn = new SqlConnection(@"Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
				{
					string query = "SELECT * FROM RLkey WHERE Code = '" + passwordTextBox.Text.Trim() + "'";
					SqlDataAdapter sda = new SqlDataAdapter(query, conn);
					DataTable dta = new DataTable();
					sda.Fill(dta);
					if (dta.Rows.Count == 1)
					{
						MessageBox.Show("Welcome to Recovery Platform");
						Recovery Re = new Recovery();
						this.Hide();
						Re.Show();
					}
					else
					{
						MessageBox.Show("Invalid Code", "Error");
					}
				}
			}
			
		}
		private bool isValid()
		{
			if (passwordTextBox.Text.TrimStart() == string.Empty)
			{
				MessageBox.Show("Enter Valid Code", "error");
				return false;
			}
			
			return true;
		}
	}
}
