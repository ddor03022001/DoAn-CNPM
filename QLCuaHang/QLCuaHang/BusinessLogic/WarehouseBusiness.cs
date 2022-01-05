using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WarehouseBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly WarehouseDataAccess dataAccess = new WarehouseDataAccess();

        public DataTable GetList()
        {
            DataTable result = dataAccess.GetList();
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public DataTable GetListByGoodsId(int id)
        {
            DataTable result = dataAccess.GetListByGoodsId(id);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }
    }
}
