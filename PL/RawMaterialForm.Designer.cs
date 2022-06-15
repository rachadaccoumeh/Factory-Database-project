using System.ComponentModel;

namespace Factory_Database.PL {
	partial class RawMaterialForm {
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
		  this.txtSearch = new System.Windows.Forms.TextBox();
		  this.lblPosition = new System.Windows.Forms.Label();
		  this.label5 = new System.Windows.Forms.Label();
		  this.groupBox2 = new System.Windows.Forms.GroupBox();
		  this.btnSearch = new System.Windows.Forms.Button();
		  this.dgList = new System.Windows.Forms.DataGridView();
		  this.label2 = new System.Windows.Forms.Label();
		  this.groupBox1 = new System.Windows.Forms.GroupBox();
		  this.btnPrevious = new System.Windows.Forms.Button();
		  this.btnLast = new System.Windows.Forms.Button();
		  this.btnFirst = new System.Windows.Forms.Button();
		  this.btnNext = new System.Windows.Forms.Button();
		  this.txtLastName = new System.Windows.Forms.TextBox();
		  this.txtFirstName = new System.Windows.Forms.TextBox();
		  this.label1 = new System.Windows.Forms.Label();
		  this.groupBox3 = new System.Windows.Forms.GroupBox();
		  this.btnEdit = new System.Windows.Forms.Button();
		  this.btnDelete = new System.Windows.Forms.Button();
		  this.btnAdd = new System.Windows.Forms.Button();
		  this.btnNew = new System.Windows.Forms.Button();
		  this.groupBox2.SuspendLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.dgList)).BeginInit();
		  this.groupBox1.SuspendLayout();
		  this.groupBox3.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // txtSearch
		  // 
		  this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.txtSearch.Location = new System.Drawing.Point(60, 19);
		  this.txtSearch.Name = "txtSearch";
		  this.txtSearch.Size = new System.Drawing.Size(209, 20);
		  this.txtSearch.TabIndex = 3;
		  this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
		  // 
		  // lblPosition
		  // 
		  this.lblPosition.AutoSize = true;
		  this.lblPosition.Location = new System.Drawing.Point(134, 133);
		  this.lblPosition.Name = "lblPosition";
		  this.lblPosition.Size = new System.Drawing.Size(30, 13);
		  this.lblPosition.TabIndex = 9;
		  this.lblPosition.Text = "0 / 0";
		  // 
		  // label5
		  // 
		  this.label5.AutoSize = true;
		  this.label5.Location = new System.Drawing.Point(13, 23);
		  this.label5.Name = "label5";
		  this.label5.Size = new System.Drawing.Size(41, 13);
		  this.label5.TabIndex = 2;
		  this.label5.Text = "Search";
		  // 
		  // groupBox2
		  // 
		  this.groupBox2.Controls.Add(this.btnSearch);
		  this.groupBox2.Controls.Add(this.txtSearch);
		  this.groupBox2.Controls.Add(this.label5);
		  this.groupBox2.Controls.Add(this.dgList);
		  this.groupBox2.Location = new System.Drawing.Point(322, 24);
		  this.groupBox2.Name = "groupBox2";
		  this.groupBox2.Size = new System.Drawing.Size(348, 236);
		  this.groupBox2.TabIndex = 11;
		  this.groupBox2.TabStop = false;
		  this.groupBox2.Text = "Raw Materials list";
		  // 
		  // btnSearch
		  // 
		  this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		  this.btnSearch.ImageKey = "find.png";
		  this.btnSearch.Location = new System.Drawing.Point(275, 17);
		  this.btnSearch.Name = "btnSearch";
		  this.btnSearch.Size = new System.Drawing.Size(67, 24);
		  this.btnSearch.TabIndex = 9;
		  this.btnSearch.Text = "seach";
		  this.btnSearch.UseVisualStyleBackColor = true;
		  this.btnSearch.Click += new System.EventHandler(this.button1_Click);
		  // 
		  // dgList
		  // 
		  this.dgList.AllowUserToAddRows = false;
		  this.dgList.AllowUserToDeleteRows = false;
		  this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		  this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		  this.dgList.Location = new System.Drawing.Point(6, 45);
		  this.dgList.MultiSelect = false;
		  this.dgList.Name = "dgList";
		  this.dgList.ReadOnly = true;
		  this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		  this.dgList.Size = new System.Drawing.Size(336, 183);
		  this.dgList.TabIndex = 1;
		  this.dgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellClick);
		  // 
		  // label2
		  // 
		  this.label2.AutoSize = true;
		  this.label2.Location = new System.Drawing.Point(26, 66);
		  this.label2.Name = "label2";
		  this.label2.Size = new System.Drawing.Size(46, 13);
		  this.label2.TabIndex = 2;
		  this.label2.Text = "Quantity";
		  // 
		  // groupBox1
		  // 
		  this.groupBox1.Controls.Add(this.lblPosition);
		  this.groupBox1.Controls.Add(this.btnPrevious);
		  this.groupBox1.Controls.Add(this.btnLast);
		  this.groupBox1.Controls.Add(this.btnFirst);
		  this.groupBox1.Controls.Add(this.btnNext);
		  this.groupBox1.Controls.Add(this.txtLastName);
		  this.groupBox1.Controls.Add(this.label2);
		  this.groupBox1.Controls.Add(this.txtFirstName);
		  this.groupBox1.Controls.Add(this.label1);
		  this.groupBox1.Location = new System.Drawing.Point(23, 24);
		  this.groupBox1.Name = "groupBox1";
		  this.groupBox1.Size = new System.Drawing.Size(293, 171);
		  this.groupBox1.TabIndex = 10;
		  this.groupBox1.TabStop = false;
		  this.groupBox1.Text = "Raw Material Data";
		  // 
		  // btnPrevious
		  // 
		  this.btnPrevious.ImageKey = "resultset_next.png";
		  this.btnPrevious.Location = new System.Drawing.Point(179, 125);
		  this.btnPrevious.Name = "btnPrevious";
		  this.btnPrevious.Size = new System.Drawing.Size(35, 28);
		  this.btnPrevious.TabIndex = 9;
		  this.btnPrevious.Text = ">>";
		  this.btnPrevious.UseVisualStyleBackColor = true;
		  this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
		  // 
		  // btnLast
		  // 
		  this.btnLast.ImageKey = "resultset_first.png";
		  this.btnLast.Location = new System.Drawing.Point(30, 125);
		  this.btnLast.Name = "btnLast";
		  this.btnLast.Size = new System.Drawing.Size(35, 28);
		  this.btnLast.TabIndex = 11;
		  this.btnLast.Text = "|<<";
		  this.btnLast.UseVisualStyleBackColor = true;
		  this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
		  // 
		  // btnFirst
		  // 
		  this.btnFirst.ImageKey = "resultset_last.png";
		  this.btnFirst.Location = new System.Drawing.Point(229, 125);
		  this.btnFirst.Name = "btnFirst";
		  this.btnFirst.Size = new System.Drawing.Size(31, 28);
		  this.btnFirst.TabIndex = 8;
		  this.btnFirst.Text = ">>|";
		  this.btnFirst.UseVisualStyleBackColor = true;
		  this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
		  // 
		  // btnNext
		  // 
		  this.btnNext.ImageKey = "resultset_previous.png";
		  this.btnNext.Location = new System.Drawing.Point(84, 125);
		  this.btnNext.Name = "btnNext";
		  this.btnNext.Size = new System.Drawing.Size(35, 28);
		  this.btnNext.TabIndex = 10;
		  this.btnNext.Text = "<<";
		  this.btnNext.UseVisualStyleBackColor = true;
		  this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
		  // 
		  // txtLastName
		  // 
		  this.txtLastName.Location = new System.Drawing.Point(114, 63);
		  this.txtLastName.Name = "txtLastName";
		  this.txtLastName.Size = new System.Drawing.Size(138, 20);
		  this.txtLastName.TabIndex = 3;
		  this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
		  // 
		  // txtFirstName
		  // 
		  this.txtFirstName.Location = new System.Drawing.Point(114, 29);
		  this.txtFirstName.Name = "txtFirstName";
		  this.txtFirstName.Size = new System.Drawing.Size(138, 20);
		  this.txtFirstName.TabIndex = 1;
		  this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
		  // 
		  // label1
		  // 
		  this.label1.AutoSize = true;
		  this.label1.Location = new System.Drawing.Point(26, 32);
		  this.label1.Name = "label1";
		  this.label1.Size = new System.Drawing.Size(75, 13);
		  this.label1.TabIndex = 0;
		  this.label1.Text = "Material Name";
		  // 
		  // groupBox3
		  // 
		  this.groupBox3.Controls.Add(this.btnEdit);
		  this.groupBox3.Controls.Add(this.btnDelete);
		  this.groupBox3.Controls.Add(this.btnAdd);
		  this.groupBox3.Controls.Add(this.btnNew);
		  this.groupBox3.Location = new System.Drawing.Point(23, 201);
		  this.groupBox3.Name = "groupBox3";
		  this.groupBox3.Size = new System.Drawing.Size(293, 59);
		  this.groupBox3.TabIndex = 12;
		  this.groupBox3.TabStop = false;
		  this.groupBox3.Text = "Available operation";
		  // 
		  // btnEdit
		  // 
		  this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnEdit.ImageKey = "arrow_refresh.png";
		  this.btnEdit.Location = new System.Drawing.Point(221, 19);
		  this.btnEdit.Name = "btnEdit";
		  this.btnEdit.Size = new System.Drawing.Size(63, 27);
		  this.btnEdit.TabIndex = 3;
		  this.btnEdit.Text = "edit";
		  this.btnEdit.UseVisualStyleBackColor = true;
		  this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
		  // 
		  // btnDelete
		  // 
		  this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnDelete.ImageKey = "cancel.png";
		  this.btnDelete.Location = new System.Drawing.Point(143, 19);
		  this.btnDelete.Name = "btnDelete";
		  this.btnDelete.Size = new System.Drawing.Size(72, 27);
		  this.btnDelete.TabIndex = 2;
		  this.btnDelete.Text = "delete";
		  this.btnDelete.UseVisualStyleBackColor = true;
		  this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
		  // 
		  // btnAdd
		  // 
		  this.btnAdd.Enabled = false;
		  this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnAdd.ImageKey = "disk.png";
		  this.btnAdd.Location = new System.Drawing.Point(71, 19);
		  this.btnAdd.Name = "btnAdd";
		  this.btnAdd.Size = new System.Drawing.Size(66, 27);
		  this.btnAdd.TabIndex = 1;
		  this.btnAdd.Text = "add";
		  this.btnAdd.UseVisualStyleBackColor = true;
		  this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
		  // 
		  // btnNew
		  // 
		  this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		  this.btnNew.ImageKey = "add.png";
		  this.btnNew.Location = new System.Drawing.Point(6, 19);
		  this.btnNew.Name = "btnNew";
		  this.btnNew.Size = new System.Drawing.Size(59, 27);
		  this.btnNew.TabIndex = 0;
		  this.btnNew.Text = "new";
		  this.btnNew.UseVisualStyleBackColor = true;
		  this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
		  // 
		  // RawMaterialForm
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(681, 266);
		  this.Controls.Add(this.groupBox2);
		  this.Controls.Add(this.groupBox1);
		  this.Controls.Add(this.groupBox3);
		  this.MaximizeBox = false;
		  this.Name = "RawMaterialForm";
		  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		  this.Text = "Raw Material mangment";
		  this.Load += new System.EventHandler(this.FRM_RawMaterialS_Load);
		  this.groupBox2.ResumeLayout(false);
		  this.groupBox2.PerformLayout();
		  ((System.ComponentModel.ISupportInitialize) (this.dgList)).EndInit();
		  this.groupBox1.ResumeLayout(false);
		  this.groupBox1.PerformLayout();
		  this.groupBox3.ResumeLayout(false);
		  this.ResumeLayout(false);
	  }

        #endregion

        //private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
	}
}