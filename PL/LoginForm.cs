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
			MainForm.GetMainForm.logOutToolStripMenuItem_Click(null, null);
			var dataTable = _clsLogin.Login(txtUsername.Text, txtPassword.Text);
			if (dataTable.Rows.Count > 0) {
				switch (dataTable.Rows[0][2].ToString()) {
					case "ADMIN":
						MainForm.GetMainForm.productToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.customersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.usersToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.createBackupToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.restoreBackupToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.reciepToolStripMenuItem.Enabled = true;
						MainForm.GetMainForm.productionProcessToolStripMenuItem.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel2.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel3.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel5.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel6.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel7.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel8.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel9.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel10.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel11.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel13.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel15.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel17.Enabled = true;
						break;
					case "RECIPE":
						MainForm.GetMainForm.reciepToolStripMenuItem.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel15.Enabled = true;
						break;
					case "WORKER":
						MainForm.GetMainForm.productionProcessToolStripMenuItem.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel17.Enabled = true;
						break;
					case "ORDER":
						MainForm.GetMainForm.customersToolStripMenuItem.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel5.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel6.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel7.Enabled = true;
						break;
					case "INVENTORY":
						MainForm.GetMainForm.productToolStripMenuItem.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel8.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel11.Enabled = true;
						StatisticsForm.GetStatisticsForm.linkLabel13.Enabled = true;

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