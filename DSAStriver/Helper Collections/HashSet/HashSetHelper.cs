using System.ComponentModel;
using System.Xml.Linq;

namespace DSAStriver.Helper_Collections.HashSet
{
    public class HashSetHelper
    {
        public void HashSetHelperMethod()
        {
            // HashSet is a collection of Unique elements
            // It doesn't allow duplicates
            // Fast O(1) time complexity for Add, Contains and Remove operations

            // 1. Create and Add Method
            HashSet<int> set = new HashSet<int>();
            set.Add(10);
            set.Add(20);
            set.Add(30);
            set.Add(10);    // duplicate, will be ignored

            Console.WriteLine("HashSet: " + string.Join(", ", set));
            // Output: HashSet: 10, 20, 30

            // 2. Check if Element exists
            Console.WriteLine(set.Contains(20));    // True
            Console.WriteLine(set.Contains(5));     // False

            // 3. Remove an Element
            set.Remove(30);
            Console.WriteLine("After Removing 30, set will be: " + string.Join(", ", set)); // 10, 20

            // 4. Count Elements
            Console.WriteLine("Count: " + set.Count);   // Output: Count = 2

            // 5. Clear All Elements
            set.Clear();
            Console.WriteLine("Count after cleargin set: " + set.Count());  // Output: 0

            // 6. Union & Intersect (For Set Operations)
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            // Union (All Unique Elements)
            set1.UnionWith(set2);
            Console.WriteLine("Union: " + string.Join(", ", set1)); // Output: 1, 2, 3, 4, 5

            // Reset and Intersect
            set1 = new HashSet<int>() { 1, 2, 3 };
            set1.IntersectWith(set2);
            Console.WriteLine("Intersaction: " + string.Join(" ", set1));   // Output: 3

            // 7. Set Comparison
            HashSet<int> a = new HashSet<int>() { 1, 2 };
            HashSet<int> b = new HashSet<int>() { 1, 2, 3 };

            Console.WriteLine("Is A subset of B: " + a.IsSubsetOf(b));  // True
            Console.WriteLine("Is B superset of A: " + b.IsSupersetOf(a));  // True

            // 8. Loop through Set
            HashSet<string> names = new HashSet<string>() { "Lewis", "George", "Oscar" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            #region Summary
            //Method                Description                                     Complexity
            //Add(item)             Adds element if not present                     O(1)
            //Contains(item)        Checks if element exists                        O(1)
            //Remove(item)          Removes element                                 O(1)
            //Clear()               Removes all                                     O(n)
            //Count                 Returns count                                   O(1)
            //UnionWith(set)        Combine all                                     O(n)
            //IntersectWith(set)    Keep only common                                O(n)
            //IsSubsetOf(set)       True if all elements exist in other             O(n)
            //IsSupersetOf(set)     True if contains all of other                   O(n)
            #endregion
        }
    }
}
