namespace ConsoleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var service = new BackupService();
        var result = service.Backup();
        Assert.False(result);
    }
}