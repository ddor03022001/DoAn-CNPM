using Presentation.Controller;
using Presentation.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormContainer : Form
    {
        private readonly WarehouseController warehouseController = new WarehouseController();
        private readonly GoodsController goodsController = new GoodsController();
        private readonly GoodsReceivedController goodsReceivedController = new GoodsReceivedController();
        private readonly OrderInfoController orderInfoController = new OrderInfoController();
        private readonly StatisticController statisticController = new StatisticController();
        public FormContainer()
        {
            InitializeComponent();
            ReloadWarehouse();
            ReloadGoods();
            ReloadReceived();
            ReloadDelivery();
            ReloadStatistic();
        }

        void ReloadStatistic()
        {
            (int warehouseCount, int goodsCount, int goodsInStockCount, int receivedCount, int goodsReceivedCount, int orderCount, int goodsOrderCount, int notDeliveryCount, int deliveringCount, int deliveredCount, int notPaid, int paid) result = statisticController.GetInfo();
            lblWarehouseCount.Text = result.warehouseCount.ToString();
            lblGoodsCount.Text = result.goodsCount.ToString();
            lblGoodsInStockCount.Text = result.goodsInStockCount.ToString();
            lblReceivedCount.Text = result.receivedCount.ToString();
            lblGoodsReceivedCount.Text = result.goodsReceivedCount.ToString();
            lblOrderCount.Text = result.orderCount.ToString();
            lblGoodsOrderCount.Text = result.goodsOrderCount.ToString();
            lblNotDelivery.Text = result.notDeliveryCount.ToString();
            lblDelivering.Text = result.deliveringCount.ToString();
            lblDelivered.Text = result.deliveredCount.ToString();
            lblNotPaid.Text = result.notPaid.ToString();
            lblPaid.Text = result.paid.ToString();
        }

        /// <summary>
        /// Tải lại danh sách kho
        /// </summary>
        public void ReloadWarehouse()
        {
            DataTable dt = warehouseController.GetList();
            dgvWarehouse.DataSource = dt;
            ReloadStatistic();
        }

        /// <summary>
        /// Tải lại danh sách hàng hóa
        /// </summary>
        public void ReloadGoods()
        {
            DataTable dt = goodsController.GetList();
            dgvGoods.DataSource = dt;
            ReloadStatistic();
        }

        public void ReloadReceived()
        {
            DataTable dt = goodsReceivedController.GetList();
            dgvReceived.DataSource = dt;
            ReloadStatistic();
        }

        public void ReloadDelivery()
        {
            DataTable dt = orderInfoController.GetList();
            dgvOrder.DataSource = dt;
            ReloadStatistic();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGoodsName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return;
            }
            bool result = goodsController.Insert(txtGoodsName.Text);
            if (result)
            {
                MessageBox.Show("Thêm mới sản phẩm thành công");
                txtGoodsName.Clear();
                ReloadGoods();
            }
            else
            {
                MessageBox.Show(goodsController.ReturnMess);
            }
        }


        private void dgvGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == goods_delete.Index)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = (int)dgvGoods.Rows[e.RowIndex].Cells["goods_id"].Value;
                    if (!goodsController.Delete(id))
                        MessageBox.Show(goodsController.ReturnMess);
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm thành công");
                        ReloadGoods();
                    }
                }
            }
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            FormReceived formReceiver = new FormReceived(this);
            formReceiver.ShowDialog();
        }

        private void dgvReceived_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == received_detail.Index)
            {
                int id = (int)dgvReceived.Rows[e.RowIndex].Cells["received_id"].Value;
                FormReceivedDetail formReceivedDetail = new FormReceivedDetail(id);
                formReceivedDetail.ShowDialog();
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == order_detail.Index)
            {
                int id = (int)dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value;
                FormDeliveryDetail formDeliveryDetail = new FormDeliveryDetail(id, this);
                formDeliveryDetail.ShowDialog();
            }
        }
    }
}
