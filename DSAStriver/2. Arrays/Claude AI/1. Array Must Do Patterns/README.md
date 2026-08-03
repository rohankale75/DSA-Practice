# DSA Prep — Rohan Kale

Target: 20+ LPA | Stack: C# | Timeline: 2-3 months

## Progress tracker

| Topic | Problems solved | Status |
|---|---|---|
| Arrays — Two Pointers | 1 | In progress |
| Arrays — HashMap | 3 | In progress |
| Strings | 0 | Pending |
| LinkedList | 0 | Pending |
| Trees | 0 | Pending |

## Folder structure

```
DSA/
├── Arrays/
│   ├── P001_TwoSum_Sorted.cs
│   ├── P002_TwoSum_Unsorted.cs
│   ├── P003_AllPairs_SmallInput.cs
│   └── P004_AllPairs_LargeInput.cs
└── _Notes/
    └── Concepts.md
```

## Key concepts (quick reference)

### When to use what

| Situation | Technique | Time | Space |
|---|---|---|---|
| Sorted array, find pair | Two pointers | O(n) | O(1) |
| Unsorted array, find pair | HashMap | O(n) | O(n) |
| n <= 100, any array | Brute force O(n²) fine | O(n²) | O(1) |
| n <= 100,000 | Must use O(n) | O(n) | O(n) |
| Values can be negative | Cannot use two pointers directly | — | — |
| "Have I seen this before?" | HashMap | O(1) lookup | — |

### Complexity cheat sheet

```
One loop              = O(n)
Loop inside loop      = O(n²)
No extra storage      = O(1) space
Store n items         = O(n) space
n <= 100              = O(n²) acceptable
n <= 10,000           = O(n log n) needed
n <= 1,000,000        = Must be O(n)
```
