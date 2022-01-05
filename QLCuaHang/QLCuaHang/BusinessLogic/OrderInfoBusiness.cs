using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OrderInfoBusiness
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly OrderInfoDataAccess dataAccess = new OrderInfoDataAccess();

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

        public bool Insert(string customerName, string address, int paymentMethodId, int goodsId, int amount)
        {
            bool result = dataAccess.Insert(customerName.Trim(), address.Trim(), paymentMethodId, goodsId, amount);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }

        public bool UpdateStatus(int id, int paymentStatusId, int deliveryStatusId)
        {
            bool result = dataAccess.UpdateStatus(id, paymentStatusId, deliveryStatusId);
            ReturnCode = dataAccess.ReturnCode;
            ReturnMess = dataAccess.ReturnMess;
            return result;
        }
    }
}
