using System;

    class Person 
{
    public string name;
    private int age;

    public void setage(int a){
        age =a;
    }

    public int getage(){
        return age;
    }

    

    
}

public class Program
{
    public static void Main(string[] args)
    {
     Person p1 = new Person();
     p1.name=("Mishon Das");
     p1.setage(33);
       
    Console.WriteLine($" Person Name:{p1.name} And Age is {p1.getage()}"); 
    }
}