using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAFROMXML
{
    public class XMLDEMO
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class file
        {

            private fileAmericas americasField;

            private fileAsia asiaField;

            private fileEuropeMiddleEastandAfrica europeMiddleEastandAfricaField;

            /// <remarks/>
            public fileAmericas Americas
            {
                get
                {
                    return this.americasField;
                }
                set
                {
                    this.americasField = value;
                }
            }

            /// <remarks/>
            public fileAsia Asia
            {
                get
                {
                    return this.asiaField;
                }
                set
                {
                    this.asiaField = value;
                }
            }

            /// <remarks/>
            public fileEuropeMiddleEastandAfrica EuropeMiddleEastandAfrica
            {
                get
                {
                    return this.europeMiddleEastandAfricaField;
                }
                set
                {
                    this.europeMiddleEastandAfricaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericas
        {

            private fileAmericasIndustry[] industriesField;

            private fileAmericasProducts productsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("industry", IsNullable = false)]
            public fileAmericasIndustry[] industries
            {
                get
                {
                    return this.industriesField;
                }
                set
                {
                    this.industriesField = value;
                }
            }

            /// <remarks/>
            public fileAmericasProducts products
            {
                get
                {
                    return this.productsField;
                }
                set
                {
                    this.productsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasIndustry
        {

            private fileAmericasIndustryApplication[] applicationField;

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("application")]
            public fileAmericasIndustryApplication[] application
            {
                get
                {
                    return this.applicationField;
                }
                set
                {
                    this.applicationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasIndustryApplication
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasProducts
        {

            private fileAmericasProductsBussinessunit[] bussinessunitsField;

            private fileAmericasProductsGroupname[] brandsField;

            private fileAmericasProductsProduct[] productgroupsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("bussinessunit", IsNullable = false)]
            public fileAmericasProductsBussinessunit[] bussinessunits
            {
                get
                {
                    return this.bussinessunitsField;
                }
                set
                {
                    this.bussinessunitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("groupname", IsNullable = false)]
            public fileAmericasProductsGroupname[] brands
            {
                get
                {
                    return this.brandsField;
                }
                set
                {
                    this.brandsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
            public fileAmericasProductsProduct[] productgroups
            {
                get
                {
                    return this.productgroupsField;
                }
                set
                {
                    this.productgroupsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasProductsBussinessunit
        {

            private fileAmericasProductsBussinessunitProduct[] productField;

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("product")]
            public fileAmericasProductsBussinessunitProduct[] product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasProductsBussinessunitProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasProductsGroupname
        {

            private fileAmericasProductsGroupnameProduct[] productField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("product")]
            public fileAmericasProductsGroupnameProduct[] product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasProductsGroupnameProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAmericasProductsProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsia
        {

            private fileAsiaIndustry[] industriesField;

            private fileAsiaProducts productsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("industry", IsNullable = false)]
            public fileAsiaIndustry[] industries
            {
                get
                {
                    return this.industriesField;
                }
                set
                {
                    this.industriesField = value;
                }
            }

            /// <remarks/>
            public fileAsiaProducts products
            {
                get
                {
                    return this.productsField;
                }
                set
                {
                    this.productsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaIndustry
        {

            private fileAsiaIndustryApplication[] applicationField;

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("application")]
            public fileAsiaIndustryApplication[] application
            {
                get
                {
                    return this.applicationField;
                }
                set
                {
                    this.applicationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaIndustryApplication
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaProducts
        {

            private fileAsiaProductsBussinessunit[] bussinessunitsField;

            private fileAsiaProductsGroupname[] brandsField;

            private fileAsiaProductsProduct[] productgroupsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("bussinessunit", IsNullable = false)]
            public fileAsiaProductsBussinessunit[] bussinessunits
            {
                get
                {
                    return this.bussinessunitsField;
                }
                set
                {
                    this.bussinessunitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("groupname", IsNullable = false)]
            public fileAsiaProductsGroupname[] brands
            {
                get
                {
                    return this.brandsField;
                }
                set
                {
                    this.brandsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
            public fileAsiaProductsProduct[] productgroups
            {
                get
                {
                    return this.productgroupsField;
                }
                set
                {
                    this.productgroupsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaProductsBussinessunit
        {

            private fileAsiaProductsBussinessunitProduct[] productField;

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("product")]
            public fileAsiaProductsBussinessunitProduct[] product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaProductsBussinessunitProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaProductsGroupname
        {

            private fileAsiaProductsGroupnameProduct[] productField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("product")]
            public fileAsiaProductsGroupnameProduct[] product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaProductsGroupnameProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileAsiaProductsProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfrica
        {

            private fileEuropeMiddleEastandAfricaIndustry[] industriesField;

            private fileEuropeMiddleEastandAfricaProducts productsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("industry", IsNullable = false)]
            public fileEuropeMiddleEastandAfricaIndustry[] industries
            {
                get
                {
                    return this.industriesField;
                }
                set
                {
                    this.industriesField = value;
                }
            }

            /// <remarks/>
            public fileEuropeMiddleEastandAfricaProducts products
            {
                get
                {
                    return this.productsField;
                }
                set
                {
                    this.productsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaIndustry
        {

            private fileEuropeMiddleEastandAfricaIndustryApplication[] applicationField;

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("application")]
            public fileEuropeMiddleEastandAfricaIndustryApplication[] application
            {
                get
                {
                    return this.applicationField;
                }
                set
                {
                    this.applicationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaIndustryApplication
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaProducts
        {

            private fileEuropeMiddleEastandAfricaProductsBussinessunit[] bussinessunitsField;

            private fileEuropeMiddleEastandAfricaProductsGroupname[] brandsField;

            private fileEuropeMiddleEastandAfricaProductsProduct[] productgroupsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("bussinessunit", IsNullable = false)]
            public fileEuropeMiddleEastandAfricaProductsBussinessunit[] bussinessunits
            {
                get
                {
                    return this.bussinessunitsField;
                }
                set
                {
                    this.bussinessunitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("groupname", IsNullable = false)]
            public fileEuropeMiddleEastandAfricaProductsGroupname[] brands
            {
                get
                {
                    return this.brandsField;
                }
                set
                {
                    this.brandsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("product", IsNullable = false)]
            public fileEuropeMiddleEastandAfricaProductsProduct[] productgroups
            {
                get
                {
                    return this.productgroupsField;
                }
                set
                {
                    this.productgroupsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaProductsBussinessunit
        {

            private fileEuropeMiddleEastandAfricaProductsBussinessunitProduct[] productField;

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("product")]
            public fileEuropeMiddleEastandAfricaProductsBussinessunitProduct[] product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaProductsBussinessunitProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaProductsGroupname
        {

            private fileEuropeMiddleEastandAfricaProductsGroupnameProduct[] productField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("product")]
            public fileEuropeMiddleEastandAfricaProductsGroupnameProduct[] product
            {
                get
                {
                    return this.productField;
                }
                set
                {
                    this.productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaProductsGroupnameProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class fileEuropeMiddleEastandAfricaProductsProduct
        {

            private string idField;

            private string urlField;

            private string nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }


    }
}
