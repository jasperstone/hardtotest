namespace ConsoleApp;

public class BackupService
{
    public bool Backup()
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
        {
            Console.WriteLine("Backing up data...");
            return true;
        }
        return false;
    }
}
