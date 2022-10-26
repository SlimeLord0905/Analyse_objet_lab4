using CollegeLib;

namespace CollegeDataLib;

public class MockCourseRepo : IDataRepo<Course, int>
{
    private readonly List<Course> _courses;
    public int Count => _courses.Count;

    public MockCourseRepo()
    {
        _courses = new List<Course>()
        {
            new("0SW", "Catherine"),
            new("0SU", "Denis"),
            new("WS3", "Alice"),
            new("0Q7", "Bob")
        };
    }

    public List<Course> Select()
    {
        return _courses;
    }

    public Course? Select(int id)
    {
        return _courses[id];
    }

    public int Insert(Course data)
    {
        _courses.Add(data);
        return 1;
    }

    public bool Update(Course data)
    {
        for (int i = 0; i < _courses.Count; i++)
        {
            if (_courses[i].Equals(data))
            {
                _courses[i] = data;
                return true;
            }
        }

        return false;
    }

    public bool Delete(Course data)
    {
        for (int i = 0; i < _courses.Count; i++)
        {
            if (_courses[i].Equals(data))
            {
                return Delete(_courses[i]);
            }
        }
        return false;
    }

    public bool Delete(int key)
    {
        _courses.RemoveAt(key);
        return false;
    }
}