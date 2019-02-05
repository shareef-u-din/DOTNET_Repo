using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGenericIEnumerable
{
    public class EnumerableGeneric<T> : IEnumerable<T>, IEnumerator<T>
    {
        List<T> list;
        public EnumerableGeneric()
        {
            list = new List<T>();
        }
        public void Add(T obj)
        {
            list.Add(obj);
        }
        private T _current;
        // Implement the IEnumerator(T).Current publicly, but implement
        // IEnumerator.Current, which is also required, privately.
        public T Current
        {

            get
            {
                if (list == null)
                {
                    throw new InvalidOperationException();
                }


                return _current;
            }
        }

        private object Current1
        {

            get { return this.Current; }
        }

        object IEnumerator.Current
        {
            get { return Current1; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            int c=list.IndexOf(Current);
            int num = list.Count;
            if(c < num-1)
            {
                _current = list.ElementAt(c + 1);
                return true;
            }
            return false;
        }

        public void Reset()
        {

            list.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Dispose()
        {


        }
        // Implement IDisposable, which is also implemented by IEnumerator(T).




    }
}
