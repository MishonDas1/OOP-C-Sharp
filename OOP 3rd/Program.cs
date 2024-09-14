using System;

    class Person 
{
    public string name;
    public int age;
    
    public void value(string n,int a){
        name = n;
        age =a;
    }

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
        p1.value("Mishon Das", 21);
        p1.Method();
        

        Person p2 =new Person();
        p2.value("Arnab Kumar",22);
        p2.Method();
        
    }
}
