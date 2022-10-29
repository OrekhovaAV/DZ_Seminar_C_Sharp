/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
int[] Massiv_N (int n) {
    int[] arr = new int[n];
    for (int i = 0; i < n; i++){
        arr[i] = new Random().Next(100,999);
    }
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ", arr));
}
int kol(int[] arr){
    int k = 0;
    for(int i=0;i<arr.Length;i++){
       if (arr[i] % 2 == 0) k++;
    }
    return k;
}
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
array = Massiv_N(n);
Print(array);
Console.WriteLine($"Количество четных чисел в массиве - {kol(array)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] numbers (int a) {
    int[] arr = new int[a];
    for (int i = 0; i < a; i++){
        arr[i] = new Random().Next(-10,10);
    }
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ", arr));
}
int nechet_poz (int[] arr){
    int sum = 0;
    for(int i=0;i<arr.Length;i = i + 2){
       sum = sum + arr[i];
    }
    return sum;
}
Console.WriteLine("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];
array = numbers(a);
Print(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {nechet_poz(array)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
void num (double[] arr) { // выводит массив
    for (int i = 0; i < arr.Length; i++){
        arr[i] = Convert.ToDouble(new Random().Next(10,1000)) / 100;
    }
}
void Print(double[] arr){ 
    Console.WriteLine(String.Join(" ", arr));
}
void dif (double[] arr){
double max = arr[0];
double min = arr[0];
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] > max) {
            max = arr[i];
        }
        if (arr[i] < min) {
            min = arr[i];
        }
    }
Console.WriteLine($"Максиальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max-min}");
}
Console.WriteLine("Введите количество элементов массива: ");
int k = int.Parse(Console.ReadLine());
double[] array = new double[k];
num(array);
Print(array);
dif(array);
*/