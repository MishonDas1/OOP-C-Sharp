using System;

    class Person 
{
    public string name;
    public int age;

    public void Method()
    {
       Console.WriteLine($"First Person Name:{name} And Age is {age}"); 
    }
}

public class Program
{
    public static void Main(string[] args)
    {
     Person p1 = new Person();
        p1.name = "Shiahab";
        p1.age = 22;
        p1.Method();
        

        Person p2 =new Person();
        p2.name = "Mishon";
        p2.age = 22;
       p2.Method();
        
    }
}
