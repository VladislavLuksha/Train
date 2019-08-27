using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImplementationList
{
    class Node
    {
        public object value;
        public Node nextNode { get; private set; }
        public Node(object value)
        {
            nextNode = null;
            this.value = value;
        }

        public void SetNextNode(Node node)
        {
            nextNode = node;
        }

        public void PrintNode(Node node)
        {
            Console.WriteLine(value);
        }
    }
}
