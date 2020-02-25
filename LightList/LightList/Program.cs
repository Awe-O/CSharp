using System;
using System.Collections.Generic;

namespace LightListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1: List = 100
            Console.WriteLine("Задание 1: List = 100");
            LightList<Item> myLightList1 = new LightList<Item>();
            if (myLightList1.Count() == 0 && myLightList1.CountArrayLenght() == 100)
            {
                Console.WriteLine("The resulting lenghts in {0} are as expected!", nameof(myLightList1));
            }


            //задание 2: List произвольной длинны
            Console.WriteLine("\r\nЗадание 2: List произвольной длинны");

            LightList <Item> myLightList = new LightList<Item>(20);
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
                Console.WriteLine("Items in list (1 item added and 2 items removed): {0}", myLightList.Count());

            myLightList.Add(new Item() { Id = 99 });

            if (myLightList.Count() == 5 && myLightList.CountArrayLenght() == 20)
            {
                Console.WriteLine("The resulting lenghts in {0} are as expected!", nameof(myLightList));
            }


            //задание 3: структуру можно использовать в операторе foreach
            Console.WriteLine("\r\nЗадание 3: структуру можно использовать в операторе foreach");
            LightList<Item> myLightList2 = new LightList<Item>(10);
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


            //задание 4: структуру можно передовать в конструктор List<> и в него можно было передавать в конструктор List<>
            Console.WriteLine("\r\nЗадание 4: структуру можно передовать в " +
                "конструктор List<> и в него можно было передавать в конструктор List<>");
            LightList<Item> myLightList3 = new LightList<Item>(new List<Item>());
            List<Item> myLightList4 = new List<Item>(myLightList3);
        }
    }
}
