using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Factory_Database.BL;
using Factory_Database.Report;

namespace Factory_Database.PL {
	public partial class ProductsForm : Form {
		private readonly ClsProducts _clsProducts = new ClsProducts();
		private static ProductsForm _productsForm;

		public ProductsForm() {
			InitializeComponent();
		}

		private void ProductsForm_Load(object sender, EventArgs e) {
			if (_productsForm == null) {
				_productsForm = this;
			}

			dataGridView1.DataSource = _clsProducts.GetAllProducts();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			dataGridView1.DataSource = _clsProducts.SearchProduct(((TextBox) sender).Text);
		}

		private void button1_Click(object sender, EventArgs e) {
			var addProductForm = new AddProductForm();
			addProductForm.MdiParent = ActiveForm;
			addProductForm.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Do you want to delete selected producy", "Delete operation", MessageBoxButtons.YesNo,
				    MessageBoxIcon.Exclamation) == DialogResult.Yes) {
				_clsProducts.DeleteProduct(dataGridView1.CurrentRow.Cells[0].Value.ToString());
				MessageBox.Show("deleted succesfuly", "delete operation", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				dataGridView1.DataSource = _clsProducts.GetAllProducts();
			} else {
				MessageBox.Show("deleted cannceled", "delete operation", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}

		private void button3_Click(object sender, EventArgs e) {
			var addProductForm = new AddProductForm();
			//addProductForm.MdiParent = ActiveForm;
			addProductForm.Text = "Edit Product: " + dataGridView1.CurrentRow.Cells[1].Value;
			addProductForm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			addProductForm.txtId.ReadOnly = true;
			addProductForm.txtDes.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			addProductForm.txtQty.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			addProductForm.txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			addProductForm.categoriesCB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			addProductForm.btnAdd.Text = "Edit";
			var image = (byte[]) _clsProducts.GetProductImage(dataGridView1.CurrentRow.Cells[0].Value.ToString())
				.Rows[0][0];
			addProductForm.pictureBox1.Image = Image.FromStream(new MemoryStream(image));
			addProductForm.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e) {
			var imagePreviewForm = new ImagePreviewForm();
			var image = (byte[]) _clsProducts.GetProductImage(dataGridView1.CurrentRow.Cells[0].Value.ToString())
				.Rows[0][0];
			imagePreviewForm.pictureBox1.Image = Image.FromStream(new MemoryStream(image));
			imagePreviewForm.ShowDialog();
		}

		private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e) {
			_productsForm = null;
		}

		public static ProductsForm GetProductsForm {
			get {
				if (_productsForm == null) {
					_productsForm = new ProductsForm();
				}

				return _productsForm;
			}
		}

		private void button5_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var productReport = new ProductReport();
			productReport.SetParameterValue("@ID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
			var reportForm = new ReportForm();
			reportForm.crystalReportViewer1.ReportSource = productReport;
			reportForm.ShowDialog();
			Cursor = Cursors.Default;
		}

		private void button6_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var productsReport = new ProductsReport();
			var reportForm = new ReportForm();
			reportForm.crystalReportViewer1.ReportSource = productsReport;
			reportForm.ShowDialog();
			Cursor = Cursors.Default;
		}

		private void button7_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var productsReport = new ProductsReport();
			var destinationOptions = new DiskFileDestinationOptions {
				DiskFileName = @"D:\myProjectTest\Products.xls"
			};
			var exportOptions = productsReport.ExportOptions;
			exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
			exportOptions.ExportFormatType = ExportFormatType.Excel;
			exportOptions.ExportFormatOptions = new ExcelFormatOptions();
			exportOptions.DestinationOptions = destinationOptions;
			productsReport.Export();
			MessageBox.Show("saved successfully");
			Cursor = Cursors.Default;
		}

		private void button8_Click(object sender, EventArgs e) {
			Close();
		}
	}
}