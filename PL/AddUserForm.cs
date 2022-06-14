using System;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class AddUserForm : Form {
		private readonly ClsLogin _clsLogin = new ClsLogin();

		public AddUserForm() {
			InitializeComponent();
		}

		private void AddUserForm_Load(object sender, EventArgs e) {
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void button1_Click(object sender, EventArgs e) {
			if (txtID.Text == string.Empty || txtPWD.Text == string.Empty || txtFullName.Text == string.Empty ||
			    txtPWDConfirm.Text == string.Empty) {
				MessageBox.Show("Fill all the data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (txtPWD.Text != txtPWDConfirm.Text) {
				MessageBox.Show("Password doesn't match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			switch (btnSave.Text) {
				case "Save User":
					_clsLogin.AddUser(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
					MessageBox.Show("User Added successfully", "Add new user", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					break;
				case "Edit User":
					_clsLogin.EditUser(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
					MessageBox.Show("User Edited Successfuly", "Edit User", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					Close();
					break;
			}

			txtID.Clear();
			txtFullName.Clear();
			txtPWD.Clear();
			txtPWDConfirm.Clear();
			txtID.Focus();
		}

		private void txtPWDConfirm_Validated(object sender, EventArgs e) {
			if (txtPWD.Text != txtPWDConfirm.Text)
				MessageBox.Show("Password doesn't match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}