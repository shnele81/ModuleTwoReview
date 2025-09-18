namespace ModuleTwoReview;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; } =  new List<double>(); //created the 3 parameters

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
        if (Grades.Count == null) //if statement accounts for no grades = 0
        {
            return 0;
        }
        else
        {
            return Grades.Average(); //else statement returns the average when grades are given
        }
     // second git commit and push completed
        
        
    }
}