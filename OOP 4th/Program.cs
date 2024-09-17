using System;

    class Person 
{
    public string name;
    public int age;

    public Person(){
      name ="Mishon Das";
      age =20;

    }
    public Person(string n,int a){
      name =n;
      age =a;

    }
    

    public void Method()
    {
       Console.WriteLine($" Person Name:{name} And Age is {age}"); 
    }
}

public class Program
{
    public static void Main(string[] args)
    {
     Person p1 = new Person("Arnab kumar" ,21);
       
        p1.Method();
        

        Person p2 =new Person("Jahed Hasan",25);
        p2.Method();
        
        Person p3 =new Person();
        p3.Method();
    }
}