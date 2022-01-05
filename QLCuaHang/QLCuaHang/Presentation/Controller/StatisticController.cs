using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    internal class StatisticController
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        StatisticBusiness business = new StatisticBusiness();
        public (int warehouseCount, int goodsCount, int goodsInStockCount, int receivedCount, int goodsReceivedCount, int orderCount, int goodsOrderCount, int notDeliveryCount, int deliveringCount, int deliveredCount, int notPaid, int paid) GetInfo()
        {
            var result = business.GetStatistic();
            ReturnCode = business.ReturnCode;
            ReturnMess = business.ReturnMess;
            return result;
        }
    }
}
