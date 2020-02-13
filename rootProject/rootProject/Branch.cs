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
        public abstract string ShowDisplayName();

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

    }
}
