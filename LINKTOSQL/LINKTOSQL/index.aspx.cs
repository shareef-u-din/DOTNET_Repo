using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINKTOSQL
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            LINQTOSQLDataContext lsql = new LINQTOSQLDataContext();
            GridView1.DataSource = from emp in lsql.Employees
                                   select emp;
            GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using(LINQTOSQLDataContext lsql=new LINQTOSQLDataContext())
            {
                Employee emp = new Employee
                {
                    FirstName="Fancy",
                    LastName="Fateh",
                    Gender="Female",
                    DepartmentId=3,
                    Salary=1000000
                };
                lsql.Employees.InsertOnSubmit(emp);
                lsql.SubmitChanges();
            }
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs ee)
        {
            LINQTOSQLDataContext lsql = new LINQTOSQLDataContext();
            var employee =lsql.Employees.SingleOrDefault(e => e.ID == 11);
            lsql.Employees.DeleteOnSubmit(employee);
            lsql.SubmitChanges();
            LoadData();

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}