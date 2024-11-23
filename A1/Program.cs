
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagementSystem
{
 class Program
 {
  static void Main(string[] args)
  {
   StudentManager studentManager = new StudentManager();
   studentManager.LoadData();

   bool exit = false;

   while (!exit)
   {
    Console.Clear();
    Console.WriteLine("Student Management System");
    Console.WriteLine("1. Add New Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Save Data");
    Console.WriteLine("4. Load Data");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
     case "1":
      studentManager.AddStudent();
      break;
     case "2":
      studentManager.ViewAllStudents();
      break;
     case "3":
      studentManager.SaveData();
      break;
     case "4":
      studentManager.LoadData();
      break;
     case "5":
      exit = true;
      break;
     default:
      Console.WriteLine("Invalid choice! Press any key to try again...");
      Console.ReadKey();
      break;
    }
   }
  }
 }

 public class Student
 {
  public string Name { get; set; }
  public int Age { get; set; }
  public string Course { get; set; }

  public Student(string name, int age, string course)
  {
   Name = name;
   Age = age;
   Course = course;
  }

  public override string ToString()
  {
   return $"{Name} | Age: {Age} | Course: {Course}";
  }
 }

 public class StudentManager
 {
  private List<Student> students = new List<Student>();
  private const string DataFile = "students.txt";

  public void AddStudent()
  {
   Console.Clear();
   Console.WriteLine("Add New Student");

   Console.Write("Enter student's name: ");
   string name = Console.ReadLine();

   Console.Write("Enter student's age: ");
   int age = Convert.ToInt32(Console.ReadLine());

   Console.Write("Enter student's course: ");
   string course = Console.ReadLine();

   Student newStudent = new Student(name, age, course);
   students.Add(newStudent);

   Console.WriteLine("Student added successfully! Press any key to continue...");
   Console.ReadKey();
  }

  public void ViewAllStudents()
  {
   Console.Clear();
   Console.WriteLine("View All Students");

   if (students.Count == 0)
   {
    Console.WriteLine("No students available. Press any key to go back...");
    Console.ReadKey();
    return;
   }

   foreach (var student in students)
   {
    Console.WriteLine(student);
   }

   Console.WriteLine("\nPress any key to go back...");
   Console.ReadKey();
  }

  public void SaveData()
  {
   try
   {
    using (StreamWriter writer = new StreamWriter(DataFile))
    {
     foreach (var student in students)
     {
      writer.WriteLine($"{student.Name},{student.Age},{student.Course}");
     }
    }
    Console.WriteLine("Data saved successfully! Press any key to continue...");
   }
   catch (Exception ex)
   {
    Console.WriteLine($"Error saving data: {ex.Message}");
   }
   Console.ReadKey();
  }

  public void LoadData()
  {
   try
   {
    if (File.Exists(DataFile))
    {
     using (StreamReader reader = new StreamReader(DataFile))
     {
      students.Clear();
      while (!reader.EndOfStream)
      {
       string line = reader.ReadLine();
       string[] data = line.Split(',');

       if (data.Length == 3)
       {
        string name = data[0];
        int age = int.Parse(data[1]);
        string course = data[2];

        students.Add(new Student(name, age, course));
       }
      }
     }
     Console.WriteLine("Data loaded successfully! Press any key to continue...");
    }
    else
    {
     Console.WriteLine("No data file found. Starting fresh. Press any key to continue...");
    }
   }
   catch (Exception ex)
   {
    Console.WriteLine($"Error loading data: {ex.Message}");
   }
   Console.ReadKey();
  }
 }
}
