using System;
using System.Windows.Forms;
using Factory_Database.BL;
using Factory_Database.Report;

namespace Factory_Database.PL {
	public partial class OrdersForm : Form {
		private ClsOrders _clsOrders = new ClsOrders();

		public OrdersForm() {
			InitializeComponent();
		}

		private void OrdersForm_Load(object sender, EventArgs e) {
			dgvOrders.DataSource = _clsOrders.SearchOrders("");
		}

		private void button2_Click(object sender, EventArgs e) {
			Close();
		}

		private void button1_Click(object sender, EventArgs e) {
			Cursor = Cursors.WaitCursor;
			var orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value);
			var report = new BillReport();
			var frm = new ReportForm();
			report.SetDataSource(_clsOrders.GetOrderDetails(orderId));
			frm.crystalReportViewer1.ReportSource = report;
			frm.ShowDialog();
			Cursor = Cursors.Default;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e) {
			dgvOrders.DataSource = _clsOrders.SearchOrders(txtSearch.Text);
		}
	}
}