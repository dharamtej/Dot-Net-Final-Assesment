using System;
using System.Data;
using System.Data.SqlClient;

namespace CustomerDAL
{
    public class GetCustomers
    {
        string ConnStr = "Data Source=192.168.50.95;Initial Catalog=dkandakatla;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

        public DataTable CustomersList()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                var sql = "Select * from Customers21";
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    using(SqlDataAdapter ad =  new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dataTable);
                    }
                }

            }
            return dataTable;
        }

        public DataTable Question4()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                var sql = "Select c.CustomerId , CustomerName,BankName,TagId from  Tags t join  Customers21 c on t.CustomerId = c.CustomerId join  Banks b on t.BankId = b.BankId";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(dataTable);
                    }
                }

            }
            return dataTable;
        }
    }
}
