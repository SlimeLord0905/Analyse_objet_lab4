namespace CollegeLib;

public class CourseOffering :  IComparable<CourseOffering>
{
    public int Year { get; set; }
    public string Semester { get; set; }
    public Course Course { get; set; }
    public Teacher? Teacher { get; set; }

    public CourseOffering(int year, string semester, 
        Course course, Teacher? teacher = null)
    {
        Year = year;
        Semester = semester;
        Course = course;
        Teacher = teacher;
    }

    // public CourseOffering(int year, string semester, 
    //     Course course) : this(year, semester, course, null)
    // {
    //     Year = year;
    //     Semester = semester;
    //     Course = course;
    // }
    public int CompareTo(CourseOffering? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        int result = Year.CompareTo(other.Year);
        if (result == 0)
        {
            int result2 = Semester.CompareTo(other.Semester);
            if (result2 == 0)
            {
                int result3 = Course.CompareTo(other.Course);
                if (result3 == 0)
                {
                    return 0;
                }
                else if (result3 > 0)
                {
                    return 1;
                }
                else if (result3 < 0)
                {
                    return 0;
                }
            }
            else if (result2 > 0)
            {
                return 1;
            }
            else if (result2 < 0)
            {
                return 0;
            }
        }
        else if (result > 0)
        {
            return 1;
        }
        else if (result < 0)
        {
            return 0;
        }


        return 0;
    }
    
}