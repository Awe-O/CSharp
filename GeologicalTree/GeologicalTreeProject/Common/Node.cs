using System;
using System.Collections.Generic;
using System.Text;

namespace GeologicalTreeProject.Common
{
    interface Node<TPerson>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Node<TPerson> Left { get; set; }
        public Node<TPerson> Right { get; set; }
        public Node<TPerson> Parent { get; set; }
        public bool IsParent { get; }
    }
}
