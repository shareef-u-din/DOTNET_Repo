using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            this.customerId = customerId;
        }
        public static int instanceCount { get; set; }
        private string _lastName;


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int customerId { get; private set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public void Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            return isValid;
        }


    }
}
