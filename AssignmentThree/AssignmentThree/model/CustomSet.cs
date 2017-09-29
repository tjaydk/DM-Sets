using System.Collections;
using System.Collections.Generic;

namespace AssignmentThree.model
{
    /// <summary>
    /// Custom created HashSet.
    /// DOES NOT ACCEPT THE DEFAULT VALUE OF T WITH THE ENUMERATOR
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CustomSet<T> : ICustomSet<T>
    {
        private int M;
        // The number of keys in the set
        private int count;
        // The Set.
        private T[] keys;

        public CustomSet()
        {
            M = 8;
            keys = new T[M];
        }

        /// <summary>
        /// Adds a key to the set
        /// </summary>
        /// <param name="key"></param>
        public void Add(T key)
        {
            bool newEntry = true;
            int i;
            // As there can be more than one value on one specific hash, this will probe the array until either the key is found, or the value is of a different hash.
            for (i = Hash(key); !keys[i].Equals(default(T)); i = (i + 1) % M)
            {
                // If a key already exists newEntry is set to false.
                if (keys[i].Equals(key))
                {
                    newEntry = false;
                    break;
                }
            }
            keys[i] = key;

            // If there is a new entry the DoubleArray method is called, in case the array has to be doubled.
            if (newEntry)
            {
                count++;
                DoubleArray();
            }
        }

        /// <summary>
        /// Deletes a key from the set
        /// </summary>
        /// <param name="key"></param>
        public void Delete(T key)
        {
            int i;
            // As there can be more than one value on one specific hash, this will probe the array until either the key is found, or the value is of a different hash.
            for (i = Hash(key); !keys[i].Equals(default(T)); i = (i + 1) % M)
            {
                // If the key is found the entry has to be deleted
                if (keys[i].Equals(key))
                {
                    keys[i] = default(T);
                    count--;
                    // The halfArray Method is called and if there is to few keys in the array the array is halved.
                    HalfArray();
                    break;
                }
            }
        }

        /// <summary>
        /// Checks if the set contains a key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(T key)
        {
            int i;
            // As there can be more than one value on one specific hash, this will probe the array until either the key is found, or the value is of a different hash.
            for (i = Hash(key); !keys[i].Equals(default(T)); i = (i + 1) % M)
            {
                if (keys[i].Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the size of the set.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return count;
        }

        /// <summary>
        /// Doubles the Array that contains the set.
        /// </summary>
        private void DoubleArray()
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

        /// <summary>
        /// Halves the Array that contains the set.
        /// </summary>
        private void HalfArray()
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

        /// <summary>
        /// Returns the Hash value of a key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int Hash(T key)
        {
            return (key.GetHashCode() & 0x7fffffff % M);
        }

        /// <summary>
        /// Goes through all the keys in the array.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in keys)
            {
                if (!t.Equals(default(T)))
                {
                    yield return t;
                }
            }
        }

        /// <summary>
        /// Method to allow Foreach method.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
