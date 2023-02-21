// Задача 29: Напишите метод, который задаёт 
// массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
using static Metods;
public class ex003
{
  public static void ex003_Array()
  {
    // создаем массив
    int []array = CreateArray(Input("Введите размер массива: "));
    WriteArray(array); 
    Console.Write();
    // заполняем массив рандомно
    FillArray (array);
    // выводим массив на экран
    WriteArray(array); 
  }
}
