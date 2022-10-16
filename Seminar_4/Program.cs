// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Сделать в функции, сделать проверку на отрицательность.
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
void num (int A, int B){
        if (B<0) Console.WriteLine($"Число В дожно быть положительное");
        else Console.WriteLine($"Результат возведения в степень: {Math.Abs(Math.Pow(A,B))}");
}
num(A,B);
