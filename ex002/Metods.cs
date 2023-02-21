public class Metods
{
 
// 1. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}

//2. сумма цифр в числе

public static int SummInNumber (int number)
{
  int summ = 0;
  while (number > 0)
{
  summ = summ + (number % 10);
  number = number / 10;
}
  return summ;
}
}
