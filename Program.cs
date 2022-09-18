
Console.WriteLine("It is a programm to count the area of rectangle");

int a, b, area=0;
bool isNumber=false;
while (!isNumber) {
    Console.WriteLine("Write the length: ");
    string? line=Console.ReadLine();
    isNumber=int.TryParse(line, out a);
    if (isNumber)
    {
        a = Convert.ToInt32(line);
        area = a;
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
        area *= b;
    }
    else
        Console.WriteLine("Wrong input... Try again)");
}
Console.WriteLine("Area is: ");
Console.WriteLine(area);
