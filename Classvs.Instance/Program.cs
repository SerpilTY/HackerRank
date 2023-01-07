class Person
{

    public int age;

    public Person(int initialAge)
    {
        if (initialAge >= 0) age = initialAge;
        else if (initialAge < 0)
        {
            System.Console.WriteLine("Age is not valid, setting age to 0.");
            initialAge = 0;
            age = initialAge;
        }
    }

    void yearPasses()
    {
        age++;
    }

    void amIOld()
    {
        if (age < 13) System.Console.WriteLine("You are young.");
        else if (age >= 13 && age < 18) System.Console.WriteLine("You are a teenager..");
        else System.Console.WriteLine("You are a old..");
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
