using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    public class BranchLeft : Branch
    {
        private string branchName = "Левая ветка";

        public override string ShowDisplayName()
        {
            return branchName;
        }
    }
}
