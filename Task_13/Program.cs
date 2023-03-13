Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 && a > -100)
    Console.WriteLine("Третьей цифры нет");
if ((a < 1000 && a >= 100) || (a <= -100 && a > -1000))
    Console.WriteLine(Math.Abs(a % 10));
if ((a < 10000 && a >=1000) || (a <= -1000 && a > -10000))
    Console.WriteLine(Math.Abs(a % 100/10));
if ((a < 100000 && a >=10000) || (a <= -10000 && a > -100000))
    Console.WriteLine(Math.Abs(a % 1000/100));