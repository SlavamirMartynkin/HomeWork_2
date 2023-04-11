int x = new Random().Next(100, 1000);
System.Console.WriteLine(x);

int second = x / 10 % 10;

System.Console.WriteLine($"Вторая цифра числа {x} - это {second}.");