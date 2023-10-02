/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
 */


//1 вариант:

/* Console.Write("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
A(n, m);

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
}
Console.WriteLine(A(n, m)); */

//2 вариант:

/* Console.Write("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (m != 0 && n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}
Console.WriteLine(A(m, n)); */





/*
Задача 64: Задайте значения N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5. -> "5, 4, 3, 2, 1"
N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NatLow(number, count);


void NatLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NatLow(n, count + 1);
        Console.Write(count + " ");
    }
} */





/*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
 
/* Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m, n);

// вызов функции "сумма чисел от M до N"
void Sum(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
} */