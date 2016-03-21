namespace CommonInterfaces
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        // Compare Cars alphabetically by Name.
        public int CompareTo(Car other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

    internal class CarComparer : IComparer<Car>
    {
        // The field to compare.
        public enum CompareField
        {
            Name, 

            MaxMph, 

            Horsepower, 

            Price, 
        }

        public CompareField SortBy = CompareField.Name;

        public int Compare(Car x, Car y)
        {
            switch (SortBy)
            {
                case CompareField.Name:
                    return x.Name.CompareTo(y.Name);
                case CompareField.MaxMph:
                    return x.MaxMph.CompareTo(y.MaxMph);
                case CompareField.Horsepower:
                    return x.Horsepower.CompareTo(y.Horsepower);
                case CompareField.Price:
                    return x.Price.CompareTo(y.Price);
            }
            return x.Name.CompareTo(y.Name);
        }
    }

    internal class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            return (FirstName == other.FirstName) && (LastName == other.LastName);
        }
    }

    internal class Person1 : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person1 Manager { get; set; }

        // Return a clone of this person.
        public object Clone()
        {
            Person1 person = new Person1();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Manager = Manager;
            return person;
        }
    }

    internal class TreeEnumerator : IEnumerator<TreeNode>
    {
        // The tree's nodes in their proper order.
        private List<TreeNode> Nodes;

        // The index of the current node.
        private int CurrentIndex;

        // Constructor.
        public TreeEnumerator(TreeNode root)
        {
            Nodes = root.Preorder();
            Reset();
        }

        public TreeNode Current
        {
            get
            {
                return GetCurrent();
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return GetCurrent();
            }
        }

        private TreeNode GetCurrent()
        {
            if (CurrentIndex < 0)
            {
                throw new InvalidOperationException();
            }
            if (CurrentIndex >= Nodes.Count)
            {
                throw new InvalidOperationException();
            }
            return Nodes[CurrentIndex];
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return CurrentIndex < Nodes.Count;
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }

        public void Dispose()
        {
        }
    }

    internal class TreeNode : IEnumerable<TreeNode>
    {
        public int Depth = 0;

        public string Text = string.Empty;

        public List<TreeNode> Children = new List<TreeNode>();

        public TreeNode(string text)
        {
            Text = text;
        }

        // Add and create children.
        public TreeNode AddChild(string text)
        {
            TreeNode child = new TreeNode(text);
            child.Depth = Depth + 1;
            Children.Add(child);
            return child;
        }

        // Return the tree's nodes in an preorder traversal.
        public List<TreeNode> Preorder()
        {
            // Make the result list.
            List<TreeNode> nodes = new List<TreeNode>();

            // Traverse this node's subtree.
            TraversePreorder(nodes);

            // Return the result.
            return nodes;
        }

        private void TraversePreorder(List<TreeNode> nodes)
        {
            // Traverse this node.
            nodes.Add(this);

            // Traverse the children.
            foreach (TreeNode child in Children)
            {
                child.TraversePreorder(nodes);
            }
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return new TreeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TreeEnumerator(this);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}