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



