// Задача 25: Напишите метод, который принимает на вход
//  два числа (A и B) и возводит число A в натуральную 
//  степень B.
// Math.Pow использовать нельзя
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static Metods;
public class Ex001
{
  public static void ex001_aToB()
  {
  //получаем числа
  int number1 = Input("Введите число A: ");
  int number2 = Input("Введите число B: ");
  //возводим number1 в степень number2
  //выводим в консоль
  Console.WriteLine($"{number1}, {number2} -> {AupToB(number1, number2)}");
  }
}