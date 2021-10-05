using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class MyMapNode<K, V>
    {
        private int size;
        private LinkedList<KeyValuePair<K, V>>[] items;

        public object Key { get; private set; }

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<K, V>>[size];

        }
        public int GetArrayPosition(K key)
        {
            int position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedlist = GetLinkedlist(position);
            foreach (KeyValuePair<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }

            }
        }
           return default()

           public void Add(K key, V Value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> LinkedList = GetLinkedList(position);
            KeyValuePair<K, V> item = new KeyValuePair<K, V>() { K = key, V = value };
            LinkedList.AddLast(item);

        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> LinkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValuePair<K, V> foundItem = default(KeyValuePair<K, V>);
            foreach (KeyValuePair<K, V> item in LinkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                LinkedList.Remove(foundItem);
            }
        }
        public LinkedList<KeyValuePair<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValuePair<K, V>>();
                items[position] = linkedList;

            }
            return linkedList;
        }

    }
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}







