namespace Hello_worldTooling.Tests;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {   var result=Hello.Sayhello();
       Assert.Equal("Hello, World!", result);
    }
}
