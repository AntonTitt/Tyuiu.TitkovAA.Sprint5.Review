using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TitkovAA.Sprint5.Review.V18.Lib;

namespace Tyuiu.TitkovAA.Sprint5.Review.V18
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #5 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask7V17.txt (файл взять из архива *");
            Console.WriteLine(@"* согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Заменить *");
            Console.WriteLine("* все буквы \"н\" на \"нн\".Полученный результат сохранить в файл         *");
            Console.WriteLine("* OutPutDataFileTask7V18.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";

            Console.WriteLine("В файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("В файле: " + path);
            Console.WriteLine(dt.LoadDataAndSave(path));

        }
    }
}
