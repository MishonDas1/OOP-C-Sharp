using System ;
namespace HelloWorld
{
    class Program
    {
        static void Main ( string [] args )
        {
            int [] numbers ={1,2,3,4,5};
            int sum = 0;

            foreach(int number in numbers){
                sum=sum+number;
            }
            Console.WriteLine(sum);

            /*for(int i=0;i<names.Length;i++){
                Console.WriteLine(names[i]);
            }*/
        }
    }
}

