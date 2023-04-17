using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Secure_Backup_System
{
	public partial class Recovery : Form
	{
		public Recovery()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			using (SqlConnection connection = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
			{
				connection.Open();

				string sql = "SELECT SeqCode, FileName, DateUpload FROM Storage";

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

		private void btn_recovery_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				int seqCode = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SeqCode"].Value);
				string fileName = dataGridView1.SelectedRows[0].Cells["FileName"].Value.ToString();

				string query = "SELECT FileData FROM Storage WHERE SeqCode = @SeqCode";
				using (SqlConnection connection = new SqlConnection("Server=tcp:finalprojectsecure.database.windows.net,1433;Initial Catalog=projectdb;Persist Security Info=False;User ID=banya;Password=Moemakha2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
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

		private void btn_logout_Click(object sender, EventArgs e)
		{
			AdminHome f1 = new AdminHome();
			f1.Show();
			this.Hide();
		}
	}
}
