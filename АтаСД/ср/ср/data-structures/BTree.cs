using System;
using System.Collections.Generic;
using System.Text;

namespace ср.data_structures
{
    public class Node
    {
        public List<int> Keys { get; set; }
        public List<Node> Children { get; set; }

        public Node()
        {
            Keys = new List<int>();
            Children = new List<Node>();
        }

        public Node Search(int key)
        {
            int i = 0;
            while (i < Keys.Count && key > Keys[i]) i++;

            if (i < Keys.Count && Keys[i] == key)
                return this;

            if (Children.Count == 0)
                return null;

            return Children[i].Search(key);
        }

        public void SplitChild(int index)
        {
            Node full = Children[index];
            Node right = new Node();
            int middleKey = full.Keys[1];

            right.Keys.Add(full.Keys[2]);

            if (full.Children.Count > 0)
            {
                right.Children.Add(full.Children[2]);
                right.Children.Add(full.Children[3]);
                full.Children.RemoveRange(2, 2);
            }

            full.Keys.RemoveRange(1, 2);

            Children.Insert(index + 1, right);
            Keys.Insert(index, middleKey);
        }

        public void InsertNonFull(int key)
        {
            int i = Keys.Count - 1;

            if (Children.Count == 0)
            {
                Keys.Add(0);
                while (i >= 0 && Keys[i] > key)
                {
                    Keys[i + 1] = Keys[i];
                    i--;
                }
                Keys[i + 1] = key;
            }
            else
            {
                while (i >= 0 && Keys[i] > key) i--;
                i++;

                if (Children[i].Keys.Count == 3)
                {
                    SplitChild(i);
                    if (key > Keys[i]) i++;
                }
                Children[i].InsertNonFull(key);
            }
        }

        public void PrintAll()
        {
            int i;
            for (i = 0; i < Keys.Count; i++)
            {
                if (Children.Count > 0)
                    Children[i].PrintAll();
                Console.Write(Keys[i] + " ");
            }
            if (Children.Count > 0)
                Children[i].PrintAll();
        }
    }

    public class BTree
    {
        public Node Root { get; set; }

        public bool Search(int key) => Root?.Search(key) != null;

        public void Insert(int key)
        {
            if (Root == null)
            {
                Root = new Node();
                Root.Keys.Add(key);
                return;
            }

            if (Root.Keys.Count == 3)
            {
                Node newRoot = new Node();
                newRoot.Children.Add(Root);
                newRoot.SplitChild(0);
                Root = newRoot;
            }

            Root.InsertNonFull(key);
        }

        public void Print()
        {
            if (Root == null)
            {
                Console.WriteLine("Порожнє дерево");
                return;
            }
            Root.PrintAll();
            Console.WriteLine();
        }
    }
}