using GeologicalTreeProject.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeologicalTreeProject.Persons
{
    class Relatives<TPerson> : Node<TPerson>
        where TPerson: class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Node<TPerson> Left { get; set; }
        public Node<TPerson> Right { get; set; }
        public Node<TPerson> Parent { get; set; }
        public Relatives()
        {

        }
        public Relatives(TPerson relative)
        {

        }

        public string ParentName
        {
            get
            {
                if (IsParent)
                {
                    return string.Format("Для этого человека совтавлено генеалогическое дерево.");
                }
                return string.Format("{0} {1} ребёнок этого человека", Parent.FirstName, Parent.LastName);
            }
        }

        public bool IsParent
        {
            get
            {
                return Parent == null;
            }
        }
    }
}
