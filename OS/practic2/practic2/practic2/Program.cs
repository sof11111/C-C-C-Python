using System;
using System.Text.Json;

namespace HelloApp
{
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Person tom = new Person { Name = "Tom", Age = 35 };
      string json = JsonSerializer.Serialize<Person>(tom);
      Console.WriteLine(json);
      Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
      Console.WriteLine(restoredPerson.Name);
    }
  }
}