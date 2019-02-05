using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DATAFROMXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //XDocument xdoc = XDocument.Load(@"D:\DOT-NET\generatedMenu.xml");
            //XElement element = xdoc.Root;

            //var BbusinessQuery = from node in element.Elements()
            //                     where node.Name == "Americas"
            //                     select node.Element("products").Element("bussinessunits");


            //var list = new List<string>();

            //foreach (var businessUnits in BbusinessQuery.Elements<XElement>())
            //{
            //    //Console.WriteLine(businessUnits.Attribute("id").Value);
            //    if (businessUnits.Attribute("id").Value == "7c507fbd-6791-45e1-a9b8-62c155217ee5")
            //    {
            //        foreach (var businessUnit in businessUnits.Elements())
            //        {
            //            list.Add(businessUnit.Attribute("name").Value);
            //        }
            //    }


            //}


            //Console.WriteLine("*******************************Industries*********************************");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //var x = new Form1();
            //x.Show();
            //    SQLDemo sd = new SQLDemo();
            //    sd.DipslayData();
            //    Console.WriteLine("Enter DepartmentId to Insert record");
            //    int id=int.Parse(Console.ReadLine());
            //    sd.insert("shareef","bhat",id,20000);
            //    Console.ReadKey();
            //}
            //var nodeNames = XDocument.Load(@"D:\DOT-NET\generatedMenu.xml")
            //               .Descendants("industry");
            //var industryNames = nodeNames.Descendants<XElement>("application");
            //var names = from name in industryNames
            //            select name.Attribute("name").Value;
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            //// Console.Beep();
            //// Console.Clear();

            //var xmlDoc = XDocument.Load(@"D:\VISUAL_STUDIO_PROGRAMS\DATAFROMXML\DATAFROMXML\Data\Country.xml");
            //var countries = xmlDoc.Descendants("country");

            //var countryNames = from country in countries.Elements<XElement>("title")
            //                    select country.Value;
            //var cityNames = from citys in countries.Elements<XElement>("cities").Elements<XElement>("city")
            //                select citys.Value;
            //var countrylist = countryNames.ToList<string>();


            //var displayData = from element in countries
            //                  select new
            //                  {
            //                      country = element.Element("title").Value,
            //                      baakiElements = element.Elements("cities").Elements<XElement>("city")

            //                  };
            //Console.WriteLine("\n\n*******************************************************************************");
            //foreach (var country in displayData)
            //{
            //    Console.WriteLine("********************"+country.country+"*******************");
            //    foreach (var citz in country.baakiElements)
            //    {
            //        Console.WriteLine(citz.Value);
            //    }
            //}


            //.Elements<XElement>("string").OrderBy(e=> e.Value)
            Console.WriteLine("*******************************************************************************");
            var document = XDocument.Load(@"D:\VISUAL_STUDIO_PROGRAMS\DATAFROMXML\DATAFROMXML\Data\CountriesStattes.xml");
            var countries = from country in document.Descendants("dict").Elements<XElement>("array").Elements<XElement>("dict")
                            select new
                            {
                                CountryName = country.Element("string").Value,
                                stateNames = country.Elements("array").Elements<XElement>("dict"),
                                Cities = country.Elements("array").Elements<XElement>("dict").Elements<XElement>("array").Elements<XElement>("string")

                            };
            foreach (var country in countries)
            {
                if (country.CountryName == "India")
                {
                    Console.WriteLine("***********************************   " + country.CountryName + "    **************************************");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    foreach (var state in country.stateNames)
                    {

                        // Console.WriteLine(state.Value);
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    foreach (var city in country.Cities)
                    {
                        // Console.WriteLine(city.Value);
                    }
                    Console.WriteLine("*************************************************************************");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            Console.WriteLine("*******************************************************************************");

            foreach (var country in countries)
            {
                if (country.CountryName == "India")
                    foreach (var state in country.stateNames.Elements<XElement>("string"))
                    {

                        if (state.Value == "Telangana")
                        {

                            foreach (var city in country.stateNames.Elements<XElement>("array").Elements<XElement>("string"))
                            {
                                if(city.Parent.Parent.Element("string").Value == "Telangana")
                                {
                                    Console.WriteLine(city.Value);
                                }

                            }

                        }

                    }
            }

            Console.WriteLine("*******************************************************************************");

            Console.ReadKey();
        }
    }
}
