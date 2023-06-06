// Przykładowa aplikacja konsolowa
using WzorceProjektowe;

class Program
{
    
    static void Main(string[] args)
    {
        
        // Tworzenie fabryki i produktów
        IAbstractFactory factory = new ConcreteFactory();
        IProductA productA = factory.CreateProductA();
        IProductB productB = factory.CreateProductB();

        productA.OperationA();
        productB.OperationB();

        // Wykorzystanie wzorca Command
        Receiver receiver = new Receiver();
        ICommand command = new ConcreteCommand(receiver);
        command.Execute();

        

        // Wykorzystanie wzorca Decorator
        IComponent component = new ConcreteComponent();
        IComponent decoratedComponent = new Decorator(component);
        decoratedComponent.Operation();
        System.Console.WriteLine("");
        System.Console.WriteLine(" Naciśnij ENTER aby wczytać szczegółowy opis projektu");
        Console.ReadLine();
        System.Console.WriteLine("Wczytuje opis...");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Yellow;

     

        System.Console.WriteLine("");
        System.Console.WriteLine("Oto bardziej szczegółowe omówienie projektu:");
        System.Console.WriteLine("");
        System.Console.WriteLine("1.Wzorzec Abstract Factory:");
        System.Console.WriteLine("      -Tworzymy interfejsy `IProductA` i `IProductB` dla produktów, które chcemy utworzyć.");
        System.Console.WriteLine("      -Tworzymy interfejs `IAbstractFactory`, który deklaruje metody do tworzenia tych produktów.");
        System.Console.WriteLine("      -Implementujemy konkretne klasy `Special_ProductA` i `Special_ProductB`, ");
        System.Console.WriteLine("       które implementują interfejsy `IProductA` i `IProductB` odpowiednio.");
        System.Console.WriteLine("      -Tworzymy klasę `ConcreteFactory`, ");
        System.Console.WriteLine("       która implementuje interfejs `IAbstractFactory` i dostarcza konkretne implementacje metod do tworzenia produktów.");
        System.Console.WriteLine("      -W głównej funkcji `Main` tworzymy fabrykę `ConcreteFactory`, ");
        System.Console.WriteLine("       a następnie za jej pomocą tworzymy produkty `productA` i `productB`. Wywołujemy na nich odpowiednie operacje.");
        System.Console.WriteLine("");
        System.Console.WriteLine("2.Wzorzec Command:");
        System.Console.WriteLine("      -Tworzymy interfejs `ICommand`, który definiuje metodę `Execute()`.");
        System.Console.WriteLine("      -Implementujemy klasę `ConcreteCommand`, która implementuje interfejs `ICommand`. ");
        System.Console.WriteLine("       Ta klasa zawiera referencję do obiektu `Receiver`, który wykonuje właściwą akcję.");
        System.Console.WriteLine("      -Tworzymy klasę `Receiver`, która zawiera metodę `Action()` wykonującą określoną operację.");
        System.Console.WriteLine("      -W funkcji `Main` tworzymy obiekt `Receiver` i przekazujemy go do obiektu `ConcreteCommand`.");
        System.Console.WriteLine("");
        System.Console.WriteLine("       Następnie wywołujemy metodę `Execute()` na obiekcie `ConcreteCommand`, co prowadzi do wykonania akcji na obiekcie `Receiver`.");

        System.Console.WriteLine("");
        System.Console.WriteLine("3.Wzorzec Decorator:");
        System.Console.WriteLine("      -Tworzymy interfejs `IComponent`, który deklaruje metodę `Operation()`.");
        System.Console.WriteLine("      -Implementujemy klasę `ConcreteComponent`, która implementuje interfejs `IComponent` i dostarcza podstawową implementację operacji.");
        System.Console.WriteLine("      -Tworzymy klasę `Decorator`, która implementuje interfejs `IComponent` i ma referencję do obiektu `IComponent`. ");
        System.Console.WriteLine("      -Ta klasa dodaje dodatkową funkcjonalność do operacji, która jest wywoływana po wykonaniu operacji przez komponent podstawowy.");
        System.Console.WriteLine("      -W funkcji `Main` tworzymy obiekt `ConcreteComponent` i przekazujemy go do obiektu `Decorator`. ");
        System.Console.WriteLine("       Następnie wywołujemy metodę `Operation()` na obiekcie `Decorator`, ");
        System.Console.WriteLine("       co powoduje wykonanie operacji na obiekcie `ConcreteComponent` i dodatkową operację dostarczoną przez `Decorator`.");
        System.Console.WriteLine("");
        System.Console.WriteLine("Projekt ten przedstawia prostą aplikację konsolową, w której wykorzystane są trzy wzorce projektowe: Abstract Factory, Command i Decorator. ");
        System.Console.WriteLine("Każdy z tych wzorców rozwiązuje określone problemy projektowe i wprowadza elastyczność oraz rozszerzalność do projektu.");
        System.Console.WriteLine("");
        System.Console.WriteLine("");
        System.Console.WriteLine("    Naciśnij 2x ENTER aby zakończyć działanie programu");
        Console.ReadLine();
        System.Console.WriteLine("Zamykam program...");
        System.Threading.Thread.Sleep(1000);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        Console.ReadLine();
    }
}