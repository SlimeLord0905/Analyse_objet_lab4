using CollegeDataLib;

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
    
    

}