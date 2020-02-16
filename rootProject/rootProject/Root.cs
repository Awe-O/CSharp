using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    public class Root
    {
        /// <summary>
        /// Root.BranchLeft - левая ветка, тип Branch
        /// Root.BranchRight - правая ветка, тип Branch
        /// TODO вроде по заданию, но не понимаю зачем это!? Как это предполагается использовать?
        /// </summary>
        public Branch BranchLeft { get; }
        public Branch BranchRight { get; }

        /// <summary>
        /// Root.Items содержит Branch
        /// </summary>
       List<Branch> Items = new List<Branch>();      
        
        public void AddBranchToItems(Branch branch)
        {
            Items.Add(branch);
            return;
        }

        /// <summary>
        /// Root.GetAllGreenBranches() - список ВСЕХ зелёных веток
        /// </summary>
        public List<Branch> GetAllGreenBranches()
        {
            int i = Items.Count - 1;
            List<Branch> allGreenBranches = new List<Branch>();
            foreach (Branch branch in Items)
            {
                if (Items[i].Color.ToLower() == "зелёный")
                {
                    allGreenBranches.Add(Items[i]);
                }
                i--;
            }
            return allGreenBranches;
        }

        public void PrintAllGreenBranchName()
        {
            int numberOfBranches = GetAllGreenBranches().Count - 1;           

            while (numberOfBranches >= 0)
            {
                Console.WriteLine("Название зелёной ветки номер {0}: {1}", numberOfBranches,
                    GetAllGreenBranches()[numberOfBranches].BranchName);
                numberOfBranches--;
            };
        }


        public void AddNewBranch(string color)
        {
            Branch branch = new BranchRight { Color = color };
            Items.Add(branch);
            return;
        }
    }
}
