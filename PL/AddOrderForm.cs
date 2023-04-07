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
	public partial class AddOrderForm : Form {
		private readonly ClsOrders _clsOrders = new ClsOrders();

		private readonly DataTable _dataTable = new DataTable();

		public AddOrderForm() {
			InitializeComponent();
		}

		private void AddOrderForm_Load(object sender, EventArgs e) {
			txtSalesMan.Text = Program.SalesMan;
			_dataTable.Columns.Add("Product Id");
			_dataTable.Columns.Add("Product Name");
			_dataTable.Columns.Add("Price");
			_dataTable.Columns.Add("Quantity");
			_dataTable.Columns.Add("Amount");
			_dataTable.Columns.Add("Discount (%)");
			_dataTable.Columns.Add("Total Amount");
			dgvProducts.DataSource = _dataTable;
			dgvProducts.RowHeadersWidth = 86;
			dgvProducts.Columns[0].Width = 99;
			dgvProducts.Columns[1].Width = 199;
			dgvProducts.Columns[2].Width = 85;
			dgvProducts.Columns[3].Width = 93;
			dgvProducts.Columns[4].Width = 85;
			dgvProducts.Columns[5].Width = 93;
			dgvProducts.Columns[6].Width = 121;
			dtOrder.MinDate=DateTime.Now;
		}

		private void btnNew_Click(object sender, EventArgs e) {
			txtOrderID.Text = _clsOrders.GetLastOrderId().Rows[0][0].ToString();
			btnNew.Enabled = false;
			btnAdd.Enabled = true;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (txtOrderID.Text == string.Empty || txtCustomerID.Text == string.Empty || dgvProducts.Rows.Count < 1 ||
			    txtDesOrder.Text == string.Empty) {
				MessageBox.Show("fill all the boxes", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_clsOrders.AddOrder(Convert.ToInt32(txtOrderID.Text), dtOrder.Value, Convert.ToInt32(txtCustomerID.Text),
				txtDesOrder.Text, txtSalesMan.Text);
			for (var i = 0; i < dgvProducts.Rows.Count; i++) {
				_clsOrders.AddOrderDetails(dgvProducts.Rows[i].Cells[0].Value.ToString(),
					Convert.ToInt32(txtOrderID.Text), Convert.ToInt32(dgvProducts.Rows[i].Cells[3].Value),
					dgvProducts.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(dgvProducts.Rows[i].Cells[5].Value),
					dgvProducts.Rows[i].Cells[4].Value.ToString(), dgvProducts.Rows[i].Cells[6].Value.ToString());
			}

			MessageBox.Show("Saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
			txtOrderID.Clear();
			txtDesOrder.Clear();
			txtSalesMan.Clear();
			dtOrder.ResetText();
			txtCustomerID.Clear();
			txtFirstName.Clear();
			txtLastName.Clear();
			txtEmail.Clear();
			txtTel.Clear();
			ClearBoxes();
			_dataTable.Clear();
			dgvProducts.DataSource = null;
			txtSumTotals.Clear();
			pbox.Image = null;
			btnAdd.Enabled = false;
			btnNew.Enabled = true;
			btnPrint.Enabled = true;
		}

		private void btnPrint_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var orderId = Convert.ToInt32(_clsOrders.GetLastOrderForPrint().Rows[0][0]);
			var report = new BillReport();
			var frm = new ReportForm();
			report.SetDataSource(_clsOrders.GetOrderDetails(orderId));
			frm.crystalReportViewer1.ReportSource = report;
			frm.ShowDialog();
			Cursor = Cursors.Default;
		}

		private void button4_Click(object sender, EventArgs e) {
			Close();
		}

		private void button2_Click(object sender, EventArgs e) {
			var productsListForm = new ListForm();
			productsListForm.dataGridView1.DataSource = new ClsProducts().GetAllProducts();
			productsListForm.ShowDialog();
			txtIDproduct.Text = productsListForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtNameProduct.Text = productsListForm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtPrice.Text = productsListForm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtQty.Focus();
		}

		private void ToolStripMenuItem_ClickDeleteAll(object sender, EventArgs e) {
			_dataTable.Clear();
			dgvProducts.Refresh();
		}

		private void ToolStripMenuItem_ClickDeleteCurrentRow(object sender, EventArgs e) {
			dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
		}

		private void ToolStripMenuItem_ClickEdit(object sender, EventArgs e) {
			dgvProducts_DoubleClick(sender, e);
		}

		private void dgvProducts_DoubleClick(object sender, EventArgs e) {
			try {
				txtIDproduct.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
				txtNameProduct.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
				txtPrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
				txtQty.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
				txtAmount.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
				txtDiscount.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
				txtTotalAmount.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
				dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
				txtQty.Focus();
			} catch {
				// ignored
			}
		}

		private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {
			txtSumTotals.Text =
				(from DataGridViewRow row in dgvProducts.Rows
					where row.Cells[6].FormattedValue?.ToString() != string.Empty
					select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
		}

		private void button1_Click(object sender, EventArgs e) {
			var customersListForm = new ListForm();
			customersListForm.dataGridView1.DataSource = new ClsCustomers().GetAllCustomers();
			customersListForm.dataGridView1.Columns[0].Visible = false;
			customersListForm.dataGridView1.Columns[5].Visible = false;
			customersListForm.ShowDialog();
			pbox.Image = null;
			try {
				txtCustomerID.Text = customersListForm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
				txtFirstName.Text = customersListForm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
				txtLastName.Text = customersListForm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
				txtTel.Text = customersListForm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
				txtEmail.Text = customersListForm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
				if (customersListForm.dataGridView1.SelectedRows[0].Cells[5].Value == DBNull.Value) return;
				var memoryStream =
					new MemoryStream((byte[]) customersListForm.dataGridView1.SelectedRows[0].Cells[5].Value);
				pbox.Image = Image.FromStream(memoryStream);
			} catch (NullReferenceException exception) {
				Console.WriteLine(exception);
			}
		}


		private void txtDiscount_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode != Keys.Enter) return;
			if (_clsOrders.VerifyQty(txtIDproduct.Text, Convert.ToInt32(txtQty.Text)).Rows.Count < 1) {
				MessageBox.Show("The quantity not available", "Alert", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				txtQty.Focus();
				return;
			}

			for (var i = 0; i < dgvProducts.Rows.Count; i++) {
				if (dgvProducts.Rows[i].Cells[0].Value.ToString() != txtIDproduct.Text) continue;
				MessageBox.Show("this product already added", "Alert", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
				return;
			}

			var dataRow = _dataTable.NewRow();
			dataRow[0] = txtIDproduct.Text;
			dataRow[1] = txtNameProduct.Text;
			dataRow[2] = txtPrice.Text;
			dataRow[3] = txtQty.Text;
			dataRow[4] = txtAmount.Text;
			dataRow[5] = txtDiscount.Text;
			dataRow[6] = txtTotalAmount.Text;
			_dataTable.Rows.Add(dataRow);
			dgvProducts.DataSource = _dataTable;
			ClearBoxes();
			txtSumTotals.Text =
				(from DataGridViewRow row in dgvProducts.Rows
					where row.Cells[6].FormattedValue?.ToString() != string.Empty
					select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
		}

		private void txtDiscount_KeyUp(object sender, KeyEventArgs e) {
			if (txtDiscount.Text == string.Empty || txtAmount.Text == string.Empty) return;
			var discount = Convert.ToDouble(txtDiscount.Text);
			var amount = Convert.ToDouble(txtAmount.Text);
			var totalAmount = amount - (amount * (discount / 100));
			txtTotalAmount.Text = totalAmount.ToString();
		}

		private void txtQty_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter && txtQty.Text != string.Empty) {
				txtDiscount.Focus();
			}
		}

		private void txt_KeyPress(object sender, KeyPressEventArgs e) {
			if (((TextBox) sender).Name == txtPrice.Name) {
				var decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != decimalSeparator) {
					e.Handled = true;
				}
			} else {
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
					e.Handled = true;
				}
			}
		}

		private void txt_KeyUp(object sender, KeyEventArgs e) {
			if (txtPrice.Text == string.Empty || txtQty.Text == string.Empty) return;
			txtAmount.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString();
			txtDiscount_KeyUp(sender, e);
		}

		private void txtPrice_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty) {
				txtQty.Focus();
			}
		}

		private void ClearBoxes() {
			txtIDproduct.Clear();
			txtNameProduct.Clear();
			txtPrice.Clear();
			txtQty.Clear();
			txtAmount.Clear();
			txtDiscount.Clear();
			txtTotalAmount.Clear();
			btnBrowse.Focus();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			ToolStripMenuItem_ClickDeleteCurrentRow(null, null);
		}
	}
}