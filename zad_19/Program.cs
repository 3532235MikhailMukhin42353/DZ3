/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int pol = number.Length;
Console.WriteLine(Polindrom(pol));

string Polindrom (int pol)
{
    string res;
if (pol == 5)
{
    if (number[0] == number[4] && number[1] == number[3]) res = "Число полиндром";
    else res = "Число не полиндром";
}
else res = "Введите именно пятизначное!!!";
return res;
}