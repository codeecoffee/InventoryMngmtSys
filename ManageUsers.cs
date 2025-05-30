using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace InventoryMngmtSys
{
    public partial class ManageUsers : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\Projects\InventoryManagementSys\InventoryMngmtSys\DB\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public ManageUsers()
        {
            InitializeComponent();
            try
            {
                Connection.Open();
                populateDataGridView();
                //MessageBox.Show("Connection Successful!");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to DB Failed: " + ex.Message);
            }
        }
        private void populateDataGridView()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserTbl", Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            UserDGV.DataSource = dt;
        }
        private void ResetFields()
        {
            Username.Text = "";
            FullName.Text = "";
            Password.Text = "";
            Phone.Text = "";
        }

        private void QuitBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBttn_Click(object sender, EventArgs e)
        //(Username, FullName, Password, Phone) VALUES (@Uname, @Ufullname ,@Upassword, @Uphone)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl values('" + Username.Text + "','" + FullName.Text + "','" + Password.Text + "','" + Phone.Text + "')", Connection);
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully!");
                ResetFields();
                populateDataGridView();
                Connection.Close();
            }
            catch { }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            if (Phone.Text == "")
            {
                MessageBox.Show("Please select a user to delete!");
            }
            else
            {
                string deletequery = "DELETE FROM UserTbl WHERE Uphone='" + Phone.Text + "';";
                SqlCommand cmd = new SqlCommand(deletequery, Connection);
                //cmd.Parameters.AddWithValue("@Uphone", Phone.Text);
                try
                {
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully!");
                    ResetFields();
                    populateDataGridView();
                    Connection.Close();
                }
                catch { }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Username.Text = UserDGV?.SelectedRows[0].Cells[0].Value?.ToString();
            FullName.Text = UserDGV?.SelectedRows[0].Cells[1].Value?.ToString();
            Password.Text = UserDGV?.SelectedRows[0].Cells[2].Value?.ToString();
            Phone.Text = UserDGV?.SelectedRows[0].Cells[3].Value?.ToString();
        }

        private void EditBttn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl set Uname='" + Username.Text + "',Ufullname='" + FullName.Text + "',Upassword='" + Password.Text + "',Uphone='" + Phone.Text + "'where Uphone='" + Phone.Text + "'", Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully!");
                ResetFields();
                populateDataGridView();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
