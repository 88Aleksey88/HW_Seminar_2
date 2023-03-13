Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if ((a >= 100 && a < 1000) || (a <=-100 && a >= -1000))
    {
    int b = a / 10;
    Console.WriteLine(Math.Abs(b % 10));
    }
else 
    Console.WriteLine("Вы ввели не трехзначное число");
