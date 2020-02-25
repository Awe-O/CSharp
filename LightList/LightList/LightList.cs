using System;
using System.Collections.Generic;
using System.Collections;

namespace LightListProject
{
    public class LightList<TObject> : ILightList<TObject>
        where TObject : class
    {
        private TObject[] _listOfObjects = new TObject[100];
        public int Index { get; set; } = 0;

        public LightList()
        {

        }

        public LightList(int itemsInList)
        {
            _listOfObjects = new TObject[itemsInList];
        }

        public LightList(List<TObject> list)
        {

        }

        public void Add(TObject itemToAdd)
        {
            _listOfObjects[Index] = itemToAdd;
            Index++;
            return;
        }
        
        public int Count()
        {
            int indexOfItem = _listOfObjects.Length - 1;
            int indexWithValue = 0;
            while (indexOfItem >= 0)
            {
                if (_listOfObjects[indexOfItem] != null)
                    indexWithValue++;
                indexOfItem--;
            }
            return indexWithValue;
        }

        public int CountArrayLenght()
        {
            return _listOfObjects.Length;
        }

        private int _IndexOf(TObject[] _listOfObjects, TObject item)
        {
            int getIndex = Array.IndexOf(_listOfObjects, item);
            return getIndex;
        }

        public TObject GetObjectByIndex (int indexOfItem)
        {
            return (TObject)_listOfObjects.GetValue(indexOfItem);
        }

        public void Remove(TObject item)
        {            
            if (_listOfObjects.Length > 0)
            {
                int getIndex = _IndexOf(_listOfObjects, item);

                if (_listOfObjects[getIndex + 1] == null)
                {
                    _listOfObjects[getIndex] = null;
                }
                else
                {
                    for (int i = getIndex; i < _listOfObjects.Length; i++)
                    {
                        if (_listOfObjects[i] == null)
                            break;

                        _listOfObjects[i] = _listOfObjects[i + 1];
                    }                    
                }
                return;
            }
            Console.WriteLine("Add items to list before delet it.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<TObject> GetEnumerator()
        {
            foreach (TObject obj in _listOfObjects)
            {                
                yield return obj;
            }
        }





    }
}
