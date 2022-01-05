using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class GoodsReceivedDataAccess
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
                cmd.CommandText = "select a.Id, a.DateReceived, b.Name as PaymentMethod, (select sum(Amount) from GoodsReceivedDetail where GoodsReceivedId = a.Id) as TotalAmount from GoodsReceived a inner join PaymentMethod b on a.PaymentMethodId = b.Id";
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
                cmd.CommandText = "select a.Id, a.DateReceived, b.Name as PaymentMethod, (select sum(Amount) from GoodsReceivedDetail where GoodsReceivedId = a.Id) as TotalAmount from GoodsReceived a inner join PaymentMethod b on a.PaymentMethodId = b.Id where a.Id = @Id";
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

        public DataTable GetDetailByGoodsReceivedId(int id)
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select a.Id, b.Name, a.Amount, a.WarehouseId, c.Name as Warehouse, a.Price from GoodsReceivedDetail a inner join Goods b on a.GoodsId = b.Id inner join Warehouse c on a.WarehouseId = c.Id where a.GoodsReceivedId = @Id";
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

        public int Insert(DateTime dateReceived, int paymentMethodId)
        {
            int id = -1;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "insert into GoodsReceived(DateReceived, PaymentMethodId) output INSERTED.ID values (@DateReceived, @PaymentMethodId)";
                cmd.Parameters.AddWithValue("@DateReceived", dateReceived);
                cmd.Parameters.AddWithValue("@PaymentMethodId", paymentMethodId);
                id = (int)cmd.ExecuteScalar();
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
            return id;
        }

        public bool InsertDetail(int goodsReceivedId, int goodsId, int warehouseId, int amount, int price)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "insert into GoodsReceivedDetail(GoodsReceivedId, GoodsId, WarehouseId, Amount, Price) values (@GoodsReceivedId, @GoodsId, @WarehouseId, @Amount, @Price)";
                cmd.Parameters.AddWithValue("@GoodsReceivedId", goodsReceivedId);
                cmd.Parameters.AddWithValue("@GoodsId", goodsId);
                cmd.Parameters.AddWithValue("@WarehouseId", warehouseId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Price", price);
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
