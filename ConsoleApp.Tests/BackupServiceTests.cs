namespace ConsoleApp.Tests;

public class BackupServiceTests
{
    [Fact]
    public void Test1()
    {
        var service = new BackupService();
        var result = service.Backup();
        Assert.False(result);
    }
}