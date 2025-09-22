namespace ModuleTwoReview;

class Program
{
    static void Main(string[] args)
    {   
        //list of students
        List<Student> students = new List<Student>();
        
        //creating 4 student objects and adding grades to grades list
        var studentOne = new Student();
        studentOne.Name = "Brad";
        studentOne.ID = 1;
        studentOne.Grades = [72.1, 83.5, 56.1];
            
        studentOne.AddGrade(95.4, 89.4, 87.6);
            
        var studentTwo = new Student();
        studentTwo.Name = "Stacy";
        studentTwo.ID = 2;
        studentTwo.Grades = [74.4, 98.1, 45.1];
            
        studentTwo.AddGrade(93.4, 89.4, 95.1);
            
        var studentThree = new Student();
        studentThree.Name = "Frank";
        studentThree.ID = 3;
        studentThree.Grades = [90.4, 90.1, 89.9];
        
        studentThree.AddGrade(72.7, 67.1, 90.5);
            
        var studentFour = new Student();
        studentFour.Name = "Beth";
        studentFour.ID = 4;
        studentFour.Grades = [97.1, 99.9, 45.7];
            
        studentFour.AddGrade(88.8, 89.1, 99.4);
        
        //adding students to student list
        students.AddRange(studentOne, studentTwo, studentThree, studentFour);
        
        //nested foreach loops it iterate through students and print student info, then iterate
        //through students grades to print all grades, then average each students grades and print
        foreach (Student item in students)
        {
            Console.WriteLine($"Student Name: {item.Name}, ID: {item.ID}, Student Grades:");
                
            foreach (double grade in item.Grades)
            {
                Console.WriteLine($"{grade:F2}");
            }
            Console.WriteLine("Average:");
            Console.WriteLine(Math.Round(item.CalculateAverageGrade(), 2));  
        }
    }
}