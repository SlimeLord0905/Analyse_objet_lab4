using CollegeDataLib;
using CollegeLib;

namespace CollegeLibDataTest;

public class MockCourseOfferingRepoTest
{
    private readonly MockCourseOfferingRepo _mock;

    public MockCourseOfferingRepoTest()
    {
        _mock = new MockCourseOfferingRepo();
    }
    
    [Fact]
    public void SelectTest()
    {
        var actual = _mock.Select();
        Assert.Equal(4, actual.Count);
    }
    public void SelectByIdTest()
    {
        var actual = _mock.Select(2);
        Assert.Equal(2022, actual?.Year);

        actual = _mock.Select(3);
        Assert.Equal(2022, actual?.Year);

        actual = _mock.Select(0);
        Assert.Equal(2022, actual?.Year);

        actual = _mock.Select(-1);
        Assert.Null(actual);
    }
    public void InsertTest()
    {
        Assert.Equal(4, _mock.Count);
        
        Assert.Equal(1, _mock.Insert( new(2022,"aut2022", new Course("0SW", "dev mobile") , new Teacher(1, "Catherine", DateOnly.FromDateTime(new DateTime(2022, 10, 10)), 1,"info",true, "teacher"))));
        Assert.Equal(5, _mock.Count);
        
    }
    
    
    
    
    
    
    
    
    
    
    
    [Fact]
    public void DeleteTest()
    {
        MockCourseRepo mock = new  MockCourseRepo();
        Assert.Equal(4, mock.Count);

        Assert.False(mock.Delete(0));
        Assert.Equal(3, mock.Count);
    }
}