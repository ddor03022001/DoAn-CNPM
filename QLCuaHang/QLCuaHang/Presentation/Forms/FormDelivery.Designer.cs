namespace Presentation.Forms
{
    partial class FormDelivery
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
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nbPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsList_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.goodsList_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_warehouseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGoodsList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nbAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGoods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDeliveryDate.Location = new System.Drawing.Point(289, 40);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(120, 20);
            this.dtDeliveryDate.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(82, 40);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(146, 21);
            this.cbPaymentMethod.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Thanh toán";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(764, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 23);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Tạo phiếu";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nbPrice
            // 
            this.nbPrice.Location = new System.Drawing.Point(444, 13);
            this.nbPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbPrice.Name = "nbPrice";
            this.nbPrice.Size = new System.Drawing.Size(120, 20);
            this.nbPrice.TabIndex = 22;
            this.nbPrice.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Giá";
            // 
            // goodsList_delete
            // 
            this.goodsList_delete.HeaderText = "Xóa";
            this.goodsList_delete.Name = "goodsList_delete";
            this.goodsList_delete.ReadOnly = true;
            this.goodsList_delete.Text = "Xóa";
            this.goodsList_delete.UseColumnTextForButtonValue = true;
            // 
            // goodsList_price
            // 
            this.goodsList_price.HeaderText = "Giá";
            this.goodsList_price.Name = "goodsList_price";
            this.goodsList_price.ReadOnly = true;
            // 
            // goodsList_warehouse
            // 
            this.goodsList_warehouse.HeaderText = "Kho";
            this.goodsList_warehouse.Name = "goodsList_warehouse";
            this.goodsList_warehouse.ReadOnly = true;
            // 
            // goodsList_warehouseid
            // 
            this.goodsList_warehouseid.HeaderText = "Mã kho";
            this.goodsList_warehouseid.Name = "goodsList_warehouseid";
            this.goodsList_warehouseid.ReadOnly = true;
            // 
            // goodsList_amount
            // 
            this.goodsList_amount.HeaderText = "Số lượng";
            this.goodsList_amount.Name = "goodsList_amount";
            this.goodsList_amount.ReadOnly = true;
            // 
            // goodsList_name
            // 
            this.goodsList_name.HeaderText = "Tên";
            this.goodsList_name.Name = "goodsList_name";
            this.goodsList_name.ReadOnly = true;
            // 
            // goodsList_id
            // 
            this.goodsList_id.HeaderText = "Mã";
            this.goodsList_id.Name = "goodsList_id";
            this.goodsList_id.ReadOnly = true;
            // 
            // dgvGoodsList
            // 
            this.dgvGoodsList.AllowUserToAddRows = false;
            this.dgvGoodsList.AllowUserToDeleteRows = false;
            this.dgvGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsList_id,
            this.goodsList_name,
            this.goodsList_amount,
            this.goodsList_warehouseid,
            this.goodsList_warehouse,
            this.goodsList_price,
            this.goodsList_delete});
            this.dgvGoodsList.Location = new System.Drawing.Point(14, 67);
            this.dgvGoodsList.Name = "dgvGoodsList";
            this.dgvGoodsList.ReadOnly = true;
            this.dgvGoodsList.Size = new System.Drawing.Size(842, 238);
            this.dgvGoodsList.TabIndex = 20;
            this.dgvGoodsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsList_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(764, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nbAmount
            // 
            this.nbAmount.Location = new System.Drawing.Point(289, 13);
            this.nbAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbAmount.Name = "nbAmount";
            this.nbAmount.Size = new System.Drawing.Size(120, 20);
            this.nbAmount.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng";
            // 
            // cbGoods
            // 
            this.cbGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Location = new System.Drawing.Point(82, 13);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(146, 21);
            this.cbGoods.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa chỉ nhận hàng";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(515, 41);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(243, 20);
            this.txtAddress.TabIndex = 29;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(602, 13);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(156, 21);
            this.cbWarehouse.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kho";
            // 
            // FormDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 318);
            this.Controls.Add(this.cbWarehouse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDeliveryDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nbPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGoodsList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nbAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGoods);
            this.Controls.Add(this.label1);
            this.Name = "FormDelivery";
            this.Text = "FormDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.nbPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn goodsList_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_warehouseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_id;
        private System.Windows.Forms.DataGridView dgvGoodsList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.Label label7;
    }
}