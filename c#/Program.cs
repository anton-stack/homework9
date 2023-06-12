// Задача 1 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке огт N до 1.

// N = 5 -> "1, 2, 3, 4, 5"

// void ShowNumbers(int n)
// {
//     if (n > 0) 
//     {
//         System.Console.Write(n + " ");
//         ShowNumbers(n-1);
        
//     }
// }

// ShowNumbers(5);

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число M:");
// int numberN = int.Parse(Console.ReadLine());

// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }

// GapNumberSum(numberM, numberN, 0);

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}