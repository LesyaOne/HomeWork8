/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumOfElem (int m, int n)
{
    if (m != n) return n+SumOfElem(m, n-1);
    else return m;
}
Console.Write("Enter first positive number: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second positive number: ");
int userN = Convert.ToInt32(Console.ReadLine());
if (userM <= userN) Console.Write($"Sum of elements is {SumOfElem(userM, userN)}");
if (userM > userN) Console.Write($"Sum of elements is {SumOfElem(userN, userM)}");