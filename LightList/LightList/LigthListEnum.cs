using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LightList
{
    public class LigthListEnum<TObject> : ILightList<TObject>, IEnumerator
        where TObject : class
    {
        int position = -1;
        private TObject[] _listOfObjects;

        public LigthListEnum(TObject[] list)
        {
            _listOfObjects = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _listOfObjects.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public TObject Current
        {
            get
            {
                try
                {
                    return _listOfObjects[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

  

        public int Index { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void Add(TObject item)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Remove(TObject item)
        {
            throw new NotImplementedException();
        }
    }
}
