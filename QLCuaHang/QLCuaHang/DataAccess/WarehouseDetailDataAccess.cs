using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WarehouseDetailDataAccess
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

        public bool DeleteByGoodsId(int goodsId)
        {
            bool result = false;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = "delete from WarehouseDetail where GoodsId  = @Id";
                cmd.Parameters.AddWithValue("@Id", goodsId);
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
