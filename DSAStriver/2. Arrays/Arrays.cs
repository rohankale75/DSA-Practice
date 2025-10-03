using DSAStriver._2._Arrays.LeetCodeProblems;

namespace DSAStriver._2._Arrays
{
    public class Arrays
    {
        public void ArrayMethods()
        {
            //BasicArrayOperations arrayOperations = new BasicArrayOperations();
            //arrayOperations.BasicArrayNotes();

            BasicProblmes problems = new BasicProblmes();
            int[] numbers = { 10, 20, 30, 40 };

            var largest = 0;
            foreach (int number in numbers)
                largest = problems.LargestElement(numbers);
            Console.WriteLine("Largest element of Array is: " + largest);
            Console.WriteLine();
            // ----------------------------------------------------------------------------------------------

            int[] arr1 = { 10, 20, 5, 8 };    // -> 10
            int[] arr2 = { 5, 5, 5 };         // -> No second largest
            int[] arr3 = { 1 };               // -> Array must have at least 2 elements
            int[] arr4 = { -3, -1, -2 };      // -> -2

            Console.WriteLine("Second Largest element of Array is: " + problems.SecondLargestElement(arr1));
            Console.WriteLine("Second Largest element of Array is: " + problems.SecondLargestElement(arr2));
            Console.WriteLine("Second Largest element of Array is: " + problems.SecondLargestElement(arr3));
            Console.WriteLine("Second Largest element of Array is: " + problems.SecondLargestElement(arr4));
            // ----------------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Is Array Sorted: " + problems.IsArraySorted(arr1));
            Console.WriteLine("Is Array Sorted: " + problems.IsArraySorted(arr2));
            Console.WriteLine("Is Array Sorted: " + problems.IsArraySorted(arr3));
            Console.WriteLine("Is Array Sorted: " + problems.IsArraySorted(arr4));
            // ----------------------------------------------------------------------------------------------

            Console.WriteLine("Current Array");
            foreach (var num in arr1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reversed Array");
            var newArray = problems.ReverseArray(arr1);
            foreach (var num in newArray)
            {
                Console.Write(num +  " ");
            }
            // ----------------------------------------------------------------------------------------------


        }

        public void LeetCodeMethods()
        {
            #region Two Sum (Problem No 1 on Leetcode)
            TwoSum ts = new TwoSum();
            int[] arr = { 10, 20, 4, 7, 5 };
            int target = 9;
            int[] result = ts.TwoSumArrayBasic(arr, target);
            Console.WriteLine($"Two Sum Basic Solution: [{result[0]}, {result[1]}]");

            Console.WriteLine();
            int[] dictResult = ts.TwoSumDictionary(arr, target);
            Console.WriteLine($"Two Sum using Dictionary: [{dictResult[0]}, {dictResult[1]}]");
            #endregion

            #region Best Time to Buy And Sell Stock (Problem No 121 on Leetcode)
            BestTimeToBuySellStock bs = new BestTimeToBuySellStock();
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            // Output = 5 (Profit = 6 - 1 = 5)
            Console.WriteLine();
            Console.WriteLine("Best Time to Buy and Sell Stock is: " + bs.MaxProfit(prices));

            // int[] prices = { 7,6,4,3,1 }
            // Output = 0 
            #endregion
        }
    }

    #region Basic Array Operations
    public class BasicArrayOperations
    {
        public void BasicArrayNotes()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            // 1. Array Length
            Console.WriteLine("Length of Array is: " + arr.Length);

            // 2. Access Element
            Console.WriteLine("Element at index 2 is: " + arr[2]);

            // 3. Update Element
            arr[3] = 41;
            Console.WriteLine("Updated element at index 3 is: " + arr[3]);

            // 4. Loop / Iterate
            int index = 0;
            foreach (var item in arr)
            {
                index = Array.IndexOf(arr, item);
                Console.WriteLine($"Element at Index {index} is: {item}");
            }

            // 5. Sort an Array in Ascending Order
            Console.WriteLine("Current Array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Array.Sort(arr);
            Console.WriteLine("Sorted Array: " );
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            // 6. Reverse an Array 
            Console.WriteLine();
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 7. Search (IndexOf) Find Index of Element
            Console.WriteLine($"Index of {arr[2]} is: {Array.IndexOf(arr, 30)}");

            // 3. Copy an Array into another (Copy first 3 elements of arr to arr2)
            int[] arr2 = { 11, 22, 33 };
            Array.Copy(arr, arr2, 3);
            Console.WriteLine("Arr2 elements are: ");
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }
        }
    }
    #endregion

    #region Basic Problems
    public class BasicProblmes()
    {
        #region 1. Largest Element in an Array
        public int LargestElement(int[] arr)
        {
            int max = arr[0];

            foreach (var item in arr)
            {
                if (item > max) max = item;
            }
            return max;
        }
        #endregion

        #region 2. 2nd Largest Element in an Array
        public int SecondLargestElement(int[] arr)
        {
            int largest = int.MinValue, second = int.MinValue; // -2147483648, this is the min valud of int and is added to consider -ve numbers as well
            
            if (arr.Length < 2) return -1;

            foreach (var num in arr)
            {
                if (num > largest)
                {
                    second = largest;
                    largest = num;
                }
                else if (num > second && num != largest)    // 2nd condition coz largest != smallest as both should be different and largest > smallest
                {
                    second = num;
                }
            }
            return second == int.MinValue ? -1 : second;
        }
        #endregion

        #region 3. Is Array Sorted ?
        public bool IsArraySorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }
            return true;
        }
        #endregion

        #region 4. Reverse an Array
        public int[] ReverseArray(int[] arr)
        {
            // 10, 20, 5, 8
            int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return arr;
        }
        #endregion
    }
    #endregion
}
