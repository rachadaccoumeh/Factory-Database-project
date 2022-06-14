using System.ComponentModel;

namespace Factory_Database.PL {
	partial class CategoriesForm {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(483, 252);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "categories data";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(244, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "0/0";
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.Location = new System.Drawing.Point(87, 204);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(33, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "||<<";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(143, 204);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(33, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "<<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(339, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(33, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = ">>";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(394, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = ">>||";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(173, 97);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(283, 84);
			this.textBox2.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(173, 59);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "category Description:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "category ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button12);
			this.groupBox2.Controls.Add(this.button11);
			this.groupBox2.Controls.Add(this.button10);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Location = new System.Drawing.Point(12, 275);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(482, 58);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Available Operation";
			// 
			// button12
			// 
			this.button12.AutoSize = true;
			this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button12.Location = new System.Drawing.Point(333, 19);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(83, 23);
			this.button12.TabIndex = 8;
			this.button12.Text = "save selected";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button11
			// 
			this.button11.AutoSize = true;
			this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button11.Location = new System.Drawing.Point(420, 19);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(56, 23);
			this.button11.TabIndex = 7;
			this.button11.Text = "save all ";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button10
			// 
			this.button10.AutoSize = true;
			this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button10.Location = new System.Drawing.Point(277, 19);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(50, 23);
			this.button10.TabIndex = 6;
			this.button10.Text = "print all";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button5.Location = new System.Drawing.Point(191, 19);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(80, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "print selected";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button9
			// 
			this.button9.AutoSize = true;
			this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button9.Location = new System.Drawing.Point(144, 19);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(39, 23);
			this.button9.TabIndex = 4;
			this.button9.Text = "New";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.AutoSize = true;
			this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button8.Location = new System.Drawing.Point(103, 19);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(35, 23);
			this.button8.TabIndex = 3;
			this.button8.Text = "Edit";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button7.Location = new System.Drawing.Point(49, 19);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 23);
			this.button7.TabIndex = 2;
			this.button7.Text = "Delete";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(7, 19);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(36, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "Add";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(13, 339);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(483, 177);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Categories List";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(471, 155);
			this.dataGridView1.TabIndex = 0;
			// 
			// CategoriesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 528);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "CategoriesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CategoriesForm";
			this.Load += new System.EventHandler(this.CategoriesForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button button12;

		private System.Windows.Forms.Button button11;

		private System.Windows.Forms.Button button10;

		private System.Windows.Forms.Button button5;

		private System.Windows.Forms.DataGridView dataGridView1;

		private System.Windows.Forms.GroupBox groupBox3;

		private System.Windows.Forms.Button button9;

		private System.Windows.Forms.Button button8;

		private System.Windows.Forms.Button button7;

		private System.Windows.Forms.Button button6;

		private System.Windows.Forms.GroupBox groupBox2;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;

		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.TextBox textBox2;

		private System.Windows.Forms.TextBox textBox1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.GroupBox groupBox1;

		#endregion
	}
}