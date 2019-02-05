using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Assessment
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFormCOntrols();
        }

        private void LoadFormCOntrols()
        {
            comboBox2.Items.Clear();
            for (int i = 18; i < 40; i++)
            {
                comboBox1.Items.Add(i);
            }
            string str;
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                cmd = new SqlCommand("select Id from Employees", con);
                con.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBox2.Items.Add(sdr["Id"]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToUpper();
            string email = txtEmail.Text.ToUpper();
            int age = int.Parse(comboBox1.Text);
            string str;
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                cmd = new SqlCommand("Insert into Employees Values(@a1,@a2,@a3)", con);
                cmd.Parameters.AddWithValue("@a1", name);
                cmd.Parameters.AddWithValue("@a2", email);
                cmd.Parameters.AddWithValue("@a3", age);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception sqle)
            {

                MessageBox.Show(sqle.Message);
            }
            finally
            {
                if(ConnectionState.Open== con.State)
                {
                    con.Close();
                }
            }
            MessageBox.Show("Data Saved Successfully");
            LoadFormCOntrols();


        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string str;
            int i = 0;
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                cmd = new SqlCommand("update Employees set Name=@a1  where Id=@a2", con);
                cmd.Parameters.AddWithValue("@a1", txtName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@a2", comboBox2.Text);
                con.Open();
                i=cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception sqle)
            {

                MessageBox.Show(sqle.Message);
            }
            finally
            {
                if (ConnectionState.Open == con.State)
                {
                    con.Close();
                }
            }
            if (i != 0)
            {
                MessageBox.Show("Name Updated Successfully");
            }

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

            string str;
            int i = 0;
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                cmd = new SqlCommand("update Employees set Email=@a1  where Id=@a2", con);
                cmd.Parameters.AddWithValue("@a1", txtEmail.Text.ToUpper());
                cmd.Parameters.AddWithValue("@a2", comboBox2.Text);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception sqle)
            {

                MessageBox.Show(sqle.Message);
            }
            finally
            {
                if (ConnectionState.Open == con.State)
                {
                    con.Close();
                }
            }
            if (i != 0)
            {
                MessageBox.Show("Email Updated Successfully");
            }

        }

        private void btnAge_Click(object sender, EventArgs e)
        {

            string str;
            int i = 0;
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                cmd = new SqlCommand("update Employees set Age=@a1  where Id=@a2", con);
                cmd.Parameters.AddWithValue("@a1", comboBox1.Text);
                cmd.Parameters.AddWithValue("@a2", comboBox2.Text);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception sqle)
            {

                MessageBox.Show(sqle.Message);
            }
            finally
            {
                if (ConnectionState.Open == con.State)
                {
                    con.Close();
                }
            }
            if (i != 0)
            {
                MessageBox.Show("Age Updated Successfully");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            SqlDataReader sdr;
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                cmd = new SqlCommand("select * from Employees where Id=@a1", con);
                cmd.Parameters.AddWithValue("@a1", comboBox2.Text);
                con.Open();
                sdr=cmd.ExecuteReader();
                if (sdr.Read())
                {
                    txtName.Text = sdr["Name"].ToString();
                    txtEmail.Text = sdr["Email"].ToString();
                    comboBox1.Text = sdr["Age"].ToString();

                }
                con.Close();
            }
            catch (Exception sqle)
            {

                MessageBox.Show(sqle.Message);
            }
            finally
            {
                if (ConnectionState.Open == con.State)
                {
                    con.Close();
                }
            }
        }
    }
}
