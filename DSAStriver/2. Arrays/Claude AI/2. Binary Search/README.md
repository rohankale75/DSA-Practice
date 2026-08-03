# Binary Search O(log n)
---

**Binary Search — the idea:**

You're searching for a number in a sorted array. Two approaches:

**Linear search — O(n):**
```
[1, 3, 5, 7, 9, 11, 13, 15]
Check 1 → no
Check 3 → no
Check 5 → no
... checks every element
```

**Binary search — O(log n):**
```
[1, 3, 5, 7, 9, 11, 13, 15]
Target = 11

Step 1: Check middle element = 7
        11 > 7 → target is in RIGHT half
        Eliminate left half entirely

[9, 11, 13, 15]
Step 2: Check middle = 11
        Found! ✓
```

Two steps instead of eight. For 1 million elements — binary search takes only 20 steps. Linear takes 1 million.

---

**The core rule:**

```
Array MUST be sorted.
Every step eliminates HALF the remaining elements.
That's why it's O(log n).
```

---

**The template — memorise this:**

```csharp
int left = 0, right = nums.Length - 1;

while (left <= right) {
    int mid = left + (right - left) / 2; // avoids integer overflow
    
    if (nums[mid] == target)
        return mid; // found
    else if (nums[mid] < target)
        left = mid + 1; // target in right half
    else
        right = mid - 1; // target in left half
}

return -1; // not found
```

**Why `left + (right - left) / 2` instead of `(left + right) / 2`:**
If left and right are both large numbers — adding them causes integer overflow. The first formula is safer.

---

**Dry run:**

```
Array:  [1, 3, 5, 7, 9, 11, 13, 15]
Index:   0  1  2  3  4   5   6   7
Target: 11
```

```
left=0, right=7
mid = 0 + (7-0)/2 = 3 → nums[3] = 7
11 > 7 → left = mid+1 = 4

left=4, right=7
mid = 4 + (7-4)/2 = 5 → nums[5] = 11
11 == 11 → found at index 5 ✓
```

---

**When to use binary search — beyond just searching:**

This is what most people miss. Binary search applies to any problem where:

```
1. Array is sorted
2. Search space can be halved each step
3. "Find minimum/maximum that satisfies a condition"
```

Classic patterns:
- Search in sorted array
- Find first/last occurrence of element
- Search in rotated sorted array
- Find minimum in rotated array
- Binary search on answer — find minimum capacity, minimum days etc.

---

**Complexity:**

```
Time:  O(log n) — halving each step
Space: O(1) — just left, right, mid variables
```

---

**Visual of why it's log n:**

```
n = 8   → 3 steps  (8 → 4 → 2 → 1)
n = 16  → 4 steps
n = 1M  → 20 steps
n = 1B  → 30 steps
```

Incredibly fast.

---

**Tomorrow when you have laptop — solve these in order:**

```
Leetcode #704 — Binary Search (Easy) — Amazon, Google
Leetcode #34  — First and Last Position (Medium) — Facebook, Amazon
Leetcode #33  — Search in Rotated Array (Medium) — Amazon, Microsoft
```

Start with #704 — it's the pure template, exactly what I showed above.