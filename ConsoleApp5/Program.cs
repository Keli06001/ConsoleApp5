using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get { return FirstName + " " + LastName; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        DateTime Date1 = new DateTime(2005,12,22);

        DateTime datetime2=DateTime.Now;
        TimeSpan TimeSpan1 = TimeSpan.FromDays(18);
 
        person.FirstName = "John";
        person.LastName = "Doe";

        Console.WriteLine("Full Name: " + person.FullName);

        if (datetime2 - Date1 >= TimeSpan1)
        {
            Console.WriteLine("Du är över 18");
        }
        else
        {
            Console.WriteLine("Du är under 18");
        }
    }
}
