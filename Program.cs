/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
Console.Clear();
int m = 3;
int n = 2;
int AkermannFuntion (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkermannFuntion (m - 1, 1);
    else if (m > 0 && n > 0) return AkermannFuntion (m - 1, AkermannFuntion(m, n - 1));
    return 0;
}
Console.WriteLine(AkermannFuntion(m, n));
