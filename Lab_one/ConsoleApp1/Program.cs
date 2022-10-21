
byte ByteTry()
{
    byte res = 0;
    bool trying = true;
    {
        while (trying)
        {
            bool sucsess = byte.TryParse(Console.ReadLine(), out res);
            if (!sucsess)
            {
                Console.WriteLine("Write the number");
            }
            else
            {
                if (res < 0)
                {
                    Console.WriteLine("Wrong imput");
                }
                else
                {
                    trying = false;
                }
            }
        }
        return res;
    }
}
Console.WriteLine("Write the first number:");
byte first = ByteTry();
Console.WriteLine("Write the second number:");
byte second = ByteTry();
Console.WriteLine("&");
Console.WriteLine(first & second);
Console.WriteLine("|");
Console.WriteLine(first | second);
Console.WriteLine("^");
Console.WriteLine(first ^ second);
