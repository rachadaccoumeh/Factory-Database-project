using System;
using System.Data;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class LoginForm : Form {
		private readonly ClsLogin _clsLogin = new ClsLogin();

		public LoginForm() {
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e) {
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			var dataTable = _clsLogin.Login(txtUsername.Text, txtPassword.Text);
			if (dataTable.Rows.Count > 0) {
				switch (dataTable.Rows[0][2].ToString()) {
					case "ADMIN":
						MainForm.GetMainForm.productToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.customersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.usersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.createBackupToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.restoreBackupToolStripMenuItem.Enabled = true;
						break;
					case "MANAGER":
						MainForm.GetMainForm.productToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.customersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.usersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.createBackupToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.restoreBackupToolStripMenuItem.Enabled = true;
						break;
					case "USER":
						MainForm.GetMainForm.productToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.customersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.usersToolStripMenuItem.Enabled = false;
						MainForm.GetMainForm.createBackupToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.restoreBackupToolStripMenuItem.Enabled = true;
						break;
				}

				Program.SalesMan = dataTable.Rows[0]["Full_Name"].ToString();
				Close();
			} else {
				MessageBox.Show("Login Failed");
			}
		}
	}
}