using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    internal class WarehouseController
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        WarehouseBusiness business = new WarehouseBusiness();
        public DataTable GetList()
        {
            DataTable result = business.GetList();
            ReturnCode = business.ReturnCode;
            ReturnMess = business.ReturnMess;
            return result;
        }
    }
}
