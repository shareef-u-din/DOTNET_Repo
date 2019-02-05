using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DATAFROMXML
{
    public class SQLDemo
    {
        public SQLDemo()
        {
            ltDataContext = new LinqTestsDataContext();
        }
        LinqTestsDataContext ltDataContext;

        public void DipslayData()
        {
            foreach (var item in ltDataContext.Employees)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName +",       "+item.Gender);
            }
        }
        public void insert(string fname,string lname,int deartmentId,float salary)
        {

            Console.WriteLine("Inside Insert Method");
            Employee emp = new Employee();
            emp.FirstName = fname;
            emp.LastName = lname;
            emp.DepartmentId = deartmentId;
            emp.Salary = salary;
            emp.Gender="Male";
            ltDataContext.Employees.InsertOnSubmit(emp);
            ltDataContext.SubmitChanges();
            DipslayData();
        }




    }
}
