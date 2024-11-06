string[] names = { "John", "Paul", "George", "Ringo" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
foreach (int i in inventory)
{
    sum += i;
}
    Console.WriteLine($"We currently have {sum} items in inventory."