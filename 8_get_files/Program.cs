using System;
using System.IO;

namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
            Count();
        }

        static void GetCatalogs()
        {
            
            string dirName = @"/";  //Прописываем путь к корневой директории
            if (Directory.Exists(dirName))  //Проверим что директория существует
            {
                Console.WriteLine("Папки: ");
                string[] dirs = Directory.GetDirectories(dirName);  //Получим все директоррии корневого каталога

                foreach(string d in dirs)
                {
                    Console.WriteLine(d);
                   
                }

                

                Console.WriteLine();
                Console.WriteLine("Файлы: ");
                string[] files = Directory.GetFiles(dirName);   //Получим все файлы коневого каталога

                foreach(string s in files)  //Выведем их все
                    Console.WriteLine(s);
                
            }
        }
        static void Count()
        {
        
      
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/");
                if (dirInfo.Exists)
                {
                    Console.WriteLine($"Кол-во папок и файлов: {dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length}");
                }
                //Создание новой директории
                DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();
                Console.WriteLine("Новая директори создана");
                //Удаление директории
                DirectoryInfo delInfo = new DirectoryInfo(@"/newDirectory");
                delInfo.Delete(true);
                Console.WriteLine("Директори удалена");
                //Новый подсчет файлов и папок
                Console.WriteLine($"Кол-во папок и файлов: {dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}