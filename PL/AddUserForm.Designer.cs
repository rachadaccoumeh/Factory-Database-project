using System.ComponentModel;

namespace Factory_Database.PL {
	partial class AddUserForm {
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
	this.cmbType = new System.Windows.Forms.ComboBox();
	this.label5 = new System.Windows.Forms.Label();
	this.txtPWDConfirm = new System.Windows.Forms.TextBox();
	this.label4 = new System.Windows.Forms.Label();
	this.txtPWD = new System.Windows.Forms.TextBox();
	this.label3 = new System.Windows.Forms.Label();
	this.txtFullName = new System.Windows.Forms.TextBox();
	this.label1 = new System.Windows.Forms.Label();
	this.txtID = new System.Windows.Forms.TextBox();
	this.label2 = new System.Windows.Forms.Label();
	this.btnSave = new System.Windows.Forms.Button();
	this.button2 = new System.Windows.Forms.Button();
	this.groupBox1.SuspendLayout();
	this.SuspendLayout();
	// 
	// groupBox1
	// 
	this.groupBox1.Controls.Add(this.cmbType);
	this.groupBox1.Controls.Add(this.label5);
	this.groupBox1.Controls.Add(this.txtPWDConfirm);
	this.groupBox1.Controls.Add(this.label4);
	this.groupBox1.Controls.Add(this.txtPWD);
	this.groupBox1.Controls.Add(this.label3);
	this.groupBox1.Controls.Add(this.txtFullName);
	this.groupBox1.Controls.Add(this.label1);
	this.groupBox1.Controls.Add(this.txtID);
	this.groupBox1.Controls.Add(this.label2);
	this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
	this.groupBox1.Location = new System.Drawing.Point(12, 21);
	this.groupBox1.Name = "groupBox1";
	this.groupBox1.Size = new System.Drawing.Size(368, 222);
	this.groupBox1.TabIndex = 0;
	this.groupBox1.TabStop = false;
	this.groupBox1.Text = "User Information";
	// 
	// cmbType
	// 
	this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
	this.cmbType.FormattingEnabled = true;
	this.cmbType.Items.AddRange(new object[] {"MANAGER", "USER", "ADMIN"});
	this.cmbType.Location = new System.Drawing.Point(153, 157);
	this.cmbType.Name = "cmbType";
	this.cmbType.Size = new System.Drawing.Size(200, 27);
	this.cmbType.TabIndex = 4;
	// 
	// label5
	// 
	this.label5.AutoSize = true;
	this.label5.Location = new System.Drawing.Point(61, 160);
	this.label5.Name = "label5";
	this.label5.Size = new System.Drawing.Size(83, 19);
	this.label5.TabIndex = 11;
	this.label5.Text = "User Type:";
	// 
	// txtPWDConfirm
	// 
	this.txtPWDConfirm.Location = new System.Drawing.Point(153, 127);
	this.txtPWDConfirm.Name = "txtPWDConfirm";
	this.txtPWDConfirm.PasswordChar = '*';
	this.txtPWDConfirm.Size = new System.Drawing.Size(200, 26);
	this.txtPWDConfirm.TabIndex = 3;
	this.txtPWDConfirm.Validated += new System.EventHandler(this.txtPWDConfirm_Validated);
	// 
	// label4
	// 
	this.label4.AutoSize = true;
	this.label4.Location = new System.Drawing.Point(12, 130);
	this.label4.Name = "label4";
	this.label4.Size = new System.Drawing.Size(135, 19);
	this.label4.TabIndex = 10;
	this.label4.Text = "Confirm Password:";
	// 
	// txtPWD
	// 
	this.txtPWD.Location = new System.Drawing.Point(153, 98);
	this.txtPWD.Name = "txtPWD";
	this.txtPWD.PasswordChar = '*';
	this.txtPWD.Size = new System.Drawing.Size(200, 26);
	this.txtPWD.TabIndex = 2;
	// 
	// label3
	// 
	this.label3.AutoSize = true;
	this.label3.Location = new System.Drawing.Point(67, 101);
	this.label3.Name = "label3";
	this.label3.Size = new System.Drawing.Size(77, 19);
	this.label3.TabIndex = 8;
	this.label3.Text = "Password:";
	// 
	// txtFullName
	// 
	this.txtFullName.Location = new System.Drawing.Point(153, 69);
	this.txtFullName.Name = "txtFullName";
	this.txtFullName.Size = new System.Drawing.Size(200, 26);
	this.txtFullName.TabIndex = 1;
	// 
	// label1
	// 
	this.label1.AutoSize = true;
	this.label1.Location = new System.Drawing.Point(61, 72);
	this.label1.Name = "label1";
	this.label1.Size = new System.Drawing.Size(83, 19);
	this.label1.TabIndex = 6;
	this.label1.Text = "Full Name:";
	// 
	// txtID
	// 
	this.txtID.Location = new System.Drawing.Point(153, 40);
	this.txtID.Name = "txtID";
	this.txtID.Size = new System.Drawing.Size(200, 26);
	this.txtID.TabIndex = 0;
	// 
	// label2
	// 
	this.label2.AutoSize = true;
	this.label2.Location = new System.Drawing.Point(80, 43);
	this.label2.Name = "label2";
	this.label2.Size = new System.Drawing.Size(64, 19);
	this.label2.TabIndex = 4;
	this.label2.Text = "User Id:";
	// 
	// btnSave
	// 
	this.btnSave.Location = new System.Drawing.Point(38, 259);
	this.btnSave.Name = "btnSave";
	this.btnSave.Size = new System.Drawing.Size(110, 23);
	this.btnSave.TabIndex = 0;
	this.btnSave.Text = "Save User";
	this.btnSave.UseVisualStyleBackColor = true;
	this.btnSave.Click += new System.EventHandler(this.button1_Click);
	// 
	// button2
	// 
	this.button2.Location = new System.Drawing.Point(238, 259);
	this.button2.Name = "button2";
	this.button2.Size = new System.Drawing.Size(110, 23);
	this.button2.TabIndex = 1;
	this.button2.Text = "Exit";
	this.button2.UseVisualStyleBackColor = true;
	this.button2.Click += new System.EventHandler(this.button2_Click);
	// 
	// AddUserForm
	// 
	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	this.ClientSize = new System.Drawing.Size(392, 307);
	this.Controls.Add(this.button2);
	this.Controls.Add(this.btnSave);
	this.Controls.Add(this.groupBox1);
	this.MaximizeBox = false;
	this.Name = "AddUserForm";
	this.RightToLeft = System.Windows.Forms.RightToLeft.No;
	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	this.Text = "Add New User";
	this.Load += new System.EventHandler(this.AddUserForm_Load);
	this.groupBox1.ResumeLayout(false);
	this.groupBox1.PerformLayout();
	this.ResumeLayout(false);
}

        #endregion

        public  System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtPWDConfirm;
        public  System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPWD;
        public  System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtFullName;
        public  System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtID;
        public  System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbType;
        public  System.Windows.Forms.Label label5;
        public  System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnSave;
	}
}