// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int[] new_array(int M){
    int[] arr = new int[M];
    Console.WriteLine("Введите числа:");
    for(int i = 0; i < M; i++){
        arr[i] = int.Parse(Console.ReadLine());
        }
    return arr;
}
// void Print(int[] arr){
   // Console.WriteLine(String.Join(", ", arr));
// }
int kol(int[] arr){ 
    int n = 0;
    int max = 0;
    for(int i=0;i<arr.Length;i++){
        if(arr[i]>0){
            n++;
        }
        if (n>max){
            max=n;
        }
    }
    return max;
}
Console.WriteLine("Введите количество элементов: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];
array = new_array(M);
// Console.Write("Полученный массив: ");
// Print(array);
Console.Write("Количество введенных чисел больше 0: ");
Console.WriteLine(kol(array));
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
double znach_1 (int b1, int k1, int b2, int k2){
    double result = (double) (b2 - b1) / (k1 - k2);
    return result;
}
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());
double x = znach_1(b1,k1,b2,k2);
double y = (double) k1*x + b1;
if (k1==k2)
    Console.WriteLine("Прямые параллельны");
else
    Console.WriteLine($"Точка пересечения: {x};{y}");
*/