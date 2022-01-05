namespace Presentation
{
    partial class FormContainer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvWarehouse = new System.Windows.Forms.DataGridView();
            this.warehouse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.goods_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnReceived = new System.Windows.Forms.Button();
            this.dgvReceived = new System.Windows.Forms.DataGridView();
            this.received_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received_datereceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received_paymentmethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received_totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_paymentmethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_paymentstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_deliverystatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblWarehouseCount = new System.Windows.Forms.Label();
            this.lblGoodsCount = new System.Windows.Forms.Label();
            this.lblGoodsInStockCount = new System.Windows.Forms.Label();
            this.lblReceivedCount = new System.Windows.Forms.Label();
            this.lblGoodsReceivedCount = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.lblGoodsOrderCount = new System.Windows.Forms.Label();
            this.lblNotDelivery = new System.Windows.Forms.Label();
            this.lblDelivering = new System.Windows.Forms.Label();
            this.lblDelivered = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNotPaid = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceived)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvWarehouse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh mục kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvWarehouse
            // 
            this.dgvWarehouse.AllowUserToAddRows = false;
            this.dgvWarehouse.AllowUserToDeleteRows = false;
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouse_id,
            this.warehouse_name,
            this.warehouse_amount});
            this.dgvWarehouse.Location = new System.Drawing.Point(6, 6);
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.ReadOnly = true;
            this.dgvWarehouse.Size = new System.Drawing.Size(792, 446);
            this.dgvWarehouse.TabIndex = 1;
            // 
            // warehouse_id
            // 
            this.warehouse_id.DataPropertyName = "Id";
            this.warehouse_id.HeaderText = "Mã";
            this.warehouse_id.Name = "warehouse_id";
            this.warehouse_id.ReadOnly = true;
            // 
            // warehouse_name
            // 
            this.warehouse_name.DataPropertyName = "Name";
            this.warehouse_name.HeaderText = "Tên";
            this.warehouse_name.Name = "warehouse_name";
            this.warehouse_name.ReadOnly = true;
            // 
            // warehouse_amount
            // 
            this.warehouse_amount.DataPropertyName = "Amount";
            this.warehouse_amount.HeaderText = "Số lượng hàng";
            this.warehouse_amount.Name = "warehouse_amount";
            this.warehouse_amount.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGoodsName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnAddGoods);
            this.tabPage2.Controls.Add(this.dgvGoods);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh mục sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(87, 8);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(209, 20);
            this.txtGoodsName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sản phẩm";
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Location = new System.Drawing.Point(302, 6);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(75, 23);
            this.btnAddGoods.TabIndex = 3;
            this.btnAddGoods.Text = "Thêm mới";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.AllowUserToDeleteRows = false;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_id,
            this.goods_name,
            this.goods_amount,
            this.goods_delete});
            this.dgvGoods.Location = new System.Drawing.Point(6, 35);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.Size = new System.Drawing.Size(792, 417);
            this.dgvGoods.TabIndex = 2;
            this.dgvGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellClick);
            // 
            // goods_id
            // 
            this.goods_id.DataPropertyName = "Id";
            this.goods_id.HeaderText = "Mã";
            this.goods_id.Name = "goods_id";
            this.goods_id.ReadOnly = true;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "Name";
            this.goods_name.HeaderText = "Tên";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // goods_amount
            // 
            this.goods_amount.DataPropertyName = "Amount";
            this.goods_amount.HeaderText = "Số lượng hàng";
            this.goods_amount.Name = "goods_amount";
            this.goods_amount.ReadOnly = true;
            // 
            // goods_delete
            // 
            this.goods_delete.HeaderText = "Xóa";
            this.goods_delete.Name = "goods_delete";
            this.goods_delete.ReadOnly = true;
            this.goods_delete.Text = "Xóa";
            this.goods_delete.UseColumnTextForButtonValue = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReceived);
            this.tabPage3.Controls.Add(this.dgvReceived);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhập kho";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnReceived
            // 
            this.btnReceived.Location = new System.Drawing.Point(6, 6);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(75, 23);
            this.btnReceived.TabIndex = 7;
            this.btnReceived.Text = "Tạo phiếu";
            this.btnReceived.UseVisualStyleBackColor = true;
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // dgvReceived
            // 
            this.dgvReceived.AllowUserToAddRows = false;
            this.dgvReceived.AllowUserToDeleteRows = false;
            this.dgvReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.received_id,
            this.received_datereceived,
            this.received_paymentmethod,
            this.received_totalamount,
            this.received_detail});
            this.dgvReceived.Location = new System.Drawing.Point(6, 35);
            this.dgvReceived.Name = "dgvReceived";
            this.dgvReceived.ReadOnly = true;
            this.dgvReceived.Size = new System.Drawing.Size(792, 417);
            this.dgvReceived.TabIndex = 6;
            this.dgvReceived.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceived_CellClick);
            // 
            // received_id
            // 
            this.received_id.DataPropertyName = "Id";
            this.received_id.HeaderText = "Mã";
            this.received_id.Name = "received_id";
            this.received_id.ReadOnly = true;
            // 
            // received_datereceived
            // 
            this.received_datereceived.DataPropertyName = "DateReceived";
            this.received_datereceived.HeaderText = "Ngày nhập";
            this.received_datereceived.Name = "received_datereceived";
            this.received_datereceived.ReadOnly = true;
            // 
            // received_paymentmethod
            // 
            this.received_paymentmethod.DataPropertyName = "PaymentMethod";
            this.received_paymentmethod.HeaderText = "Hình thức thanh toán";
            this.received_paymentmethod.Name = "received_paymentmethod";
            this.received_paymentmethod.ReadOnly = true;
            // 
            // received_totalamount
            // 
            this.received_totalamount.DataPropertyName = "TotalAmount";
            this.received_totalamount.HeaderText = "Số lượng hàng";
            this.received_totalamount.Name = "received_totalamount";
            this.received_totalamount.ReadOnly = true;
            // 
            // received_detail
            // 
            this.received_detail.HeaderText = "Chi tiết";
            this.received_detail.Name = "received_detail";
            this.received_detail.ReadOnly = true;
            this.received_detail.Text = "Xem";
            this.received_detail.UseColumnTextForButtonValue = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvOrder);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(804, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Đơn hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.order_customername,
            this.order_paymentmethod,
            this.order_paymentstatus,
            this.order_deliverystatus,
            this.order_detail});
            this.dgvOrder.Location = new System.Drawing.Point(6, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(792, 449);
            this.dgvOrder.TabIndex = 8;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "Id";
            this.order_id.HeaderText = "Mã";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            // 
            // order_customername
            // 
            this.order_customername.DataPropertyName = "CustomerName";
            this.order_customername.HeaderText = "Tên khách hàng";
            this.order_customername.Name = "order_customername";
            this.order_customername.ReadOnly = true;
            // 
            // order_paymentmethod
            // 
            this.order_paymentmethod.DataPropertyName = "PaymentMethod";
            this.order_paymentmethod.HeaderText = "Hình thức thanh toán";
            this.order_paymentmethod.Name = "order_paymentmethod";
            this.order_paymentmethod.ReadOnly = true;
            // 
            // order_paymentstatus
            // 
            this.order_paymentstatus.DataPropertyName = "PaymentStatus";
            this.order_paymentstatus.HeaderText = "Tình trạng thanh toán";
            this.order_paymentstatus.Name = "order_paymentstatus";
            this.order_paymentstatus.ReadOnly = true;
            // 
            // order_deliverystatus
            // 
            this.order_deliverystatus.DataPropertyName = "DeliveryStatus";
            this.order_deliverystatus.HeaderText = "Tình trạng vận chuyển";
            this.order_deliverystatus.Name = "order_deliverystatus";
            this.order_deliverystatus.ReadOnly = true;
            // 
            // order_detail
            // 
            this.order_detail.HeaderText = "Chi tiết";
            this.order_detail.Name = "order_detail";
            this.order_detail.ReadOnly = true;
            this.order_detail.Text = "Xem";
            this.order_detail.UseColumnTextForButtonValue = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(804, 458);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Thống kê";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số hàng tồn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGoodsInStockCount);
            this.groupBox1.Controls.Add(this.lblGoodsCount);
            this.groupBox1.Controls.Add(this.lblWarehouseCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGoodsReceivedCount);
            this.groupBox2.Controls.Add(this.lblReceivedCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(212, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng số phiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng số hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPaid);
            this.groupBox3.Controls.Add(this.lblNotPaid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblDelivered);
            this.groupBox3.Controls.Add(this.lblDelivering);
            this.groupBox3.Controls.Add(this.lblNotDelivery);
            this.groupBox3.Controls.Add(this.lblGoodsOrderCount);
            this.groupBox3.Controls.Add(this.lblOrderCount);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(418, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 116);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tổng số hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chưa vận chuyển:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Đang vận chuyển:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Đã nhận hàng:";
            // 
            // lblWarehouseCount
            // 
            this.lblWarehouseCount.AutoSize = true;
            this.lblWarehouseCount.Location = new System.Drawing.Point(164, 16);
            this.lblWarehouseCount.Name = "lblWarehouseCount";
            this.lblWarehouseCount.Size = new System.Drawing.Size(30, 13);
            this.lblWarehouseCount.TabIndex = 3;
            this.lblWarehouseCount.Text = "Data";
            this.lblWarehouseCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoodsCount
            // 
            this.lblGoodsCount.AutoSize = true;
            this.lblGoodsCount.Location = new System.Drawing.Point(164, 34);
            this.lblGoodsCount.Name = "lblGoodsCount";
            this.lblGoodsCount.Size = new System.Drawing.Size(30, 13);
            this.lblGoodsCount.TabIndex = 4;
            this.lblGoodsCount.Text = "Data";
            this.lblGoodsCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoodsInStockCount
            // 
            this.lblGoodsInStockCount.AutoSize = true;
            this.lblGoodsInStockCount.Location = new System.Drawing.Point(164, 52);
            this.lblGoodsInStockCount.Name = "lblGoodsInStockCount";
            this.lblGoodsInStockCount.Size = new System.Drawing.Size(30, 13);
            this.lblGoodsInStockCount.TabIndex = 5;
            this.lblGoodsInStockCount.Text = "Data";
            this.lblGoodsInStockCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReceivedCount
            // 
            this.lblReceivedCount.AutoSize = true;
            this.lblReceivedCount.Location = new System.Drawing.Point(164, 16);
            this.lblReceivedCount.Name = "lblReceivedCount";
            this.lblReceivedCount.Size = new System.Drawing.Size(30, 13);
            this.lblReceivedCount.TabIndex = 4;
            this.lblReceivedCount.Text = "Data";
            this.lblReceivedCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoodsReceivedCount
            // 
            this.lblGoodsReceivedCount.AutoSize = true;
            this.lblGoodsReceivedCount.Location = new System.Drawing.Point(164, 34);
            this.lblGoodsReceivedCount.Name = "lblGoodsReceivedCount";
            this.lblGoodsReceivedCount.Size = new System.Drawing.Size(30, 13);
            this.lblGoodsReceivedCount.TabIndex = 5;
            this.lblGoodsReceivedCount.Text = "Data";
            this.lblGoodsReceivedCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Location = new System.Drawing.Point(164, 16);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(30, 13);
            this.lblOrderCount.TabIndex = 6;
            this.lblOrderCount.Text = "Data";
            this.lblOrderCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGoodsOrderCount
            // 
            this.lblGoodsOrderCount.AutoSize = true;
            this.lblGoodsOrderCount.Location = new System.Drawing.Point(164, 34);
            this.lblGoodsOrderCount.Name = "lblGoodsOrderCount";
            this.lblGoodsOrderCount.Size = new System.Drawing.Size(30, 13);
            this.lblGoodsOrderCount.TabIndex = 7;
            this.lblGoodsOrderCount.Text = "Data";
            this.lblGoodsOrderCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNotDelivery
            // 
            this.lblNotDelivery.AutoSize = true;
            this.lblNotDelivery.Location = new System.Drawing.Point(164, 52);
            this.lblNotDelivery.Name = "lblNotDelivery";
            this.lblNotDelivery.Size = new System.Drawing.Size(30, 13);
            this.lblNotDelivery.TabIndex = 8;
            this.lblNotDelivery.Text = "Data";
            this.lblNotDelivery.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDelivering
            // 
            this.lblDelivering.AutoSize = true;
            this.lblDelivering.Location = new System.Drawing.Point(164, 70);
            this.lblDelivering.Name = "lblDelivering";
            this.lblDelivering.Size = new System.Drawing.Size(30, 13);
            this.lblDelivering.TabIndex = 9;
            this.lblDelivering.Text = "Data";
            this.lblDelivering.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDelivered
            // 
            this.lblDelivered.AutoSize = true;
            this.lblDelivered.Location = new System.Drawing.Point(164, 88);
            this.lblDelivered.Name = "lblDelivered";
            this.lblDelivered.Size = new System.Drawing.Size(30, 13);
            this.lblDelivered.TabIndex = 10;
            this.lblDelivered.Text = "Data";
            this.lblDelivered.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Chưa thanh toán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Đã thanh toán:";
            // 
            // lblNotPaid
            // 
            this.lblNotPaid.AutoSize = true;
            this.lblNotPaid.Location = new System.Drawing.Point(344, 52);
            this.lblNotPaid.Name = "lblNotPaid";
            this.lblNotPaid.Size = new System.Drawing.Size(30, 13);
            this.lblNotPaid.TabIndex = 13;
            this.lblNotPaid.Text = "Data";
            this.lblNotPaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(344, 70);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(30, 13);
            this.lblPaid.TabIndex = 14;
            this.lblPaid.Text = "Data";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 508);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormContainer";
            this.Text = "FormContainer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceived)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_amount;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_amount;
        private System.Windows.Forms.DataGridViewButtonColumn goods_delete;
        private System.Windows.Forms.Button btnReceived;
        private System.Windows.Forms.DataGridView dgvReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn received_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn received_datereceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn received_paymentmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn received_totalamount;
        private System.Windows.Forms.DataGridViewButtonColumn received_detail;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_paymentmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_paymentstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_deliverystatus;
        private System.Windows.Forms.DataGridViewButtonColumn order_detail;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDelivered;
        private System.Windows.Forms.Label lblDelivering;
        private System.Windows.Forms.Label lblNotDelivery;
        private System.Windows.Forms.Label lblGoodsOrderCount;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGoodsReceivedCount;
        private System.Windows.Forms.Label lblReceivedCount;
        private System.Windows.Forms.Label lblGoodsInStockCount;
        private System.Windows.Forms.Label lblGoodsCount;
        private System.Windows.Forms.Label lblWarehouseCount;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblNotPaid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}