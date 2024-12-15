# F# Extended Euclidean Algorithm Bug

This repository demonstrates a bug in an F# implementation of the extended Euclidean algorithm. The algorithm itself is correct, but the use of mutable variables leads to unexpected results.

## Bug Description

The original code uses mutable variables (`x`, `y`, `z`) to store intermediate results during the calculation of the greatest common divisor (GCD) and the extended GCD coefficients.  This approach is prone to errors and makes the code harder to understand and maintain.

## Solution

The solution replaces the mutable variables with a purely functional approach using recursion and tuples to pass values. This is safer and generally more idiomatic F#.

## How to reproduce

1. Clone this repository.
2. Open `bug.fs` in an F# compiler. The output will be incorrect.
3. Open `bugSolution.fs` in an F# compiler. The output will be correct.
