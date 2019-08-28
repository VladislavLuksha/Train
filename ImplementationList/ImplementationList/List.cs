using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImplementationList
{
    class List
    {
        Node root;
        Node head;

        public int Count { get; private set; }

        public List()
        {
            root = new Node(null);
            head = root;
        }

        public List(object value)
        {
            root = new Node(value);
        }

        public void Add(object value)
        {
            Node newValue = new Node(value);
            head.SetNextNode(newValue);
            head = newValue;
            if (0 == Count)
            {
                root = head;
            }
            Count++;
        }

        public void PrintList()
        {
            Node currentNode = root;
            while (currentNode != null)
            {
                currentNode.PrintNode(currentNode);
                currentNode = currentNode.nextNode;
            }
            
        }

        public bool Remove(object value)
        {
            Node previous = null;
            Node currentNode = root;
            while(currentNode!=null)
            {
                if (currentNode.value.Equals(value))
                {
                    if (root == currentNode)
                    {
                        currentNode = currentNode.nextNode;
                        root = currentNode;
                    }
                    if(currentNode==null)
                    {
                        head = previous; 
                    }
                    if (currentNode != root)
                    {
                        previous.SetNextNode(currentNode.nextNode);
                    }
                    if (1==Count)
                    {
                        root = null;
                        head = root;
                    }
                    Count--;
                    return true;
                }
                previous = currentNode;
                currentNode = currentNode.nextNode;
            }
            return false;
        }

        public bool Contains(object value)
        {
            Node current = root;

            while(current!=null)
            {
                if (current.value.Equals(value))
                {
                    return true;
                }
                current = current.nextNode;
            }
            return false;
        }

        public void Clear()
        {
            root = null;
            head = root;
            Count = 0;
        }

        public object CopyTo(object[] array,int index)
        {
            Node current = root;
            while(current!=null)
            {
                array[index++] = current.value;
                current = current.nextNode;
            }
            return array;
        }
    }
}
