using System;
using System.Data;
using CustomerDAL;

namespace CustomerBAL
{
    public class GetCustomersBAL
    {

        public DataTable CustomersList()
        {
            DataTable data = new DataTable();

            data = new GetCustomers().CustomersList();

            return data;
        }

        public DataTable Question4()
        {
            DataTable data = new DataTable();

            data = new GetCustomers().Question4();

            return data;
        }



    }
}
