using CollegeLib;
using static System.DateTime;

namespace CollegeDataLib;

public class MockCourseOfferingRepo: IDataRepo<CourseOffering, int>
{
    private readonly List<CourseOffering> _courseOfferings;
    public int Count => _courseOfferings.Count;

    public MockCourseOfferingRepo()
    {
        _courseOfferings = new List<CourseOffering>()
        {
            new(2022,"aut2022", new Course("0SW", "dev mobile") , new Teacher(1, "Catherine", DateOnly.FromDateTime(new DateTime(2022, 10, 10)), 1,"info",true, "teacher")),
            new(2022,"aut2022", new Course("0Q7", "Analyse objet") , new Teacher(1, "Catherine", DateOnly.FromDateTime(new DateTime(2022, 10, 10)), 1,"info",true, "teacher")),
            new(2022,"aut2022", new Course("WS2", "web server 2") , new Teacher(1, "Catherine", DateOnly.FromDateTime(new DateTime(2022, 10, 10)), 1,"info",true, "teacher")),
            new(2022,"aut2022", new Course("0SW", "dev sujet spéciaux") , new Teacher(1, "Catherine", DateOnly.FromDateTime(new DateTime(2022, 10, 10)), 1,"info",true, "teacher")),
        };
    }

    public List<CourseOffering> Select()
    {
        return _courseOfferings;
    }

    public CourseOffering? Select(int id)
    {
        return _courseOfferings[id];
    }

    public int Insert(CourseOffering data)
    {
        _courseOfferings.Add(data);
        return 1;
    }

    public bool Update(CourseOffering data)
    {
        for (int i = 0; i < _courseOfferings.Count; i++)
        {
            if (_courseOfferings[i].Equals(data))
            {
                _courseOfferings[i] = data;
                return true;
            }
        }

        return false;
    }

    public bool Delete(CourseOffering data)
    {
        for (int i = 0; i < _courseOfferings.Count; i++)
        {
            if (_courseOfferings[i].Equals(data))
            {
                return Delete(_courseOfferings[i]);
            }
        }
        return false;
    }

    public bool Delete(int key)
    {
        return Delete(_courseOfferings[key]);
    }
}