using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WarehouseDataAccess
    {
        public int ReturnCode { get; set; }
        public string ReturnMess { get; set; }
        private readonly SqlConnection sqlConnection = new SqlConnection(ConnectionInfo.CONNECTION_STRING);

        /// <summary>
        /// Get danh sách kho, số lượng hàng hóa trong kho
        /// </summary>
        /// <returns></returns>
        public DataTable GetList()
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select a.*, (select sum(Amount) from WarehouseDetail b where b.WarehouseId = a.Id) as Amount from Warehouse a";
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

        public DataTable GetListByGoodsId(int id)
        {
            DataTable tbl = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "select distinct(a.WarehouseId), b.Name from WarehouseDetail a inner join Warehouse b on a.WarehouseId = b.Id where GoodsId = @Id";
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
    }
}
