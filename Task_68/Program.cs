// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрица-тельных числа m и n. 


Console.Clear();
int num1 = Prompt("Введите m ");
int num2 = Prompt("Введите n ");

Console.Write($"A({num1},{num2}) = {Akerman(num1, num2)} ");

//--------------MEТОДЫ---------------------
// ввод числа пользователем----------------
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
// функция Аккермана

int Akerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akerman(n - 1, 1);
    else
      return Akerman(n - 1, Akerman(n, m - 1));
}