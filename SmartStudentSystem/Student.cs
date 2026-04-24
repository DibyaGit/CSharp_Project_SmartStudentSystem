using System;

namespace SmartStudentSystem
{
    // This is a Custom Attribute. 
    // We use "string.Empty" to fix the "Non-nullable" error.
    public class StudentInfoAttribute : Attribute
    {
        public string Description { get; set; } = string.Empty;
    }

    [StudentInfo(Description = "Used to store student record details")]
    public class Student
    {
        public int Id { get; set; }
        // Adding "= string.Empty" fixes the non-nullable warning
        public string Name { get; set; } = string.Empty;
        public int Marks { get; set; }

        public Student(int id, string name, int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Marks: {Marks}";
        }
    }
}