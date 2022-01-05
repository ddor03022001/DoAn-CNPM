using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormReceived : Form
    {
        private readonly GoodsBusiness goodsBusiness = new GoodsBusiness();
        private readonly PaymentMethodBusiness paymentMethodBusiness = new PaymentMethodBusiness();
        private readonly WarehouseBusiness warehouseBusiness = new WarehouseBusiness();
        private readonly GoodsReceivedBusiness goodsReceivedBusiness = new GoodsReceivedBusiness();
        private readonly FormContainer formContainer;
        public FormReceived(FormContainer _formContainer)
        {
            InitializeComponent();
            ReloadGoods();
            ReloadPaymentMethod();
            ReloadWarehouse();
            dtReceiverDate.Value = DateTime.Now;
            formContainer = _formContainer;
        }

        void ReloadWarehouse()
        {
            DataTable dt = warehouseBusiness.GetList();
            cbWarehouse.DataSource = dt;
            cbWarehouse.ValueMember = "Id";
            cbWarehouse.DisplayMember = "Name";
        }

        void ReloadGoods()
        {
            DataTable dt = goodsBusiness.GetList();
            cbGoods.DataSource = dt;
            cbGoods.ValueMember = "Id";
            cbGoods.DisplayMember = "Name";
        }

        void ReloadPaymentMethod()
        {
            DataTable dt = paymentMethodBusiness.GetList();
            cbPaymentMethod.DataSource = dt;
            cbPaymentMethod.ValueMember = "Id";
            cbPaymentMethod.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nbAmount.Value == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            foreach (DataGridViewRow row in dgvGoodsList.Rows)
            {
                if ((int)row.Cells["goodsList_id"].Value == (int)cbGoods.SelectedValue)
                {
                    MessageBox.Show("Mặt hàng này đã tồn tại trong phiếu");
                    return;
                }
            }
            dgvGoodsList.Rows.Add(cbGoods.SelectedValue, cbGoods.Text, nbAmount.Value, cbWarehouse.SelectedValue, cbWarehouse.Text, nbPrice.Value, null);
        }

        private void dgvGoodsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == goodsList_delete.Index)
            {
                dgvGoodsList.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dgvGoodsList.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu chưa có sản phẩm nào");
                return;
            }

            List<GoodsReceivedDetail> listDetail = new List<GoodsReceivedDetail>();
            foreach (DataGridViewRow item in dgvGoodsList.Rows)
            {
                GoodsReceivedDetail detail = new GoodsReceivedDetail();
                detail.GoodsId = Convert.ToInt32(item.Cells["goodsList_id"].Value);
                detail.WarehouseId = Convert.ToInt32(item.Cells["goodsList_warehouseid"].Value);
                detail.Amount = Convert.ToInt32(item.Cells["goodsList_amount"].Value);
                detail.Price = Convert.ToInt32(item.Cells["goodsList_price"].Value);
                listDetail.Add(detail);
            }

            bool result = goodsReceivedBusiness.Insert(dtReceiverDate.Value, Convert.ToInt32(cbPaymentMethod.SelectedValue), listDetail);
            if (!result)
                MessageBox.Show(goodsReceivedBusiness.ReturnMess);
            else
            {
                MessageBox.Show("Tạo phiếu thành công");
                formContainer.ReloadReceived();
                Dispose();
            }
        }
    }
}
