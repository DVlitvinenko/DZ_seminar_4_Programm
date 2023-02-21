//Задача 27: Напишите метод, который принимает 
//на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
using static Metods;
public class ex002
{
  public static void ex002_Summ()
  {
    //получаем число
    int number = Input("Введите число: ");
    // Находим сумму цифр в числе
    Console.Write(SummInNumber(number));
  }
}
