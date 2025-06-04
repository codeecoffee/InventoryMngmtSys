using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;
using InventoryMngmtSys.Helpers;

namespace InventoryMngmtSys
{
    public partial class ManageCustomers : Form
    {
        DbHelper dbHelper = new DbHelper();
        public ManageCustomers()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            var ds = dbHelper.Populate(DbHelper.DbTables.CustomerTbl);
            //DataTable dt = new DataTable();
            if (ds == null)
            {
                MessageBox.Show("Failed to retrieve data from the database.");
                return;
            }
            CustomerDGV.DataSource = ds.Tables[0];
        }
        private void ResetFields()
        {
            CustomerId.Text = "";
            CustomerNameTb.Text = "";
            CustomerPhoneTb.Text = "";

        }
        private void AddBttn_Click(object sender, EventArgs e)
        {
            try
            {
                dbHelper.CreateCustomer(CustomerId.Text, CustomerNameTb.Text, CustomerPhoneTb.Text);
                MessageBox.Show("Customer Added Successfully!");
                populate();
                ResetFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void DeleteBttn_Click(object sender, EventArgs e)
        {
            if (Phone.Text == "")
            {
                MessageBox.Show("Please select a user to delete!");
            }
            else
            {
                try
                {
                    await dbHelper.DeleteCustomerAsync(CustomerPhoneTb.Text);
                    MessageBox.Show("Customer Deleted Successfully!");
                    populate();
                    ResetFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void EditBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
