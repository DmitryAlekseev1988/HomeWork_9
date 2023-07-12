// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные ЧёТНЫЕ
//  числа в промежутке от N до 0. Выполнить с помощью рекурсии.

Console.Clear();
int num = Prompt("Введите N ");
Console.Write(NaturalNum(num));

//---------------МЕТОДЫ---------------------------------
int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

string NaturalNum(int n)
{
    if (n == 1)

    {
        return "0";
    }
    else
    if (n % 2 == 0)
        return n + ", " + NaturalNum(n - 1);
    else
        return "" + NaturalNum(n - 1);

}