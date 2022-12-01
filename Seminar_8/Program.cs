// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:          В итоге получается вот такой массив:    
//      1 4 7 2                             7 4 2 1
//      5 9 2 3                             9 5 3 2
//      8 4 2 4                             8 4 4 2
/*
void FillMas(int[,] arr){
    for(int i=0; i<5; i++)
        for(int j=0; j<5; j++)
            arr[i,j]= new Random().Next(0,10);
}
void Output(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Swap(int[,] arr){
    for (int i=0; i<arr.GetLength(0); i++){
        for (int j=0; j<arr.GetLength(1); j++){
            for (int k=0; k<arr.GetLength(1)-1; k++){
                if (arr[i,k]<arr[i,k+1]){
                    int temp=arr[i,k+1];
                    arr[i,k+1]=arr[i, k];
                    arr[i,k]=temp;
                }
            }
        }
    }
    return arr;
}
int[,] array = new int[5,5];
FillMas(array);
Output(array);
int[,] newArr = new int[5,5];
newArr = Swap(array);
Output(array);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//      1 4 7 2
//      5 9 2 3
//      8 4 2 4
//      5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
void FillMas(int[,] arr){
    for(int i=0; i<5; i++)
        for(int j=0; j<5; j++)
            arr[i,j]= new Random().Next(0,10);
}
void Output(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] Swap(int[,] arr){
    int sumLine=0;
    int minSumLine=0;
    int minSum=0;
    for (int i=0; i<arr.GetLength(0); i++){
        sumLine += arr[0, i];
    }
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++) 
            minSumLine += arr[i, j];
            if (minSumLine < sumLine) {
                minSumLine = sumLine;
                minSum = i;
            }
        minSumLine=0;
    }
     Console.WriteLine($"Строка с наименьшей суммой элементов - {minSum+1}");
return arr;
}

int[,] array = new int[5,5];
FillMas(array);
Output(array);
int[,] newArr = new int[5,5];
newArr = Swap(array);
*/

// ??????    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:            Результирующая матрица будет:
//      2 4 | 3 4                               18 20
//      3 2 | 3 3                               15 18

void FirstMas(int[,] arr){
    for(int i=0; i<2; i++)
        for(int j=0; j<2; j++)
            arr[i,j]= new Random().Next(0,10);
}
void FirstOutput(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SecondMas(int[,] arr){
    for(int i=0; i<2; i++)
        for(int j=0; j<2; j++)
            arr[i,j]= new Random().Next(0,10);
}

void SecondOutput(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void resultMas(int[,] FirstMas, int[,] SecondMas, int[,] thirdMas){
    int[,] thirdMas = new int[2,2]
    for (int i = 0; i < thirdMas.GetLength(0); i++){
        for (int j = 0; j < thirdMas.GetLength(1); j++){
            thirdMas[i,j]=0;
            for (int k = 0; k < FirstMas.GetLength(1); k++){
                thirdMas[i,j] += FirstMas[i,k] * SecondMas[k,j];
            }
        }
    }
}

int[,] array = new int[2,2];

Console.WriteLine("Матрица №1");
FirstMas(array);
FirstOutput(array);

Console.WriteLine("Матрица №2");
SecondMas(array);
SecondOutput(array);

Console.WriteLine("Результат произведения матриц");
resultMas(FirstMas, SecondMas, thirdMas);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
void FillMas(int[,,] arr){
    int count = 10;
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++){
            for (int k=0; k<arr.GetLength(2); k++){
                arr[i,j,k]= new Random().Next(0,10);
                arr[i,j,k] += count;
                count += 3;
            }
        }
    }
}
void Output(int[,,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++){
            Console.WriteLine();
                for (int k=0; k<arr.GetLength(2); k++){
                    Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
                }
        }
    }
}

int[,,] array = new int[2,2,2];
FillMas(array);
Output(array);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

void Output(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++)
            Console.Write(arr[i,j]+"\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = new int[n,n];

int N = 1;
int i = 0;
int j = 0;

while (N <= n * n)
{
    array[i, j] = N;
    if (i <= j + 1 && i + j < n - 1) j++;
    else if (i < j && i + j >= n - 1) i++;
    else if (i >= j && i + j > n - 1) j--;
    else i--;
    N++;
}

Output(array);
*/






