# ConsoleApplication1 - List Comparison using C#

## 📌 Overview
This project demonstrates different approaches to comparing two integer arrays in C#. The goal is to identify:

- Common elements between two lists
- Elements unique to the first list
- Elements unique to the second list

The solution is implemented using three distinct methods:
1. LINQ set operations (`Intersect`, `Except`)
2. LINQ filtering (`Where`, `Contains`)
3. Manual nested loop comparison

---

## 📊 Problem Statement

Given the following two integer arrays:

```csharp
List1 = { 1, 2, 3, 4, 5 }
List2 = { 3, 4, 5, 6, 7 }
