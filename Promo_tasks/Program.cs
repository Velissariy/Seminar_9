// Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Menu();

void Menu() //Меню выбора задачи.
{
    Console.Clear();
    Console.WriteLine("Меню выбора задачи.");
    Console.WriteLine("Введите цифру для выбора задачи:");
    Console.WriteLine("1 - Программа для вывода всех натуральных чисел в промежутке от M до N.");
    Console.WriteLine("2 - Программа для принятия на вход числа и возвращения суммы его цифр.");
    Console.WriteLine("3 - Программа для принятия на вход два числа A и B, и возводения числа А в целую степень B с помощью рекурсии.");

    int result = PutNumber("Введите номер задачи");

      switch (result)
      {
        case 1:
          Console.Clear();
          Task_65();
          break;

        case 2:
          Console.Clear();
          Task_67();
          break;

        case 3:
          Console.Clear();
          Task_69();
          break;

        default:
          Console.Clear();
          Console.WriteLine("Номер задачи введен некорректно. Повторите попытку.");
          Console.ReadLine();
          break;
    }
  }

int PutNumber(string message)
{
  System.Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

string ReturnNumber(int M, int N)
{
  if (M == N) return N + "";
  else
      return M +" " + ReturnNumber(M + 1, N);
}

int SumNumber(int number)
{
  if (number == 0) return 0;
  else
  return number % 10 + SumNumber(number/10);
}

int PowNumber(int a,int b)
{
  if( b==1)return a;
  else if(b==0) return 1;
  return a*PowNumber(a, b-1);
}

void Task_65()
{
  System.Console.WriteLine(ReturnNumber(PutNumber("Введите M: "),PutNumber("Введите N: ")));
}

void Task_67()
{
  System.Console.WriteLine(SumNumber(PutNumber("Введите число: ")));

}

void Task_69()
{
  int powNum = PowNumber(PutNumber("Введите основание."),PutNumber("Введите степень."));
  Console.WriteLine(powNum);
  Console.ReadLine();

}