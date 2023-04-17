using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Secure_Backup_System
{
	public partial class usersetting : Form
	{
		SqlConnection con = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public usersetting()
		{
			InitializeComponent();
		}
		
		private void btn_update_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(currentPasswordTextBox.Text)
	   || string.IsNullOrWhiteSpace(newPasswordTextBox.Text) || string.IsNullOrWhiteSpace(confirmNewPasswordTextBox.Text))
			{
				MessageBox.Show("Please fill all fields.");
				return;
			}

			if (!IsPasswordValid(newPasswordTextBox.Text))
			{
				MessageBox.Show("New password is invalid. It must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.");
				return;
			}

			if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text)
			{
				MessageBox.Show("New password and confirm password fields do not match.");
				return;
			}

			string connectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
			string sql = "SELECT Salt, Password FROM Users WHERE Username = @Username";
			byte[] salt = null;
			byte[] encryptedPassword = null;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							salt = (byte[])reader["Salt"];
							encryptedPassword = (byte[])reader["Password"];
						}
					}
				}
			}

			if (salt == null || encryptedPassword == null)
			{
				MessageBox.Show("Invalid username or password.");
				return;
			}

			byte[] inputPassword = Encoding.UTF8.GetBytes(currentPasswordTextBox.Text);
			using (AesManaged aes = new AesManaged())
			{
				aes.KeySize = 256;
				aes.BlockSize = 128;
				using (Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(inputPassword, salt, 10000))
				{
					aes.Key = keyGenerator.GetBytes(aes.KeySize / 8);
					aes.IV = keyGenerator.GetBytes(aes.BlockSize / 8);
				}
				using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
				{
					inputPassword = decryptor.TransformFinalBlock(encryptedPassword, 0, encryptedPassword.Length);
				}
			}

			if (!inputPassword.SequenceEqual(Encoding.UTF8.GetBytes(currentPasswordTextBox.Text)))
			{
				MessageBox.Show("Invalid username or password.");
				return;
			}
			
			byte[] newSalt = GenerateSalt();
			byte[] newEncryptedPassword = EncryptPassword(newPasswordTextBox.Text, newSalt);

			sql = "UPDATE Users SET Password = @Password, Salt = @Salt WHERE Username = @Username";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.AddWithValue("@Username", usernameTextBox.Text);
					command.Parameters.AddWithValue("@Password", newEncryptedPassword);
					command.Parameters.AddWithValue("@Salt", newSalt);
					int rowsAffected = command.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						MessageBox.Show("Password updated successfully.");
					}
					else
					{
						MessageBox.Show("Failed to update password.");
					}
				}
			}
		}

		public bool IsPasswordValid(string password)
		{
			const int MIN_LENGTH = 8;
			const int MAX_LENGTH = 20;
			const string VALID_SPECIAL_CHARS = "!@#$%^&*()_+-=[]{}|;:,.<>?";

			if (string.IsNullOrEmpty(password))
			{
				return false;
			}

			if (password.Length < MIN_LENGTH || password.Length > MAX_LENGTH)
			{
				return false;
			}

			bool hasUpperCase = false;
			bool hasLowerCase = false;
			bool hasDigit = false;
			bool hasSpecialChar = false;

			foreach (char c in password)
			{
				if (char.IsUpper(c))
				{
					hasUpperCase = true;
				}
				else if (char.IsLower(c))
				{
					hasLowerCase = true;
				}
				else if (char.IsDigit(c))
				{
					hasDigit = true;
				}
				else if (VALID_SPECIAL_CHARS.Contains(c))
				{
					hasSpecialChar = true;
				}
			}

			if (!hasUpperCase || !hasLowerCase || !hasDigit || !hasSpecialChar)
			{
				return false;
			}

			return true;
		}

		private byte[] GenerateSalt()
		{
			byte[] salt = new byte[16];
			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				rng.GetBytes(salt);
			}
			return salt;
		}

		private byte[] EncryptPassword(string password, byte[] salt)
		{
			using (AesManaged aes = new AesManaged())
			{
				aes.KeySize = 256;
				aes.BlockSize = 128;
				using (Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt, 10000))
				{
					aes.Key = keyGenerator.GetBytes(aes.KeySize / 8);
					aes.IV = keyGenerator.GetBytes(aes.BlockSize / 8);
				}
				using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
				{
					byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
					byte[] encryptedPassword = encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);
					return encryptedPassword;
				}
			}
		}


		private void btn_search_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtID.Text))
			{
				MessageBox.Show("Please enter the user ID.");
				return;
			}
			con.Open();
			SqlCommand command = new SqlCommand("select Username from Users where Id='" + int.Parse(txtID.Text) + "'", con);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				usernameTextBox.Text = reader.GetValue(0).ToString();
				
			}
			else
			{
				MessageBox.Show("No Data Found!");
				txtID.Text = "";
				usernameTextBox.Text = "";
				currentPasswordTextBox.Text = "";
				newPasswordTextBox.Text = "";			
			}
			con.Close();
		}

		private void btnback(object sender, EventArgs e)
		{
			Upload f1 = new Upload();
			f1.Show();
			this.Hide();
		}
	}
}
