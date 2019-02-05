using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionImplementation
{
    public class BusinessObjectCollection<T> : ICollection<T> where T : BusinessObjectBase
    {
        #region "Member Variables"

        protected ArrayList _innerArray;  //inner ArrayList object
        protected bool _IsReadOnly;       //flag for setting collection to read-only mode (not used in this example)

        #endregion

        #region "Constructors"

        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessObjectCollection()
        {
            _innerArray = new ArrayList();
        }

        #endregion

        #region "Properties"

        /// <summary>
        /// Default accessor for the collection
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual T this[int index]
        {
            get
            {
                return (T)_innerArray[index];
            }
            set
            {
                _innerArray[index] = value;
            }
        }

        /// <summary>
        /// Number of elements in the collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                return _innerArray.Count;
            }
        }

        /// <summary>
        /// Flag sets whether or not this collection is read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return _IsReadOnly;
            }
        }

        #endregion

        #region "Methods"

        /// <summary>
        /// Add a business object to the collection
        /// </summary>
        /// <param name="BusinessObject"></param>
        public virtual void Add(T BusinessObject)
        {
            _innerArray.Add(BusinessObject);
        }

        /// <summary>
        /// Remove first instance of a business object from the collection
        /// </summary>
        /// <param name="BusinessObject"></param>
        /// <returns></returns>
        public virtual bool Remove(T BusinessObject)
        {
            bool result = false;

            //loop through the inner array's indices
            for (int i = 0; i < _innerArray.Count; i++)
            {
                //store current index being checked
                T obj = (T)_innerArray[i];

                //compare the BusinessObjectBase UniqueId property
                if (obj.UniqueId == BusinessObject.UniqueId)
                {
                    //remove item from inner ArrayList at index i
                    _innerArray.RemoveAt(i);
                    result = true;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns true/false based on whether or not it finds the requested object in the collection.
        /// </summary>
        /// <param name="BusinessObject"></param>
        /// <returns></returns>
        public bool Contains(T BusinessObject)
        {
            //loop through the inner ArrayList
            foreach (T obj in _innerArray)
            {
                //compare the BusinessObjectBase UniqueId property
                if (obj.UniqueId == BusinessObject.UniqueId)
                {
                    //if it matches return true
                    return true;
                }
            }

            //no match
            return false;
        }

        /// <summary>
        /// Copy objects from this collection into another array
        /// </summary>
        /// <param name="BusinessObjectArray"></param>
        /// <param name="index"></param>
        public virtual void CopyTo(T[] BusinessObjectArray, int index)
        {
            throw new Exception("This Method is not valid for this implementation.");
        }

        /// <summary>
        /// Clear the collection of all it's elements
        /// </summary>
        public virtual void Clear()
        {
            _innerArray.Clear();
        }

        /// <summary>
        /// Returns custom generic enumerator for this BusinessObjectCollection
        /// </summary>
        /// <returns></returns>


        /// <summary>
        /// Explicit non-generic interface implementation for IEnumerable extended and required by ICollection (implemented by ICollection<T>)
        /// </summary>
        /// <returns></returns>


        #endregion
    }
}
