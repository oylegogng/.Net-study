using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate System.Collections.Generic.KeyValuePair<TKey, TValue>
GenerateElement<TKey, TValue>(int j);


namespace lab1
{
    class TestCollection<TKey, TValue>
    {
        private List<TKey> _list = new List<TKey>();
        private List<string> _list2 = new List<string>();

        private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();
        private Dictionary<string, TValue> _dictionary2 = new Dictionary<string, TValue>();

        private GenerateElement<TKey, TValue> generateElement;

        public TestCollection(int n, GenerateElement<TKey, TValue> j)
        {       
            generateElement = j;
            for(int i = 0; i < n; i++)
            {
                var element = generateElement(i);
                _list.Add(element.Key);
                _list2.Add(element.Key.ToString());
                _dictionary.Add(element.Key, element.Value);
                _dictionary2.Add(element.Key.ToString(), element.Value);
            }
        }


        public void searchKeyList()
        {
            var first = _list[0];
            var middle = _list[_list.Count / 2];
            var last = _list[_list.Count - 1];
            var none = generateElement(_list.Count + 1).Key;

            var watch = Stopwatch.StartNew();
            _list.Contains(first);
            watch.Stop();
            Console.WriteLine("For the first element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _list.Contains(middle);
            watch.Stop();
            Console.WriteLine("For the middle element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _list.Contains(last);
            watch.Stop();
            Console.WriteLine("For the last element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _list.Contains(none);
            watch.Stop();
            Console.WriteLine("For the element that there is no in list: " + watch.Elapsed.Ticks);
        }

        public void searchStrList()
        {
            Console.WriteLine("\nIn String List\nTime of the search:\n");

            var first = _list2[0];
            var middle = _list2[_list2.Count / 2];
            var last = _list2[_list2.Count - 1];
            var none = generateElement(_list2.Count + 1).Key.ToString();

            var watch = Stopwatch.StartNew();
            _list2.Contains(first);
            watch.Stop();
            Console.WriteLine("For the first element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _list2.Contains(middle);
            watch.Stop();
            Console.WriteLine("For the middle element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _list2.Contains(last);
            watch.Stop();
            Console.WriteLine("For the last element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _list2.Contains(none);
            watch.Stop();
            Console.WriteLine("For the element that there is no in list: " + watch.Elapsed.Ticks);
        }

        public void searchTKeyDictionaryByKey()
        {
            Console.WriteLine("\nTKey Dictionary by Key\nTime of the search:\n");

            var first = _dictionary.ElementAt(0).Key;
            var middle = _dictionary.ElementAt(_dictionary.Count / 2).Key;
            var last = _dictionary.ElementAt(_dictionary.Count - 1).Key;
            var none = generateElement(_dictionary.Count + 1).Key;

            var watch = Stopwatch.StartNew();
            _dictionary.ContainsKey(first);
            watch.Stop();
            Console.WriteLine("For the first element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary.ContainsKey(middle);
            watch.Stop();
            Console.WriteLine("For the middle element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary.ContainsKey(last);
            watch.Stop();
            Console.WriteLine("For the last element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary.ContainsKey(none);
            watch.Stop();
            Console.WriteLine("For the element that there is no in list: " + watch.Elapsed.Ticks);
        }

        public void searchStrDictionaryByKey()
        {
            Console.WriteLine("\nString Dictionary by Key\nTime of the search:\n");

            var first = _dictionary2.ElementAt(0).Key;
            var middle = _dictionary2.ElementAt(_dictionary2.Count / 2).Key;
            var last = _dictionary2.ElementAt(_dictionary2.Count - 1).Key;
            var none = generateElement(_dictionary2.Count + 1).Key.ToString();

            var watch = Stopwatch.StartNew();
            _dictionary2.ContainsKey(first);
            watch.Stop();
            Console.WriteLine("For the first element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary2.ContainsKey(middle);
            watch.Stop();
            Console.WriteLine("For the middle element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary2.ContainsKey(last);
            watch.Stop();
            Console.WriteLine("For the last element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary2.ContainsKey(none);
            watch.Stop();
            Console.WriteLine("For the element that there is no in list: " + watch.Elapsed.Ticks);
        }

        public void searchTKeyDictionaryByValue()
        {
            Console.WriteLine("\nTKey Dictionary by Value\nTime of the search:\n");

            var first = _dictionary.ElementAt(0).Value;
            var middle = _dictionary.ElementAt(_dictionary.Count / 2).Value;
            var last = _dictionary.ElementAt(_dictionary.Count - 1).Value;
            var none = generateElement(_dictionary.Count + 1).Value;

            var watch = Stopwatch.StartNew();
            _dictionary.ContainsValue(first);
            watch.Stop();
            Console.WriteLine("For the first element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary.ContainsValue(middle);
            watch.Stop();
            Console.WriteLine("For the middle element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary.ContainsValue(last);
            watch.Stop();
            Console.WriteLine("For the last element: " + watch.Elapsed.Ticks);

            watch.Restart();
            _dictionary.ContainsValue(none);
            watch.Stop();
            Console.WriteLine("For the element that there is no in list: " + watch.Elapsed.Ticks);
        }

    }

}
