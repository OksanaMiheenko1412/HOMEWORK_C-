Console.Clear();
Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
if (a%2 == 0)
    Console.Write("yes");
else
    Console.Write("no");    