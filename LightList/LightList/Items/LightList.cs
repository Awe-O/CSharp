using System;
using System.Collections.Generic;
using System.Collections;
using LightListProject.Common;
using LightListProject.Common.Log;

namespace LightListProject.Items
{
    public class LightList<TObject> : ILightList<TObject>
        where TObject : class
    {
        private TObject[] _listOfObjects;
        private ILogger _logger;
        public int Index { get; set; } = 0;

        public LightList(ILogger logger)
        {
            _logger = logger;
            _listOfObjects = new TObject[100];
        }

        public LightList(int lenghOfArray, 
            ILogger logger) : this(logger)
        {
            _listOfObjects = new TObject[lenghOfArray];
        }

        public LightList(List<TObject> list,
            ILogger logger) : this (logger)
        {
            int lenghOfArray = list.Count;
            _listOfObjects = new TObject[lenghOfArray];

            while (lenghOfArray > 0)
            {
                _logger.Info("Item added to the LightList.");
                Add(list[lenghOfArray - 1]);
                lenghOfArray--;
            }
        }

        public void Add(TObject itemToAdd)
        {
            _logger.Info("Item added to the LightList.");
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
            return _listOfObjects[indexOfItem];
        }

        public void Remove(TObject item)
        {
            _logger.Info("Item removed from the LightList.");
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
