using System.Linq.Expressions;

namespace Ticketio;

public class Menu
{
    List<Events> events;

    public Menu()
    {        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Welcome to TIcketio");
        Console.WriteLine("Your personal system to manage events");
        Console.WriteLine("---------------------------------------");

        this.events = new List<Events>();
        this.navegator();
    }

    public void navegator()
    {
        int iterator;
        
        do
        {
            Console.WriteLine("Please selction an navegation option:");
            Console.WriteLine("1. Events");
            Console.WriteLine("2. Tickets");
            Console.WriteLine("0. Exit");

            iterator = int.Parse(Console.ReadLine());

            switch (iterator)
            {
                case 0:

                    Console.WriteLine("Bye");
                    break;
                
                case 1:
                                        
                    Events events = new Events(ref this.events);

                    break;

                case 2:

                    Console.WriteLine("Tickets");
                    break;

                default:

                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        } while(iterator != 0);
    }
}
