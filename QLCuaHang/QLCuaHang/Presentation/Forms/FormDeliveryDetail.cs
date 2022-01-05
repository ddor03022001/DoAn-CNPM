using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormDeliveryDetail : Form
    {
        private readonly OrderInfoBusiness orderInfoBusiness = new OrderInfoBusiness();
        private readonly DeliveryStatusBusiness deliveryStatusBusiness = new DeliveryStatusBusiness();
        private readonly PaymentStatusBusiness paymentStatusBusiness = new PaymentStatusBusiness();
        private readonly FormContainer formContainer = new FormContainer();
        private readonly int id;
        public FormDeliveryDetail(int _id, FormContainer _formContainer)
        {
            InitializeComponent();
            formContainer = _formContainer;
            id = _id;
            DataTable dt = orderInfoBusiness.GetById(id);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không thể truy vấn dữ liệu");
                return;
            }
            lblPaymentMethod.Text = dt.Rows[0]["PaymentMethod"].ToString();
            lblCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
            lblAddress.Text = dt.Rows[0]["Address"].ToString();
            int paymentStatusId = Convert.ToInt32(dt.Rows[0]["PaymentStatusId"]), deliveryStatusId = Convert.ToInt32(dt.Rows[0]["DeliveryStatusId"]);

            dgvGoodsList.Rows.Add(dt.Rows[0]["GoodsId"], dt.Rows[0]["Goods"], dt.Rows[0]["Amount"]);

            dt = paymentStatusBusiness.GetList();
            cbPaymentStatus.DataSource = dt;
            cbPaymentStatus.ValueMember = "Id";
            cbPaymentStatus.DisplayMember = "Name";
            cbPaymentStatus.SelectedValue = paymentStatusId;

            dt = deliveryStatusBusiness.GetList();
            cbDeliveryStatus.DataSource = dt;
            cbDeliveryStatus.ValueMember = "Id";
            cbDeliveryStatus.DisplayMember = "Name";
            cbDeliveryStatus.SelectedValue = deliveryStatusId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = orderInfoBusiness.UpdateStatus(id, (int)cbPaymentStatus.SelectedValue, (int)cbDeliveryStatus.SelectedValue);
            if (result)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                formContainer.ReloadDelivery();
                Dispose();
            }
            else
                MessageBox.Show(orderInfoBusiness.ReturnMess);
        }
    }
}
