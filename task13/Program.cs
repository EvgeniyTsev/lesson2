Console.WriteLine("Введите число: ");
string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);

int thirdDigital = ((parsedInput1 / 10) % 10); 

if (parsedInput1 < 100)
{
    Console.WriteLine("Это не трехзначное число");
}
else
{
    Console.WriteLine($"Третье число: {thirdDigital}");
}


