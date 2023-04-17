using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Secure_Backup_System
{
	public partial class StaffLogin : Form
	{
		SqlConnection con = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		public StaffLogin()
		{
			InitializeComponent();
			passwordTextBox.UseSystemPasswordChar = true;
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				MessageBox.Show("Please enter a username and password.");
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

			byte[] inputPassword = Encoding.UTF8.GetBytes(passwordTextBox.Text);
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

			if (inputPassword.SequenceEqual(Encoding.UTF8.GetBytes(passwordTextBox.Text)))
			{
				con.Open();
				SqlCommand command = new SqlCommand("select email from Users where Username='" + (usernameTextBox.Text) + "'", con);
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					emailTextBox.Text = reader.GetValue(0).ToString();
				}
				else
				{
					MessageBox.Show("No Data Found!");
				}
				con.Close();
				MessageBox.Show("Please Request OTP");
			}
			else
			{
				MessageBox.Show("Invalid username or password.");
				passwordTextBox.Text = "";
				passwordTextBox.Focus();
			}
		}

		int vCode = 1000;
		private void btn_request_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text))
			{
				MessageBox.Show("Please Login.");
				return;
			}
			timvcode.Stop();
			string to, from, pass, mail;
			to = emailTextBox.Text;
			from = "nationalgoverment@gmail.com";
			mail = vCode.ToString();
			pass = "sgrhpgsfzacajyvy";
			MailMessage message = new MailMessage();
			message.To.Add(to);
			message.From = new MailAddress(from);
			message.Body = mail;
			message.Subject = "Secure Data Backup System - Verification Code";
			SmtpClient smtp = new SmtpClient("smtp.gmail.com");
			smtp.EnableSsl = true;
			smtp.Port = 587;
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtp.Credentials = new NetworkCredential(from, pass);
			try
			{
				smtp.Send(message);
				MessageBox.Show("OTP sent, Please Check your mail!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				otptextbox.Enabled = true;
				btn_access.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void timvcode_Tick(object sender, EventArgs e)
		{
			vCode += 10;
			if (vCode == 9999)
			{
				vCode = 1000;
			}
		}

		private void btn_access_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(otptextbox.Text))
			{
				MessageBox.Show("Please enter OTP.");
				return;
			}
			if (otptextbox.Text == vCode.ToString())
			{
				Upload upload = new Upload();
				upload.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Invalid OTP");
			}
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Role f1 = new Role();
			f1.Show();
			this.Hide();
		}
	}
}
