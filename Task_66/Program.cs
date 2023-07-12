// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 

Console.Clear();
int num1 = Prompt("Введите M ");
int num2 = Prompt("Введите N ");

Console.Write($"Сумма всех натуральных чисел от М до N = {GetNum(num1, num2)} ");

//--------------MEТОДЫ---------------------
// ввод числа пользователем----------------
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
// c помошью реккурсии записываем наши числа в строке----------------

int GetNum(int n, int m)
{
    if (n == m)
    {
        return m;
    }
    else
        return n + GetNum(n + 1, m);
}
