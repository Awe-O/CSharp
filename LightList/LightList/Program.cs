using System;

namespace LightList
{
    class Program
    {
        static void Main(string[] args)
        {
            LightList<Item> myLightList = new LightList<Item>(20);
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

            LightList<Item> myLightList1 = new LightList<Item>();
            if (myLightList1.Count() == 0 && myLightList1.CountArrayLenght() == 100)
            {
                Console.WriteLine("The resulting lenghts in {0} are as expected!", nameof(myLightList1));
            }
        }
    }
}
