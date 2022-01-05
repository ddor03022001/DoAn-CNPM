using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormReceivedDetail : Form
    {
        private readonly GoodsReceivedBusiness goodsReceivedBusiness = new GoodsReceivedBusiness();
        public FormReceivedDetail(int id)
        {
            InitializeComponent();

            DataTable dt = goodsReceivedBusiness.GetById(id);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không thể truy vấn dữ liệu");
                return;
            }
            lblPaymentMethod.Text = dt.Rows[0]["PaymentMethod"].ToString();
            lblDate.Text = DateTime.Parse(dt.Rows[0]["DateReceived"].ToString()).ToString("dd/MM/yyyy");

            dt = goodsReceivedBusiness.GetDetailByGoodsReceivedId(id);
            dgvGoodsList.DataSource = dt;
        }
    }
}
