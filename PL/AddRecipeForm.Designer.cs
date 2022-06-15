using System.ComponentModel;

namespace Factory_Database.PL {
	partial class AddRecipeForm {
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
		  this.components = new System.ComponentModel.Container();
		  this.groupBox2 = new System.Windows.Forms.GroupBox();
		  this.button1 = new System.Windows.Forms.Button();
		  this.txtProductID = new System.Windows.Forms.TextBox();
		  this.label5 = new System.Windows.Forms.Label();
		  this.txtFirstName = new System.Windows.Forms.TextBox();
		  this.label1 = new System.Windows.Forms.Label();
		  this.groupBox3 = new System.Windows.Forms.GroupBox();
		  this.txtIDrawMaterial = new System.Windows.Forms.TextBox();
		  this.label18 = new System.Windows.Forms.Label();
		  this.txtQty = new System.Windows.Forms.TextBox();
		  this.label14 = new System.Windows.Forms.Label();
		  this.txtNamerawMaterial = new System.Windows.Forms.TextBox();
		  this.label12 = new System.Windows.Forms.Label();
		  this.label11 = new System.Windows.Forms.Label();
		  this.dgvrawMaterials = new System.Windows.Forms.DataGridView();
		  this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		  this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
		  this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		  this.ToolStripMenuItemCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
		  this.ToolStripMenuItemDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
		  this.btnBrowse = new System.Windows.Forms.Button();
		  this.btnClose = new System.Windows.Forms.Button();
		  this.btnPrint = new System.Windows.Forms.Button();
		  this.btnAdd = new System.Windows.Forms.Button();
		  this.groupBox2.SuspendLayout();
		  this.groupBox3.SuspendLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.dgvrawMaterials)).BeginInit();
		  this.contextMenuStrip1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // groupBox2
		  // 
		  this.groupBox2.Controls.Add(this.button1);
		  this.groupBox2.Controls.Add(this.txtProductID);
		  this.groupBox2.Controls.Add(this.label5);
		  this.groupBox2.Controls.Add(this.txtFirstName);
		  this.groupBox2.Controls.Add(this.label1);
		  this.groupBox2.Location = new System.Drawing.Point(13, 12);
		  this.groupBox2.Name = "groupBox2";
		  this.groupBox2.Size = new System.Drawing.Size(480, 103);
		  this.groupBox2.TabIndex = 1;
		  this.groupBox2.TabStop = false;
		  this.groupBox2.Text = "Cusotmer Data";
		  // 
		  // button1
		  // 
		  this.button1.Location = new System.Drawing.Point(397, 22);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(48, 23);
		  this.button1.TabIndex = 11;
		  this.button1.Text = "...";
		  this.button1.UseVisualStyleBackColor = true;
		  this.button1.Click += new System.EventHandler(this.button1_Click);
		  // 
		  // txtProductID
		  // 
		  this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtProductID.Location = new System.Drawing.Point(133, 24);
		  this.txtProductID.Name = "txtProductID";
		  this.txtProductID.ReadOnly = true;
		  this.txtProductID.Size = new System.Drawing.Size(258, 23);
		  this.txtProductID.TabIndex = 0;
		  // 
		  // label5
		  // 
		  this.label5.AutoSize = true;
		  this.label5.Location = new System.Drawing.Point(40, 28);
		  this.label5.Name = "label5";
		  this.label5.Size = new System.Drawing.Size(77, 17);
		  this.label5.TabIndex = 9;
		  this.label5.Text = "Product Id:";
		  // 
		  // txtFirstName
		  // 
		  this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtFirstName.Location = new System.Drawing.Point(134, 63);
		  this.txtFirstName.Name = "txtFirstName";
		  this.txtFirstName.ReadOnly = true;
		  this.txtFirstName.Size = new System.Drawing.Size(312, 23);
		  this.txtFirstName.TabIndex = 1;
		  // 
		  // label1
		  // 
		  this.label1.AutoSize = true;
		  this.label1.Location = new System.Drawing.Point(18, 65);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(99, 17);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "Product Name:";
		  // 
		  // groupBox3
		  // 
		  this.groupBox3.Controls.Add(this.txtIDrawMaterial);
		  this.groupBox3.Controls.Add(this.label18);
		  this.groupBox3.Controls.Add(this.txtQty);
		  this.groupBox3.Controls.Add(this.label14);
		  this.groupBox3.Controls.Add(this.txtNamerawMaterial);
		  this.groupBox3.Controls.Add(this.label12);
		  this.groupBox3.Controls.Add(this.label11);
		  this.groupBox3.Controls.Add(this.dgvrawMaterials);
		  this.groupBox3.Controls.Add(this.btnBrowse);
		  this.groupBox3.Location = new System.Drawing.Point(6, 121);
		  this.groupBox3.Name = "groupBox3";
		  this.groupBox3.Size = new System.Drawing.Size(487, 208);
		  this.groupBox3.TabIndex = 2;
		  this.groupBox3.TabStop = false;
		  this.groupBox3.Text = "rawMaterials";
		  // 
		  // txtIDrawMaterial
		  // 
		  this.txtIDrawMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtIDrawMaterial.Location = new System.Drawing.Point(294, 55);
		  this.txtIDrawMaterial.Name = "txtIDrawMaterial";
		  this.txtIDrawMaterial.ReadOnly = true;
		  this.txtIDrawMaterial.Size = new System.Drawing.Size(99, 23);
		  this.txtIDrawMaterial.TabIndex = 1;
		  this.txtIDrawMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  // 
		  // label18
		  // 
		  this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label18.Location = new System.Drawing.Point(392, 29);
		  this.label18.Name = "label18";
		  this.label18.Padding = new System.Windows.Forms.Padding(3);
		  this.label18.Size = new System.Drawing.Size(85, 27);
		  this.label18.TabIndex = 24;
		  this.label18.Text = "Choose";
		  this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtQty
		  // 
		  this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtQty.Location = new System.Drawing.Point(7, 55);
		  this.txtQty.MaxLength = 8;
		  this.txtQty.Name = "txtQty";
		  this.txtQty.Size = new System.Drawing.Size(93, 23);
		  this.txtQty.TabIndex = 4;
		  this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
		  this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
		  // 
		  // label14
		  // 
		  this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label14.Location = new System.Drawing.Point(7, 29);
		  this.label14.Name = "label14";
		  this.label14.Padding = new System.Windows.Forms.Padding(3);
		  this.label14.Size = new System.Drawing.Size(93, 27);
		  this.label14.TabIndex = 16;
		  this.label14.Text = "Quantity";
		  this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtNamerawMaterial
		  // 
		  this.txtNamerawMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtNamerawMaterial.Location = new System.Drawing.Point(96, 55);
		  this.txtNamerawMaterial.Name = "txtNamerawMaterial";
		  this.txtNamerawMaterial.ReadOnly = true;
		  this.txtNamerawMaterial.Size = new System.Drawing.Size(199, 23);
		  this.txtNamerawMaterial.TabIndex = 2;
		  // 
		  // label12
		  // 
		  this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label12.Location = new System.Drawing.Point(96, 29);
		  this.label12.Name = "label12";
		  this.label12.Padding = new System.Windows.Forms.Padding(3);
		  this.label12.Size = new System.Drawing.Size(199, 27);
		  this.label12.TabIndex = 12;
		  this.label12.Text = "rawMaterial name";
		  this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // label11
		  // 
		  this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label11.Location = new System.Drawing.Point(294, 29);
		  this.label11.Name = "label11";
		  this.label11.Padding = new System.Windows.Forms.Padding(3);
		  this.label11.Size = new System.Drawing.Size(99, 27);
		  this.label11.TabIndex = 10;
		  this.label11.Text = "Material ID";
		  this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // dgvrawMaterials
		  // 
		  this.dgvrawMaterials.AllowUserToAddRows = false;
		  this.dgvrawMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		  this.dgvrawMaterials.ColumnHeadersVisible = false;
		  this.dgvrawMaterials.ContextMenuStrip = this.contextMenuStrip1;
		  this.dgvrawMaterials.Location = new System.Drawing.Point(7, 77);
		  this.dgvrawMaterials.MultiSelect = false;
		  this.dgvrawMaterials.Name = "dgvrawMaterials";
		  this.dgvrawMaterials.ReadOnly = true;
		  this.dgvrawMaterials.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		  this.dgvrawMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		  this.dgvrawMaterials.Size = new System.Drawing.Size(470, 116);
		  this.dgvrawMaterials.TabIndex = 2;
		  this.dgvrawMaterials.DoubleClick += new System.EventHandler(this.dgvrawMaterials_DoubleClick);
		  // 
		  // contextMenuStrip1
		  // 
		  this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripMenuItemEdit, this.toolStripSeparator1, this.ToolStripMenuItemCurrentRow, this.ToolStripMenuItemDeleteAll});
		  this.contextMenuStrip1.Name = "contextMenuStrip1";
		  this.contextMenuStrip1.Size = new System.Drawing.Size(176, 76);
		  // 
		  // ToolStripMenuItemEdit
		  // 
		  this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
		  this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(175, 22);
		  this.ToolStripMenuItemEdit.Text = "Edit";
		  this.ToolStripMenuItemEdit.Click += new System.EventHandler(this.ToolStripMenuItem_ClickEdit);
		  // 
		  // toolStripSeparator1
		  // 
		  this.toolStripSeparator1.Name = "toolStripSeparator1";
		  this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
		  // 
		  // ToolStripMenuItemCurrentRow
		  // 
		  this.ToolStripMenuItemCurrentRow.Name = "ToolStripMenuItemCurrentRow";
		  this.ToolStripMenuItemCurrentRow.Size = new System.Drawing.Size(175, 22);
		  this.ToolStripMenuItemCurrentRow.Text = "Delete Current Line";
		  this.ToolStripMenuItemCurrentRow.Click += new System.EventHandler(this.ToolStripMenuItem_ClickDeleteCurrentRow);
		  // 
		  // ToolStripMenuItemDeleteAll
		  // 
		  this.ToolStripMenuItemDeleteAll.Name = "ToolStripMenuItemDeleteAll";
		  this.ToolStripMenuItemDeleteAll.Size = new System.Drawing.Size(175, 22);
		  this.ToolStripMenuItemDeleteAll.Text = "Delete All";
		  this.ToolStripMenuItemDeleteAll.Click += new System.EventHandler(this.ToolStripMenuItem_ClickDeleteAll);
		  // 
		  // btnBrowse
		  // 
		  this.btnBrowse.Location = new System.Drawing.Point(390, 52);
		  this.btnBrowse.Name = "btnBrowse";
		  this.btnBrowse.Size = new System.Drawing.Size(88, 27);
		  this.btnBrowse.TabIndex = 0;
		  this.btnBrowse.Text = "...";
		  this.btnBrowse.UseVisualStyleBackColor = true;
		  this.btnBrowse.Click += new System.EventHandler(this.button2_Click);
		  // 
		  // btnClose
		  // 
		  this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnClose.ImageKey = "cross.png";
		  this.btnClose.Location = new System.Drawing.Point(369, 335);
		  this.btnClose.Name = "btnClose";
		  this.btnClose.Size = new System.Drawing.Size(90, 27);
		  this.btnClose.TabIndex = 17;
		  this.btnClose.Text = "Exit";
		  this.btnClose.UseVisualStyleBackColor = true;
		  this.btnClose.Click += new System.EventHandler(this.button4_Click);
		  // 
		  // btnPrint
		  // 
		  this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnPrint.ImageKey = "printer.png";
		  this.btnPrint.Location = new System.Drawing.Point(194, 335);
		  this.btnPrint.Name = "btnPrint";
		  this.btnPrint.Size = new System.Drawing.Size(125, 27);
		  this.btnPrint.TabIndex = 16;
		  this.btnPrint.Text = "Print Recipe";
		  this.btnPrint.UseVisualStyleBackColor = true;
		  this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
		  // 
		  // btnAdd
		  // 
		  this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnAdd.ImageKey = "disk.png";
		  this.btnAdd.Location = new System.Drawing.Point(31, 335);
		  this.btnAdd.Name = "btnAdd";
		  this.btnAdd.Size = new System.Drawing.Size(125, 27);
		  this.btnAdd.TabIndex = 15;
		  this.btnAdd.Text = "Save Recipe";
		  this.btnAdd.UseVisualStyleBackColor = true;
		  this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
		  // 
		  // AddRecipeForm
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(505, 370);
		  this.Controls.Add(this.btnClose);
		  this.Controls.Add(this.btnPrint);
		  this.Controls.Add(this.btnAdd);
		  this.Controls.Add(this.groupBox3);
		  this.Controls.Add(this.groupBox2);
		  this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
		  this.MaximizeBox = false;
		  this.Name = "AddRecipeForm";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Orders Main Screen";
		  this.Load += new System.EventHandler(this.AddRecipeForm_Load);
		  this.groupBox2.ResumeLayout(false);
		  this.groupBox2.PerformLayout();
		  this.groupBox3.ResumeLayout(false);
		  this.groupBox3.PerformLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.dgvrawMaterials)).EndInit();
		  this.contextMenuStrip1.ResumeLayout(false);
		  this.ResumeLayout(false);
	  }

	  #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvrawMaterials;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtNamerawMaterial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDrawMaterial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteAll;
	}
}