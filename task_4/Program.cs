Console.Clear();
Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
Console.Write("Введите 2-ое  число");
int b = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
Console.Write("Введите 1-ое число");
int c = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
if (a > b && a > c)
    Console.Write(a);
if (b > a && b > c)
    Console.Write(b);
if (c > a && c > b)
    Console.Write(c);