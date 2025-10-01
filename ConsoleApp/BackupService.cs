namespace ConsoleApp;

public class BackupService
{
    public bool Backup()
    {
        var dow = DateTime.Now.DayOfWeek;
        if (dow == DayOfWeek.Saturday)
        {
            Console.WriteLine("Backing up");
            return true;
        }
        return false;
    }
}
