using System.Linq.Expressions;

public class Events
{    
    
    protected List<Events> events;

    public int id { get; set; }
    public string name { get; set; }
    public DateOnly date { get; set; }
    public float value { get; set; }
    public int maxCapacity { get; set; }
    public int soldTickets { get; set; }

    public Events(ref List<Events> _events)    
    {
        
        Events events = new Events(ref _events);

        Console.Clear();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Events Menu");
        Console.WriteLine("---------------------------------------");
        
        int iterator;
        
        this.events = _events;        

        do
        {
            Console.WriteLine("Please selction an navegation option:");
            Console.WriteLine("1. Create an Event");
            Console.WriteLine("2. See Events");
            Console.WriteLine("3. Delete an Event");
            Console.WriteLine("0. Exist");            

            iterator = Console.Read();

            switch (iterator)
            {
                case 0:

                    Console.WriteLine("Bye");
                    break;
                
                case 1:

                    this.createEvent();
                    _events.Add(this);

                    break;

                case 2:

                    Console.WriteLine("Tickets");
                    break;

                case 3:

                    Console.WriteLine("Tickets");
                    break;


                default:

                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }

        } while(iterator != 0);
    }

    public void createEvent()
    {
        Console.Clear();
        Console.WriteLine("Please, type the event name:");
        name = Console.ReadLine();
        
        Console.WriteLine("Please, type the event date:");
        date = DateOnly.Parse(Console.ReadLine());
        
        Console.WriteLine("Please, type the event value:");
        value = float.Parse(Console.ReadLine());
    
        Console.WriteLine("Please, type the event max capacity:");
        maxCapacity = int.Parse(Console.ReadLine());        
        id = events.Count() + 1;
    }
}