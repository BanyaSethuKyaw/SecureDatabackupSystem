using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Secure_Backup_System
{
	public partial class AdminHome : Form
	{
		SqlConnection con = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		string connectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
		int codeLength = 6;

		public AdminHome()
		{
			InitializeComponent();
			LoadData();
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtdate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
		}

		private void LoadData()
		{
			using (SqlConnection connection = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				connection.Open();

				string sql = "SELECT Id, Username, Email, Phone, DateUpload FROM Users";

				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);
						dataGridView1.DataSource = dataTable;
					}
				}
				connection.Close();
			}
		}

		private async void pictureBox2_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			string code = "";
			for (int i = 0; i < codeLength; i++)
			{
				code += random.Next(0, 9).ToString();
			}

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				await connection.OpenAsync();
				SqlCommand command = new SqlCommand($"UPDATE RLkey SET Code='{code}'", connection);
				await command.ExecuteNonQueryAsync();
			}

			MessageBox.Show($"Only for Authorized Person!");

			RecoveryLogin RecLog = new RecoveryLogin();
			RecLog.Show();
			this.Hide();
		}


		private void Generate_Click(object sender, EventArgs e)
		{
			int passwordLength = 20;
			string password = GenerateRandomPassword(passwordLength);
			textBox3.Text = password;
		}

		private string GenerateRandomPassword(int passwordLength)
		{
			const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;:,.<>?";

			StringBuilder password = new StringBuilder();
			Random random = new Random();

			while (0 < passwordLength--)
			{
				password.Append(validChars[random.Next(validChars.Length)]);
			}
			return password.ToString();
		}

		private void btn_logout_Click(object sender, EventArgs e)
		{
			AdminLogin f1 = new AdminLogin();
			f1.Show();
			this.Hide();
		}

		private void btn_adduser_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
			{
				MessageBox.Show("Please enter a username and password.");
				return;
			}

			byte[] salt = new byte[32];
			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				rng.GetBytes(salt);
			}
			using (Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(txtpass.Text, salt, 10000))
			{
				byte[] key = keyGenerator.GetBytes(32);
				byte[] iv = keyGenerator.GetBytes(16);

				using (Aes aes = Aes.Create())
				{
					aes.Key = key;
					aes.IV = iv;
					using (ICryptoTransform encryptor = aes.CreateEncryptor())
					{
						byte[] plaintextPassword = Encoding.UTF8.GetBytes(txtpass.Text);
						byte[] encryptedPassword = encryptor.TransformFinalBlock(plaintextPassword, 0, plaintextPassword.Length);

						string connectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
						string sql = "INSERT INTO Users (Username, Salt, Password, Email, Phone) VALUES (@Username, @Salt, @Password, @Email, @Phone)";
						using (SqlConnection connection = new SqlConnection(connectionString))
						{
							connection.Open();
							using (SqlCommand command = new SqlCommand(sql, connection))
							{
								command.Parameters.AddWithValue("@Username", txtname.Text);
								command.Parameters.AddWithValue("@Salt", salt);
								command.Parameters.AddWithValue("@Password", encryptedPassword);
								command.Parameters.AddWithValue("@Email", txtemail.Text);
								command.Parameters.AddWithValue("@Phone", txtphone.Text);
								int rowsAffected = command.ExecuteNonQuery();
								if (rowsAffected > 0)
								{
									MessageBox.Show("Admin registered successfully.");
									LoadData();
								}
								else
								{
									MessageBox.Show("Error registering user.");
								}
							}
						}
					}
				}
			}
		}

		private void btn_resetuser_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand command = new SqlCommand("update Users set Username=@Username, Email=@Email, Phone=@Phone where Id=@Id", con);
			command.Parameters.AddWithValue("@Id", int.Parse(txtID.Text));
			command.Parameters.AddWithValue("@Username", txtname.Text);			
			command.Parameters.AddWithValue("@Email", txtemail.Text);
			command.Parameters.AddWithValue("@Phone", txtphone.Text);
			command.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Updated");
			this.txtID.Text = "";
			this.txtname.Text = "";
			this.txtemail.Text = "";
			this.txtpass.Text = "";
			this.txtphone.Text = "";
			this.txtdate.Text = "";
			LoadData();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			int userIdToDelete = Convert.ToInt32(txtID.Text);

			using (SqlConnection connection = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				connection.Open();
				string deleteQuery = "DELETE FROM Users WHERE Id = @Id";
				SqlCommand command = new SqlCommand(deleteQuery, connection);
				command.Parameters.AddWithValue("@Id", userIdToDelete);

				int rowsAffected = command.ExecuteNonQuery();

				if (rowsAffected > 0)
				{
					MessageBox.Show("User information deleted successfully");
					txtID.Text = "";
					txtname.Text = "";
					txtpass.Text = "";
					txtphone.Text = "";
					txtemail.Text = "";
					txtdate.Text = "";
					LoadData();
				}
				else
				{
					MessageBox.Show("User with ID " + userIdToDelete + " not found");
					txtID.Text = "";
					txtname.Text = "";
					txtpass.Text = "";
					txtphone.Text = "";
					txtemail.Text = "";
					txtdate.Text = "";
				}
			}
		}

		private void btn_setting_Click(object sender, EventArgs e)
		{
			adminsetting adset = new adminsetting();
			adset.ShowDialog();
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand command = new SqlCommand("select username, phone, email, dateupload from Users where Id='" + int.Parse(txtID.Text) + "'", con);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				txtname.Text = reader.GetValue(0).ToString();
				txtphone.Text = reader.GetValue(1).ToString();
				txtemail.Text = reader.GetValue(2).ToString();
				txtdate.Text = reader.GetValue(3).ToString();
			}
			else
			{
				MessageBox.Show("No Data Found!");
				txtID.Text = "";
				txtname.Text = "";
				txtpass.Text = "";
				txtphone.Text = "";
				txtemail.Text = "";
				txtdate.Text = "";
			}
			con.Close();
		}
	}
}
