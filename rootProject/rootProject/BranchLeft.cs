using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    public class BranchLeft : Branch
    {
        private string _branchName = "Левая ветка";

        public override string BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                _branchName = value;
            }
        }

        public override string ShowDisplayName()
        {
            return _branchName;
        }
    }
}
