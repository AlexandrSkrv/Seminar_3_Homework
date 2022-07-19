// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if  (num > 99999 || num < 10000)
{ 
  Console.WriteLine("Число не соответствует условию задачи"); 
}
else{   
int newnum = 0;
int oldnum = num;
while (num > 0)
{
  int dig = num % 10;
  newnum = newnum * 10 + dig;
  num = num / 10;
}
if (oldnum == newnum)

  Console.WriteLine($" {newnum} -> палиндром");

else

  Console.WriteLine($" {oldnum} -> не палиндром");
}