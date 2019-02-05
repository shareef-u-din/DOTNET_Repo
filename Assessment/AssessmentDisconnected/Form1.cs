using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AssessmentDisconnected
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder cbdr;

        public Form1()
        {
            InitializeComponent();
        }


        private void LoadFormCOntrols()
        {
            comboBox2.Items.Clear();
            for (int i = 18; i < 40; i++)
            {
                comboBox1.Items.Add(i);
            }
            int id = 0;
            foreach (var item in ds.Tables["Employees"].AsEnumerable())
            {
                comboBox2.Items.Add(item["Id"]);

            }


        #region commentData
        //string str;
        //SqlDataReader sdr;
        //DataTable dt = new DataTable();
        //try
        //{
        //    str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
        //    con = new SqlConnection(str);
        //    cmd = new SqlCommand("select Id from Employees", con);
        //    con.Open();
        //    sdr = cmd.ExecuteReader();
        //    while (sdr.Read())
        //    {
        //        comboBox2.Items.Add(sdr["Id"]);
        //    }
        //    con.Close();

        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
        #endregion
    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Query = from row in ds.Tables["Employees"].AsEnumerable()
                        orderby row["Id"] descending
                        select row;
            var maxid = Query.FirstOrDefault();
            DataRow dr = ds.Tables["Employees"].NewRow();
            dr["Id"] = (int)maxid["Id"] + 1;
            dr["Name"] = txtName.Text.ToUpper();
            dr["Email"] = txtEmail.Text.ToUpper();
            dr["Age"] = comboBox1.Text;
            ds.Tables["Employees"].Rows.Add(dr);
            #region commentedData

            //string name = txtName.Text.ToUpper();
            //string email = txtEmail.Text.ToUpper();
            //int age = int.Parse(comboBox1.Text);
            //string str;
            //try
            //{
            //    str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
            //    con = new SqlConnection(str);
            //    cmd = new SqlCommand("Insert into Employees Values(@a1,@a2,@a3)", con);
            //    cmd.Parameters.AddWithValue("@a1", name);
            //    cmd.Parameters.AddWithValue("@a2", email);
            //    cmd.Parameters.AddWithValue("@a3", age);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //catch (Exception sqle)
            //{

            //    MessageBox.Show(sqle.Message);
            //}
            //finally
            //{
            //    if (ConnectionState.Open == con.State)
            //    {
            //        con.Close();
            //    }
            //}
            #endregion
            MessageBox.Show("Data Saved Successfully");
            LoadFormCOntrols();


        }

        private void btnName_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (var row in ds.Tables["Employees"].AsEnumerable())
            {
                if(row["Id"].ToString() == comboBox2.Text)
                {
                    row["Name"] = txtName.Text.ToUpper();
                    i = 1;
                    break;
                }

            }

            if (i != 0)
            {
                MessageBox.Show("Name Updated Successfully");
            }

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

            int i = 0;
            foreach (var row in ds.Tables["Employees"].AsEnumerable())
            {
                if (row["Id"].ToString() == comboBox2.Text)
                {
                    row["Email"] = txtEmail.Text.ToUpper();
                    i = 1;
                    break;
                }

            }

            if (i != 0)
            {
                MessageBox.Show("Email Updated Successfully");
            }

        }

        private void btnAge_Click(object sender, EventArgs e)
        {

            int i = 0;
            foreach (var row in ds.Tables["Employees"].AsEnumerable())
            {
                if (row["Id"].ToString() == comboBox2.Text)
                {
                    row["Age"] = comboBox1.Text;
                    i = 1;
                    break;
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
            try
            {
                var data = from row in ds.Tables["Employees"].AsEnumerable()
                           where row.Field<int>("Id") == int.Parse(comboBox2.Text)
                           select new
                           {
                               EmployeeName = row.Field<string>("Name"),
                               EmployeeEmail = row.Field<string>("Email"),
                               EmployeeAge = row.Field<int>("Age").ToString()

                           };
                foreach (var item in data)
                {
                    txtName.Text = item.EmployeeName;
                    txtEmail.Text = item.EmployeeEmail;
                    comboBox1.Text = item.EmployeeAge;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;
                con = new SqlConnection(str);
                sda = new SqlDataAdapter("select * from Employees", con);
                ds = new DataSet();
                cbdr = new SqlCommandBuilder(sda);
                sda.Fill(ds, "Employees");

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
            LoadFormCOntrols();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("DO YOU WANT COMMIT CHANGES TO DATABASE", "DATA COMMIT", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    sda.Update(ds, "Employees");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Changes not committed");
                return;
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCommit_Click(sender,e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
