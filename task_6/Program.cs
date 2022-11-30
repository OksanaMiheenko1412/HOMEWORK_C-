// Задача 6. Программа на вход принимает число и выдает, является ли число четным
// то есть делится ли оно на два без остатка. Например: 4->да; -3->нет; 7->нет.
Console.Clear();
Console.Write("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
if (a%2 == 0)
    Console.Write("yes");
else
    Console.Write("no");    