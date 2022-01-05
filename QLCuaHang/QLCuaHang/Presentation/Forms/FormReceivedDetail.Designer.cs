namespace Presentation.Forms
{
    partial class FormReceivedDetail
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGoodsList = new System.Windows.Forms.DataGridView();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.goodsList_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_warehouseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Thanh toán:";
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
            this.goodsList_price});
            this.dgvGoodsList.Location = new System.Drawing.Point(22, 36);
            this.dgvGoodsList.Name = "dgvGoodsList";
            this.dgvGoodsList.ReadOnly = true;
            this.dgvGoodsList.Size = new System.Drawing.Size(842, 238);
            this.dgvGoodsList.TabIndex = 20;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(89, 12);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(65, 13);
            this.lblPaymentMethod.TabIndex = 28;
            this.lblPaymentMethod.Text = "Thanh toán:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(282, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "Ngày:";
            // 
            // goodsList_id
            // 
            this.goodsList_id.DataPropertyName = "Id";
            this.goodsList_id.HeaderText = "Mã";
            this.goodsList_id.Name = "goodsList_id";
            this.goodsList_id.ReadOnly = true;
            // 
            // goodsList_name
            // 
            this.goodsList_name.DataPropertyName = "Name";
            this.goodsList_name.HeaderText = "Tên";
            this.goodsList_name.Name = "goodsList_name";
            this.goodsList_name.ReadOnly = true;
            // 
            // goodsList_amount
            // 
            this.goodsList_amount.DataPropertyName = "Amount";
            this.goodsList_amount.HeaderText = "Số lượng";
            this.goodsList_amount.Name = "goodsList_amount";
            this.goodsList_amount.ReadOnly = true;
            // 
            // goodsList_warehouseid
            // 
            this.goodsList_warehouseid.DataPropertyName = "WarehouseId";
            this.goodsList_warehouseid.HeaderText = "Mã kho";
            this.goodsList_warehouseid.Name = "goodsList_warehouseid";
            this.goodsList_warehouseid.ReadOnly = true;
            // 
            // goodsList_warehouse
            // 
            this.goodsList_warehouse.DataPropertyName = "Warehouse";
            this.goodsList_warehouse.HeaderText = "Kho";
            this.goodsList_warehouse.Name = "goodsList_warehouse";
            this.goodsList_warehouse.ReadOnly = true;
            // 
            // goodsList_price
            // 
            this.goodsList_price.DataPropertyName = "Price";
            this.goodsList_price.HeaderText = "Giá";
            this.goodsList_price.Name = "goodsList_price";
            this.goodsList_price.ReadOnly = true;
            // 
            // FormReceivedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 283);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvGoodsList);
            this.Name = "FormReceivedDetail";
            this.Text = "FormReceivedDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGoodsList;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_warehouseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_price;
    }
}