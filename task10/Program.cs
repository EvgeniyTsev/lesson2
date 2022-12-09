Console.WriteLine("Введите трехзначное число: ");
string input1 = Console.ReadLine()!;
int parsedInput1 = int.Parse(input1);

int secondDigital = ((parsedInput1 / 10) % 10); 

Console.WriteLine($"Второе число: {secondDigital}");