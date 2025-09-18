namespace ModuleTwoReview;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        foreach (var studentOne in students)
        {
            studentOne.Name = "Brad";
            studentOne.ID = 1;
        }

        foreach (var studentTwo in students)
        {
            studentTwo.Name = "Stacy";
            studentTwo.ID = 2;
        }

        foreach (var studentThree in students)
        {
            studentThree.Name = "Frank";
            studentThree.ID = 3;
        }

        foreach (var studentFour in students)
        {
            studentFour.Name = "Beth";
            studentFour.ID = 4;
        }
        //created 4 instances of students and gave them names and ID numbers. Commit work spot.

    }
}