System.Console.WriteLine("Введите число");
string number = Console.ReadLine();
int number1 = int.Parse(number);

int length = 1;
int count = 10;

while (number1 / count > 0)
{
    length++;
    count = count * 10;
}
System.Console.WriteLine($"Длина числа {length} символов.");

if (length < 3)
{
    System.Console.WriteLine("Третьей цифры нет.");
}
else
{
    count = count / 1000;
    System.Console.WriteLine($"Третья цифра числа {number1} - это {number1 / count % 10}");
}
