Console.WriteLine("Ввидите номер дня недели:");
string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);

if (parsedInput1 >= 1 && parsedInput1 <= 5)
{
    Console.Write("Не выходной");
}
else if (parsedInput1 >= 6 && parsedInput1 <= 7)
{
    Console.Write("Выходной");
}
else Console.Write("Не существует такого дня недели");
