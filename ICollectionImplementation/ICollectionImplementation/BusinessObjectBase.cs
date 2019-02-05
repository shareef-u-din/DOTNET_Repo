using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionImplementation
{
    /// <summary>
    /// Abstract base class for all business object in the Business Logic Layer
    /// </summary>
    public abstract class BusinessObjectBase
    {
        #region "Member Variables"

        protected Guid? _UniqueId;  //local member variable which stores the object's UniqueId

        #endregion

        #region "Constructors"

        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessObjectBase()
        {
            //create a new unique id for this business object
            _UniqueId = Guid.NewGuid();
        }

        #endregion

        #region "Properties"

        /// <summary>
        /// UniqueId property for every business object
        /// </summary>
        public Guid? UniqueId
        {
            get
            {
                return _UniqueId;
            }
            set
            {
                _UniqueId = value;
            }
        }

        #endregion
    }
}
