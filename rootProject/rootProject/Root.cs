using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    public class Root
    {
        public Branch BranchLeft { get; }
        public Branch BranchRight { get; }

        public List<BranchLeft> Items = new List<BranchLeft>();        

        public List<Branch> GetAllGreenBranches(List<Branch> Branches)
        {
             return Branches;
        }

    }
}
