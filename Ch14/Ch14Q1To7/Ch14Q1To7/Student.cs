// Define a class Student, which contains the following information about 
// students: full name, course, subject, university, e-mail and phone 
// number.
// Declare several constructors for the class Student, which have different 
// lists of parameters (for complete information about a student or part of 
// it). Data, which has no initial value to be initialized with null. Use 
// nullable types for all non-mandatory data.
// Add a static field for the class Student, which holds the number of 
// created objects of this class.
// Add a method in the class Student, which displays complete information 
// about the student.
// Modify the current source code of Student class so as to encapsulate 
// the data in the class using properties.
// Write a class StudentTest, which has to test the functionality of the 
// class Student.
// Add a static method in class StudentTest, which creates several 
// objects of type Student and store them in static fields. Create a static 
// property of the class to access them. Write a test program, which 
// displays the information about them in the console.


using System.Text.RegularExpressions;
public class Student
{
    private static uint _noOfStudents = 0;
    private string _name = string.Empty;
    private string? _course = null;
    private string? _subject = null;
    private string? _university = null;
    private string? _email = null;
    private uint? _phoneNo = null;

    public static uint NoOfStudents
    {
        get => _noOfStudents;
    }

    public string Name
    {
        get => _name;
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException("Invalid argument. Argument cannot be null empty or whitespace");
            }
        }
    }

    public string? Course {get => _course; set => _course = value;}

    public string? Subject {get => _subject; set => _subject = value;}

    public string? University {get => _university; set => _university = value;}

    // Validate with regex
    // username@domain.com
    public string? Email
    {
        get => _email;
        set
        {
            string pattern = @"([\w\.\-]+)@([\w\.\-]+)\.([\w]+)";
            if(string.IsNullOrWhiteSpace(value))
            {
                _email = null;
            }
            else if(Regex.IsMatch(value, pattern))
            {
                _email = value;
            }
            else
            {
                throw new ArgumentException("Invalid email id");
            }
        }
    }

    public uint? PhoneNo
    {
        get => _phoneNo;
        set
        {
            if(value == null || value >= 10_0000_0000 && value <= 99_9999_9999)
            {
                _phoneNo = value;
            }
            else
            {
                throw new ArgumentException($"{value} is not a valid phone no.");
            }
        }
    }

    public Student(string name, string? course, string? subject, string? university, string? email, uint? phoneNo)
    {
        Name = name;
        Course = course;
        Subject = subject;
        University = university;
        Email = email;
        PhoneNo = phoneNo;
        _noOfStudents += 1;
    }

    public Student(string name, string? course, string? subject, string? university, string? email)
        : this(name, course, subject, university, email, null)
    {
    }

    public Student(string name, string? course, string? subject, string? university)
        : this(name, course, subject, university, null)
    {
    }

    public Student(string name, string? course, string? subject)
        : this(name, course, subject, null)
    {
    }

    public Student(string name, string? course) : this(name, course, null)
    {
    }

    public Student(string name) : this(name, null)
    {
    }

    public override string ToString()
    {
        // Print student info

        const int PAD = 15;

        string s = "Name:".PadRight(PAD) + Name + "\n" +
            "Course:".PadRight(PAD) + Course + "\n" +
            "Subject:".PadRight(PAD) + Subject + "\n" +
            "University:".PadRight(PAD) + University + "\n" +
            "Email:".PadRight(PAD) + Email + "\n" +
            "Phone:".PadRight(PAD) + PhoneNo + "\n";

        return s;
    }
}