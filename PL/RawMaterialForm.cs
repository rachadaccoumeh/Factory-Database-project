using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class RawMaterialForm : Form {
		private readonly ClsRawMaterial _clsRawMaterials = new ClsRawMaterial();

		public RawMaterialForm() {
			InitializeComponent();
		}

		private void FRM_RawMaterialS_Load(object sender, EventArgs e) {
			dgList.DataSource = _clsRawMaterials.GetAllRawMaterials();
			dgList_CellClick(null, null);
		}

		private void btnNew_Click(object sender, EventArgs e) {
			txtFirstName.Clear();
			txtLastName.Clear();
			txtFirstName.Focus();
			btnAdd.Enabled = true;
			btnNew.Enabled = false;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (txtFirstName.Text == string.Empty && txtLastName.Text == string.Empty) return;
			_clsRawMaterials.AddRawMaterials(txtFirstName.Text, Convert.ToInt32(txtLastName.Text));
			dgList.DataSource = _clsRawMaterials.GetAllRawMaterials();
			MessageBox.Show("Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnAdd.Enabled = false;
			btnNew.Enabled = true;
			dgList_CellClick(null, null);
		}


		private void txtFirstName_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				txtLastName.Focus();
			}
		}


		private void btnDelete_Click(object sender, EventArgs e) {
			if (dgList.CurrentRow == null) return;
			if (MessageBox.Show("Do you want to delete this RawMaterial", "Delete", MessageBoxButtons.YesNo,
				    MessageBoxIcon.Question) != DialogResult.Yes) return;
			_clsRawMaterials.DeleteRawMaterial((int) dgList.CurrentRow.Cells[0].Value);
			MessageBox.Show("Deleted succesfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			dgList.DataSource = _clsRawMaterials.GetAllRawMaterials();
			dgList_CellClick(null, null);
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (dgList.CurrentRow == null) return;
			_clsRawMaterials.EditRawMaterial(txtFirstName.Text, Convert.ToInt32(txtLastName.Text),
				(int) dgList.CurrentRow.Cells[0].Value);
			dgList.DataSource = _clsRawMaterials.GetAllRawMaterials();
			MessageBox.Show("Edited Successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnAdd.Enabled = false;
			btnNew.Enabled = true;
			dgList_CellClick(null, null);
		}


		private void btnNext_Click(object sender, EventArgs e) {
			try {
				if (dgList.SelectedRows[0].Index <= 0) return;
				dgList.Rows[dgList.SelectedRows[0].Index - 1].Selected = true;
			} catch (ArgumentOutOfRangeException exception) {
				Console.WriteLine(exception);
			}

			dgList_CellClick(null, null);
		}

		private void btnFirst_Click(object sender, EventArgs e) {
			try {
				dgList.Rows[dgList.Rows.Count - 1].Selected = true;
			} catch (ArgumentOutOfRangeException exception) {
				Console.WriteLine(exception);
			}

			dgList_CellClick(null, null);
		}

		private void btnLast_Click(object sender, EventArgs e) {
			try {
				dgList.Rows[0].Selected = true;
			} catch (ArgumentOutOfRangeException exception) {
				Console.WriteLine(exception);
			}

			dgList_CellClick(null, null);
		}

		private void btnPrevious_Click(object sender, EventArgs e) {
			try {
				if (dgList.Rows.Count - 1 <= dgList.SelectedRows[0].Index) return;
				dgList.Rows[dgList.SelectedRows[0].Index + 1].Selected = true;
			} catch (ArgumentOutOfRangeException exception) {
				Console.WriteLine(exception);
			}

			dgList_CellClick(null, null);
		}

		private void button1_Click(object sender, EventArgs e) {
			dgList.DataSource = _clsRawMaterials.SearchRawMaterial(txtSearch.Text);
		}

		private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				button1_Click(null, null);
			}
		}

		private void dgList_CellClick(object sender, DataGridViewCellEventArgs e) {
			try {
				txtFirstName.Text = dgList.SelectedRows[0].Cells[1].Value.ToString();
				txtLastName.Text = dgList.SelectedRows[0].Cells[2].Value.ToString();
				lblPosition.Text = dgList.SelectedRows[0].Index + 1 + " / " + dgList.Rows.Count;
			} catch (ArgumentOutOfRangeException exception) {
				Console.WriteLine(exception);
				btnNew.Enabled = false;
				btnAdd.Enabled = true;
				lblPosition.Text = "0 / 0";
			}
		}


		private void txtLastName_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
				e.Handled = true;
			}
		}
	}
}