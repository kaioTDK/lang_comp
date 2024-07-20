namespace csharp;
using static System.Console;

class Program
{
    static void Main(string[] args){

        var fizzbuzz = new Fizzbuzz();

        fizzbuzz.FizzBuzz(10000);
        Prime.test(10_000);
        
    }
}
