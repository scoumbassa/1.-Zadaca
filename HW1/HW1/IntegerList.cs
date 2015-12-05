using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int _lastAddedElement = 0;

        public IntegerList()
        {
            _internalStorage = new int[4];
        
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
        }

        public int Count
        {
            get
            {
               return _lastAddedElement;
            }
        }

        public void Add(int item)
        {
            if(_lastAddedElement >= _internalStorage.Length)
            {
                Array.Resize(ref _internalStorage, 2 * _internalStorage.Length);
            }
            
            _internalStorage[_lastAddedElement] = item;
            _lastAddedElement++;
        }

        public void Clear()
        {
            
            Array.Clear(_internalStorage, 0, Count);
            _lastAddedElement = 0;

        }

        public bool Contains(int item)
        {
            if (_internalStorage.Contains(item))
            {
                return true;
            }
            else
                return false;
        }

        public int GetElement(int index)
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

        public int IndexOf(int item)
        {
            
            for(int i=0, size = Count; i < size; i++)
            {
                if(_internalStorage[i] == item)
                {
                    return i;
                }
                
            }
            return -1;
        }

        public bool Remove(int item)
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
            _internalStorage[i] = 0;
            _lastAddedElement--;
            return true;
        }
    }
}
