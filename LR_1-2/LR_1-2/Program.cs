using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть назву першого вхiдного файлу: ");
        string inputFile1 = Console.ReadLine();

        Console.Write("Введiть назву другого вхiдного файлу: ");
        string inputFile2 = Console.ReadLine();

        Console.Write("Введiть назву вихiдного файлу: ");
        string outputFile = Console.ReadLine();

        try
        {
            // Відкриваємо файли для читання і запису
            using (StreamReader reader1 = new StreamReader(inputFile1))
            using (StreamReader reader2 = new StreamReader(inputFile2))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                // Копіюємо вміст першого файлу в вихідний файл
                string line;
                while ((line = reader1.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }

                // Копіюємо вміст другого файлу в вихідний файл
                while ((line = reader2.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Файли успiшно об’єднано!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
