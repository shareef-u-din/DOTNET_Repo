using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Web;

namespace RecruitmentForm
{
    /// <summary>
    /// Summary description for WorkFlow
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WorkFlow : System.Web.Services.WebService
    {

        [System.Web.Services.WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public string GetAllPractices()
        {
            List<string> test = new List<string>();
            test.Add(".NET PRACTICE");
            test.Add("AEM PRACTICE");
            test.Add("DEVOPS PRACTICE");
            //return test;
            return JsonConvert.SerializeObject(test, Newtonsoft.Json.Formatting.Indented);
        }

        [System.Web.Services.WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public void GetAllEmployees(string practice)
        {
            List<Employee> test = new List<Employee>();

            Employee e1 = new Employee { Practice = ".NET PRACTICE", Name = "Madhuri", Email = "adhikarlamadhuri66@gmail.com", Phone = "98789876788",Position="HR" };
            Employee e2 = new Employee { Practice = ".AEM PRACTICE", Name = "Bharvi", Email = "shareefudin0721@gmail.com", Phone = "94389876788",Position="TECH LEAD" };
            test.Add(e1);
            test.Add(e2);

            HttpContext.Current.Response.ContentType = "application/json";
            HttpContext.Current.Response.Write(JsonConvert.SerializeObject(test));
            HttpContext.Current.Response.End();
            //// Return JSON data
            //JavaScriptSerializer js = new JavaScriptSerializer();
            //string retJSON = js.Serialize(test);
            //return retJSON;
        }

       
    }


}
