using System;

namespace MyNamespace
{

  class Person
  {
    
    public string name;
    public int age;

    public Person(string n,int a){
      name =n;
      age =a;
    }

    public Person(){
      name ="Mishon Das";
      age = 23;

    }

    public void Method(){
         Console.WriteLine($"{name}   {age}");
      
    }
  }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1=new Person("Mishon kumar Das",55);
            p1.Method();

            Person p2 =new Person();
            p2.Method();
           
        }
    }
}
