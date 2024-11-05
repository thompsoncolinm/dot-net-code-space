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

