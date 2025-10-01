namespace ConsoleApp;

public class BackupServiceBetter
{
    private readonly IDTWrapper _dTWrapper;

    public BackupServiceBetter(IDTWrapper dTWrapper)
    {
        _dTWrapper = dTWrapper;
    }

    public bool Backup()
    {
        var dow = _dTWrapper.Now().DayOfWeek;
        if (dow == DayOfWeek.Saturday)
        {
            Console.WriteLine("Backing up");
            return true;
        }
        return false;
    }
}
