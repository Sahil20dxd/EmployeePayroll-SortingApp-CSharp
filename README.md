# EmployeePayroll-SortingApp-CSharp

## Overview

A C# console application reads employee records from a CSV file, calculates gross pay (including overtime), and allows sorting based on different employee attributes using custom sort algorithms.

## Features

- Reads employee data from `employees.txt` into a fixed-size array.
- Calculates gross pay with overtime (1.5x after 40 hours).
- Allows sorting by:
  - Employee Name (ascending)
  - Employee Number (ascending)
  - Pay Rate (descending)
  - Hours Worked (descending)
  - Gross Pay (descending)
- Displays employee records in a neatly formatted table.
- Uses a custom sorting algorithm (not Bubble Sort).
- Modular design with separate `Employee` and `Program` classes.
- Includes internal and XML documentation for all classes and methods.
- Handles exceptions during file reading and input validation.

## Project Structure

Lab1/
├── Employee.cs # Contains the Employee class and logic
├── Program.cs # Main driver with menu and logic
├── employees.txt # Input data file with employee records
├── Lab1.csproj # Project file
└── Properties/
└── AssemblyInfo.cs # Assembly metadata


## How to Run

1. Open the solution in **Visual Studio Professional 2019** (available via Mohawk Apps).
2. Build the project.
3. Ensure `employees.txt` is in the same directory as the executable.
4. Run the program to interact with the console menu.

## Documentation

- Inline comments explain major logic blocks.
- XML documentation is included for all public methods and classes.
- A comment block at the top of each file includes:
  - File date
  - Purpose

