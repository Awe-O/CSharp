using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    public class BranchRight : Branch
    {
        private string branchName = "Правая ветка";

        private string _color = "Жёлтый";
        public override string ShowDisplayName()
        {
            return branchName;
        }

        public override string Color 
                    {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            } 
        }


    }
}
