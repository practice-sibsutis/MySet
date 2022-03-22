using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    internal class MyStringSet : ICollection
    {
        List<string> _list;
        public MyStringSet()
        {
            _list = new List<string>();
        }

        public MyStringSet(IEnumerable<string> collection) : this()
        {
            foreach(string item in collection)
            {
                Add(item);
            }
        }

        //Возврат размер множества
        public int Count
        {
            get => _list.Count;
        }

        //Добавляет элемент в множество
        public void Add(string item)
        {
            if(_list.Contains(item) == false)
            {
                _list.Add(item);
            }
        }

        public bool IsReadOnly => false;

        public bool IsSynchronized => false;

        public object SyncRoot => null;

        

        public static MyStringSet Union(MyStringSet s1, MyStringSet s2)
        {
            MyStringSet result = new MyStringSet(s1._list);
            foreach (string item in s2._list)
            {
                result.Add(item);
            }

            return result;
        }

        public static MyStringSet Intersection(MyStringSet s1, MyStringSet s2)
        {
            MyStringSet result = new MyStringSet();

            foreach(string item in s1._list)
            {
                if(s2.Contains(item) != false)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static MyStringSet Complement(MyStringSet s1, MyStringSet s2)
        {
            MyStringSet result = new MyStringSet(s1._list);

            foreach (string item in s2._list)
            {
                result.Remove(item);
            }
                return result;
        }

        public static MyStringSet DisjunctionUnion(MyStringSet s1, MyStringSet s2)
        {
            return MyStringSet.Complement(MyStringSet.Union(s1, s2), MyStringSet.Intersection(s1, s2));
        }

        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public bool Contains(string item)
        {
            return _list.Contains(item);
        }

        public bool Remove(string item)
        {
            return _list.Remove(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public void CopyTo(Array array, int arrayIndex)
        {
            foreach(string item in _list)
            {
                array.SetValue(item, arrayIndex);
                ++arrayIndex;
            }
        }

    }
}
