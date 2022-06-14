using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Factory_Database.Report;

namespace Factory_Database.PL {
	public partial class CategoriesForm : Form {
		private readonly SqlConnection sqlConnection =
			new SqlConnection(@"Server=.\SQLEXPRESS; DATABASE=sales; INTEGRATED SECURITY =TRUE;");

		private SqlDataAdapter _sqlDataAdapter;
		private readonly DataTable _dataTable = new DataTable();
		private BindingManagerBase _bindingManagerBase;
		private SqlCommandBuilder _sqlCommandBuilder;

		public CategoriesForm() {
			InitializeComponent();
		}

		private void CategoriesForm_Load(object sender, EventArgs e) {
			_sqlDataAdapter =
				new SqlDataAdapter("select ID_CAT as 'Category Id', DESCRIPTION_CAT as 'category Name' from CATEGORIES",
					sqlConnection);
			_sqlDataAdapter.Fill(_dataTable);
			dataGridView1.DataSource = _dataTable;
			textBox1.DataBindings.Add("text", _dataTable, "category Id");
			textBox2.DataBindings.Add("text", _dataTable, "category Name");
			_bindingManagerBase = BindingContext[_dataTable];
			_bindingManagerBase.PositionChanged += positionChanged;
			positionChanged(null, null);
		}

		private void positionChanged(object sender, EventArgs e) {
			label3.Text = _bindingManagerBase.Position + 1 + " / " + _bindingManagerBase.Count;
		}


		private void button4_Click(object sender, EventArgs e) {
			_bindingManagerBase.Position = 0;
		}

		private void button3_Click(object sender, EventArgs e) {
			_bindingManagerBase.Position--;
		}

		private void button2_Click(object sender, EventArgs e) {
			_bindingManagerBase.Position++;
		}

		private void button1_Click(object sender, EventArgs e) {
			_bindingManagerBase.Position = _bindingManagerBase.Count;
		}

		private void button9_Click(object sender, EventArgs e) {
			_bindingManagerBase.AddNew();
			button6.Enabled = true;
			button9.Enabled = false;
			textBox1.Text = _dataTable.Rows.Count != 0
				? (Convert.ToInt32(_dataTable.Rows[_dataTable.Rows.Count - 1][0]) + 1).ToString()
				: "0";

			textBox2.Focus();
		}

		private void button6_Click(object sender, EventArgs e) {
			_bindingManagerBase.EndCurrentEdit();
			_sqlCommandBuilder = new SqlCommandBuilder(_sqlDataAdapter);
			_sqlDataAdapter.Update(_dataTable);
			MessageBox.Show("added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
			button6.Enabled = false;
			button9.Enabled = true;
		}

		private void button7_Click(object sender, EventArgs e) {
			_bindingManagerBase.RemoveAt(_bindingManagerBase.Position);
			_bindingManagerBase.EndCurrentEdit();
			_sqlCommandBuilder = new SqlCommandBuilder(_sqlDataAdapter);
			_sqlDataAdapter.Update(_dataTable);
			MessageBox.Show("deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button8_Click(object sender, EventArgs e) {
			_bindingManagerBase.EndCurrentEdit();
			_sqlCommandBuilder = new SqlCommandBuilder(_sqlDataAdapter);
			_sqlDataAdapter.Update(_dataTable);
			MessageBox.Show("Edited successfully", "edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button10_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var crystalReport3 = new CategoriesReport();
			var reportForm = new ReportForm();
			// reportForm.Refresh();
			reportForm.crystalReportViewer1.ReportSource = crystalReport3;
			reportForm.Show();
			Cursor = Cursors.Default;
		}

		private void button5_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var crystalReport4 = new CategoryReport();
			var reportForm = new ReportForm();
			crystalReport4.SetParameterValue("@ID", Convert.ToInt32(textBox1.Text));
			reportForm.crystalReportViewer1.ReportSource = crystalReport4;
			reportForm.Show();
			Cursor = Cursors.Default;
		}

		private void button11_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var crystalReport3 = new CategoriesReport();
			var destinationOptions = new DiskFileDestinationOptions {
				DiskFileName = @"D:\myProjectTest\categoriesList.pdf"
			};
			var exportOptions = crystalReport3.ExportOptions;
			exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
			exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
			exportOptions.ExportFormatOptions = new PdfFormatOptions();
			exportOptions.DestinationOptions = destinationOptions;
			crystalReport3.Export();
			MessageBox.Show("saved successfully");
			Cursor = Cursors.Default;
		}

		private void button12_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var crystalReport4 = new CategoryReport();
			crystalReport4.SetParameterValue("@ID", Convert.ToInt32(textBox1.Text));
			var destinationOptions = new DiskFileDestinationOptions {
				DiskFileName = @"D:\myProjectTest\SelectedCategory.pdf"
			};
			var exportOptions = crystalReport4.ExportOptions;
			exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
			exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
			exportOptions.ExportFormatOptions = new PdfFormatOptions();
			exportOptions.DestinationOptions = destinationOptions;
			crystalReport4.Export();
			MessageBox.Show("saved successfully");
			Cursor = Cursors.Default;
		}
	}
}