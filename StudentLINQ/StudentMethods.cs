namespace StudentLINQ;

using System.Collections.Generic;

public class StudentMethods
{
    private List<Student> students;

    public StudentMethods(List<Student> students)
    {
        this.students = students;
    }


    public List<Student> GetTopStudents()
    {
        return students
            .Where(student => student.Grade > 80)
            .ToList();
    }

    public List<string> GetTopStudentsByGrade()
    {
        return students
            .OrderByDescending(student => student.Grade)
            .Select(student => $"{student.Name}-{student.Grade}")
            .ToList();
    }

    public List<string> GetStudentProgramList()
    {
        return students
            .Select(student => $"{student.Name}-{student.Program.Name}")
            .ToList();
    }
    
    public List<string> GetStudentCountByProgram()
    {
        return students
            .GroupBy(student => student.Program.Name)
            .Select(group => $"{group.Key} - {group.Count()} studenter")
            .ToList();
            
}

    public List<string> GetAverageGradeByProgram()
    {
        return students
            .GroupBy(student=>student.Program.Name)
            .Select(group => $"{group.Key} - snitt {group.Average(student => student.Grade)}")
            .ToList();
    }
    
    public bool AllNursesStudentsArePassing()
    {
        return students.Where(student => student.Program.Name == "Undersköterska")
            .All(student => student.Grade >= 50);
            
    }
    
    public Student GetOldestStudent()
    {
        return students.OrderBy(student => student.Birthdate)
            .First();
    }
    
    public List<Student> GetTop5Students()
    {
        return students
            .OrderByDescending(student => student.Grade)
            .Take(5)
            .ToList();
    }
    
    public List<string> GetCompletionPercentage()
    {
        return students
            .Select(student =>
                $"{student.Name} - {(double)student.Program.CurrentSemester / student.Program.TotalSemesters * 100}%")
            .ToList();
    }
    
    public List<string> GetProgramsWithHighAverage()
    {
        return students
            .GroupBy(student => student.Program.Name)
            .Where(group => group.Average(student => student.Grade) > 70)
            .Select(group => group.Key)
            .ToList();
    }