class Assignment4
{
    public static void Main(string[] args)
    {
        int sum;
        double average;

        Console.WriteLine("Sum and Average Calculator Program 3 Numbers");

        Console.Write("Enter Your First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Third Number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2 + num3;
        average = sum / 3;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
    }
}



# C-Console-Project-Assignment-3

A simple C# console application developed using .NET 10.0.  
This project demonstrates user input handling, data conversion, and console output using C#.

---

## 📌 Project Overview

The application takes user input from the console and displays the entered information, including:

- Name
- Age
- CGPA

This project is created as part of a C# Console Project Assignment.

---

## 🛠 Technologies Used

- C#
- .NET 10.0 SDK

---

## 📂 Project Structure

```bash
C-Console-Project-Assignment-3/
│── Program.cs
│── C-Console-Project-Assignment-3.csproj
│── README.md
```

---

## ▶️ How to Run

### Clone the Repository

```bash
git clone <your-repository-url>
```

### Navigate to Project Folder

```bash
cd C-Console-Project-Assignment-3
```

### Run the Application

```bash
dotnet run
```

---

## 💻 Sample Output

```text
Enter Your Name: Seam
Enter Your Age: 22
Enter Your CGPA: 3.85

Name: Seam
Age: 22
CGPA: 3.85
```

---

## 🎯 Learning Objectives

- Understanding C# console applications
- Taking user input using `Console.ReadLine()`
- Converting input data types using `Convert`
- Using nullable data types
- Displaying formatted output with string interpolation
- Practicing basic program structure in .NET

---

## 👨‍💻 Author

Seam  
Full-stack Developer

---