using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GoodsDeliveryDataAccess
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly SqlConnection sqlConnection = new SqlConnection(ConnectionInfo.CONNECTION_STRING);

        //public DataTable GetList()
        //{
        //    DataTable tbl = new DataTable();
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand cmd = sqlConnection.CreateCommand();
        //        cmd.CommandText = "select a.Id, a.DateDelivery, b.Name as PaymentMethod, c.Name as PaymentStatus, d.Name as DeliveryStatus, (select sum(Amount) from GoodsDeliveryDetail where GoodsDeliveryId = a.Id) as TotalAmount from GoodsDelivery a inner join PaymentMethod b on a.PaymentMethodId = b.Id inner join PaymentStatus c on a.PaymentStatusId = c.Id inner join DeliveryStatus d on a.DeliveryStatusId = d.Id";
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(tbl);
        //        ReturnCode = 1;
        //        ReturnMess = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        ReturnMess = ex.Message;
        //        ReturnCode = -1;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //    return tbl;
        //}

        //public DataTable GetById(int id)
        //{
        //    DataTable tbl = new DataTable();
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand cmd = sqlConnection.CreateCommand();
        //        cmd.CommandText = "select a.Id, a.DateDelivery, a.PaymentStatusId, a.DeliveryStatusId, b.Name as PaymentMethod, c.Name as PaymentStatus, d.Name as DeliveryStatus, (select sum(Amount) from GoodsDeliveryDetail where GoodsDeliveryId = a.Id) as TotalAmount from GoodsDelivery a inner join PaymentMethod b on a.PaymentMethodId = b.Id inner join PaymentStatus c on a.PaymentStatusId = c.Id inner join DeliveryStatus d on a.DeliveryStatusId = d.Id where a.Id = @Id";
        //        cmd.Parameters.AddWithValue("@Id", id);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(tbl);
        //        ReturnCode = 1;
        //        ReturnMess = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        ReturnMess = ex.Message;
        //        ReturnCode = -1;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //    return tbl;
        //}

        //public DataTable GetDetailByGoodsDeliveryId(int id)
        //{
        //    DataTable tbl = new DataTable();
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand cmd = sqlConnection.CreateCommand();
        //        cmd.CommandText = "select a.Id, b.Name, a.Amount, a.WarehouseId, c.Name as Warehouse, a.Price from GoodsDeliveryDetail a inner join Goods b on a.GoodsId = b.Id inner join Warehouse c on a.WarehouseId = c.Id where a.GoodsDeliveryId = @Id";
        //        cmd.Parameters.AddWithValue("@Id", id);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(tbl);
        //        ReturnCode = 1;
        //        ReturnMess = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        ReturnMess = ex.Message;
        //        ReturnCode = -1;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //    return tbl;
        //}

        //public int Insert(DateTime dateDelivery, int orderInfoId)
        //{
        //    int id = -1;
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand cmd = sqlConnection.CreateCommand();
        //        cmd.CommandText = "insert into GoodsDelivery(DateDelivery, OrderInfoId) output INSERTED.ID values (@DateDelivery, @OrderInfoId)";
        //        cmd.Parameters.AddWithValue("@DateDelivery", dateDelivery);
        //        cmd.Parameters.AddWithValue("@OrderInfoId", orderInfoId);
        //        id = (int)cmd.ExecuteScalar();
        //        ReturnCode = 1;
        //        ReturnMess = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        ReturnMess = ex.Message;
        //        ReturnCode = -1;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //    return id;
        //}

        //public bool InsertDetail(int goodsDeliveryId, int goodsId, int warehouseId, int amount, int price)
        //{
        //    bool result = false;
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand cmd = sqlConnection.CreateCommand();
        //        cmd.CommandText = "insert into GoodsDeliveryDetail(GoodsDeliveryId, GoodsId, WarehouseId, Amount, Price) values (@GoodsDeliveryId, @GoodsId, @WarehouseId, @Amount, @Price)";
        //        cmd.Parameters.AddWithValue("@GoodsDeliveryId", goodsDeliveryId);
        //        cmd.Parameters.AddWithValue("@GoodsId", goodsId);
        //        cmd.Parameters.AddWithValue("@WarehouseId", warehouseId);
        //        cmd.Parameters.AddWithValue("@Amount", amount);
        //        cmd.Parameters.AddWithValue("@Price", price);
        //        cmd.ExecuteNonQuery();
        //        result = true;
        //        ReturnCode = 1;
        //        ReturnMess = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        ReturnMess = ex.Message;
        //        ReturnCode = -1;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //    return result;
        //}

        //public bool UpdateStatus(int id, int paymentStatusId, int deliveryStatusId)
        //{
        //    bool result = false;
        //    try
        //    {
        //        sqlConnection.Open();
        //        SqlCommand cmd = sqlConnection.CreateCommand();
        //        cmd.CommandText = "update GoodsDelivery set PaymentStatusId = @PaymentStatusId, DeliveryStatusId = @DeliveryStatusId where Id = @Id";
        //        cmd.Parameters.AddWithValue("@PaymentStatusId", paymentStatusId);
        //        cmd.Parameters.AddWithValue("@DeliveryStatusId", deliveryStatusId);
        //        cmd.Parameters.AddWithValue("@Id", id);
        //        cmd.ExecuteNonQuery();
        //        result = true;
        //        ReturnCode = 1;
        //        ReturnMess = "success";
        //    }
        //    catch (Exception ex)
        //    {
        //        ReturnMess = ex.Message;
        //        ReturnCode = -1;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //    return result;
        //}
    }
}
