using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Secure_Backup_System
{
	public partial class adminsetting : Form
	{
		SqlConnection con = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public adminsetting()
		{
			InitializeComponent();
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
						string sql = "INSERT INTO Admin (Username, Salt, Password, Email, Phone) VALUES (@Username, @Salt, @Password, @Email, @Phone)";
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

		private void btn_delete_Click(object sender, EventArgs e)
		{
			int userIdToDelete = Convert.ToInt32(txtID.Text);

			using (SqlConnection connection = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				connection.Open();			
				string deleteQuery = "DELETE FROM Admin WHERE Id = @Id";
				SqlCommand command = new SqlCommand(deleteQuery, connection);
				command.Parameters.AddWithValue("@Id", userIdToDelete);

				int rowsAffected = command.ExecuteNonQuery();

				if (rowsAffected > 0)
				{
					MessageBox.Show("Admin information deleted successfully");
					txtID.Text = "";
					txtname.Text = "";
					txtpass.Text = "";
					txtphone.Text = "";
					txtemail.Text = "";
				}
				else
				{
					MessageBox.Show("User with ID " + userIdToDelete + " not found");
					txtID.Text = "";
					txtname.Text = "";
					txtpass.Text = "";
					txtphone.Text = "";
					txtemail.Text = "";
				}
			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
			{
				MessageBox.Show("Please enter Information.");
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
						string sql = "UPDATE Admin SET Salt = @Salt, Password = @Password, Email = @Email, Phone = @Phone WHERE Username = @Username";
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
									MessageBox.Show("Admin updated successfully.");
								}
								else
								{
									MessageBox.Show("Error updating admin.");
								}
							}
						}
					}
				}
			}
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtname.Text))
			{
				MessageBox.Show("Please enter the user ID.");
				return;
			}
			con.Open();
			SqlCommand command = new SqlCommand("select Id, username, phone, email from Admin where Username='"+(txtname.Text)+"'",con);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				txtID.Text = reader.GetValue(0).ToString();
				txtname.Text = reader.GetValue(1).ToString();
				txtphone.Text = reader.GetValue(2).ToString();
				txtemail.Text = reader.GetValue(3).ToString();
			}
			else
			{
				MessageBox.Show("No Data Found!");
				txtID.Text = "";
				txtname.Text = "";
				txtpass.Text = "";
				txtphone.Text = "";
				txtemail.Text = "";
			}
			con.Close();
		}

		private void btnback(object sender, EventArgs e)
		{
			this.Hide();
		}
	}

}
