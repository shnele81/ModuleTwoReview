namespace ModuleTwoReview;

public class Student
{
    public string Name { get; set; } = "";
    public int ID { get; set; } = 0;
    public List<double> Grades { get; set; }  = [];//created the 3 parameters

    public void AddGrade(double grade) //created the first method
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double [] grades) //created the second method
    {
        Grades.AddRange(grades);
    }
    // first git commit and push completed

    public double CalculateAverageGrade() //created a double type method with no parameters
    {
        if (Grades.Count == 0) //if statement accounts for no grades = 0
        {
            return 0;
        }
        double total = Grades.Any() ? Grades.Average() : 0;
        return total;
        //{
            //return Grades.Average(); //else statement returns the average when grades are given
        //}
     // second git commit and push completed
        
        
    }
}