using System.ComponentModel;

namespace Factory_Database.PL {
	partial class StatisticsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.File = new System.Windows.Forms.GroupBox();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel13 = new System.Windows.Forms.LinkLabel();
			this.linkLabel11 = new System.Windows.Forms.LinkLabel();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.Users = new System.Windows.Forms.GroupBox();
			this.linkLabel9 = new System.Windows.Forms.LinkLabel();
			this.linkLabel10 = new System.Windows.Forms.LinkLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.linkLabel15 = new System.Windows.Forms.LinkLabel();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.linkLabel17 = new System.Windows.Forms.LinkLabel();
			this.File.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.Users.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// File
			// 
			this.File.Controls.Add(this.linkLabel4);
			this.File.Controls.Add(this.linkLabel3);
			this.File.Controls.Add(this.linkLabel2);
			this.File.Controls.Add(this.linkLabel1);
			this.File.Location = new System.Drawing.Point(12, 12);
			this.File.Name = "File";
			this.File.Size = new System.Drawing.Size(141, 149);
			this.File.TabIndex = 0;
			this.File.TabStop = false;
			this.File.Text = "File";
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Location = new System.Drawing.Point(34, 115);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(40, 13);
			this.linkLabel4.TabIndex = 3;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Logout";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Enabled = false;
			this.linkLabel3.Location = new System.Drawing.Point(34, 87);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(84, 13);
			this.linkLabel3.TabIndex = 2;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Restore Backup";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Enabled = false;
			this.linkLabel2.Location = new System.Drawing.Point(34, 54);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(78, 13);
			this.linkLabel2.TabIndex = 1;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Create Backup";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(34, 26);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(33, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Login";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel13);
			this.groupBox1.Controls.Add(this.linkLabel11);
			this.groupBox1.Controls.Add(this.linkLabel8);
			this.groupBox1.Location = new System.Drawing.Point(159, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 149);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inverntory";
			// 
			// linkLabel13
			// 
			this.linkLabel13.AutoSize = true;
			this.linkLabel13.Enabled = false;
			this.linkLabel13.Location = new System.Drawing.Point(34, 40);
			this.linkLabel13.Name = "linkLabel13";
			this.linkLabel13.Size = new System.Drawing.Size(116, 13);
			this.linkLabel13.TabIndex = 4;
			this.linkLabel13.TabStop = true;
			this.linkLabel13.Text = "Manage Raw Materials";
			this.linkLabel13.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel13_LinkClicked);
			// 
			// linkLabel11
			// 
			this.linkLabel11.AutoSize = true;
			this.linkLabel11.Enabled = false;
			this.linkLabel11.Location = new System.Drawing.Point(34, 115);
			this.linkLabel11.Name = "linkLabel11";
			this.linkLabel11.Size = new System.Drawing.Size(91, 13);
			this.linkLabel11.TabIndex = 2;
			this.linkLabel11.TabStop = true;
			this.linkLabel11.Text = "Manage Products";
			this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);
			// 
			// linkLabel8
			// 
			this.linkLabel8.AutoSize = true;
			this.linkLabel8.Enabled = false;
			this.linkLabel8.Location = new System.Drawing.Point(36, 77);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(89, 13);
			this.linkLabel8.TabIndex = 1;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "Add new Product";
			this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.linkLabel7);
			this.groupBox2.Controls.Add(this.linkLabel6);
			this.groupBox2.Controls.Add(this.linkLabel5);
			this.groupBox2.Location = new System.Drawing.Point(159, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(189, 149);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Customers";
			// 
			// linkLabel7
			// 
			this.linkLabel7.AutoSize = true;
			this.linkLabel7.Enabled = false;
			this.linkLabel7.Location = new System.Drawing.Point(34, 107);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(80, 13);
			this.linkLabel7.TabIndex = 6;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "Manage Orders";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
			// 
			// linkLabel6
			// 
			this.linkLabel6.AutoSize = true;
			this.linkLabel6.Enabled = false;
			this.linkLabel6.Location = new System.Drawing.Point(34, 74);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(80, 13);
			this.linkLabel6.TabIndex = 5;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "Add New Order";
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
			// 
			// linkLabel5
			// 
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.Enabled = false;
			this.linkLabel5.Location = new System.Drawing.Point(34, 42);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(98, 13);
			this.linkLabel5.TabIndex = 4;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "Manage Customers";
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
			// 
			// Users
			// 
			this.Users.Controls.Add(this.linkLabel9);
			this.Users.Controls.Add(this.linkLabel10);
			this.Users.Location = new System.Drawing.Point(12, 167);
			this.Users.Name = "Users";
			this.Users.Size = new System.Drawing.Size(141, 149);
			this.Users.TabIndex = 4;
			this.Users.TabStop = false;
			this.Users.Text = "Users";
			// 
			// linkLabel9
			// 
			this.linkLabel9.AutoSize = true;
			this.linkLabel9.Enabled = false;
			this.linkLabel9.Location = new System.Drawing.Point(34, 87);
			this.linkLabel9.Name = "linkLabel9";
			this.linkLabel9.Size = new System.Drawing.Size(74, 13);
			this.linkLabel9.TabIndex = 2;
			this.linkLabel9.TabStop = true;
			this.linkLabel9.Text = "Manage users";
			this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
			// 
			// linkLabel10
			// 
			this.linkLabel10.AutoSize = true;
			this.linkLabel10.Enabled = false;
			this.linkLabel10.Location = new System.Drawing.Point(34, 54);
			this.linkLabel10.Name = "linkLabel10";
			this.linkLabel10.Size = new System.Drawing.Size(72, 13);
			this.linkLabel10.TabIndex = 1;
			this.linkLabel10.TabStop = true;
			this.linkLabel10.Text = "Add new user";
			this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(368, 350);
			this.dataGridView1.TabIndex = 5;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(354, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(380, 385);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "less amount of Product";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView2);
			this.groupBox4.Location = new System.Drawing.Point(740, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(380, 385);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "less amount of Raw Materials";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(6, 17);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView2.Size = new System.Drawing.Size(368, 350);
			this.dataGridView2.TabIndex = 5;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.linkLabel15);
			this.groupBox5.Location = new System.Drawing.Point(12, 322);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(141, 75);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Recipe";
			// 
			// linkLabel15
			// 
			this.linkLabel15.AutoSize = true;
			this.linkLabel15.Enabled = false;
			this.linkLabel15.Location = new System.Drawing.Point(29, 33);
			this.linkLabel15.Name = "linkLabel15";
			this.linkLabel15.Size = new System.Drawing.Size(83, 13);
			this.linkLabel15.TabIndex = 1;
			this.linkLabel15.TabStop = true;
			this.linkLabel15.Text = "Manage Recipe";
			this.linkLabel15.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel15_LinkClicked);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.linkLabel17);
			this.groupBox6.Location = new System.Drawing.Point(159, 322);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(189, 75);
			this.groupBox6.TabIndex = 8;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "production process";
			// 
			// linkLabel17
			// 
			this.linkLabel17.AutoSize = true;
			this.linkLabel17.Enabled = false;
			this.linkLabel17.Location = new System.Drawing.Point(34, 33);
			this.linkLabel17.Name = "linkLabel17";
			this.linkLabel17.Size = new System.Drawing.Size(128, 13);
			this.linkLabel17.TabIndex = 5;
			this.linkLabel17.TabStop = true;
			this.linkLabel17.Text = "Add a production process";
			this.linkLabel17.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel17_LinkClicked);
			// 
			// StatisticsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(1129, 406);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.Users);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.File);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "StatisticsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StatisticsForm";
			this.Activated += new System.EventHandler(this.StatisticsForm_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatisticsForm_FormClosed);
			this.Load += new System.EventHandler(this.StatisticsForm_Load);
			this.Shown += new System.EventHandler(this.StatisticsForm_Shown);
			this.File.ResumeLayout(false);
			this.File.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.Users.ResumeLayout(false);
			this.Users.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
		}

		public System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.LinkLabel linkLabel17;

		public System.Windows.Forms.GroupBox groupBox5;
		public System.Windows.Forms.LinkLabel linkLabel15;

		public System.Windows.Forms.GroupBox groupBox4;
		public System.Windows.Forms.DataGridView dataGridView2;

		public System.Windows.Forms.GroupBox groupBox3;

		public System.Windows.Forms.DataGridView dataGridView1;

		public System.Windows.Forms.LinkLabel linkLabel13;

		public System.Windows.Forms.LinkLabel linkLabel8;
		public System.Windows.Forms.LinkLabel linkLabel11;

		public System.Windows.Forms.GroupBox Users;
		public System.Windows.Forms.LinkLabel linkLabel9;
		public System.Windows.Forms.LinkLabel linkLabel10;

		public System.Windows.Forms.LinkLabel linkLabel6;
		public System.Windows.Forms.LinkLabel linkLabel7;

		public System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.LinkLabel linkLabel5;

		public  System.Windows.Forms.LinkLabel linkLabel2;
		public  System.Windows.Forms.LinkLabel linkLabel3;
		public  System.Windows.Forms.LinkLabel linkLabel4;

		public  System.Windows.Forms.LinkLabel linkLabel1;

		public System.Windows.Forms.GroupBox File;
		public System.Windows.Forms.GroupBox groupBox1;

		#endregion
	}
}