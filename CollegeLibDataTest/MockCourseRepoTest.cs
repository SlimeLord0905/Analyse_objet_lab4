using CollegeDataLib;

namespace CollegeLibDataTest;

public class MockCourseRepoTest
{
private readonly MockCourseRepo _mock;

    public MockCourseRepoTest()
    {
        _mock = new MockCourseRepo();
    }

    [Fact]
    public void SelectTest()
    {
        var actual = _mock.Select();
        Assert.Equal(4, actual.Count);
    }

    [Fact]
    public void SelectByIdTest()
    {
        var actual = _mock.Select(2);
        Assert.Equal("Alice", actual?.Name);

        actual = _mock.Select(3);
        Assert.Equal("Bob", actual?.Name);

        actual = _mock.Select(0);
        Assert.Equal("Catherine", actual?.Name);

        actual = _mock.Select(-1);
        Assert.Null(actual);
    }

    [Fact]
    public void InsertTest()
    {
        Assert.Equal(4, _mock.Count);
        
        Assert.Equal(1, _mock.Insert(new("0SW", "Catherine")));
        Assert.Equal(5, _mock.Count);
        
        Assert.Equal(1, _mock.Insert( new("0SW", "Catherine")));
        Assert.Equal(6, _mock.Count);
    }
    
    [Fact]
    public void UpdateTest()
    {
        Assert.Equal(4, _mock.Count);

        /*Assert.False(_mock.Update(new(0, "Zxc", DateOnly.Parse("1910-10-10"))));
        Assert.Equal(4, _mock.Count);
        
        Assert.True(_mock.Update(new(1, "Asd", DateOnly.Parse("1912-12-12"))));
        Assert.Equal(4, _mock.Count);
        var person = _mock.Select(1);
        Assert.Equal(1, person?.Id);
        Assert.Equal("Asd", person?.Name);
        Assert.Equal(DateOnly.Parse("1912-12-12"), person?.Dob);*/
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