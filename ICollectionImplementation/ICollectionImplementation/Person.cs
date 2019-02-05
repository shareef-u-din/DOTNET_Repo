using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionImplementation
{
    public class Person : BusinessObjectBase
    {
        #region "Member Variables"

        private string _FirstName = "";
        private string _LastName = "";

        #endregion

        #region "Constructors"

        /// <summary>
        /// Paramaterized constructor for immediate instantiation
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        public Person(string first, string last)
        {
            _FirstName = first;
            _LastName = last;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
            //nothing
        }

        #endregion

        #region "Properties"

        /// <summary>
        /// Person' First Name
        /// </summary>
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        /// <summary>
        /// Person's Last Name
        /// </summary>
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        #endregion
    }
}
