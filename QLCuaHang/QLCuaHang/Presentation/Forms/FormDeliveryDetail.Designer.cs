namespace Presentation.Forms
{
    partial class FormDeliveryDetail
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGoodsList = new System.Windows.Forms.DataGridView();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goodsList_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsList_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hình thức thanh toán:";
            // 
            // dgvGoodsList
            // 
            this.dgvGoodsList.AllowUserToAddRows = false;
            this.dgvGoodsList.AllowUserToDeleteRows = false;
            this.dgvGoodsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsList_id,
            this.goodsList_name,
            this.goodsList_amount});
            this.dgvGoodsList.Location = new System.Drawing.Point(22, 65);
            this.dgvGoodsList.Name = "dgvGoodsList";
            this.dgvGoodsList.ReadOnly = true;
            this.dgvGoodsList.Size = new System.Drawing.Size(842, 209);
            this.dgvGoodsList.TabIndex = 30;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(377, 9);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(62, 13);
            this.lblPaymentMethod.TabIndex = 33;
            this.lblPaymentMethod.Text = "Thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tình trạng thanh toán";
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Location = new System.Drawing.Point(133, 38);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentStatus.TabIndex = 36;
            // 
            // cbDeliveryStatus
            // 
            this.cbDeliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeliveryStatus.FormattingEnabled = true;
            this.cbDeliveryStatus.Location = new System.Drawing.Point(380, 38);
            this.cbDeliveryStatus.Name = "cbDeliveryStatus";
            this.cbDeliveryStatus.Size = new System.Drawing.Size(121, 21);
            this.cbDeliveryStatus.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tình trạng vận chuyển";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(788, 36);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Khách hàng:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(93, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerName.TabIndex = 41;
            this.lblCustomerName.Text = "Khách hàng";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(93, 22);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 13);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Địa chỉ:";
            // 
            // goodsList_id
            // 
            this.goodsList_id.DataPropertyName = "GoodsId";
            this.goodsList_id.HeaderText = "Mã";
            this.goodsList_id.Name = "goodsList_id";
            this.goodsList_id.ReadOnly = true;
            // 
            // goodsList_name
            // 
            this.goodsList_name.DataPropertyName = "Goods";
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
            // FormDeliveryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 283);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbDeliveryStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvGoodsList);
            this.Controls.Add(this.lblPaymentMethod);
            this.Name = "FormDeliveryDetail";
            this.Text = "FormDeliveryDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGoodsList;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbDeliveryStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsList_amount;
    }
}