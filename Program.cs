using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RockPaperScrissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create the service collection.
            var services = new ServiceCollection();

            // 2. Register (add and configure) the services.
            services.AddTransient<IHumanPlayer, Human>();
            services.AddTransient<IComputerPlayer, Computer>();
            services.AddTransient<GameManager>();

            // 3. Build the service provider from the service collection.
            var serviceProvider = services.BuildServiceProvider();


            // 4. Resolve the services that you need.
            var greetingService = serviceProvider.GetRequiredService<GameManager>();


            //GameManager game = new GameManager(new Human(),new Computer());



            // 5. Use the services
            while (true){
                Console.WriteLine(greetingService.Play().ToString());
                Console.WriteLine("Do you want to play more? Y or N");
                string input = Console.ReadLine().ToUpper();
                if (input == "N") {
                    break;
                }
            }
        }
    }
}
