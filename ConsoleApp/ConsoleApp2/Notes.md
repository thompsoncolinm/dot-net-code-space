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

