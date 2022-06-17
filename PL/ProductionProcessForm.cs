using System;
using System.Data;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class ProductionProcessForm : Form {
		private readonly DataTable _dataTable = new DataTable();

		public ProductionProcessForm() {
			InitializeComponent();
		}

		private void ProductionProcessForm_Load(object sender, EventArgs e) {
			_dataTable.Columns.Add("rawMaterial Id");
			_dataTable.Columns.Add("rawMaterial Name");
			_dataTable.Columns.Add("Quantity");
			dgvrawMaterials.DataSource = _dataTable;
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
				e.Handled = true;
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
				var dataTable = new ClsRecipe().GetRecipeDetails(txtProductID.Text);
				_dataTable.Clear();
				for (var i = 0; i < dataTable.Rows.Count; i++) {
					_dataTable.Rows.Add(dataTable.Rows[i][1], dataTable.Rows[i][4], dataTable.Rows[i][3]);
				}

				dgvrawMaterials.Refresh();
			} catch (NullReferenceException exception) {
				Console.WriteLine(exception);
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			var state = true;
			if (dgvrawMaterials.Rows.Count <= 0 || textBox1.Text == string.Empty) return;
			for (var i = 0; i < dgvrawMaterials.Rows.Count; i++) {
				if (new ClsRawMaterial().verifyRawQty(Convert.ToInt32(dgvrawMaterials.Rows[i].Cells[0].Value),
						    Convert.ToInt32(dgvrawMaterials.Rows[i].Cells[2].Value) * Convert.ToInt32(textBox1.Text))
					    .Rows
					    .Count > 0) continue;
				MessageBox.Show(dgvrawMaterials.Rows[i].Cells[1].Value + " qunatity is not enough");
				state = false;
				break;
			}

			if (state) {
				for (var i = 0; i < dgvrawMaterials.Rows.Count; i++) {
					new ClsRawMaterial().removeRawQty(Convert.ToInt32(dgvrawMaterials.Rows[i].Cells[0].Value),
						Convert.ToInt32(dgvrawMaterials.Rows[i].Cells[2].Value) * Convert.ToInt32(textBox1.Text));
				}

				new ClsProducts().addQuantity(txtProductID.Text, Convert.ToInt32(textBox1.Text));
				MessageBox.Show("Added successfully");
			}
		}
	}
}