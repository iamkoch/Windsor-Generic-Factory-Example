namespace Iamkoch.Samples.WindsorCommandExecutor.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commandIssuer = new CommandIssuer();

            commandIssuer.Start();

            System.Console.WriteLine("Press any key to quit");
            System.Console.ReadKey();
        }
    }
}
