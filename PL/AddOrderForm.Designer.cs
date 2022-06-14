using System.ComponentModel;

namespace Factory_Database.PL {
	partial class AddOrderForm {
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
		  this.txtCustomerID = new System.Windows.Forms.TextBox();
		  this.label5 = new System.Windows.Forms.Label();
		  this.pbox = new System.Windows.Forms.PictureBox();
		  this.txtEmail = new System.Windows.Forms.TextBox();
		  this.label4 = new System.Windows.Forms.Label();
		  this.txtTel = new System.Windows.Forms.TextBox();
		  this.label3 = new System.Windows.Forms.Label();
		  this.txtLastName = new System.Windows.Forms.TextBox();
		  this.label2 = new System.Windows.Forms.Label();
		  this.txtFirstName = new System.Windows.Forms.TextBox();
		  this.label1 = new System.Windows.Forms.Label();
		  this.groupBox1 = new System.Windows.Forms.GroupBox();
		  this.dtOrder = new System.Windows.Forms.DateTimePicker();
		  this.txtOrderID = new System.Windows.Forms.TextBox();
		  this.label6 = new System.Windows.Forms.Label();
		  this.txtSalesMan = new System.Windows.Forms.TextBox();
		  this.label8 = new System.Windows.Forms.Label();
		  this.label9 = new System.Windows.Forms.Label();
		  this.txtDesOrder = new System.Windows.Forms.TextBox();
		  this.label10 = new System.Windows.Forms.Label();
		  this.groupBox3 = new System.Windows.Forms.GroupBox();
		  this.txtIDproduct = new System.Windows.Forms.TextBox();
		  this.label18 = new System.Windows.Forms.Label();
		  this.txtTotalAmount = new System.Windows.Forms.TextBox();
		  this.label17 = new System.Windows.Forms.Label();
		  this.txtDiscount = new System.Windows.Forms.TextBox();
		  this.label15 = new System.Windows.Forms.Label();
		  this.txtAmount = new System.Windows.Forms.TextBox();
		  this.label16 = new System.Windows.Forms.Label();
		  this.txtQty = new System.Windows.Forms.TextBox();
		  this.label14 = new System.Windows.Forms.Label();
		  this.txtPrice = new System.Windows.Forms.TextBox();
		  this.label13 = new System.Windows.Forms.Label();
		  this.txtNameProduct = new System.Windows.Forms.TextBox();
		  this.label12 = new System.Windows.Forms.Label();
		  this.label11 = new System.Windows.Forms.Label();
		  this.txtSumTotals = new System.Windows.Forms.TextBox();
		  this.label7 = new System.Windows.Forms.Label();
		  this.btnDelete = new System.Windows.Forms.Button();
		  this.dgvProducts = new System.Windows.Forms.DataGridView();
		  this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		  this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
		  this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		  this.ToolStripMenuItemCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
		  this.ToolStripMenuItemDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
		  this.btnBrowse = new System.Windows.Forms.Button();
		  this.btnClose = new System.Windows.Forms.Button();
		  this.btnPrint = new System.Windows.Forms.Button();
		  this.btnAdd = new System.Windows.Forms.Button();
		  this.btnNew = new System.Windows.Forms.Button();
		  this.groupBox2.SuspendLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.pbox)).BeginInit();
		  this.groupBox1.SuspendLayout();
		  this.groupBox3.SuspendLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.dgvProducts)).BeginInit();
		  this.contextMenuStrip1.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // groupBox2
		  // 
		  this.groupBox2.Controls.Add(this.button1);
		  this.groupBox2.Controls.Add(this.txtCustomerID);
		  this.groupBox2.Controls.Add(this.label5);
		  this.groupBox2.Controls.Add(this.pbox);
		  this.groupBox2.Controls.Add(this.txtEmail);
		  this.groupBox2.Controls.Add(this.label4);
		  this.groupBox2.Controls.Add(this.txtTel);
		  this.groupBox2.Controls.Add(this.label3);
		  this.groupBox2.Controls.Add(this.txtLastName);
		  this.groupBox2.Controls.Add(this.label2);
		  this.groupBox2.Controls.Add(this.txtFirstName);
		  this.groupBox2.Controls.Add(this.label1);
		  this.groupBox2.Location = new System.Drawing.Point(451, 12);
		  this.groupBox2.Name = "groupBox2";
		  this.groupBox2.Size = new System.Drawing.Size(427, 195);
		  this.groupBox2.TabIndex = 1;
		  this.groupBox2.TabStop = false;
		  this.groupBox2.Text = "Cusotmer Data";
		  // 
		  // button1
		  // 
		  this.button1.Location = new System.Drawing.Point(246, 30);
		  this.button1.Name = "button1";
		  this.button1.Size = new System.Drawing.Size(48, 23);
		  this.button1.TabIndex = 11;
		  this.button1.Text = "...";
		  this.button1.UseVisualStyleBackColor = true;
		  this.button1.Click += new System.EventHandler(this.button1_Click);
		  // 
		  // txtCustomerID
		  // 
		  this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtCustomerID.Location = new System.Drawing.Point(121, 30);
		  this.txtCustomerID.Name = "txtCustomerID";
		  this.txtCustomerID.ReadOnly = true;
		  this.txtCustomerID.Size = new System.Drawing.Size(118, 23);
		  this.txtCustomerID.TabIndex = 0;
		  // 
		  // label5
		  // 
		  this.label5.AutoSize = true;
		  this.label5.Location = new System.Drawing.Point(14, 32);
		  this.label5.Name = "label5";
		  this.label5.Size = new System.Drawing.Size(91, 17);
		  this.label5.TabIndex = 9;
		  this.label5.Text = "Customer Id:";
		  // 
		  // pbox
		  // 
		  this.pbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
		  this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.pbox.Cursor = System.Windows.Forms.Cursors.Hand;
		  this.pbox.Location = new System.Drawing.Point(300, 33);
		  this.pbox.Name = "pbox";
		  this.pbox.Size = new System.Drawing.Size(110, 141);
		  this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		  this.pbox.TabIndex = 8;
		  this.pbox.TabStop = false;
		  // 
		  // txtEmail
		  // 
		  this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtEmail.Location = new System.Drawing.Point(122, 151);
		  this.txtEmail.Name = "txtEmail";
		  this.txtEmail.ReadOnly = true;
		  this.txtEmail.Size = new System.Drawing.Size(172, 23);
		  this.txtEmail.TabIndex = 4;
		  // 
		  // label4
		  // 
		  this.label4.AutoSize = true;
		  this.label4.Location = new System.Drawing.Point(57, 151);
		  this.label4.Name = "label4";
		  this.label4.Size = new System.Drawing.Size(48, 17);
		  this.label4.TabIndex = 6;
		  this.label4.Text = "Email:";
		  // 
		  // txtTel
		  // 
		  this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtTel.Location = new System.Drawing.Point(122, 122);
		  this.txtTel.Name = "txtTel";
		  this.txtTel.ReadOnly = true;
		  this.txtTel.Size = new System.Drawing.Size(172, 23);
		  this.txtTel.TabIndex = 3;
		  // 
		  // label3
		  // 
		  this.label3.AutoSize = true;
		  this.label3.Location = new System.Drawing.Point(54, 124);
		  this.label3.Name = "label3";
		  this.label3.Size = new System.Drawing.Size(51, 17);
		  this.label3.TabIndex = 4;
		  this.label3.Text = "Phone:";
		  // 
		  // txtLastName
		  // 
		  this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtLastName.Location = new System.Drawing.Point(122, 93);
		  this.txtLastName.Name = "txtLastName";
		  this.txtLastName.ReadOnly = true;
		  this.txtLastName.Size = new System.Drawing.Size(172, 23);
		  this.txtLastName.TabIndex = 2;
		  // 
		  // label2
		  // 
		  this.label2.AutoSize = true;
		  this.label2.Location = new System.Drawing.Point(27, 97);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(78, 17);
		  this.label2.TabIndex = 2;
		  this.label2.Text = "Last name:";
		  // 
		  // txtFirstName
		  // 
		  this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtFirstName.Location = new System.Drawing.Point(122, 64);
		  this.txtFirstName.Name = "txtFirstName";
		  this.txtFirstName.ReadOnly = true;
		  this.txtFirstName.Size = new System.Drawing.Size(172, 23);
		  this.txtFirstName.TabIndex = 1;
		  // 
		  // label1
		  // 
		  this.label1.AutoSize = true;
		  this.label1.Location = new System.Drawing.Point(24, 64);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(81, 17);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "First Name:";
		  // 
		  // groupBox1
		  // 
		  this.groupBox1.Controls.Add(this.dtOrder);
		  this.groupBox1.Controls.Add(this.txtOrderID);
		  this.groupBox1.Controls.Add(this.label6);
		  this.groupBox1.Controls.Add(this.txtSalesMan);
		  this.groupBox1.Controls.Add(this.label8);
		  this.groupBox1.Controls.Add(this.label9);
		  this.groupBox1.Controls.Add(this.txtDesOrder);
		  this.groupBox1.Controls.Add(this.label10);
		  this.groupBox1.Location = new System.Drawing.Point(12, 12);
		  this.groupBox1.Name = "groupBox1";
		  this.groupBox1.Size = new System.Drawing.Size(427, 195);
		  this.groupBox1.TabIndex = 0;
		  this.groupBox1.TabStop = false;
		  this.groupBox1.Text = "Bill Information";
		  // 
		  // dtOrder
		  // 
		  this.dtOrder.Location = new System.Drawing.Point(148, 118);
		  this.dtOrder.Name = "dtOrder";
		  this.dtOrder.Size = new System.Drawing.Size(262, 23);
		  this.dtOrder.TabIndex = 2;
		  // 
		  // txtOrderID
		  // 
		  this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtOrderID.Location = new System.Drawing.Point(148, 32);
		  this.txtOrderID.Name = "txtOrderID";
		  this.txtOrderID.ReadOnly = true;
		  this.txtOrderID.Size = new System.Drawing.Size(118, 23);
		  this.txtOrderID.TabIndex = 0;
		  // 
		  // label6
		  // 
		  this.label6.AutoSize = true;
		  this.label6.Location = new System.Drawing.Point(74, 32);
		  this.label6.Name = "label6";
		  this.label6.Size = new System.Drawing.Size(51, 17);
		  this.label6.TabIndex = 9;
		  this.label6.Text = "Bill Id:";
		  // 
		  // txtSalesMan
		  // 
		  this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtSalesMan.Location = new System.Drawing.Point(148, 147);
		  this.txtSalesMan.Name = "txtSalesMan";
		  this.txtSalesMan.ReadOnly = true;
		  this.txtSalesMan.Size = new System.Drawing.Size(172, 23);
		  this.txtSalesMan.TabIndex = 3;
		  // 
		  // label8
		  // 
		  this.label8.AutoSize = true;
		  this.label8.Location = new System.Drawing.Point(19, 151);
		  this.label8.Name = "label8";
		  this.label8.Size = new System.Drawing.Size(113, 17);
		  this.label8.TabIndex = 4;
		  this.label8.Text = "Customer Name:";
		  // 
		  // label9
		  // 
		  this.label9.AutoSize = true;
		  this.label9.Location = new System.Drawing.Point(45, 118);
		  this.label9.Name = "label9";
		  this.label9.Size = new System.Drawing.Size(83, 17);
		  this.label9.TabIndex = 2;
		  this.label9.Text = "Order Date:";
		  // 
		  // txtDesOrder
		  // 
		  this.txtDesOrder.Location = new System.Drawing.Point(148, 64);
		  this.txtDesOrder.Multiline = true;
		  this.txtDesOrder.Name = "txtDesOrder";
		  this.txtDesOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		  this.txtDesOrder.Size = new System.Drawing.Size(262, 48);
		  this.txtDesOrder.TabIndex = 1;
		  // 
		  // label10
		  // 
		  this.label10.AutoSize = true;
		  this.label10.Location = new System.Drawing.Point(17, 66);
		  this.label10.Name = "label10";
		  this.label10.Size = new System.Drawing.Size(108, 17);
		  this.label10.TabIndex = 0;
		  this.label10.Text = "Bill Description:";
		  // 
		  // groupBox3
		  // 
		  this.groupBox3.Controls.Add(this.txtIDproduct);
		  this.groupBox3.Controls.Add(this.label18);
		  this.groupBox3.Controls.Add(this.txtTotalAmount);
		  this.groupBox3.Controls.Add(this.label17);
		  this.groupBox3.Controls.Add(this.txtDiscount);
		  this.groupBox3.Controls.Add(this.label15);
		  this.groupBox3.Controls.Add(this.txtAmount);
		  this.groupBox3.Controls.Add(this.label16);
		  this.groupBox3.Controls.Add(this.txtQty);
		  this.groupBox3.Controls.Add(this.label14);
		  this.groupBox3.Controls.Add(this.txtPrice);
		  this.groupBox3.Controls.Add(this.label13);
		  this.groupBox3.Controls.Add(this.txtNameProduct);
		  this.groupBox3.Controls.Add(this.label12);
		  this.groupBox3.Controls.Add(this.label11);
		  this.groupBox3.Controls.Add(this.txtSumTotals);
		  this.groupBox3.Controls.Add(this.label7);
		  this.groupBox3.Controls.Add(this.btnDelete);
		  this.groupBox3.Controls.Add(this.dgvProducts);
		  this.groupBox3.Controls.Add(this.btnBrowse);
		  this.groupBox3.Location = new System.Drawing.Point(12, 219);
		  this.groupBox3.Name = "groupBox3";
		  this.groupBox3.Size = new System.Drawing.Size(866, 225);
		  this.groupBox3.TabIndex = 2;
		  this.groupBox3.TabStop = false;
		  this.groupBox3.Text = "products";
		  // 
		  // txtIDproduct
		  // 
		  this.txtIDproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtIDproduct.Location = new System.Drawing.Point(677, 49);
		  this.txtIDproduct.Name = "txtIDproduct";
		  this.txtIDproduct.ReadOnly = true;
		  this.txtIDproduct.Size = new System.Drawing.Size(99, 23);
		  this.txtIDproduct.TabIndex = 1;
		  this.txtIDproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  // 
		  // label18
		  // 
		  this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label18.Location = new System.Drawing.Point(775, 23);
		  this.label18.Name = "label18";
		  this.label18.Padding = new System.Windows.Forms.Padding(3);
		  this.label18.Size = new System.Drawing.Size(85, 27);
		  this.label18.TabIndex = 24;
		  this.label18.Text = "Choose";
		  this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtTotalAmount
		  // 
		  this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtTotalAmount.Location = new System.Drawing.Point(7, 49);
		  this.txtTotalAmount.Name = "txtTotalAmount";
		  this.txtTotalAmount.ReadOnly = true;
		  this.txtTotalAmount.Size = new System.Drawing.Size(121, 23);
		  this.txtTotalAmount.TabIndex = 7;
		  this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  // 
		  // label17
		  // 
		  this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label17.Location = new System.Drawing.Point(7, 23);
		  this.label17.Name = "label17";
		  this.label17.Padding = new System.Windows.Forms.Padding(3);
		  this.label17.Size = new System.Drawing.Size(121, 27);
		  this.label17.TabIndex = 22;
		  this.label17.Text = "Amount";
		  this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtDiscount
		  // 
		  this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtDiscount.Location = new System.Drawing.Point(127, 49);
		  this.txtDiscount.MaxLength = 3;
		  this.txtDiscount.Name = "txtDiscount";
		  this.txtDiscount.Size = new System.Drawing.Size(93, 23);
		  this.txtDiscount.TabIndex = 6;
		  this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
		  this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
		  this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
		  // 
		  // label15
		  // 
		  this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label15.Location = new System.Drawing.Point(127, 23);
		  this.label15.Name = "label15";
		  this.label15.Padding = new System.Windows.Forms.Padding(3);
		  this.label15.Size = new System.Drawing.Size(93, 27);
		  this.label15.TabIndex = 20;
		  this.label15.Text = "Discount (%)";
		  this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtAmount
		  // 
		  this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtAmount.Location = new System.Drawing.Point(219, 49);
		  this.txtAmount.Name = "txtAmount";
		  this.txtAmount.ReadOnly = true;
		  this.txtAmount.Size = new System.Drawing.Size(85, 23);
		  this.txtAmount.TabIndex = 5;
		  this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  // 
		  // label16
		  // 
		  this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label16.Location = new System.Drawing.Point(219, 23);
		  this.label16.Name = "label16";
		  this.label16.Padding = new System.Windows.Forms.Padding(3);
		  this.label16.Size = new System.Drawing.Size(85, 27);
		  this.label16.TabIndex = 18;
		  this.label16.Text = "Amount";
		  this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtQty
		  // 
		  this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtQty.Location = new System.Drawing.Point(303, 49);
		  this.txtQty.MaxLength = 8;
		  this.txtQty.Name = "txtQty";
		  this.txtQty.Size = new System.Drawing.Size(93, 23);
		  this.txtQty.TabIndex = 4;
		  this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
		  this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
		  this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
		  // 
		  // label14
		  // 
		  this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label14.Location = new System.Drawing.Point(303, 23);
		  this.label14.Name = "label14";
		  this.label14.Padding = new System.Windows.Forms.Padding(3);
		  this.label14.Size = new System.Drawing.Size(93, 27);
		  this.label14.TabIndex = 16;
		  this.label14.Text = "Quantity";
		  this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtPrice
		  // 
		  this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtPrice.Location = new System.Drawing.Point(395, 49);
		  this.txtPrice.MaxLength = 8;
		  this.txtPrice.Name = "txtPrice";
		  this.txtPrice.Size = new System.Drawing.Size(85, 23);
		  this.txtPrice.TabIndex = 3;
		  this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		  this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
		  this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
		  this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
		  // 
		  // label13
		  // 
		  this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label13.Location = new System.Drawing.Point(395, 23);
		  this.label13.Name = "label13";
		  this.label13.Padding = new System.Windows.Forms.Padding(3);
		  this.label13.Size = new System.Drawing.Size(85, 27);
		  this.label13.TabIndex = 14;
		  this.label13.Text = "Price";
		  this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtNameProduct
		  // 
		  this.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtNameProduct.Location = new System.Drawing.Point(479, 49);
		  this.txtNameProduct.Name = "txtNameProduct";
		  this.txtNameProduct.ReadOnly = true;
		  this.txtNameProduct.Size = new System.Drawing.Size(199, 23);
		  this.txtNameProduct.TabIndex = 2;
		  // 
		  // label12
		  // 
		  this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label12.Location = new System.Drawing.Point(479, 23);
		  this.label12.Name = "label12";
		  this.label12.Padding = new System.Windows.Forms.Padding(3);
		  this.label12.Size = new System.Drawing.Size(199, 27);
		  this.label12.TabIndex = 12;
		  this.label12.Text = "Product name";
		  this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // label11
		  // 
		  this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
		  this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.label11.Location = new System.Drawing.Point(677, 23);
		  this.label11.Name = "label11";
		  this.label11.Padding = new System.Windows.Forms.Padding(3);
		  this.label11.Size = new System.Drawing.Size(99, 27);
		  this.label11.TabIndex = 10;
		  this.label11.Text = "Product ID";
		  this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		  // 
		  // txtSumTotals
		  // 
		  this.txtSumTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtSumTotals.Location = new System.Drawing.Point(61, 198);
		  this.txtSumTotals.Name = "txtSumTotals";
		  this.txtSumTotals.ReadOnly = true;
		  this.txtSumTotals.Size = new System.Drawing.Size(122, 23);
		  this.txtSumTotals.TabIndex = 9;
		  // 
		  // label7
		  // 
		  this.label7.AutoSize = true;
		  this.label7.Location = new System.Drawing.Point(17, 198);
		  this.label7.Name = "label7";
		  this.label7.Size = new System.Drawing.Size(47, 17);
		  this.label7.TabIndex = 8;
		  this.label7.Text = "Total :";
		  // 
		  // btnDelete
		  // 
		  this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnDelete.ImageKey = "cancel.png";
		  this.btnDelete.Location = new System.Drawing.Point(735, 192);
		  this.btnDelete.Name = "btnDelete";
		  this.btnDelete.Size = new System.Drawing.Size(125, 27);
		  this.btnDelete.TabIndex = 4;
		  this.btnDelete.Text = "Delete selected line";
		  this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		  this.btnDelete.UseVisualStyleBackColor = true;
		  this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
		  // 
		  // dgvProducts
		  // 
		  this.dgvProducts.AllowUserToAddRows = false;
		  this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		  this.dgvProducts.ColumnHeadersVisible = false;
		  this.dgvProducts.ContextMenuStrip = this.contextMenuStrip1;
		  this.dgvProducts.Location = new System.Drawing.Point(6, 71);
		  this.dgvProducts.MultiSelect = false;
		  this.dgvProducts.Name = "dgvProducts";
		  this.dgvProducts.ReadOnly = true;
		  this.dgvProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		  this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		  this.dgvProducts.Size = new System.Drawing.Size(854, 116);
		  this.dgvProducts.TabIndex = 2;
		  this.dgvProducts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProducts_RowsRemoved);
		  this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
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
		  this.btnBrowse.Location = new System.Drawing.Point(773, 46);
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
		  this.btnClose.Location = new System.Drawing.Point(612, 450);
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
		  this.btnPrint.Location = new System.Drawing.Point(481, 450);
		  this.btnPrint.Name = "btnPrint";
		  this.btnPrint.Size = new System.Drawing.Size(125, 27);
		  this.btnPrint.TabIndex = 16;
		  this.btnPrint.Text = "Print Bill";
		  this.btnPrint.UseVisualStyleBackColor = true;
		  this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
		  // 
		  // btnAdd
		  // 
		  this.btnAdd.Enabled = false;
		  this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnAdd.ImageKey = "disk.png";
		  this.btnAdd.Location = new System.Drawing.Point(353, 450);
		  this.btnAdd.Name = "btnAdd";
		  this.btnAdd.Size = new System.Drawing.Size(125, 27);
		  this.btnAdd.TabIndex = 15;
		  this.btnAdd.Text = "Save Order";
		  this.btnAdd.UseVisualStyleBackColor = true;
		  this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
		  // 
		  // btnNew
		  // 
		  this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnNew.ImageKey = "add.png";
		  this.btnNew.Location = new System.Drawing.Point(222, 450);
		  this.btnNew.Name = "btnNew";
		  this.btnNew.Size = new System.Drawing.Size(125, 27);
		  this.btnNew.TabIndex = 14;
		  this.btnNew.Text = "New Order";
		  this.btnNew.UseVisualStyleBackColor = true;
		  this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
		  // 
		  // AddOrderForm
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(890, 496);
		  this.Controls.Add(this.btnClose);
		  this.Controls.Add(this.btnPrint);
		  this.Controls.Add(this.btnAdd);
		  this.Controls.Add(this.btnNew);
		  this.Controls.Add(this.groupBox3);
		  this.Controls.Add(this.groupBox1);
		  this.Controls.Add(this.groupBox2);
		  this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
		  this.MaximizeBox = false;
		  this.Name = "AddOrderForm";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Orders Main Screen";
		  this.Load += new System.EventHandler(this.AddOrderForm_Load);
		  this.groupBox2.ResumeLayout(false);
		  this.groupBox2.PerformLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.pbox)).EndInit();
		  this.groupBox1.ResumeLayout(false);
		  this.groupBox1.PerformLayout();
		  this.groupBox3.ResumeLayout(false);
		  this.groupBox3.PerformLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.dgvProducts)).EndInit();
		  this.contextMenuStrip1.ResumeLayout(false);
		  this.ResumeLayout(false);
	  }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalesMan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSumTotals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDproduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCurrentRow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteAll;
	}
}