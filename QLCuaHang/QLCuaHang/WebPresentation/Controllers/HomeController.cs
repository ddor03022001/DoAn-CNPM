using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPresentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Order()
        {
            ViewBag.Message = "Đặt hàng";
            return View();
        }

        [HttpPost]
        public ActionResult SetOrder(int id, string name, string amount, string address, int paymentMethod)
        {
            if (!int.TryParse(amount, out int goodsAmount))
            {
                TempData["Result"] = "Số lượng không hợp lệ";
                return Redirect("/Home/Order/" + id);
            }
            if (goodsAmount == 0)
            {
                TempData["Result"] = "Số lượng không hợp lệ";
                return Redirect("/Home/Order/" + id);
            }

            GoodsBusiness goodsBusiness = new GoodsBusiness();
            //Check xem trong kho còn ko
            if (!goodsBusiness.CheckAmount(id, goodsAmount))
            {
                TempData["Result"] = "Số hàng hóa trong kho không đủ";
                return Redirect("/Home/Order/" + id);
            }

            OrderInfoBusiness orderInfoBusiness = new OrderInfoBusiness();
            if (orderInfoBusiness.Insert(name, address, paymentMethod, id, goodsAmount))
            {
                TempData["Result"] = "Đặt hàng thành công";
                return Redirect("/Home");
            }
            else
            {
                TempData["Result"] = orderInfoBusiness.ReturnMess;
                return Redirect("/Home/Order/" + id);
            }
        }
    }
}