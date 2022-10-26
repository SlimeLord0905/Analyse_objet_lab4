using CollegeLib;

namespace CollegeDataLib;

public enum SortOrder
{
    Asc,
    Desc
}

public static class Sorting
{
    public static void SortPersonByName(List<Person> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));    
        }
        else
        {
            data.Sort((x, y) => String.Compare(y.Name, x.Name, StringComparison.Ordinal));
        }
    }
    public static void SortPersonById(List<Person> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => x.CompareTo(y));    
        }
        else
        {
            data.Sort((x, y) => y.CompareTo(x));
        }
    }
    public static void SortCourseByCode(List<Course> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => String.Compare(x.Code, y.Code, StringComparison.Ordinal));    
        }
        else
        {
            data.Sort((x, y) => String.Compare(y.Code, x.Code, StringComparison.Ordinal));
        }
    }
    public static void SortCourseByName(List<Course> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));    
        }
        else
        {
            data.Sort((x, y) => String.Compare(y.Name, x.Name, StringComparison.Ordinal));
        }
    }
    public static void SortCourseOffering(List<Course> data, SortOrder sortOrder = SortOrder.Asc)
    {
        if (sortOrder == SortOrder.Asc)
        {
            data.Sort((x, y) => x.CompareTo(y));    
        }
        else
        {
            data.Sort((x, y) => y.CompareTo(x));
        }
    }
}