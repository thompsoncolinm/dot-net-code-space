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

```csharp
string studentName = "Sophia Johnson";
string[] courseNames = { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
int[] courseCreditHours = { 3, 3, 4, 4, 3 };
int[] courseCreditGrade = { 4, 3, 3, 3, 4 };


// Write a funciton that assigns a grade to a student based the credits they've recieved

string AssignGrade(int credit)
{
    if (credit == 4)
    {
        return "A";
    }
    else if (credit == 3)
    {
        return "B";
    }
    else if (credit == 2)
    {
        return "C";
    }
    else if (credit == 1)
    {
        return "D";
    }
    else
    {
        return "F";
    }
} 

// Display the course names along with the numeric grade

for (int i = 0; i < courseNames.Length; i++)
{
    Console.WriteLine($"{courseNames[i]}: {courseCreditGrade[i]} {courseCreditHours[i]}");
}

int totalCreditHours = courseCreditHours.Sum();

int totalGradePoints = 0;

for (int i = 0; i < courseCreditHours.Length; i++)
{
    totalGradePoints += courseCreditHours[i] * courseCreditGrade[i];
}

double gpa = (double)totalGradePoints / totalCreditHours;

Console.WriteLine($"{totalGradePoints} {totalCreditHours}");
Console.WriteLine($"GPA: {gpa}");

// Format the decimal output to two decimal places

// Console.WriteLine($"GPA: {gpa.ToString("F2")}");    // GPA: 3.35 // Preferred method

// Figure out how to do that calculation with just integers

int leadingDigit = (int )gpa;
int firstTrailingDigit = (int)((gpa * 10) % 10);
int secondTrailingDigit = (int)((gpa * 100) % 10);

Console.WriteLine($"GPA: {leadingDigit}.{firstTrailingDigit}{secondTrailingDigit}");    // GPA: 3.35

Console.WriteLine($"Student: {studentName}");

Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

for (int i = 0; i < courseNames.Length; i++)
{
    string tabs = new string('\t', (32 - courseNames[i].Length + 7) / 8);
    Console.WriteLine($"{courseNames[i]}{tabs}{AssignGrade(courseCreditGrade[i])}\t{courseCreditHours[i]}");
}

```

## Methods

```csharp
Random dice = new Random(); // Create a new Random object   // state instance
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

```csharp
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
```

```csharp
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
```

## Conditionals

```csharp
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// roll1 = 6; // test rolls
// roll2 = 6; // test rolls
// roll3 = 6; // test rolls

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total >= 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
```

```csharp

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Code only displays one message
// If the user's subscripton will expire in 10 days or less, display the massage "Your subscription will expire soon. Renew now!"

// if the user's subscription will expire in five days or less, display the message "Your subscription will expire in _ days. Renew now and save 10%!"

// If the user's subscription has expired, display the message "Your subscription has expired"


// If the user's subscription doesn't expire in 10 days or less, display nothing

// if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// else if (daysUntilExpiration <= 5)
// {
//     discoutPercentage = 10;
//     Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days. Renew now and save {discoutPercentage}%!");
// }
// else if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired");
// }
// else
// {
//     Console.WriteLine("");
// }

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
```

```csharp
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

string[] numericPositons = {"first", "second", "third", "fourth", "fifth"};

for (int i = 0; i < fraudulentOrderIDs.Length; i++)
{
    Console.WriteLine($"{numericPositons[i]}: {fraudulentOrderIDs[i]}");
}
```