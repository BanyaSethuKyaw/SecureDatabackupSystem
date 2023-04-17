using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Secure_Backup_System
{
	public partial class Upload : Form
	{
		string connectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
		public Upload()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sql = "SELECT SeqCode, FileName, DateUpload FROM Tempupload";

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

		private void btn_logout_Click(object sender, EventArgs e)
		{
			StaffLogin f1 = new StaffLogin();
			f1.Show();
			this.Hide();
		}

		private void btn_upload_Click(object sender, EventArgs e)
		{
			AVscan f2 = new AVscan();
			f2.Show();
			this.Hide();
		}

		private void btn_download_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int seqCode = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SeqCode"].Value);
				string fileName = dataGridView1.SelectedRows[0].Cells["FileName"].Value.ToString();

				string query = "SELECT FileData FROM Tempupload WHERE SeqCode = @SeqCode";
				using (SqlConnection connection = new SqlConnection(connectionString))
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@SeqCode", seqCode);

					try
					{
						connection.Open();
						SqlDataReader reader = command.ExecuteReader();
						if (reader.HasRows)
						{
							reader.Read();
							byte[] fileData = (byte[])reader["FileData"];
							SaveFileDialog saveFileDialog = new SaveFileDialog();
							saveFileDialog.FileName = fileName;
							saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
							if (saveFileDialog.ShowDialog() == DialogResult.OK)
							{
								File.WriteAllBytes(saveFileDialog.FileName, fileData);
								MessageBox.Show("File downloaded successfully.");
							}
						}
						reader.Close();
						connection.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error downloading file: " + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a row first.");
			}
		}

		private void btn_backup_Click(object sender, EventArgs e)
		{
			string sourceConnectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
			string destinationConnectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
			string selectQuery = "SELECT FileName, FileData, DateUpload FROM TempUpload";

			try
			{
				
				using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
				{
					sourceConnection.Open();					
					using (SqlCommand selectCommand = new SqlCommand(selectQuery, sourceConnection))
					{
						using (SqlDataReader reader = selectCommand.ExecuteReader())
						{							
							using (SqlConnection destinationConnection = new SqlConnection(destinationConnectionString))
							{
								destinationConnection.Open();
							
								string insertQuery = "INSERT INTO Storage (FileName, FileData, DateUpload) VALUES (@FileName, @FileData, @DateUpload)";
						
								using (SqlCommand insertCommand = new SqlCommand(insertQuery, destinationConnection))
								{									
									insertCommand.Parameters.AddWithValue("@FileName", "");
									insertCommand.Parameters.AddWithValue("@FileData", "");
									insertCommand.Parameters.AddWithValue("@DateUpload", "");									
									while (reader.Read())
									{											
										insertCommand.Parameters["@FileName"].Value = reader.GetString(0);
										insertCommand.Parameters["@FileData"].Value = reader.GetSqlBinary(1);
										insertCommand.Parameters["@DateUpload"].Value = reader.GetDateTime(2);
										insertCommand.ExecuteNonQuery();										
									}
								}								
							}
						}						
					}
				    MessageBox.Show("Backup complete!");
				}
			}
			catch (Exception ex)
			{				
				MessageBox.Show("An error occurred during the backup: " + ex.Message);
			}
			DeleteAllFilesFromTable();
			LoadData();
		}
		private void DeleteAllFilesFromTable()
		{
			string connectionString = "Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
			string deleteQuery = "DELETE FROM Tempupload";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
				{
					int rowsAffected = deleteCommand.ExecuteNonQuery();
				}
			}
		}

		private void btn_setting_Click(object sender, EventArgs e)
		{
			usersetting f1 = new usersetting();
			f1.Show();
			this.Hide();
		}
	}
}

	

	