/*
    Completely free to use
 
    generates passwords, be it simple (numbers and letters) or complex (numbers, letters and symbols)

    also has a save function (SaveText)
 */
using System.Text;

var random = new Random();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine(GenerateNormal());
Console.WriteLine(GenerateComplex());

Console.ReadLine();

//functions area
async void SaveText(string text, string name, string mainaddress = "Desktop\\")
{
    string file = mainaddress + name;
    if (!File.Exists(file))
    {
        File.Create(file);
    }
    using (var writer = new StreamWriter(file))
    {
        writer.Write(text);
    }
}

string GenerateNormal(int range = 10)
{
    var alphabet = new char[]
    {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    StringBuilder text = new StringBuilder();

    for (int i = 0; i != range + 1; i++)
    {
        bool isletter = random.Next(0, 2) == 0;

        if (isletter)
        {
            text.Append(alphabet[random.Next(alphabet.Length)]);
        }
        else
        {
            text.Append(random.Next(0, 9));
        }
    }
    return text.ToString();
}

string GenerateComplex(int range = 10)
{
    var alphabet = new char[]
    {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    var symbols = new char[]
    {'(',')','.','_','@'};

    StringBuilder text = new StringBuilder();

    for (int i = 0; i != range; i++)
    {
        int number = random.Next(0, 3);

        if (number == 0)
        {
            text.Append(alphabet[random.Next(alphabet.Length)]);
        }
        if (number == 1)
        {
            text.Append(symbols[random.Next(symbols.Length)]);
        }
        else
        {
            text.Append(random.Next(0, 9));
        }
    }
    return text.ToString();
}