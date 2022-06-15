using System.ComponentModel;

namespace Factory_Database.PL {
	partial class MainForm {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restoreBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.manageRawMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reciepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productionProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addAProductionProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.productToolStripMenuItem, this.customersToolStripMenuItem, this.usersToolStripMenuItem, this.reciepToolStripMenuItem, this.productionProcessToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.logInToolStripMenuItem, this.createBackupToolStripMenuItem, this.restoreBackupToolStripMenuItem, this.logOutToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// logInToolStripMenuItem
			// 
			this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
			this.logInToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.logInToolStripMenuItem.Text = "Log In";
			this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
			// 
			// createBackupToolStripMenuItem
			// 
			this.createBackupToolStripMenuItem.Enabled = false;
			this.createBackupToolStripMenuItem.Name = "createBackupToolStripMenuItem";
			this.createBackupToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.createBackupToolStripMenuItem.Text = "Create Backup";
			this.createBackupToolStripMenuItem.Click += new System.EventHandler(this.createBackupToolStripMenuItem_Click);
			// 
			// restoreBackupToolStripMenuItem
			// 
			this.restoreBackupToolStripMenuItem.Enabled = false;
			this.restoreBackupToolStripMenuItem.Name = "restoreBackupToolStripMenuItem";
			this.restoreBackupToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.restoreBackupToolStripMenuItem.Text = "Restore Backup";
			this.restoreBackupToolStripMenuItem.Click += new System.EventHandler(this.restoreBackupToolStripMenuItem_Click);
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.logOutToolStripMenuItem.Text = "Log Out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// productToolStripMenuItem
			// 
			this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addProductToolStripMenuItem, this.manageProductToolStripMenuItem, this.toolStripSeparator1, this.manageRawMaterialsToolStripMenuItem});
			this.productToolStripMenuItem.Enabled = false;
			this.productToolStripMenuItem.Name = "productToolStripMenuItem";
			this.productToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.productToolStripMenuItem.Text = "&Inverntory";
			// 
			// addProductToolStripMenuItem
			// 
			this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
			this.addProductToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.addProductToolStripMenuItem.Text = "Add New Product";
			this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
			// 
			// manageProductToolStripMenuItem
			// 
			this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
			this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.manageProductToolStripMenuItem.Text = "Manage Products";
			this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
			// 
			// manageRawMaterialsToolStripMenuItem
			// 
			this.manageRawMaterialsToolStripMenuItem.Name = "manageRawMaterialsToolStripMenuItem";
			this.manageRawMaterialsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.manageRawMaterialsToolStripMenuItem.Text = "Manage Raw Materials";
			this.manageRawMaterialsToolStripMenuItem.Click += new System.EventHandler(this.manageRawMaterialsToolStripMenuItem_Click);
			// 
			// customersToolStripMenuItem
			// 
			this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.manageCustomersToolStripMenuItem, this.toolStripSeparator2, this.addNewToolStripMenuItem, this.manageOrderToolStripMenuItem});
			this.customersToolStripMenuItem.Enabled = false;
			this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
			this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.customersToolStripMenuItem.Text = "&Customers";
			// 
			// manageCustomersToolStripMenuItem
			// 
			this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
			this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.manageCustomersToolStripMenuItem.Text = "Manage Customers";
			this.manageCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageCustomersToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
			// 
			// addNewToolStripMenuItem
			// 
			this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
			this.addNewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.addNewToolStripMenuItem.Text = "Add New Order";
			this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
			// 
			// manageOrderToolStripMenuItem
			// 
			this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
			this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.manageOrderToolStripMenuItem.Text = "Manage Orders";
			this.manageOrderToolStripMenuItem.Click += new System.EventHandler(this.manageOrderToolStripMenuItem_Click);
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addNewUserToolStripMenuItem, this.manageUsersToolStripMenuItem});
			this.usersToolStripMenuItem.Enabled = false;
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.usersToolStripMenuItem.Text = "&Users";
			// 
			// addNewUserToolStripMenuItem
			// 
			this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
			this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.addNewUserToolStripMenuItem.Text = "Add New User";
			this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
			// 
			// manageUsersToolStripMenuItem
			// 
			this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
			this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.manageUsersToolStripMenuItem.Text = "Manage Users";
			this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
			// 
			// reciepToolStripMenuItem
			// 
			this.reciepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addNewRecipeToolStripMenuItem});
			this.reciepToolStripMenuItem.Enabled = false;
			this.reciepToolStripMenuItem.Name = "reciepToolStripMenuItem";
			this.reciepToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.reciepToolStripMenuItem.Text = "&Recipe";
			// 
			// addNewRecipeToolStripMenuItem
			// 
			this.addNewRecipeToolStripMenuItem.Name = "addNewRecipeToolStripMenuItem";
			this.addNewRecipeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addNewRecipeToolStripMenuItem.Text = "Manage recipe";
			this.addNewRecipeToolStripMenuItem.Click += new System.EventHandler(this.addNewRecipeToolStripMenuItem_Click);
			// 
			// productionProcessToolStripMenuItem
			// 
			this.productionProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addAProductionProcessToolStripMenuItem});
			this.productionProcessToolStripMenuItem.Enabled = false;
			this.productionProcessToolStripMenuItem.Name = "productionProcessToolStripMenuItem";
			this.productionProcessToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
			this.productionProcessToolStripMenuItem.Text = "&Production process";
			// 
			// addAProductionProcessToolStripMenuItem
			// 
			this.addAProductionProcessToolStripMenuItem.Name = "addAProductionProcessToolStripMenuItem";
			this.addAProductionProcessToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.addAProductionProcessToolStripMenuItem.Text = "Add a production process";
			this.addAProductionProcessToolStripMenuItem.Click += new System.EventHandler(this.addAProductionProcessToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sales Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.ToolStripMenuItem addNewRecipeToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem productionProcessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addAProductionProcessToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem reciepToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem manageRawMaterialsToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem restoreBackupToolStripMenuItem;

		public System.Windows.Forms.ToolStripMenuItem createBackupToolStripMenuItem;

		private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		#endregion
	}
}