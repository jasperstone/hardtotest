namespace ConsoleApp;

public interface IDTWrapper
{
    DateTime Now();
}

public class DateTimeWrapper : IDTWrapper
{
    public DateTime Now()
    {
        return DateTime.Now;
    }
}