using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    internal class GoodsController
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        GoodsBusiness business = new GoodsBusiness();
        public DataTable GetList()
        {
            DataTable result = business.GetList();
            ReturnCode = business.ReturnCode;
            ReturnMess = business.ReturnMess;
            return result;
        }

        public bool Insert(string name)
        {
            bool result = business.Insert(name);
            ReturnCode = business.ReturnCode;
            ReturnMess = business.ReturnMess;
            return result;
        }

        public bool Delete(int id)
        {
            bool result = business.Delete(id);
            ReturnCode = business.ReturnCode;
            ReturnMess = business.ReturnMess;
            return result;
        }
    }
}
