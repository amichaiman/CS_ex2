using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WpfApp3
{
    internal class ObservableDictionary<key_type, value_type> : INotifyPropertyChanged
    {
        private SortedDictionary<key_type, value_type> _dictionary = new SortedDictionary<key_type, value_type>();

        public SortedDictionary<key_type,value_type> Dictionary
        {
            get=>_dictionary;
            set
            {
                _dictionary = value;
                OnPropertyChanged("Dictionary");
            }
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void Add(key_type key, value_type value)
        {
            Dictionary.Add(key, value);
            SortedDictionary<key_type, value_type> temp = Dictionary;
            Dictionary = null;
            Dictionary = temp;
        }

        internal void Remove(key_type key)
        {
            Dictionary.Remove(key);
            SortedDictionary<key_type, value_type> temp = Dictionary;
            Dictionary = null;
            Dictionary = temp;
        }

        internal void SetDictionary(SortedDictionary<key_type, value_type> sortedDictionary)
        {
            Dictionary = sortedDictionary;
            SortedDictionary<key_type, value_type> temp = Dictionary;
            Dictionary = null;
            Dictionary = temp;
        }
    }
}