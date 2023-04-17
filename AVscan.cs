using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Secure_Backup_System
{
	public partial class AVscan : Form
	{
		public AVscan()
		{
			InitializeComponent();
		}

		private void btn_logout_Click(object sender, EventArgs e)
		{
			Upload f1 = new Upload();
			f1.Show();
			this.Close();
		}

		private void btn_upload_Click(object sender, EventArgs e)
		{
			
			if (lblStatus.Text == "Infected!" || string.IsNullOrWhiteSpace(pathtxt.Text))
			{				
				MessageBox.Show("This file cannot be uploaded because it is infected.");
				return;
			}

			byte[] fileData = File.ReadAllBytes(pathtxt.Text);
			
			using (SqlConnection connection = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				using (SqlCommand command = new SqlCommand("INSERT INTO Tempupload (FileName, FileData) VALUES (@FileName, @FileData)", connection))
				{
					command.Parameters.AddWithValue("@FileName", Path.GetFileName(pathtxt.Text));
					command.Parameters.AddWithValue("@FileData", fileData);

					connection.Open();

					command.ExecuteNonQuery();

					MessageBox.Show("File uploaded successfully!");
				}
			}
		}
	

		private void btn_browse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
			openFileDialog.Title = "Select a PDF File";
			DialogResult result = openFileDialog.ShowDialog();


			if (result == DialogResult.OK)
			{
				string fileName = Path.GetFileName(openFileDialog.FileName);
				pdfTextBox.Text = fileName;
				pathtxt.Text = openFileDialog.FileName;
				tbMD5.Text = GetMD5FromFile(openFileDialog.FileName);
			}

			var md5signatures = File.ReadAllLines("MD5base.txt");
			if (md5signatures.Contains(tbMD5.Text))
			{
				lblStatus.Text = "Infected!";
				lblStatus.ForeColor = Color.Red;
			}

			else
			{
				lblStatus.Text = "Clean!";
				lblStatus.ForeColor = Color.Green;
			}
		}

		public string GetMD5FromFile(string filenPath)
		{
			using (var md5 = MD5.Create())
			{
				using (var stream = File.OpenRead(filenPath))
				{
					return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
				}
			}
		}
	}
}
