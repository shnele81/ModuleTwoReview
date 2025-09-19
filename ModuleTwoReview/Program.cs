namespace ModuleTwoReview;

class Program
{
    static void Main(string[] args)
    {   
        List<Student> StudentsInformation = new List<Student>();
        
            var studentOne = new Student();
            studentOne.Name = "Brad";
            studentOne.ID = 1;
            studentOne.AddGrade(95.4, 89.4, 87.6);
            studentOne.CalculateAverageGrade();
            StudentsInformation.Add(studentOne);
            
            var studentTwo = new Student();
            studentTwo.Name = "Stacy";
            studentTwo.ID = 2;
            studentTwo.AddGrade(93.4, 89.4, 95.1);
            studentTwo.CalculateAverageGrade();
            StudentsInformation.Add(studentTwo);
            
            var studentThree = new Student();
            studentThree.Name = "Frank";
            studentThree.ID = 3;
            studentThree.AddGrade(72.7, 67.1, 90.5);
            studentThree.CalculateAverageGrade();
            StudentsInformation.Add(studentThree);
            
            var studentFour = new Student();
            studentFour.Name = "Beth";
            studentFour.ID = 4;
            studentFour.AddGrade(88.8, 89.1, 99.4);
            studentFour.CalculateAverageGrade();
            StudentsInformation.Add(studentFour);
        
        //created 4 instances of students and gave them names and ID numbers. Commit work spot.
        void ListStudents()
        {
            foreach (Student student in StudentsInformation)
            {
                Console.WriteLine($"Student Name: {student.Name}, ID: {student.ID}, Student Grades: {student.Grades}, Student GPA: {student.CalculateAverageGrade()}");
            }
        }
        ListStudents();
        
    }
}