# DSA Concepts — Quick Reference

## Two Pointers

### What it solves
Avoid nested loops (O(n²)) when comparing pairs of elements in a sorted array.
Brings time complexity down to O(n).

### Mental model
```
[1, 2, 3, 4, 5, 6]
 ↑                ↑
Left            Right

Move left  → increases sum
Move right → decreases sum
Stop when left >= right
```

### When to use
- Array is SORTED
- Finding pairs that meet a condition
- Closing in from both ends

### When NOT to use
- Array is unsorted
- Values can be negative (unless you sort first)

### Template
```csharp
int left = 0, right = arr.Length - 1;
while (left < right) {
    int sum = arr[left] + arr[right];
    if (sum == target) { /* found */ }
    else if (sum < target) left++;
    else right--;
}
```

### Complexity
- Time: O(n)
- Space: O(1)

---

## HashMap (Dictionary in C#)

### What it solves
"Have I seen this value before?" in O(1) instead of O(n) scan.
Eliminates need for nested loops in many problems.

### Mental model
```
Key   = the value you want to look up later
Value = index, frequency, or any metadata you need

complement = target - current
If complement in map → pair found
Else → store current in map
```

### When to use
- Array is unsorted
- Values can be negative
- "Find pair/complement" problems
- Need to track frequency of elements
- n is large (> 10,000) and O(n²) is too slow

### Template — find pair
```csharp
var map = new Dictionary<int, int>(); // value → index
for (int i = 0; i < nums.Length; i++) {
    int complement = target - nums[i];
    if (map.ContainsKey(complement))
        return new int[] { map[complement], i };
    map[nums[i]] = i;
}
```

### Template — count pairs with duplicates
```csharp
var map = new Dictionary<int, int>(); // value → frequency
int count = 0;
for (int i = 0; i < nums.Length; i++) {
    int complement = target - nums[i];
    if (map.ContainsKey(complement))
        count += map[complement];
    if (map.ContainsKey(nums[i])) map[nums[i]]++;
    else map[nums[i]] = 1;
}
```

### Complexity
- Time: O(n)
- Space: O(n)

---

## Reading Constraints — Decision Table

| Constraint | What it tells you |
|---|---|
| n <= 100 | O(n²) brute force is fine |
| n <= 10,000 | O(n log n) needed |
| n <= 1,000,000 | Must be O(n) |
| Array is sorted | Think two pointers first |
| Values can be negative | Two pointers won't work directly |
| "Find all pairs" | Need a list to collect results |
| "Count pairs" | Just increment a counter |

---

## Complexity Cheat Sheet

### Time
```
Single loop           = O(n)
Loop inside loop      = O(n²)
Binary search         = O(log n)
Sorting               = O(n log n)
```

### Space
```
No extra storage      = O(1)
Store n items         = O(n)
Store n² items        = O(n²)
```

### How to reason in interviews
Always state BOTH time and space, with reasoning:

"Time complexity is O(n) because we loop through the array once.
Space complexity is O(n) because in the worst case we store all
n elements in the Dictionary before finding the answer."

---

## Common Mistakes to Avoid

1. Starting inner loop at j=1 instead of j=i+1
   → Use j = i+1 to guarantee i < j without extra checks

2. Storing complement in map instead of actual number
   → Always store nums[i], not the complement

3. Not handling duplicates in frequency problems
   → Use frequency count (map[val]++) not just map[val] = index

4. Using two pointers on unsorted array
   → Always check if array is sorted before choosing two pointers

5. Forgetting space complexity in interviews
   → Always mention both time AND space
