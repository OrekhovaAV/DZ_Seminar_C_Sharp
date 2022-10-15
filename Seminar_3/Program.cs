// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите число из 5 цифр: ");
int num1 = int.Parse(Console.ReadLine());
void Number(int num1)
{
    int i = num1.ToString().Length;
    if (i < 5) Console.WriteLine($"Число не подходит по условию");
    else 
    {
        string num_str = Convert.ToString(num1);
        if((num_str[0] == num_str[4]) && (num_str[1] == num_str[3])) 
            Console.WriteLine($"{num_str} является палиндромом");
        else Console.WriteLine($"{num_str} не является палиндромом");
    }
}

Number(num1);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double S (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return result;
}
Console.WriteLine("Введите координаты числа А: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты числа B: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
Console.WriteLine();
double S1 = S(x1,y1,z1,x2,y2,z2);
Console.WriteLine(S1);
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
void cube(int N)
{
    int i = 1;
    while (i <= N)
        {
            Console.Write($"{Math.Pow(i,3)} ");
            i++;
        }
}
Console.Write($"Таблица кубов чисел от 1 до {N}: ");
cube(N);
*/
