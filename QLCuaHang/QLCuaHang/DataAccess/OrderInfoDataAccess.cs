using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderInfoDataAccess
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly SqlConnection sqlConnection = new SqlConnection(ConnectionInfo.CONNECTION_STRING);

        public DataTable GetList()
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select a.Id, a.CustomerName, b.Name as PaymentMethod, c.Name as PaymentStatus, d.Name as DeliveryStatus from OrderInfo a inner join PaymentMethod b on a.PaymentMethodId = b.Id inner join PaymentStatus c on a.PaymentStatusId = c.Id inner join DeliveryStatus d on a.DeliveryStatusId = d.Id";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tbl);
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return tbl;
        }

        public DataTable GetByDeliveryStatusId(int id)
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from OrderInfo where DeliveryStatusId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tbl);
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return tbl;
        }

        public DataTable GetByPaymentStatusId(int id)
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from OrderInfo where PaymentStatusId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tbl);
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return tbl;
        }

        public DataTable GetById(int id)
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select a.Id, a.CustomerName, a.Address, a.PaymentStatusId, a.DeliveryStatusId, a.GoodsId, a.Amount, e.Name as Goods, b.Name as PaymentMethod, c.Name as PaymentStatus, d.Name as DeliveryStatus from OrderInfo a inner join PaymentMethod b on a.PaymentMethodId = b.Id inner join PaymentStatus c on a.PaymentStatusId = c.Id inner join DeliveryStatus d on a.DeliveryStatusId = d.Id inner join Goods e on a.GoodsId = e.Id where a.Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tbl);
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return tbl;
        }

        public DataTable GetOrderGoods(int id)
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select a.amount,b.Name from OrderInfo a inner join Goods b on a.GoodsId = b.Id where a.Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tbl);
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return tbl;
        }

        public bool Insert(string customerName, string address, int paymentMethodId, int goodsId, int amount)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "insert into OrderInfo(CustomerName, Address, PaymentMethodId, GoodsId, Amount, DeliveryStatusId, PaymentStatusId) values (@CustomerName, @Address, @PaymentMethodId, @GoodsId, @Amount, 1, 1)";
                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PaymentMethodId", paymentMethodId);
                cmd.Parameters.AddWithValue("@GoodsId", goodsId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.ExecuteNonQuery();
                result = true;
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }

        public bool UpdateStatus(int id, int paymentStatusId, int deliveryStatusId)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "update OrderInfo set PaymentStatusId = @PaymentStatusId, DeliveryStatusId = @DeliveryStatusId where Id = @Id";
                cmd.Parameters.AddWithValue("@PaymentStatusId", paymentStatusId);
                cmd.Parameters.AddWithValue("@DeliveryStatusId", deliveryStatusId);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                result = true;
                ReturnCode = 1;
                ReturnMess = "success";
            }
            catch (Exception ex)
            {
                ReturnMess = ex.Message;
                ReturnCode = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }
    }
}
