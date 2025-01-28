namespace Demo_Branch;

public class UnitTest1
{
    [Fact]
    public void UnitTestA()
    {
        Assert.False(!true);
        Assert.False(!false);
        Console.Out.WriteLine("Write some random stuff");
    }
}