
public class Metods
{
  

// 1. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}

  //2. возведение number1 в степень number2
public static int AupToB(int a, int b)
{
  int result = a;
  for (int i = 2; i <= b; i++)
  {
    result = result * a;
  }
  return result;
}

}

 
