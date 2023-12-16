using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TitkovAA.Sprint5.Review.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSavedFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(pathSavedFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSavedFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                

                line = reader.ReadLine();
                


                    strLine += line.Replace("н", "нн");




                    File.AppendAllText(pathSavedFile, strLine );
                    strLine = "";
                 
            }
            return pathSavedFile;
        }
        }
    }
