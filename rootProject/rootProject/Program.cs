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
            BranchLeft branchLeft = new BranchLeft();
            Console.WriteLine(branchLeft.ShowDisplayName());

            BranchRight branchRight = new BranchRight();
            Console.WriteLine(branchRight.ShowDisplayName());
            Console.WriteLine(branchRight.Color);

            Branch branch = new BranchLeft();
            Console.WriteLine(branch.Color);

            Root root = new Root();
            Console.WriteLine(root.Items.Count); 

            


        }
    }
}
