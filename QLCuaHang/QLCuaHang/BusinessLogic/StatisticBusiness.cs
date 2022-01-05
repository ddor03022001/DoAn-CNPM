using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class StatisticBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly GoodsDataAccess goodsDataAccess = new GoodsDataAccess();
        private readonly WarehouseDetailDataAccess warehouseDetailDataAccess = new WarehouseDetailDataAccess();
        private readonly WarehouseDataAccess warehouseDataAccess = new WarehouseDataAccess();
        private readonly GoodsReceivedDataAccess goodsReceivedDataAccess = new GoodsReceivedDataAccess();
        private readonly OrderInfoDataAccess orderInfoDataAccess = new OrderInfoDataAccess();

        public (int warehouseCount, int goodsCount, int goodsInStockCount, int receivedCount, int goodsReceivedCount, int orderCount, int goodsOrderCount, int notDeliveryCount, int deliveringCount, int deliveredCount, int notPaid, int paid) GetStatistic()
        {
            int warehouseCount = 0, goodsCount = 0, goodsInStockCount = 0, receivedCount = 0, goodsReceivedCount = 0, orderCount = 0, goodsOrderCount = 0, notDeliveryCount = 0, deliveringCount = 0, deliveredCount = 0, notPaid = 0, paid = 0;
            DataTable dt = warehouseDataAccess.GetList();
            warehouseCount = dt.Rows.Count;
            foreach (DataRow row in dt.Rows)
            {
                goodsInStockCount += (int)row["Amount"];
            }

            dt = goodsDataAccess.GetList();
            goodsCount = dt.Rows.Count;

            dt = goodsReceivedDataAccess.GetList();
            receivedCount = dt.Rows.Count;
            foreach (DataRow row in dt.Rows)
            {
                goodsReceivedCount += (int)row["TotalAmount"];
            }

            dt = orderInfoDataAccess.GetList();
            orderCount = dt.Rows.Count;
            foreach (DataRow row in dt.Rows)
            {
                DataTable detail = orderInfoDataAccess.GetOrderGoods((int)row["Id"]);
                foreach (DataRow detailRow in detail.Rows)
                {
                    goodsOrderCount += (int)detailRow["Amount"];
                }
            }

            dt = orderInfoDataAccess.GetByDeliveryStatusId(1);
            notDeliveryCount = dt.Rows.Count;

            dt = orderInfoDataAccess.GetByDeliveryStatusId(2);
            deliveringCount = dt.Rows.Count;

            dt = orderInfoDataAccess.GetByDeliveryStatusId(3);
            deliveredCount = dt.Rows.Count;

            dt = orderInfoDataAccess.GetByPaymentStatusId(1);
            notPaid = dt.Rows.Count;

            dt = orderInfoDataAccess.GetByPaymentStatusId(2);
            paid = dt.Rows.Count;

            return (warehouseCount, goodsCount, goodsInStockCount, receivedCount, goodsReceivedCount, orderCount, goodsOrderCount, notDeliveryCount, deliveringCount, deliveredCount, notPaid, paid);
        }
    }
}
