using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GoodsReceivedBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly GoodsReceivedDataAccess dataAccess = new GoodsReceivedDataAccess();

        public DataTable GetList()
        {
            DataTable result = dataAccess.GetList();
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public DataTable GetById(int id)
        {
            DataTable result = dataAccess.GetById(id);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public DataTable GetDetailByGoodsReceivedId(int id)
        {
            DataTable result = dataAccess.GetDetailByGoodsReceivedId(id);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public bool Insert(DateTime dateReceived, int paymentMethodId, List<GoodsReceivedDetail> listDetail)
        {
            int id = dataAccess.Insert(dateReceived, paymentMethodId);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            if (ReturnCode != 1)
                return false;

            foreach (var item in listDetail)
            {
                item.GoodsReceivedId = id;
                dataAccess.InsertDetail(item.GoodsReceivedId, item.GoodsId, item.WarehouseId, item.Amount, item.Price);
                ReturnCode = dataAccess.ReturnCode;
                ReturnMess = dataAccess.ReturnMess;
                if (ReturnCode != 1)
                    return false;
            }

            return true;
        }
    }

    public class GoodsReceivedDetail
    {
        public int GoodsReceivedId { get; set; }
        public int GoodsId { get; set; }
        public int WarehouseId { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
