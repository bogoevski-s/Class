namespace Cas_4.Classes
{
    public class Student
    {
        //first is access modifier than the type of the property and last is name
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Grade> Grades { get; set; }
        public Car Car { get; set; }


        // method of the Student class
        public double CalculateGrades()
        {
            int average = 0;

            foreach (var grade in Grades)
            {
                average += grade.ClassGrade;
            }

            return average/Grades.Count;
        }
    }
}
