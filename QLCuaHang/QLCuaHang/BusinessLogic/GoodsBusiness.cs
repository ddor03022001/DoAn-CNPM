using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GoodsBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly GoodsDataAccess dataAccess = new GoodsDataAccess();
        private readonly WarehouseDetailDataAccess warehouseDetailDataAccess = new WarehouseDetailDataAccess();

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

        public bool CheckAmount(int goodsId, int amount)
        {
            bool result = dataAccess.CheckAmount(goodsId, amount);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public bool Insert(string name)
        {
            bool result = dataAccess.Insert(name.Trim());
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public bool Delete(int id)
        {
            bool result = warehouseDetailDataAccess.DeleteByGoodsId(id);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            if (!result)
                return result;
            result = dataAccess.Delete(id);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }
    }
}
