# C# Lab Exam: 30 Practice Programs

30 short console programs in C#, one per exam question. Each file has its own `Main`.
`CSharp_Lab_Exam_30_Programs.pdf` explains every program and shows its output. The `outputs/` folder has each program's real output.

| No. | Program | No. | Program | No. | Program |
|---|---|---|---|---|---|
| 1 | Fibonacci (first 50) | 11 | First non-repeating char | 21 | Permutations of a string |
| 2 | First 50 primes | 12 | Remove duplicates | 22 | Longest substring without repeats |
| 3 | Palindrome | 13 | Armstrong number | 23 | Rotate array by k |
| 4 | Second largest | 14 | Binary search | 24 | Array intersection |
| 5 | Anagram | 15 | Kadane (max subarray) | 25 | Majority element |
| 6 | Balanced brackets | 16 | Merge sorted arrays | 26 | Thread-safe singleton |
| 7 | Reverse words | 17 | String rotation | 27 | LRU cache |
| 8 | Two Sum | 18 | String compression | 28 | Validate BST |
| 9 | Character frequency | 19 | Reverse linked list | 29 | Count set bits |
| 10 | Missing number | 20 | Detect cycle (Floyd) | 30 | Producer-consumer |

## What you need
Any **.NET SDK** (6, 7, 8, 9 or newer). To check, type `dotnet --list-sdks` in a terminal.
If nothing is listed, install it from https://dotnet.microsoft.com/download.

## Download
Click **Code → Download ZIP** on GitHub and unzip it. If git is installed, you can run this instead:
```
git clone https://github.com/nesrekk/csharp.git
```

## Run a program
Open a terminal in the unzipped folder.

**Windows** (Command Prompt or PowerShell):
```
run 7
```
In PowerShell, type `.\run 7`.

**Mac / Linux:**
```
./run.sh 7
```

The number picks the question, so `run 15` runs Kadane. You can also give a file name: `run Q15_Kadane`.

## Run without the scripts
**Visual Studio:**
1. Create a new **Console App**.
2. Replace everything in `Program.cs` with the code of one `Qxx_*.cs` file.
3. Press **Ctrl+F5**.

**Terminal:**
```
dotnet new console -o Test
```
Then paste one file's code into `Test/Program.cs` and run:
```
dotnet run --project Test
```

**VS Code** (C# Dev Kit extension):
1. Open the `ExamPrograms` folder.
2. Open a `Qxx` file.
3. Press **F5** with the "Run open question" configuration selected.
