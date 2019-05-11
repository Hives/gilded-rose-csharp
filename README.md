# Gilded Rose - C#

1. Install IntelliJ Rider
2. Install .NET SDK
3. Install Mono (Rider was asking me to)
4. Update Rider settings with location of Mono and MSBuild
5. Now I can run the tests in Rider

Refactorings:
- Where a condition is being checked multiple times, try and extract that into one single conditional.
- Turn negative conditionals (`-=`) into positive conditionals (`==`) where possible - more readable.
- Simplify complex conditionals into switch/case blocks
- There was a series of conditionals that were 'falling through', similar to this:
  ```
  x += 1
  if (y < 10) {
    x += 1
  }
  if (y < 5) {
    x += 1
  }
  ```
  This is harder to read than this:
  ```
  if (y >= 10)
    x += 1
  }
  if (y >= 5 && y < 10) {
    x += 2
  }
  if (y < 5) {
    x += 3
  }
  ```


I notice that some refactorings I did when I did this in JS are breaking the tests I've written in C#! In other words, my tests in JS must not have been covering certain situations. Reflection - it's harder to be sure that your tests give good coverage if you write them after the fact. When TDD-ing you only write the minimum code to pass a test, which means you can be more sure that the tests accurately cover the functionality of your program.

