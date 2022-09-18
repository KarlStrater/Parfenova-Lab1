// See https://aka.ms/new-console-template for more information
Console.WriteLine("It is a programm to count the perimeter of rectangle");

int a, b, perimetr=0;
bool isNumber=false;
while (!isNumber) {
    Console.WriteLine("Write the length: ");
    string? line=Console.ReadLine();
    isNumber=int.TryParse(line, out a);
    if (isNumber)
    {
        a = Convert.ToInt32(line);
        perimetr = a + a;
    }
    else
        Console.WriteLine("Wrong input... Try again)");
 }
isNumber = false;
while (!isNumber)
{
    Console.WriteLine("Write the width: ");
    string? line = Console.ReadLine();
    isNumber = int.TryParse(line, out b);
    if (isNumber)
    {
        b = Convert.ToInt32(line);
        perimetr += b + b;
    }
    else
        Console.WriteLine("Wrong input... Try again)");
}
Console.WriteLine("Perimetr is: ");
Console.WriteLine(perimetr);
