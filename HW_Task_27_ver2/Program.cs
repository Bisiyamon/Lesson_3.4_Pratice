string num = string.Empty;
int sum = 0;

while(true)
{
    Console.Write("Input your number: ");
    num = Console.ReadLine();
    bool isNumeric = int.TryParse(num, out _);
    if(isNumeric == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorrect input, you have to enter only number");
    }
}

int[] number = new int[num.Length];

for(int i = 0; i<num.Length; i++)
{
    int num2 = 0;
    num2 = Convert.ToInt32(num);
    number[i] = (num2/Convert.ToInt32(Math.Pow(10, num.Length-1-i)))%10;
    sum = sum + number[i];
}

foreach (int ch in number)
{
    Console.Write(" / ");
    Console.Write(ch);
}
Console.WriteLine(" /");
Console.WriteLine();

System.Console.WriteLine($"Sum of each digit = {sum}");
Console.WriteLine();