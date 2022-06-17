using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Factory_Database.BL;
using Factory_Database.Report;

namespace Factory_Database.PL {
	public partial class AddRecipeForm : Form {
		private readonly ClsRecipe _clsRecipe = new ClsRecipe();

		private readonly DataTable _dataTable = new DataTable();

		public AddRecipeForm() {
			InitializeComponent();
		}

		private void AddRecipeForm_Load(object sender, EventArgs e) {
			_dataTable.Columns.Add("rawMaterial Id");
			_dataTable.Columns.Add("rawMaterial Name");
			_dataTable.Columns.Add("Quantity");
			dgvrawMaterials.DataSource = _dataTable;
			dgvrawMaterials.RowHeadersWidth = 86;
			dgvrawMaterials.Columns[0].Width = 99;
			dgvrawMaterials.Columns[1].Width = 199;
			dgvrawMaterials.Columns[2].Width = 93;
		}


		private void btnAdd_Click(object sender, EventArgs e) {
			if (txtProductID.Text == string.Empty || dgvrawMaterials.Rows.Count < 1) {
				MessageBox.Show("fill all the boxes", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_clsRecipe.deleteRecipe(txtProductID.Text);
			for (var i = 0; i < dgvrawMaterials.Rows.Count; i++) {
				_clsRecipe.AddRecipe(txtProductID.Text, Convert.ToInt32(dgvrawMaterials.Rows[i].Cells[0].Value),
					Convert.ToInt32(dgvrawMaterials.Rows[i].Cells[2].Value));
			}

			MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
			txtProductID.Clear();
			txtFirstName.Clear();
			ClearBoxes();
			_dataTable.Clear();
		}

		private void btnPrint_Click(object sender, EventArgs e) {
			if (txtProductID.Text == string.Empty) return;
			Cursor = Cursors.WaitCursor;
			var report = new Recipe();
			var frm = new ReportForm();
			report.SetDataSource(_clsRecipe.GetRecipeDetails(txtProductID.Text));
			frm.crystalReportViewer1.ReportSource = report;
			frm.ShowDialog();
			Cursor = Cursors.Default;
		}

		private void button4_Click(object sender, EventArgs e) {
			Close();
		}

		private void button2_Click(object sender, EventArgs e) {
			var rawMaterialsListForm = new ListForm();
			rawMaterialsListForm.dataGridView1.DataSource = new ClsRawMaterial().GetAllRawMaterials();
			rawMaterialsListForm.ShowDialog();
			try {
				txtIDrawMaterial.Text = rawMaterialsListForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
				txtNamerawMaterial.Text = rawMaterialsListForm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
				txtQty.Focus();
			} catch (NullReferenceException exception) {
				Console.WriteLine(exception);
			}
		}

		private void ToolStripMenuItem_ClickDeleteAll(object sender, EventArgs e) {
			_dataTable.Clear();
			dgvrawMaterials.Refresh();
		}

		private void ToolStripMenuItem_ClickDeleteCurrentRow(object sender, EventArgs e) {
			dgvrawMaterials.Rows.RemoveAt(dgvrawMaterials.CurrentRow.Index);
		}

		private void ToolStripMenuItem_ClickEdit(object sender, EventArgs e) {
			dgvrawMaterials_DoubleClick(sender, e);
		}

		private void dgvrawMaterials_DoubleClick(object sender, EventArgs e) {
			try {
				txtIDrawMaterial.Text = dgvrawMaterials.CurrentRow.Cells[0].Value.ToString();
				txtNamerawMaterial.Text = dgvrawMaterials.CurrentRow.Cells[1].Value.ToString();
				txtQty.Text = dgvrawMaterials.CurrentRow.Cells[2].Value.ToString();
				dgvrawMaterials.Rows.RemoveAt(dgvrawMaterials.CurrentRow.Index);
				txtQty.Focus();
			} catch {
				// ignored
			}
		}


		private void button1_Click(object sender, EventArgs e) {
			var productsListForm = new ListForm();
			productsListForm.dataGridView1.DataSource = new ClsProducts().GetAllProducts();
			productsListForm.dataGridView1.Columns[2].Visible = false;
			productsListForm.dataGridView1.Columns[3].Visible = false;
			productsListForm.ShowDialog();
			try {
				txtProductID.Text = productsListForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
				txtFirstName.Text = productsListForm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
				var dataTable = _clsRecipe.GetRecipeDetails(txtProductID.Text);
				_dataTable.Clear();
				for (var i = 0; i < dataTable.Rows.Count; i++) {
					_dataTable.Rows.Add(dataTable.Rows[i][1], dataTable.Rows[i][4], dataTable.Rows[i][3]);
				}

				dgvrawMaterials.Refresh();
			} catch (NullReferenceException exception) {
				Console.WriteLine(exception);
			}
		}


		private void txtQty_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode != Keys.Enter || txtQty.Text == string.Empty) return;
			for (var i = 0; i < dgvrawMaterials.Rows.Count; i++) {
				if (dgvrawMaterials.Rows[i].Cells[0].Value.ToString() != txtIDrawMaterial.Text) continue;
				MessageBox.Show("this rawMaterial already added", "Alert", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return;
			}

			var dataRow = _dataTable.NewRow();
			dataRow[0] = txtIDrawMaterial.Text;
			dataRow[1] = txtNamerawMaterial.Text;
			dataRow[2] = txtQty.Text;
			_dataTable.Rows.Add(dataRow);
			dgvrawMaterials.DataSource = _dataTable;
			ClearBoxes();
		}

		private void txt_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
				e.Handled = true;
			}
		}


		private void ClearBoxes() {
			txtIDrawMaterial.Clear();
			txtNamerawMaterial.Clear();
			txtQty.Clear();
			btnBrowse.Focus();
		}
	}
}