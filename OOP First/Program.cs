using System;

namespace Mishon
{

public class Person 
{
    public string name;
    public int age;
}

public class Program
{
    public static void Main(string[] args)
    {
     Person p1 = new Person();
        p1.name = "Shiahab";
        p1.age = 22;
        Console.WriteLine($"First Person Name:{p1.name} And Age is {p1.age}");




        Person p2 =new Person();
        p2.name = "Mishon";
        p2.age = 22;
        Console.WriteLine($"First Person Name:{p2.name} And Age is {p2.age}");
        
    }
}
}