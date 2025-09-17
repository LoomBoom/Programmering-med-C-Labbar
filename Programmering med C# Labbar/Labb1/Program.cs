using System.Numerics;

Console.WriteLine("Skriv in en text!");

string userText = Console.ReadLine();
int startNumber;
int startIndex;
BigInteger sum = 0;

for (int i = 0; i < userText.Length; i++)
{
    if (char.IsDigit(userText[i]))
    {
        startIndex = i;
        startNumber = int.Parse(userText[i].ToString());
        for (int j = i + 1; j < userText.Length; j++)
        {
            if (!char.IsDigit(userText[j]))
            {
                break;
            }else if (int.Parse(userText[j].ToString()) == startNumber)
            {
                PrintHighLightedString(startIndex, j+1, userText);
                sum += GetValueFromString(startIndex, j+1, userText);
                break;
            }
            else
            {
                
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine($"The sum of all the highlited values are {sum}");

static void PrintHighLightedString(int startIndex, int endIndex, string userText)
{
    if(startIndex != endIndex)
    {
        Console.Write(userText.Remove(startIndex));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userText.Substring(startIndex, endIndex - startIndex));
        Console.ResetColor();
        Console.Write(userText.Substring(endIndex));
        Console.WriteLine();
    }
}

static BigInteger GetValueFromString(int startIndex, int endIndex, string userText)
{
    return BigInteger.Parse(userText.Substring(startIndex, endIndex - startIndex));
}