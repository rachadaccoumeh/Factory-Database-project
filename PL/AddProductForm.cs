using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class AddProductForm : Form {
		private readonly ClsProducts _clsProducts = new ClsProducts();

		public AddProductForm() {
			InitializeComponent();
		}

		private void AddProductForm_Load(object sender, EventArgs e) {
			txtId.Focus();
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			var openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Images |*.JPG; *.PNG; *GIF; *.BMP; ";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (txtId.Text == string.Empty && txtDes.Text == string.Empty && txtPrice.Text == string.Empty &&
			    txtQty.Text == string.Empty) return;
			var memoryStream = new MemoryStream();
			pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
			var byteImage = memoryStream.ToArray();
			if (btnAdd.Text == "Add") {
				_clsProducts.AddProduct(txtDes.Text, txtId.Text, Convert.ToInt32(txtQty.Text), txtPrice.Text,
					byteImage);
				MessageBox.Show("Add success", "product added successfuly", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			} else {
				_clsProducts.UpdateProduct(txtDes.Text, txtId.Text, Convert.ToInt32(txtQty.Text), txtPrice.Text,
					byteImage);
				MessageBox.Show("update success", "product updated successfuly", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				Close();
			}

			ProductsForm.GetProductsForm.dataGridView1.DataSource = _clsProducts.GetAllProducts();
			txtDes.Clear();
			txtId.Clear();
			txtPrice.Clear();
			txtQty.Clear();
			pictureBox1.Image = null;
		}

		private void txtId_Validated(object sender, EventArgs e) {
			var dataTable = _clsProducts.VerifyProductId(((TextBox) sender).Text);
			if (btnAdd.Text != "Add") return;
			if (dataTable.Rows.Count <= 0) return;
			MessageBox.Show("id already available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			((TextBox) sender).Focus();
			((TextBox) sender).SelectionStart = 0;
			((TextBox) sender).SelectionLength = ((TextBox) sender).TextLength;
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void txtQty_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
				e.Handled = true;
			}
		}
	}
}