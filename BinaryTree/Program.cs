using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Value = new List<int> { };
            Value.Add(100);
            Value.Add(99);
            Value.Add(101);
            Value.Add(98);
            Value.Add(102);
            Value.Add(97);
            Value.Add(103);
            Value.Add(96);
            Value.Add(104);

            Node node = new Node(Value);
        }
    }
}
