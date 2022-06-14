using System;
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

			var loginForm = new LoginForm();
			loginForm.ShowDialog();
		}

		private void logInToolStripMenuItem_Click(object sender, EventArgs e) {
			MainForm_Load(null, null);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
			_mainForm = null;
		}

		public static MainForm GetMainForm {
			get {
				if (_mainForm == null) {
					_mainForm = new MainForm();
				}

				return _mainForm;
			}
		}

		private void addProductToolStripMenuItem_Click(object sender, EventArgs e) {
			var addProductForm = new AddProductForm();
			addProductForm.MdiParent = this;
			addProductForm.Show();
		}

		private void manageProductToolStripMenuItem_Click(object sender, EventArgs e) {
			var productsForm = new ProductsForm();
			productsForm.MdiParent = this;
			productsForm.Show();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e) {
			var categoriesForm = new CategoriesForm();
			categoriesForm.MdiParent = this;
			categoriesForm.Show();
		}

		private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e) {
			var customerForm = new CustomersForm();
			customerForm.MdiParent = this;
			customerForm.Show();
		}

		private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e) {
			var ordersForm = new OrdersForm();
			ordersForm.MdiParent = this;
			ordersForm.Show();
		}

		private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
			var addOrderFrom = new AddOrderForm();
			addOrderFrom.MdiParent = this;
			addOrderFrom.Show();
		}

		private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e) {
			var addUserForm = new AddUserForm();
			addUserForm.MdiParent = this;
			addUserForm.Show();
		}

		private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e) {
			var usersForm = new UsersForm();
			usersForm.MdiParent = this;
			usersForm.Show();
		}

		private void createBackupToolStripMenuItem_Click(object sender, EventArgs e) {
			var backupForm = new BackupForm();
			backupForm.MdiParent = this;
			backupForm.Show();
		}

		private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e) {
			var restoreForm = new RestoreForm();
			restoreForm.MdiParent = this;
			restoreForm.Show();
		}
	}
}