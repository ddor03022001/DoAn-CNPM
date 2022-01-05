using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GoodsDeliveryBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly GoodsDeliveryDataAccess dataAccess = new GoodsDeliveryDataAccess();

        //public DataTable GetList()
        //{
        //    DataTable result = dataAccess.GetList();
        //    ReturnCode = dataAccess.ReturnCode;
        //    ReturnMess = dataAccess.ReturnMess;
        //    return result;
        //}

        //public DataTable GetById(int id)
        //{
        //    DataTable result = dataAccess.GetById(id);
        //    ReturnCode = dataAccess.ReturnCode;
        //    ReturnMess = dataAccess.ReturnMess;
        //    return result;
        //}

        //public DataTable GetDetailByGoodsReceivedId(int id)
        //{
        //    DataTable result = dataAccess.GetDetailByGoodsDeliveryId(id);
        //    ReturnCode = dataAccess.ReturnCode;
        //    ReturnMess = dataAccess.ReturnMess;
        //    return result;
        //}

        //public bool Insert(DateTime dateDelivery, int paymentMethodId, int paymentStatusId, string address, List<GoodsDeliveryDetail> listDetail)
        //{
        //    int id = dataAccess.Insert(dateDelivery, paymentMethodId, paymentStatusId, address);
        //    ReturnCode = dataAccess.ReturnCode;
        //    ReturnMess = dataAccess.ReturnMess;
        //    if (ReturnCode != 1)
        //        return false;

        //    foreach (var item in listDetail)
        //    {
        //        item.GoodsDeliveryId = id;
        //        dataAccess.InsertDetail(item.GoodsDeliveryId, item.GoodsId, item.WarehouseId, item.Amount, item.Price);
        //        ReturnCode = dataAccess.ReturnCode;
        //        ReturnMess = dataAccess.ReturnMess;
        //        if (ReturnCode != 1)
        //            return false;
        //    }

        //    return true;
        //}

        //public bool UpdateStatus(int id, int paymentStatusId, int deliveryStatusId)
        //{
        //    bool result = dataAccess.UpdateStatus(id, paymentStatusId, deliveryStatusId);
        //    ReturnCode = dataAccess.ReturnCode;
        //    ReturnMess = dataAccess.ReturnMess;
        //    return result;
        //}
    }

    public class GoodsDeliveryDetail
    {
        public int GoodsDeliveryId { get; set; }
        public int GoodsId { get; set; }
        public int WarehouseId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
