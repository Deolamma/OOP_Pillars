using OopPillars;

class Program
{
    public static void Main(string[] args)
    {
        Human myHuman = new Human("SomeHumanName", 300);
        Student student1 = new Student("Emmanuel", 13, false);
        Worker worker1 = new Worker("SomePerson", 23, true);

        Console.WriteLine("Human Speaking>>>>>>>>>>>>>>>>>>>>>>");
        myHuman.Work();
        Console.WriteLine("\n\n");


        Console.WriteLine("Student Speaking>>>>>>>>>>>>>>>>>>>>>>");
        student1.HumanInfo();
        student1.Work();
        Console.WriteLine($"{student1.Is_Disabled()}: {student1.Name()} is NOT disabled");
        Console.WriteLine("\n\n");


        Console.WriteLine("Worker Speaking>>>>>>>>>>>>>>>>>>>>>>");
        worker1.HumanInfo();
        worker1.Work();

    }
}
