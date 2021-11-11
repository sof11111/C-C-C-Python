using System;
using System.IO;

namespace practic1 //недоделана
{
  class Program
  {
    static void Main(string[] args)
    {
      
      string path = @"C:\SomeDir2";
      DirectoryInfo dirInfo = new DirectoryInfo(path);
      if (!dirInfo.Exists)
      {
        dirInfo.Create();
      }
      Console.WriteLine("Введите строку для записи в файл:");
      string text = Console.ReadLine();

      
      using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
      {
        
        byte[] array = System.Text.Encoding.Default.GetBytes(text);
        
        fstream.Write(array, 0, array.Length);
        Console.WriteLine("Текст записан в файл");
      }

      
      using (FileStream fstream = File.OpenRead($"{path}\\note.txt"))
      {
        
        byte[] array = new byte[fstream.Length];
        
        fstream.Read(array, 0, array.Length);
        
        string textFromFile = System.Text.Encoding.Default.GetString(array);
        Console.WriteLine($"Текст из файла: {textFromFile}");
      }

      
      FileInfo fileInf = new FileInfo(path);
      if (fileInf.Exists)
      {
        fileInf.Delete();
      }

      Console.ReadLine();
    }
  } 
}
