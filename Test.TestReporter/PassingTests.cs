namespace Test.TestReporter;

[Trait("Category", "Tests")]
public class PassingTests
{
    [Fact]
    public void Passes()
    {
        Assert.True(true);
    }
}

[Trait("Category", "Tests")]
public class FailingTests
{
    [Fact]
    public void Passes()
    {
        Assert.True(false);
    }
}