using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Factory_Database.PL {
	public partial class RestoreForm : Form {
		private readonly SqlConnection _sqlConnection =
			new SqlConnection(@"Server=.\SQLEXPRESS; DATABASE=master; INTEGRATED SECURITY =TRUE;");

		private SqlCommand _sqlCommand;

		public RestoreForm() {
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				txtFileName.Text = openFileDialog1.FileName;
			}
		}

		private void l_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnCreate_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var strQuery =
				"ALTER Database sales SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database sales From Disk='" +
				txtFileName.Text + "'";
			_sqlCommand = new SqlCommand(strQuery, _sqlConnection);
			_sqlConnection.Open();
			_sqlCommand.ExecuteNonQuery();
			_sqlConnection.Close();
			Cursor = Cursors.Default;
			MessageBox.Show("Backup Restored successfuly", "Backup Restore", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}