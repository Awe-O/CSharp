using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //branchLeft.ShowDisplayName() - должен выводить "Левая ветка"
            BranchLeft branchLeft = new BranchLeft();
            Console.WriteLine("Название левой ветки: {0}", branchLeft.ShowDisplayName());

            //BranchLeft.Color - в левой ветке нет этого свойства, используется дефолтное из Branch
            //Branch.Color - по дефолту должно "Зеленый"
            Console.WriteLine("Цвет левой ветки (= дефолтному): {0}\r\n", branchLeft.Color);

            //branchRight.ShowDisplayName() - должен выводить "Правая ветка"
            BranchRight branchRight = new BranchRight();
            Console.WriteLine("Название правой ветки: {0}", branchRight.ShowDisplayName());
            
            //branchRight.Color - выводит "Жёлтый"
            Console.WriteLine("Цвет правой ветки (!= дефолтному): {0}\r\n", branchRight.Color);

            Root root = new Root();
            root.AddBranchToItems(branchRight);
            root.AddBranchToItems(branchLeft);
            root.PrintAllGreenBranchName();

            while (true)
            {
                Console.WriteLine("Введите цвет новой ветки (красный, жёлтый, зелёный и т.д.):");
                string color = Console.ReadLine();
                if (color != string.Empty)
                {
                    root.AddNewBranch(color);
                    continue;
                }
                break;
            }
            
            root.PrintAllGreenBranchName();







        }
    }
}
