using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionImplementation
{
    public class BusinessObjectEnumerator<T> :IEnumerable<T>  where T : BusinessObjectBase
    {
        #region "Member Variables"

        protected BusinessObjectCollection<T> _collection;  //enumerated collection
        protected int index;                                //current index
        protected T _current;                               //current enumerated object in the collection

        #endregion

        #region "Constructors"

        /// <summary>
        /// Default constructor
        /// </summary>
        public BusinessObjectEnumerator()
        {
            //nothing
        }

        /// <summary>
        /// Paramaterized constructor which takes the collection which this enumerator will enumerate
        /// </summary>
        /// <param name="collection"></param>
        public BusinessObjectEnumerator(BusinessObjectCollection<T> collection)
        {
            _collection = collection;
            index = -1;
            _current = default(T);
        }

        #endregion

        #region "Properties"

        /// <summary>
        /// Current Enumerated object in the inner collection
        /// </summary>
        public virtual T Current
        {
            get
            {
                return _current;
            }
        }

        /// <summary>
        /// Explicit non-generic interface implementation for IEnumerator (extended and required by IEnumerator<T>)
        /// </summary>

        #endregion

        #region "Methods"

        /// <summary>
        /// Dispose method
        /// </summary>
        public virtual void Dispose()
        {
            _collection = null;
            _current = default(T);
            index = -1;
        }


        public void Add(T BusinessObject)
        {
            _collection.Add(BusinessObject);
        }

        /// <summary>
        /// Move to next element in the inner collection
        /// </summary>
        /// <returns></returns>
        public virtual bool MoveNext()
        {
            //make sure we are within the bounds of the collection
            if (++index >= _collection.Count)
            {
                //if not return false
                return false;
            }
            else
            {
                //if we are, then set the current element to the next object in the collection
                _current = _collection[index];
            }

            //return true
            return true;
        }

        /// <summary>
        /// Reset the enumerator
        /// </summary>
        public virtual void Reset()
        {
            _current = default(T); //reset current object
            index = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _collection.Count<T>(); i++)
            {
                yield return _collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion
    }
}
