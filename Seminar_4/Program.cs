// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Сделать в функции, сделать проверку на отрицательность.
/*
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
void num (int A, int B){
        if (B<0) Console.WriteLine($"Число В дожно быть положительное");
        else Console.WriteLine($"Результат возведения в степень: {Math.Abs(Math.Pow(A,B))}");
}
num(A,B);
*/

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Sum_N(int N){
        int length_N = Convert.ToString(N).Length;
        int num_1 = 0;
        int result = 0;
        for (int i = 0; i < length_N; i++){
                num_1 = N - N % 10;
                result = result + (N - num_1);
                N = N / 10;
        }
        return result;
}
int sum = Sum_N(N);
Console.WriteLine($"Сумма цифр в числе: " + sum);
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. 
// Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
/*
int[] Massiv_1(int n){
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
                arr[i]=new Random().Next(1,50);
        return arr;
}
void Print(int[] arr){
        Console.WriteLine(String.Join(" ", arr));
}
void Massiv_2(int[] arr){
        int k = 0;
        for (int i = 0; i < arr.Length; i++){
                k = arr[i];
                int Sum_k(int k){
                int length_k = Convert.ToString(k).Length;
                int num_1 = 0;
                int result = 0;
                for (int i = 0; i < length_k; i++){
                        num_1 = k - k % 10;
                        result = result + (k - num_1);
                        k = k / 10;
                }
                return result;
        }
        int sum = Sum_k(k);
        Console.Write($"{sum} "); 
        } 
}
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
array = Massiv_1(n);
Print(array);
Console.WriteLine("Новый массив: ");
Massiv_2(array);
*/


