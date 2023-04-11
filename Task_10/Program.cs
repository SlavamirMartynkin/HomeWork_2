System.Console.WriteLine("Введите число");
string x = Console.ReadLine();
int x1 = int.Parse(x);

int second = x1 / 10 % 10;

System.Console.WriteLine($"Вторая цифра числа {x} - это {second}.");