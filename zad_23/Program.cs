/*адача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1,    8,   27   
    1^3 + 2^3 + 3^3   */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
TablKubov(number);

void TablKubov(int number)
{
    int result = 0;
    for (int i = 0; i <= number; i++)
    {
        result = i * i * i;
        Console.Write(result + "\t");
    }
}