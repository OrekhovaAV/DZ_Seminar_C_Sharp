// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int num = new Random().Next(100,999);
Console.WriteLine(num);
int s1 = (num/10)%10;
Console.WriteLine($"Вторая цифра трехзначного числа -> {s1}");
*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введите номер дня недели (от 1 до 7): ");
int day = int.Parse(Console.ReadLine());
if (day < 1 && day > 6 ) Console.WriteLine($"{day} день недели не является выходным днем");
else if (day == 6 || day == 7) Console.WriteLine($"{day} день недели является выходным днем");
else Console.WriteLine($"{day} такого дня недели не существует");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*

//1 способ:
/* 
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(N);
string N_str = Convert.ToString(N);
int N_result = N_str.Length;
if (N_result < 3) Console.WriteLine($"Третьей цифры нет");
else Console.WriteLine($"Третья цифра -> {N_str[2]}");
*/

// 2 способ: 
/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(N);
int count = N.ToString().Length;
Console.WriteLine(count);
void number(int N, int count){
    if (count<3) Console.WriteLine($"Третьей цифры нет");
    else 
    {
        
    }
}
number(N, count);
*/
