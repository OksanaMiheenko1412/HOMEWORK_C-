// Задача 8. Программа, которая на вход принимает число (N), а на выходе показывает
// все четные числа от 1 до N. Например: 5->2,4; 8->2,4,6,8.
Console.Clear();
Console.Write("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine()); // Ввод чисел
int i=2;
while (i<=n)
{
 Console.Write(i);
 i= i+2;
}