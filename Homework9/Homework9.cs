namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(111,"Alice");
        Student Bob = new Student(222,"Bob");
        Student Cathy = new Student(333,"Cathy");
        Student David  = new Student(444,"David");

        Console.WriteLine("The student list contains the following students:");
        foreach (Student student in Student.StudentList)
        {
            Console.WriteLine(student.StudentName);
        }

        Student.Gradebook.Add("Alice",4.0);
        Student.Gradebook.Add("Bob",3.6);
        Student.Gradebook.Add("Cathy",2.5);
        Student.Gradebook.Add("David",1.8);

        if (Student.Gradebook.ContainsKey("Tom")) 
        {
            // do nothing
        }
        else
        {
            Student.Gradebook.Add("Tom",3.3);
        }
        Console.WriteLine("The gradebook contains the following students:");
        foreach (var student_name in Student.Gradebook.Keys) 
        {
            Console.WriteLine(student_name);
        }
            

        double averageGrade = 0;
        foreach (Student student in Student.StudentList)
        {
            if (Student.Gradebook.ContainsKey(student.StudentName))
            {
                averageGrade+=Student.Gradebook[student.StudentName];
            }
        }
        averageGrade = averageGrade/Student.Gradebook.Count();
        Console.WriteLine($"The average grade is: {averageGrade}");
        
        foreach (Student student in Student.StudentList)
        {
            if (Student.Gradebook[student.StudentName]>averageGrade)
            {
                student.PrintStudentInfo();
            }
        }

    }

    
}

public class Student
{
    private int studentId;
    private string studentName;

    public static List<Student> StudentList = new List<Student>();
    public static Dictionary <string,double> Gradebook = new Dictionary<string,double>();
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student Id: {this.StudentId}, Student Name: {this.StudentName}");
        
    }

    public int StudentId
    {
        get; set;
    }

    public string StudentName
    {
        get; set;
    }
 public Student (int student_id, string student_name)
    {
            StudentId = student_id;
            StudentName = student_name;
            StudentList.Add(this);
     }

}
