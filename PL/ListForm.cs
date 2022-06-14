using System;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class ListForm : Form {
		public ListForm() {
			InitializeComponent();
		}


		private void ProductsListForm_Load(object sender, EventArgs e) {
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e) {
			Close();
		}

	
	}
}