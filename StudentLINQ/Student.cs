namespace StudentLINQ;
using System;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Gender { get; set; } = "";
    public DateTime Birthdate { get; set; }
    public int Grade { get; set; }
    public ProgramInfo Program { get; set; } = new();
}