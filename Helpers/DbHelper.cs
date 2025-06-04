using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMngmtSys.Helpers
{
    internal class DbHelper
    {
        public enum DbTables
        {
            CustomerTbl,
            UserTbl,
            Product,
            Category,
            Supplier
        }
        private static readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        //private static readonly string _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.Combine(AppContext.BaseDirectory, "DB", "InventoryDB.mdf")};Integrated Security=True;Connect Timeout=30;Encrypt=True";
        private SqlConnection GetConnection() => new SqlConnection(_connectionString);
        public DbHelper() { 
        
        
        }
        public DataSet? Populate(DbTables tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            try
            {
                using var Connection = GetConnection();
                Connection.Open();
                SqlCommand cmd = new SqlCommand(query, Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds);
                Connection.Close();
                Console.WriteLine(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        public void TestConnection()
        {
            using var Connection = GetConnection();
            try
            {
                Connection.Open();
                Console.WriteLine("Connection Successful!");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection to DB Failed: " + ex.Message);
            }
        }
        public void CreateCustomer(string customerId, string customerName, string customerPhone)
        {
            using var Connection = GetConnection();
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl VALUES (@Id, @Name, @Phone)", Connection);
                cmd.Parameters.AddWithValue("@CustId", customerId);
                cmd.Parameters.AddWithValue("@CustName", customerName);
                cmd.Parameters.AddWithValue("@CustPhone", customerPhone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully!");
                Populate(DbTables.CustomerTbl);
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public async Task DeleteCustomerAsync(string customerPhone)
        {
            if (string.IsNullOrEmpty(customerPhone))
            {
                throw new ArgumentException("Customer phone number cannot be empty.", nameof(customerPhone));
            }
            using var Connection = GetConnection();
            string deletequery = $"DELETE FROM CustomerTbl WHERE Cphone= @Phone";
            SqlCommand cmd = new SqlCommand(deletequery, Connection);
            cmd.Parameters.AddWithValue("@Phone", customerPhone);
            try
            {
                await Connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                //Populate(DbTables.CustomerTbl);
                Connection.Close();
                //return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Connection.Close();
                //return false;
            }
        }
        //public void DeleteCustomer(string customerPhone)
        //{
        //    if (string.IsNullOrEmpty(customerPhone))
        //    {
        //       throw new ArgumentException("Customer phone number cannot be empty.", nameof(customerPhone));
        //    }
        //    else
        //    {
        //        using var Connection = GetConnection();
        //        string deletequery = $"DELETE FROM CustomerTbl WHERE Cphone= @Phone";
        //        SqlCommand cmd = new SqlCommand(deletequery, Connection);
        //        cmd.Parameters.AddWithValue("@Phone", customerPhone);

        //        try
        //        {
        //            Connection.Open();
        //            cmd.ExecuteNonQuery();
        //            Populate(DbTables.CustomerTbl);
        //            Connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}
    }
}
