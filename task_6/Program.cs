Console.Clear();
Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
Console.Write("Введите 2-ое  число");
int b = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
Console.Write("Введите 1-ое число");
int c = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
if (a > b > c)
    Console.Write(a);
if (b > a > c)
    Console.Write(b);
if (c > a > b)
    Console.Write(c);
