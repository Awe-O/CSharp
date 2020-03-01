using System;
using System.Collections.Generic;
using System.Text;

namespace GeologicalTreeProject.Common
{
    interface Root<TPerson>
        where TPerson : class
    {
        public Node<TPerson> Left { get; set; }
        public Node<TPerson> Right { get; set; }
    }
}
