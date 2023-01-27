// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int NumPow (int A, int B)
{
    int result=1;
    int count= 1;
    while (count<=B)
    {
        result*=A;
        count++;
    }
    return result;
}
Console.Write("Введите число A: ");
int A =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{NumPow(A,B)}");
