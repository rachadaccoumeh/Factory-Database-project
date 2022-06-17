using System.ComponentModel;

namespace Factory_Database.PL {
	partial class ProductionProcessForm {
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvrawMaterials = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dgvrawMaterials)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvrawMaterials);
			this.groupBox3.Location = new System.Drawing.Point(5, 158);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(487, 208);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "rawMaterials";
			// 
			// dgvrawMaterials
			// 
			this.dgvrawMaterials.AllowUserToAddRows = false;
			this.dgvrawMaterials.AllowUserToDeleteRows = false;
			this.dgvrawMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvrawMaterials.ColumnHeadersVisible = false;
			this.dgvrawMaterials.Location = new System.Drawing.Point(7, 19);
			this.dgvrawMaterials.MultiSelect = false;
			this.dgvrawMaterials.Name = "dgvrawMaterials";
			this.dgvrawMaterials.ReadOnly = true;
			this.dgvrawMaterials.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvrawMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvrawMaterials.Size = new System.Drawing.Size(470, 174);
			this.dgvrawMaterials.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.txtProductID);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtFirstName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 140);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cusotmer Data";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(133, 106);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(312, 20);
			this.textBox1.TabIndex = 13;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Quantity:";
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
			this.txtProductID.Size = new System.Drawing.Size(258, 20);
			this.txtProductID.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Product Id:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstName.Location = new System.Drawing.Point(134, 63);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.ReadOnly = true;
			this.txtFirstName.Size = new System.Drawing.Size(312, 20);
			this.txtFirstName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Name:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(318, 379);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 22);
			this.button2.TabIndex = 5;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(85, 379);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(91, 22);
			this.button3.TabIndex = 6;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ProductionProcessForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 410);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Name = "ProductionProcessForm";
			this.Text = "ProductionProcessForm";
			this.Load += new System.EventHandler(this.ProductionProcessForm_Load);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.dgvrawMaterials)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvrawMaterials;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;

		private System.Windows.Forms.Label label1;

		#endregion
	}
}