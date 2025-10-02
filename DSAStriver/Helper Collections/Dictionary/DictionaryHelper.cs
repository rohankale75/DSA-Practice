using System;
using System.Diagnostics.Metrics;

namespace DSAStriver.Helper_Collections.Dictionary
{
    public class DictionaryHelper
    {
        public void DictionaryMethod()
        {
            int[] array = { 10, 20, 4, 7, 5 };

            // Create a Dictionary: Key = numbers, Value = index
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                map[array[i]] = i; // Here in Dictionary, Key: Array Number (10, 20, 4, 7, 5) and Value: Array Index (0, 1, 2, 3, 4) => map[arr[i]] = i
                // map[key] = value
            }

            // Show Dictionary Contents
            Console.WriteLine("Dictionary Contents:");
            foreach (var number in map)
            {
                Console.WriteLine($"Key: {number.Key}, Value: {number.Value}" + " ");
            }
            Console.WriteLine();

            // ==== Handy Dictionary Methods ====

            // 1. ContainsKey (return True or False)
            Console.WriteLine("ContainsKey(20): " + map.ContainsKey(20));       // True
            Console.WriteLine("ContainsKey(100): " + map.ContainsKey(100));     // False

            // 2. ContainsValue (return True or False)
            Console.WriteLine("ContainsValue(2): " + map.ContainsValue(2));     // True (Index of 4 is 2)
            Console.WriteLine("ContainsValue(10): " + map.ContainsValue(10));   // False (Total length of Array is 5 hence no index value upto 10

            // 3. TryGetValue (return True or False)
            if (map.TryGetValue(7, out int indexOf7))   // Gets the values associated to specified key
            {
                Console.WriteLine("TryGetValue(7): Index = " + indexOf7);   
                // Here Key is 7 in Dictionary, so its value will be 3 from Dictionary
            }

            // 4. Remove
            Console.WriteLine("Removing Key 20...");
            map.Remove(20);
            Console.WriteLine("ContainsKey(20) after removal: " + map.ContainsKey(20));

            // 5. Keys
            Console.WriteLine("All Keys");
            foreach(var key in map.Keys)
            {
                Console.Write(key + ", ");
            }

            // 6. Values
            Console.WriteLine();
            Console.WriteLine("All Values");
            foreach(var value in map.Values)
            {
                Console.Write(value + " ");
            }

            // 7. Indexer [] (map[key])
            Console.WriteLine();
            Console.WriteLine("map[10] = " + map[10]);  // return value for key 10

            // 8. Clear (Removes all keys and values from Dictionary)
            //map.Clear();

            #region Output of Above operations
            //Dictionary contents:
            //Key = 10, Value = 0
            //Key = 20, Value = 1
            //Key = 4, Value = 2
            //Key = 7, Value = 3
            //Key = 5, Value = 4

            //ContainsKey(20): True
            //ContainsKey(100): False
            //ContainsValue(2): True
            //ContainsValue(10): False
            //TryGetValue(7): index = 3
            //Removing key 20...
            //ContainsKey(20) after remove: False
            //All Keys:
            //            10
            //4
            //7
            //5
            //All Values:
            //0
            //2
            //3
            //4
            //map[10] = 0
            #endregion
        }
    }
}
