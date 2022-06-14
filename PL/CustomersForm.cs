using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class CustomersForm : Form {
		private readonly ClsCustomers _clsCustomers = new ClsCustomers();

		public CustomersForm() {
			InitializeComponent();
		}

		private void FRM_CUSTOMERS_Load(object sender, EventArgs e) {
			dgList.DataSource = _clsCustomers.GetAllCustomers();
			dgList.Columns[0].Visible = false;
			dgList.Columns[5].Visible = false;
			dgList_CellClick(null, null);
		}

		private void btnNew_Click(object sender, EventArgs e) {
			txtFirstName.Clear();
			txtLastName.Clear();
			txtTel.Clear();
			txtEmail.Clear();
			pbox.Image = null;
			txtFirstName.Focus();
			btnAdd.Enabled = true;
			btnNew.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			var ms = new MemoryStream();
			byte[] picture = null;
			try {
				pbox.Image.Save(ms, pbox.Image.RawFormat);
				picture = ms.ToArray();
			} catch {
				// ignored
			}

			_clsCustomers.AddCustomers(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture);
			dgList.DataSource = _clsCustomers.GetAllCustomers();
			MessageBox.Show("Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnAdd.Enabled = false;
			btnNew.Enabled = true;
		}

		private void pBox_Click(object sender, EventArgs e) {
			var op = new OpenFileDialog();
			op.Filter = "Images |*.JPG; *.PNG; *.GIF; *.BMP";
			if (op.ShowDialog() == DialogResult.OK) {
				pbox.Image = Image.FromFile(op.FileName);
			}
		}

		private void txtFirstName_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				txtLastName.Focus();
			}
		}

		private void txtLastName_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				txtTel.Focus();
			}
		}

		private void txtTel_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				txtEmail.Focus();
			}
		}

		private void txtEmail_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				btnAdd.Focus();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Do you want to delete this customer", "Delete", MessageBoxButtons.YesNo,
				    MessageBoxIcon.Question) != DialogResult.Yes) return;
			_clsCustomers.DeleteCustomer((int) dgList.CurrentRow.Cells[0].Value);
			MessageBox.Show("Deleted succesfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			dgList.DataSource = _clsCustomers.GetAllCustomers();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			var ms = new MemoryStream();
			byte[] picture = null;
			try {
				pbox.Image.Save(ms, pbox.Image.RawFormat);
				picture = ms.ToArray();
			} catch {
				// ignored
			}

			_clsCustomers.EditCustomer(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, picture,
				(int) dgList.CurrentRow.Cells[0].Value);
			dgList.DataSource = _clsCustomers.GetAllCustomers();
			MessageBox.Show("Edited Successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnAdd.Enabled = false;
			btnNew.Enabled = true;
		}

		private void btnClose_Click(object sender, EventArgs e) {
			Close();
		}


		private void btnNext_Click(object sender, EventArgs e) {
			if (dgList.SelectedRows[0].Index <= 0) return;
			dgList.Rows[dgList.SelectedRows[0].Index - 1].Selected = true;
			dgList_CellClick(null, null);
		}

		private void btnFirst_Click(object sender, EventArgs e) {
			dgList.Rows[dgList.Rows.Count - 1].Selected = true;
			dgList_CellClick(null, null);
		}

		private void btnLast_Click(object sender, EventArgs e) {
			dgList.Rows[0].Selected = true;
			dgList_CellClick(null, null);
		}

		private void btnPrevious_Click(object sender, EventArgs e) {
			if (dgList.Rows.Count - 1 <= dgList.SelectedRows[0].Index) return;
			dgList.Rows[dgList.SelectedRows[0].Index + 1].Selected = true;
			dgList_CellClick(null, null);
		}

		private void button1_Click(object sender, EventArgs e) {
			dgList.DataSource = _clsCustomers.SearchCustomer(txtSearch.Text);
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				button1_Click(null, null);
			}
		}

		private void dgList_CellClick(object sender, DataGridViewCellEventArgs e) {
			pbox.Image = null;
			txtFirstName.Text = dgList.SelectedRows[0].Cells[1].Value.ToString();
			txtLastName.Text = dgList.SelectedRows[0].Cells[2].Value.ToString();
			txtTel.Text = dgList.SelectedRows[0].Cells[3].Value.ToString();
			txtEmail.Text = dgList.SelectedRows[0].Cells[4].Value.ToString();
			lblPosition.Text = dgList.SelectedRows[0].Index+1 + " / " + dgList.Rows.Count;
			if (dgList.SelectedRows[0].Cells[5].Value == DBNull.Value) return;
			var ms = new MemoryStream((byte[]) dgList.SelectedRows[0].Cells[5].Value);
			pbox.Image = Image.FromStream(ms);
		}
	}
}