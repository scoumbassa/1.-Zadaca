using System;
using System.Collections;
using System.Collections.Generic;

public class GenericListEnumerator<T> : IEnumerator<T>
{
    private IGenericList<T> _collection;
    int position = -1;
    public GenericListEnumerator(IGenericList<T> collection)
    {
       _collection = collection;

    }


    public T Current
    {
        get
        {
            return _collection.GetElement(position);
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        position++;
        return (position < _collection.Count);
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

}
