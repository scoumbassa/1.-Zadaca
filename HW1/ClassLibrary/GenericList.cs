using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int _lastAddedElementIndex = 0;

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        public int Count
        {
            get
            {
                return _lastAddedElementIndex;
            }
        }

        public void Add(X item)
        {
            if(_lastAddedElementIndex >= _internalStorage.Length)
            {
                Array.Resize(ref _internalStorage, 2 * _internalStorage.Length);
            }

            _internalStorage[_lastAddedElementIndex] = item;
            _lastAddedElementIndex++;
        }

        public void Clear()
        {
            Array.Clear(_internalStorage, 0, Count);
        }

        public bool Contains(X item)
        {
            if(_internalStorage.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public X GetElement(int index)
        {
            if(index < Count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        public int IndexOf(X item)
        {
            for(int i = 0, size = Count; i < size; i++)
            {
                if(_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(X item)
        {
            return RemoveAt(IndexOf(item));
        }

        public bool RemoveAt(int index)
        {
            if(index > Count-1 || index < 0)
            {
                return false;
            }
            int i;
            
            for(i = index; i < Count-1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            Array.Clear(_internalStorage, i, 1);
            _lastAddedElementIndex--;
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
