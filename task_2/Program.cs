// Задача 2. Программа на вход принимает 2 числа и выдает какое больше, а какое
// мельше. Например: a=5,b=7 ->max =7; a=-9,b=-3 ->max=-3
Console.Clear();
Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
Console.Write("Введите 2-ое  число");
int b = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
if (a > b)
    Console.Write(a);
else
    Console.Write(b);