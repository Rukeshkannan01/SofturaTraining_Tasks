using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using AdoMVC_03.Models;
using System.Data.SqlClient;
using System.Data;

namespace AdoMVC_03.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";

        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionString:CustCon").Value;
        }
        public List<Customer> GetAllCustomers()
        {
            List<Customer> ListCustomer = new List<Customer>();
            using(SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListCustomer.Add(new Customer()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            Name = reader["Name"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            ContactNo = reader["ContactNo"].ToString()
                        }); ;
                    }

                }
            }
            return ListCustomer;

        }
        public int InsertData(Customer c)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("InsertData", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", c.CustomerID);
            cmd.Parameters.AddWithValue("@cname", c.Name);
            cmd.Parameters.AddWithValue("@email", c.EmailID);
            cmd.Parameters.AddWithValue("@contact", c.ContactNo);
            con.Open();
            int inst = cmd.ExecuteNonQuery();
            con.Close();
            return inst;


        }
    }
}
