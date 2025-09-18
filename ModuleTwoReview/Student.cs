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

}