using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentForm
{
    [Serializable]
    public class Employee
    {
        public string Practice { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }

    }
}