using System.IO;
using System.Collections.Generic;
using System.Text.Json;
namespace StudentLINQ;

class  Program
{
  static void Main(string[] args)
  {
    string json =File.ReadAllText("students.json");
    
    List<Student>? students =
      JsonSerializer.Deserialize<List<Student>>(json);
    
    Console.WriteLine($"불러온 학생 수: {students?.Count}");
  }
}