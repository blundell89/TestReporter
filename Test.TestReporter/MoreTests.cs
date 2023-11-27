namespace Test.TestReporter;

[Trait("Category", "MoreTests")]
public class MorePassingTests
{
    [Fact]
    public void Passes()
    {
        Assert.True(true);
    }
}

[Trait("Category", "MoreTests")]
public class MoreFailingTests
{
    [Fact]
    public void Fails()
    {
        Assert.True(false);
    }
}