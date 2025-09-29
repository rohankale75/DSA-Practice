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
            foreach (int number in numbers) 
            Console.WriteLine("Largest element of Array is: " + problems.LargestElement(numbers));
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
        // Largest Element in an Array
        public int LargestElement(int[] arr)
        {
            int max = arr[0];

            foreach (var item in arr)
            {
                if (item > max) max = item;
            }
            return max;
        }
    }
    #endregion
}
