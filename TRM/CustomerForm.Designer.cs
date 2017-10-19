namespace TRM
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.lvwCustomerInfo = new System.Windows.Forms.ListView();
            this.CustomerNmae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnPay = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNID = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCustomerInfo
            // 
            this.lvwCustomerInfo.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwCustomerInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerNmae,
            this.PhoneNumber,
            this.columnHeader1});
            this.lvwCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCustomerInfo.GridLines = true;
            this.lvwCustomerInfo.Location = new System.Drawing.Point(16, 33);
            this.lvwCustomerInfo.Name = "lvwCustomerInfo";
            this.lvwCustomerInfo.Size = new System.Drawing.Size(612, 474);
            this.lvwCustomerInfo.TabIndex = 152;
            this.lvwCustomerInfo.UseCompatibleStateImageBehavior = false;
            this.lvwCustomerInfo.View = System.Windows.Forms.View.Details;
            // 
            // CustomerNmae
            // 
            this.CustomerNmae.Text = "Customer Name";
            this.CustomerNmae.Width = 204;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Mobile No.";
            this.PhoneNumber.Width = 245;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Due";
            this.columnHeader1.Width = 158;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripLabel4,
            this.btnSave,
            this.toolStripLabel1,
            this.btnUpdate,
            this.toolStripLabel2,
            this.btnDelete,
            this.btnPay,
            this.toolStripLabel3,
            this.btnExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 525);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1051, 52);
            this.bindingNavigator1.TabIndex = 151;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(66, 49);
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(10, 49);
            this.toolStripLabel4.Text = " ";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 40);
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 49);
            this.toolStripLabel1.Text = " ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 49);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 49);
            this.toolStripLabel2.Text = " ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 49);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(72, 49);
            this.btnPay.Text = "Pay";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 49);
            this.toolStripLabel3.Text = " ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 49);
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNID);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(630, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 396);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(253, 241);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 12;
            this.txtCustomerID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "NID";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(147, 171);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 30);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNID
            // 
            this.txtNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNID.Location = new System.Drawing.Point(147, 139);
            this.txtNID.Multiline = true;
            this.txtNID.Name = "txtNID";
            this.txtNID.Size = new System.Drawing.Size(206, 30);
            this.txtNID.TabIndex = 9;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(147, 106);
            this.txtCustomerPhone.Multiline = true;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(206, 30);
            this.txtCustomerPhone.TabIndex = 7;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(147, 73);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(206, 30);
            this.txtCustomerAddress.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(147, 40);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(206, 30);
            this.txtCustomerName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 149;
            this.label1.Text = "Customer Information";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(777, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 30);
            this.textBox1.TabIndex = 154;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 153;
            this.label8.Text = "Search";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 577);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvwCustomerInfo);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwCustomerInfo;
        private System.Windows.Forms.ColumnHeader CustomerNmae;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNID;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}