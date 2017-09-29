using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.model
{
    class CustomSet<T> : ICustomSet<T>
    {
        private int M;
        private int count;
        private T[] keys;

        public CustomSet()
        {
            M = 8;
            keys = new T[M];
        }

        public void Add(T key)
        {
            bool newEntry = true;
            int i;
            for (i = Hash(key); !keys[i].Equals(default(T)); i = (i + 1) % M)
            {
                if (keys[i].Equals(key))
                {
                    newEntry = false;
                    break;
                }
            }
            keys[i] = key;

            if (newEntry)
            {
                count++;
                DoubleArrays();
            }
        }

        public void Delete(T key)
        {
            int i;
            for (i = Hash(key); !keys[i].Equals(default(T)); i = (i + 1) % M)
            {
                if (keys[i].Equals(key))
                {
                    keys[i] = default(T);
                    count--;
                    HalfArrays();
                    break;
                }
            }
        }

        public bool Contains(T key)
        {
            int i;
            for (i = Hash(key); !keys[i].Equals(default(T)); i = (i + 1) % M)
            {
                if (keys[i].Equals(key))
                {
                    return true;
                }
            }
            return false;
        }
        
        public int Size()
        {
            return count;
        }

        private void DoubleArrays()
        {
            if ((count * 10) / keys.Length <= 5)
            {
                return;
            }
            T[] oldKeys = keys;
            M = M * 2;
            keys = new T[M];
            count = 0;

            for (int i = 0; i < oldKeys.Length; i++)
            {
                if (!oldKeys[i].Equals(default(T)))
                {
                    Add(oldKeys[i]);
                }
            }
        }

        private void HalfArrays()
        {
            if ((count * 100) / keys.Length >= 10)
            {
                return;
            }
            T[] oldKeys = keys;
            M = M / 2;
            keys = new T[M];
            count = 0;

            for (int i = 0; i < oldKeys.Length; i++)
            {
                if (!oldKeys[i].Equals(default(T)))
                {
                    Add(oldKeys[i]);
                }
            }
        }

        private int Hash(T key)
        {
            return (key.GetHashCode() & 0x7fffffff % M);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in keys)
            {
                yield return t;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
