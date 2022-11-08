// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<3;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<4; j++)
            mylist[i].Add(Math.Round((new Random().NextDouble()*5), 1));
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ "\t");
        Console.WriteLine();
    }
}
List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 2 -> под данным номером стоит число 2
/*
void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); 
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки: ");
int numString = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numColumn = int.Parse(Console.ReadLine());

List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);

if (numString<=numbers.Count && numColumn<=numbers.Count){ 
    Console.WriteLine($"{numString} {numColumn} -> под данным номером стоит число {numbers[numString][numColumn]}");
}
else {
    Console.WriteLine($"{numString} {numColumn} -> такого числа в массиве нет");
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillList(List <List<double>> mylist){
    for (int i=0;i<5;i++){
        mylist.Add(new List<double>());
        for (int j=0; j<5; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble()*5)); 
        }
}
void PrintList(List <List<double>> mylist){
    for (int i=0;i<mylist.Count;i++){
        for (int j=0; j<mylist[i].Count;j++)
            Console.Write(mylist[i][j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double Arithmetical(List <List<double>> mylist){
    double sum = 0;
    for (int i=0;i<5;i++){
        for (int j=0; j<5; j++)
            sum+=mylist[i][j];
            sum=Math.Round((sum/5), 2);
            Console.Write(sum + "; ");}
    return sum;
}

List <List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
Arithmetical(numbers);


