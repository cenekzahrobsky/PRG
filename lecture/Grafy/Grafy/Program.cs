using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Program
    {
        class Node
        {
            int index;
            List<Node> neighbours;
            public Node(int index)
            {
                this.index = index;
                neighbours = new List<Node>();
            }
            public void AddNeighbor(Node node) 
            {
                if (neighbours.Contains(node))
                {
                    Console.WriteLine("Node "+node.index +" is already a neighbor of "+index);
                }
                else
                {
                    neighbours.Add(node);
                    node.AddNeighbor(this);
                    Console.WriteLine("Node " + node.index + " added as a neighbor of " + index);
                }
            }
            public int GetIndex()
            {
                return index;  
            }
            public int[] GetNeighborsIndices()
            {
                int[] indices = new int[neighbours.Count];
                for (int i = 0; i < neighbours.Count; i++)
                {
                    indices[i] = neighbours[i].index;
                }
                return indices;
            }
            public Node MoveToNeighbor(int index)
            {
                foreach (Node neighbor in neighbours) 
                {
                    if (neighbor.index == index)
                    {
                        return neighbor;
                    } 
                }
                Console.WriteLine("Node " + index + " is not a neighbor of " + this.index);
                return this;
            }
        }
        static void Main(string[] args)
        {
            /*
             * 1 - 4, 6
             * 2 - 3, 5, 6
             * 3 - 2, 5
             * 4 - 1, 6
             * 5 - 2, 3
             * 6 - 1, 4
             */

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            node1.AddNeighbor(node4);
            node1.AddNeighbor(node6);

            node2.AddNeighbor(node3);
            node2.AddNeighbor(node5);
            node2.AddNeighbor(node6);
            
            node3.AddNeighbor(node5);

            node4.AddNeighbor(node6);

           

            

            Node currentNode = node1;
            while (true) 
            {
                Console.WriteLine("Current node: " + currentNode.GetIndex());
                Console.Write("Neighbors: ");
                foreach (int neighborIndex in currentNode.GetNeighborsIndices())
                {
                    Console.Write(neighborIndex+ " ");
                }
                Console.Write("\n");
                Console.WriteLine("Choose where to go.");
                int desiredIndex = int.Parse(Console.ReadLine());
                currentNode =currentNode.MoveToNeighbor(desiredIndex);
            }
        }
    }
}
