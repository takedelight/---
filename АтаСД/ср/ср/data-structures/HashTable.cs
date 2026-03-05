using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ср.data_structures
{
    public class HashTableEntry
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsOccupied { get; set; } = false;
    }

    public class HashTable
    {
        private readonly int _size;
        private readonly HashTableEntry[] _table;

        public HashTable(int size = 101)
        {
            _size = size;
            _table = new HashTableEntry[_size];
            for (int i = 0; i < _size; i++) _table[i] = new HashTableEntry();
        }

        private int HashFunction(string key)
        {
            int total = key.Sum(c => (int)c);
            return Math.Abs(total) % _size;
        }

        public void Insert(string key, string value)
        {
            int index = HashFunction(key);
            int i = 0;

            while (_table[(index + i) % _size].IsOccupied && i < _size)
            {
                if (_table[(index + i) % _size].Key == key) break; 
                i++;
            }

            if (i < _size)
            {
                int targetIndex = (index + i) % _size;
                _table[targetIndex].Key = key;
                _table[targetIndex].Value = value;
                _table[targetIndex].IsOccupied = true;
            }
        }

        public string Search(string key)
        {
            int index = HashFunction(key);
            int i = 0;

            while (i < _size)
            {
                int currentIndex = (index + i) % _size;
                if (!_table[currentIndex].IsOccupied) break;
                if (_table[currentIndex].Key == key) return _table[currentIndex].Value;
                i++;
            }
            return null;
        }
        public HashTableEntry[] GetFullTable()
        {
            return _table;
        }
    }
}