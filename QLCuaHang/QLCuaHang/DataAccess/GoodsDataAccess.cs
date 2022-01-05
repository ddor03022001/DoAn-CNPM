using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GoodsDataAccess
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly SqlConnection sqlConnection = new SqlConnection(ConnectionInfo.CONNECTION_STRING);

        /// <summary>
        /// Get danh sách hàng hóa, tổng số lượng hàng hóa trong kho
        /// </summary>
        /// <returns></returns>
        public DataTable GetList()
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select a.*, (select sum(Amount) from WarehouseDetail b where b.GoodsId = a.Id) as Amount from Goods a";
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
                cmd.CommandText = "select a.*, (select sum(Amount) from WarehouseDetail b where b.GoodsId = a.Id) as Amount from Goods a where a.Id = @Id";
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

        public bool CheckAmount(int goodsId, int amount)
        {
            var result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select * from WarehouseDetail where GoodsId = @Id and Amount >= @Amount";
                cmd.Parameters.AddWithValue("@Id", goodsId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                if (tbl.Rows.Count == 0)
                    result = false;
                else
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

        public bool Insert(string name)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "insert into Goods(Name) values (@Name)";
                cmd.Parameters.AddWithValue("@Name", name);
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

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "delete from Goods where Id = @Id";
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
