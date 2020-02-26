using System;
using System.Collections.Generic;
using LightListProject.Common.Log;
using LightListProject.Items;

namespace LightListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 5: добавить логирование
            ILogger logger = new NlogLogger();

            //задание 1: List = 100
            Console.WriteLine("Задание 1: List = 100");
            LightList<Item> myLightList1 = new LightList<Item>(logger);
            if (myLightList1.Count() == 0 && myLightList1.CountArrayLenght() == 100)
            {
                Console.WriteLine("The resulting lenghts in {0} are as expected!", nameof(myLightList1));
            }


            //задание 2: List произвольной длинны
            Console.WriteLine("\r\nЗадание 2: List произвольной длинны");

            LightList <Item> myLightList = new LightList<Item>(20, logger);
            myLightList.Add(new Item() { Id = 1 });
            myLightList.Add(new Item() { Id = 2 });
            myLightList.Add(new Item() { Id = 3 });

            if (myLightList.Count() == 3)
                Console.WriteLine("Items in list: {0}", myLightList.Count());

            Item itemToRemove = new Item() { Id = 87 };
            myLightList.Add(itemToRemove);

            Item itemToRemove1 = new Item() { Id = 93 };
            myLightList.Add(itemToRemove1);

            Item itemToRemove2 = new Item() { Id = 32 };
            myLightList.Add(itemToRemove2);

            myLightList.Remove(itemToRemove);
            myLightList.Remove(itemToRemove2);
            if (myLightList.Count() == 4)
                Console.WriteLine("Items in list (3 item added and 2 items removed): {0}", myLightList.Count());

            myLightList.Add(new Item() { Id = 99 });

            if (myLightList.Count() == 5 && myLightList.CountArrayLenght() == 20)
            {
                Console.WriteLine("The resulting lenghts in {0} are as expected!", nameof(myLightList));
            }


            //задание 3: структуру можно использовать в операторе foreach
            Console.WriteLine("\r\nЗадание 3: структуру можно использовать в операторе foreach");
            LightList<Item> myLightList2 = new LightList<Item>(10, logger);
            int iterator = 1;
            foreach (Item item in myLightList2)            
            {
                myLightList2.Add(new Item() { Id = iterator });                
                iterator += 2;
            }

            int iterator1 = 0;
            foreach (Item item in myLightList2)
            {
                Item itemId = myLightList2.GetObjectByIndex(iterator1);
                Console.WriteLine("Id of Item{0} = {1}", iterator1 + 1, itemId.Id);
                iterator1++;
            }


            //задание 4: структуру можно передовать в конструктор List<> и в него можно передавать конструктор List<>
            Console.WriteLine("\r\nЗадание 4: структуру можно передавать в " +
                "конструктор List<> и в него можно передавать конструктор List<>");
            List<Item> myLightList3 = new List<Item>();
            myLightList3.Add(new Item() { Id = 999 });
            myLightList3.Add(new Item() { Id = 888 });
            myLightList3.Add(new Item() { Id = 777 });

            LightList<Item> myLightList4 = new LightList<Item>(myLightList3, logger);
            
            List<Item> myLightList5 = new List<Item>(myLightList4);
            if (myLightList5.Count == 3)
                Console.WriteLine("Items in list: {0}", myLightList5.Count);
        }
    }
}
