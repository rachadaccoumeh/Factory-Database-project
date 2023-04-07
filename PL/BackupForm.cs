using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Factory_Database.PL {
	public partial class BackupForm : Form {
		private readonly SqlConnection _sqlConnection =
			new SqlConnection(@"Server=.\SQLEXPRESS; DATABASE=sales; INTEGRATED SECURITY =TRUE;");

		private SqlCommand _sqlCommand;

		public BackupForm() {
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				txtFileName.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void l_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnCreate_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var fileName = txtFileName.Text + "\\sales" + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " +
			               DateTime.Now.ToLongTimeString().Replace(':', '-');
			var strQuery = "Backup Database sales to Disk='" + fileName + ".bak'";
			_sqlCommand = new SqlCommand(strQuery, _sqlConnection);
			_sqlConnection.Open();
			_sqlCommand.ExecuteNonQuery();
			_sqlConnection.Close();
			Cursor = Cursors.Default;
			MessageBox.Show("Backup created successfuly", "Create a backup", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}