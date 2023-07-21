/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void RowOfElem (int n)
{
    if (n >= 1)
    {
        Console.Write ($"{n}, ");
        RowOfElem(n-1);
    }
    else Console.Write("\b\b.");
}
Console.Write("Enter your number: ");
int userN = Convert.ToInt32(Console.ReadLine());
RowOfElem(userN);