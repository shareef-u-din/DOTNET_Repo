using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLRead
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("D:\\sample.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            XmlTextReader r = new XmlTextReader(@"D:\CustomersDetail.xml");
            while (r.Read())
            {
                switch (r.NodeType)
                {
                    case XmlNodeType.Element:
                        {
                            Console.Write("<" + r.Name);
                            Console.WriteLine(">");
                            break;
                        }
                    case XmlNodeType.Text:
                        {
                            Console.WriteLine(r.Value);
                            break;
                        }
                    case XmlNodeType.EndElement:
                        {
                            Console.Write("</" + r.Name);
                            Console.WriteLine(">");
                            break;
                        }
                }
            }
            #region MakeXMLFile
            //Make xml file

            //XDocument xmlDocument = new XDocument(
            //   new XDeclaration("1.0", "utf-8", "yes"),

            //   new XComment("LINQ To XML Demo"),

            //   new XElement("Customers",
            //       new XElement("Customer", new XAttribute("CustID", 1001),
            //           new XElement("Name", "Abhishek"),
            //           new XElement("MobileNo", "9820098200"),
            //           new XElement("Location", "Mumbai"),
            //           new XElement("Address", "off link road malad west Mumbai")),

            //       new XElement("Customer", new XAttribute("CustID", 1002),
            //           new XElement("Name", "Rajesh"),
            //           new XElement("MobileNo", "9820011234"),
            //           new XElement("Location", "New Delhi"),
            //           new XElement("Address", "off link road laljatnagar New delhi")),

            //       new XElement("Customer", new XAttribute("CustID", 1003),
            //           new XElement("Name", "Rohan"),
            //           new XElement("MobileNo", "9820022200"),
            //           new XElement("Location", "Mumbai"),
            //           new XElement("Address", " link road Kandivali  west Mumbai")),

            //       new XElement("Customer", new XAttribute("CustID", 1004),
            //           new XElement("Name", "Sonali"),
            //           new XElement("MobileNo", "9820098200"),
            //           new XElement("Location", "Mumbai"),
            //           new XElement("Address", "khar west Mumbai"))
            //           ));

            //xmlDocument.Save(@"D:\CustomersDetail.xml");

            #endregion
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LINK TO XML");
            Console.Title = "LINK TO XML";
            var doc = XDocument.Load(@"D:\CustomersDetail.xml");
            var alldecendants = doc.Descendants();
            foreach (var item in doc.Descendants("Customer"))
            {
                foreach (var x in item.Elements())
                {
                    Console.WriteLine("Element " + x.Name + " Value = " + x.Value);
                }
                Console.WriteLine("*******************************************");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            var abc = doc.Descendants("Customer");
            var ww = from ids in abc
                     where Convert.ToInt32(ids.Attribute("CustID").Value) >= 1003
                     select ids;
            foreach (var item in ww)
            {
                foreach (var x in item.Elements())
                {
                    Console.WriteLine("Element:" + x.Name + ", Value = " + x.Value);
                }
                Console.WriteLine("*******************************************");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            string path = @"D:\csvfile.csv";
            StreamReader myFile = new StreamReader(new FileStream(path, FileMode.Open));
            string myString = myFile.ReadToEnd();
            myFile.Close();
            string[] lines = myString.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] columns = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                    //Upload to your DB with your indexes
                }
                else
                {
                }
            }
            Console.ReadLine();
        }
    }
}
