// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
string FillNumbers(int n){
    if (n==1) return n.ToString();
    else    
        return (n+ ","+ " " + FillNumbers(n-1));
}
Console.WriteLine(FillNumbers(8));
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
/*
int sumNumb(int M, int N){
    if (M==N) return M;
    else {
        return (M + sumNumb((M+1),N));
    }
}
Console.WriteLine(sumNumb(1,15));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. С помощью рекурсии!!!
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int AkkermanFun (int m, int n){
    if (m==0) return n+1;
    else if (m>0 & n==0) return AkkermanFun(m-1,1);
    else if (m>0 & n>0) return AkkermanFun(m-1,AkkermanFun(m,n-1));
    else 
        return 0;
}
Console.WriteLine(AkkermanFun(1,2));
