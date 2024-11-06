# Syntax Notes

## Literal Values
```csharp
// Exercise - Print literal values

// Object literal values
using System.Security.Permissions;

Console.WriteLine('b'); // b   // char

// Console.WriteLine('Hello World!'); // (1,19): error CS1012: Too many characters in character literal

Console.WriteLine(123); // 123  // int

Console.WriteLine(0.25F); // 0.25   // float

Console.WriteLine(2.625); // 2.625  // double

Console.WriteLine(true); // True  // bool

Console.WriteLine(false); // False  // bool

Console.WriteLine(12.39816m); // 12.39816  // decimal

Console.WriteLine("Hello World!"); // Hello World!  // string

// Declare variables

string firstName;   // string
string lastName;    // string   

char userOption;    // char

int gameScore;      // int

decimal particlesPerMillion;    // decimal

bool precessedCustomer; // bool

firstName = "John"; // John  // string

Console.WriteLine(firstName); // John  // string

// Declare implicitly typed local variables

var message = "Hello World!"; // Hello World!  // string

// Code Challenge: Display the literal  and variable values

var name = "Bob"; // Bob  // string
var newMessages = 3; // 3  // int
var temperature = 34.4; // 34.4  // double

Console.WriteLine("Hello, " + name + "! You have " + newMessages + " messages in you inbox. The temperature is " + temperature + " celsius."); // Hello, Bob! You have 3 messages in you inbox. The temperature is 34.4 celsius.  // string

Console.WriteLine(34.40M); // 34.40  // decimal
```

## Escape Characters and Sequences
```csharp
// Combine strings using character escape sequences

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World!\"");

// Format output using character escape sequences

Console.WriteLine("Generating invoices for customer \"Contso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Verbatim String Literal

Console.WriteLine(@"    c:\source\repos
    (this is where your code goes)");

// Unicode escape characters

// Kon'nichiwa World! (Hello World! in Japanese)
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seiku-sho - seisei suru ni wa:
Console.WriteLine("\u65E5\u672C\u306E\u8D08\u4F0A\u66F8 - \u751F\u6210\u3059\u308B\u306B\u306F:");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


```

## Performing Basic String Formatting

```csharp
string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message);
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName); // Concatenation
Console.WriteLine($"{greeting} {firstName}"); // String interpolation

// string message = $"Hello {firstName}";
// Console.WriteLine(message);

// Using string interpolation with multiple variables and literal strings

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version} is available";

Console.WriteLine(message);

// Combine verbatim literals and string interpolation

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

// Challenge: Format and display instructions

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";   // Russian  // "View Russian output"

// You may not change the above strings. You can only change the code below this comment.

// Only by creating two instructons that print to the console.

// View English output:
//   c:\Exercise\ACME\data.txt

Console.WriteLine($"View English output:\n\t  c:\\Exercise\\{projectName}\\data.txt");

// Посмотреть русский вывод:
//   c:\Exercise\ACME\ru-RU\data.txt
Console.WriteLine($"{russianMessage}:\n\t  c:\\Exercise\\{projectName}\\ru-RU\\data.txt");

```

```csharp
string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message);
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName); // Concatenation
Console.WriteLine($"{greeting} {firstName}"); // String interpolation

// string message = $"Hello {firstName}";
// Console.WriteLine(message);

// Using string interpolation with multiple variables and literal strings

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version} is available";

Console.WriteLine(message);

// Combine verbatim literals and string interpolation

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

// Challenge: Format and display instructions

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";   // Russian  // "View Russian output"

// You may not change the above strings. You can only change the code below this comment.

// Only by creating two instructons that print to the console.

// View English output:
//   c:\Exercise\ACME\data.txt

Console.WriteLine($"View English output:\n\t  c:\\Exercise\\{projectName}\\data.txt");

// Посмотреть русский вывод:
//   c:\Exercise\ACME\ru-RU\data.txt
Console.WriteLine($"{russianMessage}:\n\t  c:\\Exercise\\{projectName}\\ru-RU\\data.txt");
```

```csharp
// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaGrades = { 93, 87, 98, 95, 100 };
int[] nicolasGrades = { 80, 83, 82, 88, 85 };
int[] zahirahGrades = { 84, 96, 73, 85, 79 };
int[] jeongGrades = { 90, 92, 98, 100, 97 };

int sophiaSum = sophiaGrades.Sum();
int nicolasSum = nicolasGrades.Sum();
int zahirahSum = zahirahGrades.Sum();
int jeongSum = jeongGrades.Sum();

// Create `Console.WriteLine` statements to display the student name and the value of their summed assignment scores

// Console.WriteLine($"Sophia: {sophiaSum}");
// Console.WriteLine($"Nicolas: {nicolasSum}");
// Console.WriteLine($"Zahirah: {zahirahSum}");
// Console.WriteLine($"Jeong: {jeongSum}");

// Create variables to store the average score for their graded assignments

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

// Display each student's current score and

// Console.WriteLine($"Sophia: {sophiaScore}");
// Console.WriteLine($"Nicolas: {nicolasScore}");
// Console.WriteLine($"Zahirah: {zahirahScore}");
// Console.WriteLine($"Jeong: {jeongScore}");


// Calculate the letter grade based on the following numeric to letter assignments
// 97 - 100    A+
// 93 - 96     A
// 90 - 92     A-
// 87 - 89     B+
// 83 - 86     B

// Create a function to calculate the appropriate letter grade based on the average score

string CalculateLetterGrade(decimal score)
{
    if (score >= 97)
    {
        return "A+";
    }
    else if (score >= 93)
    {
        return "A";
    }
    else if (score >= 90)
    {
        return "A-";
    }
    else if (score >= 87)
    {
        return "B+";
    }
    else if (score >= 83)
    {
        return "B";
    }
    else
    {
        return "F";
    }
}

// Display each student's score and letter grade

Console.WriteLine("Name\t\t Score\t Grade");
Console.WriteLine($"Sophia:\t\t {sophiaScore}\t{CalculateLetterGrade(sophiaScore)}");
Console.WriteLine($"Nicolas:\t {nicolasScore}\t{CalculateLetterGrade(nicolasScore)}");
Console.WriteLine($"Zahirah:\t {zahirahScore}\t{CalculateLetterGrade(zahirahScore)}");
Console.WriteLine($"Jeong:\t\t {jeongScore}\t{CalculateLetterGrade(jeongScore)}");
```
