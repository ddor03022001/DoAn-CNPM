using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PaymentStatusBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly PaymentStatusDataAccess dataAccess = new PaymentStatusDataAccess();

        public DataTable GetList()
        {
            DataTable result = dataAccess.GetList();
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }
    }
}
