using System;
using System.Drawing;
using System.Windows.Forms;
using Factory_Database.BL;

namespace Factory_Database.PL {
	public partial class StatisticsForm : Form {
		private static StatisticsForm _statisticsForm;
		private readonly ClsMain _clsMain = new ClsMain();

		public StatisticsForm() {
			InitializeComponent();
		}

		private void StatisticsForm_Load(object sender, EventArgs e) {
			if (_statisticsForm == null) {
				_statisticsForm = this;
			}

			dataGridView1.DataSource = _clsMain.GetLpQty();
			dataGridView2.DataSource = _clsMain.GetLrmQty();
		}

		private void StatisticsForm_Shown(object sender, EventArgs e) {
			for (var i = 0; i < dataGridView1.Rows.Count; i++) {
				if (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()) > 20) continue;
				dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
			}

			for (var i = 0; i < dataGridView2.Rows.Count; i++) {
				if (Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString()) > 20) continue;
				dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Red;
			}
		}


		public static StatisticsForm GetStatisticsForm {
			get {
				if (_statisticsForm == null) {
					_statisticsForm = new StatisticsForm();
				}

				return _statisticsForm;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.logInToolStripMenuItem_Click(null, null);
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.createBackupToolStripMenuItem_Click(null, null);
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.restoreBackupToolStripMenuItem_Click(null, null);
		}

		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.logOutToolStripMenuItem_Click(null, null);
		}

		private void StatisticsForm_FormClosed(object sender, FormClosedEventArgs e) {
			_statisticsForm = null;
		}

		private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.manageUsersToolStripMenuItem_Click(null, null);
		}

		private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.addNewUserToolStripMenuItem_Click(null, null);
		}

		private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.addProductToolStripMenuItem_Click(null, null);
		}

		private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.manageProductToolStripMenuItem_Click(null, null);
		}

		private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.manageCustomersToolStripMenuItem_Click(null, null);
		}

		private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.addNewToolStripMenuItem_Click(null, null);
		}

		private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.manageOrderToolStripMenuItem_Click(null, null);
		}


		private void StatisticsForm_Activated(object sender, EventArgs e) {
			StatisticsForm_Load(null, null);
			StatisticsForm_Shown(null, null);
		}

		private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.manageRawMaterialsToolStripMenuItem_Click(null, null);
		}

		private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.addNewRecipeToolStripMenuItem_Click(null, null);
		}

		private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			MainForm.GetMainForm.addAProductionProcessToolStripMenuItem_Click(null, null);
		}
	}
}