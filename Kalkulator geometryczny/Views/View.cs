namespace KalkulatorGeometryczny.Views
{
    public class View
    {
        public void ShowResult(string result)
        {
            Console.WriteLine(result);
        }

        public void ShowMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate rectangle area");
            Console.WriteLine("2. Calculate circle area");
            Console.WriteLine("3. Exit");
        }
    }
}