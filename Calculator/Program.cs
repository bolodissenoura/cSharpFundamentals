Console.Clear();
Console.WriteLine("First value: ");
string? input1 = Console.ReadLine();
Console.WriteLine("Second value: ");
string? input2 = Console.ReadLine();

float v1 = float.Parse(input1 ?? "0");
float v2 = float.Parse(input2 ?? "0");

float result = v1 + v2;

Console.WriteLine("Your Value is: " + result);
