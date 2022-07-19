// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число--Куб числа");
TableCubesNumbers(num);
void TableCubesNumbers(int num)
{
  int i = 1;
  while (i <= num)
  {
    Console.WriteLine($"| {i}  |  {i * i * i,2} |");
    i++;
  }
}
Console.WriteLine("-------------");