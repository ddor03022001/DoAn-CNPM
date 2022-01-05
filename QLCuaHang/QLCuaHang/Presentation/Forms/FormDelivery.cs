using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormDelivery : Form
    {
        private readonly FormContainer formContainer;
        private readonly PaymentMethodBusiness paymentMethodBusiness = new PaymentMethodBusiness();
        private readonly GoodsBusiness goodsBusiness = new GoodsBusiness();
        private readonly WarehouseBusiness warehouseBusiness = new WarehouseBusiness();
        private readonly GoodsDeliveryBusiness goodsDeliveryBusiness = new GoodsDeliveryBusiness();
        public FormDelivery(FormContainer _formContainer)
        {
            InitializeComponent();
            ReloadGoods();
            ReloadPaymentMethod();
            formContainer = _formContainer;
        }

        void ReloadGoods()
        {
            cbGoods.SelectedIndexChanged -= new EventHandler(cbGoods_SelectedIndexChanged);
            DataTable dt = goodsBusiness.GetList();
            cbGoods.DataSource = dt;
            cbGoods.ValueMember = "Id";
            cbGoods.DisplayMember = "Name";
            cbGoods.SelectedIndexChanged += new EventHandler(cbGoods_SelectedIndexChanged);
            dt = warehouseBusiness.GetListByGoodsId((int)dt.Rows[0]["Id"]);
            cbWarehouse.DataSource = dt;
            cbWarehouse.ValueMember = "WarehouseId";
            cbWarehouse.DisplayMember = "Name";
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
            int goodsId = (int)cbGoods.SelectedValue;
            int amount = (int)nbAmount.Value;
            if (nbAmount.Value == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            foreach (DataGridViewRow row in dgvGoodsList.Rows)
            {
                if ((int)row.Cells["goodsList_id"].Value == goodsId)
                {
                    MessageBox.Show("Mặt hàng này đã tồn tại trong phiếu");
                    return;
                }
            }
            //Check xem trong kho còn ko
            if (!goodsBusiness.CheckAmount(goodsId, amount))
            {
                nbAmount.Value = 0;
                MessageBox.Show("Số hàng hóa trong kho không đủ");
                return;
            }

            dgvGoodsList.Rows.Add(goodsId, cbGoods.Text, amount, cbWarehouse.SelectedValue, cbWarehouse.Text, nbPrice.Value, null);
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
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ nhận sản phẩm không được để trống");
                return;
            }

            List<GoodsDeliveryDetail> listDetail = new List<GoodsDeliveryDetail>();
            foreach (DataGridViewRow item in dgvGoodsList.Rows)
            {
                GoodsDeliveryDetail detail = new GoodsDeliveryDetail();
                detail.GoodsId = Convert.ToInt32(item.Cells["goodsList_id"].Value);
                detail.WarehouseId = Convert.ToInt32(item.Cells["goodsList_warehouseid"].Value);
                detail.Amount = Convert.ToInt32(item.Cells["goodsList_amount"].Value);
                detail.Price = Convert.ToInt32(item.Cells["goodsList_price"].Value);
                listDetail.Add(detail);
            }

            //bool result = goodsDeliveryBusiness.Insert(dtDeliveryDate.Value, Convert.ToInt32(cbPaymentMethod.SelectedValue), 1, txtAddress.Text, listDetail);
            //if (!result)
            //    MessageBox.Show(goodsDeliveryBusiness.ReturnMess);
            //else
            //{
            //    MessageBox.Show("Tạo phiếu thành công");
            //    formContainer.ReloadDelivery();
            //    Dispose();
            //}
        }

        private void cbGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = warehouseBusiness.GetListByGoodsId((int)cbGoods.SelectedValue);
            cbWarehouse.DataSource = dt;
            cbWarehouse.ValueMember = "WarehouseId";
            cbWarehouse.DisplayMember = "Name";
        }
    }
}
