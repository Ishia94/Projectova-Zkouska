namespace Projectova_Zkouska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            Database database = new Database();

            Console.WriteLine("********************");
            Console.WriteLine("insurance users.");
            Console.WriteLine("********************");

            Console.WriteLine("Options: ");
            Console.WriteLine("1- Add user");
            Console.WriteLine("2- find user");
            Console.WriteLine("3- Show all Data");
            Console.WriteLine("4- Exit");

            char choice = '0';
                
            while (choice != '4')
            {
                switch (choice)
                {
                    case '1':
                        database.AddUser();
                        Console.WriteLine("Welcome.");
                        Console.WriteLine("Press Spacebar for continue.");
                        database.Menu();
                        break;
                    case '2':
                        database.FindUser();
                        Console.WriteLine("Press Spacebar for continue.");
                        database.Menu();
                        break;
                    case '3':
                        database.ShowUsers();
                        Console.WriteLine("Press Spacebar for continue.");
                        database.Menu();
                        break;
                    case '4':
                        Console.WriteLine("GoodBye");
                        break;
                    default:
                        Console.WriteLine("Error Please press 1-4");
                        break;

                }
                choice = Console.ReadKey().KeyChar;
            }
        }
    }
}