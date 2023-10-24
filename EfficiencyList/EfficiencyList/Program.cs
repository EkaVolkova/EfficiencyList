using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

/// <summary>
/// Программа осуществляет сравнение производительности вставки в List и LinkedList с использованием StopWatch на примере текста.
/// Для List
/// </summary>
namespace EfficiencyList
{
    class Program
    {
        static void Main(string[] args)
        {
            //создадим список
            var list = new List<string>();

            // Создаем объект класса FileInfo.
            var path = "Text.txt";
            var fileInfo = new FileInfo(path); 

            //Запускаем подсчет времени
            var watchTwo = Stopwatch.StartNew();
            
            //Открываем файл на чтение
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = string.Empty;
                // Пока не кончатся строки - считываем из файла по одной в список
                while ((str = sr.ReadLine()) != null)
                {
                    list.Add(str);
                }

            }
            Console.WriteLine("Время работы связного списка: " + watchTwo.Elapsed.TotalMilliseconds + " мс");
        }
    }
}
