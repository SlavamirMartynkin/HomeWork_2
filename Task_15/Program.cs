System.Console.WriteLine("Введите номер дня недели");
string number = Console.ReadLine();
int weekNumber = int.Parse(number);

if (weekNumber == 6 || weekNumber == 7)
{
    System.Console.WriteLine($"День недели № {weekNumber} - выходной");
}
else if (weekNumber < 1 || weekNumber > 7)
{
    System.Console.WriteLine("Странный день недели");
}
else
{
    System.Console.WriteLine($"День недели № {weekNumber} - будний день");
}
