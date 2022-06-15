using System;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class UsersForm : Form {
		private readonly ClsLogin _clsLogin = new ClsLogin();

		public UsersForm() {
			InitializeComponent();
		}

		private void UsersForm_Load(object sender, EventArgs e) {
			dgvUsers.DataSource = _clsLogin.SearchUsers("");
		}

		private void button3_Click(object sender, EventArgs e) {
			if (dgvUsers.CurrentRow == null) return;
			var addUserForm = new AddUserForm();
			addUserForm.btnSave.Text = "Edit User";
			addUserForm.txtID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
			addUserForm.txtID.ReadOnly = true;
			addUserForm.txtFullName.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
			addUserForm.txtPWD.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
			addUserForm.txtPWDConfirm.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
			addUserForm.cmbType.Text = (dgvUsers.CurrentRow.Cells[3].Value.ToString()).ToUpper();
			addUserForm.ShowDialog();
			dgvUsers.DataSource = _clsLogin.SearchUsers("");
		}

		private void button4_Click(object sender, EventArgs e) {
			if (dgvUsers.CurrentRow == null) return;
			if (MessageBox.Show("Do you want to delete selected user", "Delete", MessageBoxButtons.YesNo,
				    MessageBoxIcon.Exclamation) != DialogResult.Yes) return;
			_clsLogin.DeleteUser(dgvUsers.CurrentRow.Cells[0].Value.ToString());
			MessageBox.Show("Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			dgvUsers.DataSource = _clsLogin.SearchUsers("");
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void button1_Click(object sender, EventArgs e) {
			var addUserForm = new AddUserForm();
			addUserForm.ShowDialog();
			dgvUsers.DataSource = _clsLogin.SearchUsers("");
		}

		private void txtSearch_TextChanged(object sender, EventArgs e) {
			dgvUsers.DataSource = _clsLogin.SearchUsers(txtSearch.Text);
		}
	}
}