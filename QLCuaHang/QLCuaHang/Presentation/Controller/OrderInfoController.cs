using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    internal class OrderInfoController
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        OrderInfoBusiness business = new OrderInfoBusiness();
        public DataTable GetList()
        {
            DataTable result = business.GetList();
            ReturnCode = business.ReturnCode;
            ReturnMess = business.ReturnMess;
            return result;
        }
    }
}
