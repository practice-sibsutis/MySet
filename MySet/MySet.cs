using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    internal class MySet<SetElementType> : ICollection<SetElementType> //where SetElementType : IComparable, ICloneable
    {
        List<SetElementType> _elements;
        public MySet()
        {
            _elements = new List<SetElementType>();
        }

        public int Count
        {
            get => _elements.Count;
        }

        public bool IsReadOnly => false;

        public MySet(IEnumerable<SetElementType> collection) : this()
        {
            foreach (SetElementType item in collection)
            {
                Add(item);
            }
        }

        public void Add(SetElementType item)
        {
            if(_elements.Contains(item) == false)
            {
                _elements.Add(item);
            }
        }

        public static MySet<SetElementType> Union(MySet<SetElementType> s1, MySet<SetElementType> s2)
        {
            MySet<SetElementType> result = new MySet<SetElementType>(s1._elements);
            foreach(SetElementType item in s2._elements)
            {
                result.Add(item);
            }

            return result;
        }

        public static MySet<SetElementType> Intersection(MySet<SetElementType> s1, MySet<SetElementType> s2)
        {
            MySet<SetElementType> result = new MySet<SetElementType>();

            foreach (SetElementType item in s1._elements)
            {
                if (s2.Contains(item) != false)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static MySet<SetElementType> Complement(MySet<SetElementType> s1, MySet<SetElementType> s2)
        {
            MySet<SetElementType> result = new MySet<SetElementType>(s1._elements);

            foreach (SetElementType item in s2._elements)
            {
                result.Remove(item);
            }
            return result;
        }

        public static MySet<SetElementType> DisjunctionUnion(MySet<SetElementType> s1, MySet<SetElementType> s2)
        {
            return MySet<SetElementType>.Complement(MySet<SetElementType>.Union(s1,s2), MySet<SetElementType>.Intersection(s2,s1));
        }

        public IEnumerator GetEnumerator()
        {
            return _elements.GetEnumerator();
        }

        public bool Contains(SetElementType item)
        {
            return _elements.Contains(item);
        }

        public bool Remove(SetElementType item)
        {
            return _elements.Remove(item);
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public void CopyTo(SetElementType[] array, int arrayIndex)
        {
            foreach(SetElementType item in _elements)
            {
                array[arrayIndex++] = item;
            }
        }

        IEnumerator<SetElementType> IEnumerable<SetElementType>.GetEnumerator()
        {
            return _elements.GetEnumerator();
        }
    }
}
