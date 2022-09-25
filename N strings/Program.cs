Console.WriteLine("N stars");
int n;
bool isNumber = false;
string stars = "*";
while (!isNumber)
{
    Console.WriteLine("Write the number:");
    string? line = Console.ReadLine();
    isNumber = int.TryParse(line, out n);
    if (!isNumber)
    {
        Console.WriteLine("Wrong input... Try again)");
    }
    else if(n<=0)
    { Console.WriteLine("Wrong input... Try again)"); }    
    for(int k=1; k<=n; k++)
    {
        Console.WriteLine(stars);
        stars += "*";
    }
}


