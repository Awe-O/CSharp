using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootProject
{
    public abstract class Branch
    {
        private string _color = "Зелёный";
        public abstract string BranchName { get; set; }

        public virtual string Color 
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

        public abstract string ShowDisplayName();

    }
}
