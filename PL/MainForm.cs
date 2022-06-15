using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Factory_Database.PL {
	public partial class MainForm : Form {
		private static MainForm _mainForm;

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			if (_mainForm == null) {
				_mainForm = this;
			}

			var statisticsForm = new StatisticsForm();
			statisticsForm.MdiParent = this;
			statisticsForm.Show();
		}

		public void logInToolStripMenuItem_Click(object sender, EventArgs e) {
			var loginForm = new LoginForm();
			loginForm.ShowDialog();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
			_mainForm = null;
		}

		public static MainForm GetMainForm {
			get { return _mainForm ?? (_mainForm = new MainForm()); }
		}

		public void addProductToolStripMenuItem_Click(object sender, EventArgs e) {
			var addProductForm = new AddProductForm();
			addProductForm.MdiParent = this;
			addProductForm.Show();
		}

		public void manageProductToolStripMenuItem_Click(object sender, EventArgs e) {
			var productsForm = new ProductsForm();
			productsForm.MdiParent = this;
			productsForm.Show();
		}

		public void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
			productToolStripMenuItem.Enabled = false;
			customersToolStripMenuItem.Enabled = false;
			usersToolStripMenuItem.Enabled = false;
			createBackupToolStripMenuItem.Enabled = false;
			restoreBackupToolStripMenuItem.Enabled = false;
			reciepToolStripMenuItem.Enabled = false;
			productionProcessToolStripMenuItem.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel2.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel3.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel5.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel6.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel7.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel8.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel9.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel10.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel11.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel13.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel15.Enabled = false;
			StatisticsForm.GetStatisticsForm.linkLabel17.Enabled = false;
			foreach (var frm in MdiChildren) {
				if (frm.GetType() == typeof(StatisticsForm)) continue;
				frm.Dispose();
				frm.Close();
			}
		}


		public void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e) {
			var customerForm = new CustomersForm();
			customerForm.MdiParent = this;
			customerForm.Show();
		}

		public void manageOrderToolStripMenuItem_Click(object sender, EventArgs e) {
			var ordersForm = new OrdersForm();
			ordersForm.MdiParent = this;
			ordersForm.Show();
		}

		public void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
			var addOrderFrom = new AddOrderForm();
			addOrderFrom.MdiParent = this;
			addOrderFrom.Show();
		}

		public void addNewUserToolStripMenuItem_Click(object sender, EventArgs e) {
			var addUserForm = new AddUserForm();
			addUserForm.MdiParent = this;
			addUserForm.Show();
		}

		public void manageUsersToolStripMenuItem_Click(object sender, EventArgs e) {
			var usersForm = new UsersForm();
			usersForm.MdiParent = this;
			usersForm.Show();
		}

		public void createBackupToolStripMenuItem_Click(object sender, EventArgs e) {
			var backupForm = new BackupForm();
			backupForm.MdiParent = this;
			backupForm.Show();
		}

		public void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e) {
			var restoreForm = new RestoreForm();
			restoreForm.MdiParent = this;
			restoreForm.Show();
		}


		public void manageRawMaterialsToolStripMenuItem_Click(object sender, EventArgs e) {
			var rawMaterialForm = new RawMaterialForm();
			rawMaterialForm.MdiParent = this;
			rawMaterialForm.Show();
		}

		public void addNewRecipeToolStripMenuItem_Click(object sender, EventArgs e) {
			var addRecipeForm = new AddRecipeForm();
			addRecipeForm.MdiParent = this;
			addRecipeForm.Show();
		}

		public void addAProductionProcessToolStripMenuItem_Click(object sender, EventArgs e) {
		}
	}
}