using System;
using System.Collections;
using System.Collections.Generic;

namespace HW1
{
    internal class GenericListEnumerator<T> : IEnumerator<T>
    {
        private GenericList<object> genericList;

        public GenericListEnumerator(GenericList<object> genericList)
        {
            this.genericList = genericList;
        }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}