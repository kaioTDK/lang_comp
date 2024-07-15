namespace prime;
using static System.Console;
using System.Diagnostics;
class Program
{
    static void Main(string[] args){

        bool is_prime(uint number) {
            for (int i = 2 ; i < number;i++){
                if (number % i == 0 | number % 2 == 0) return false;
            }
            return true;
        }

        void is_prime_range(uint number) {
            for (uint i = 1; i <= number;i++) {
                bool prime = is_prime(i);
            }
        }
        void is_prime_range2(uint number) {
            for (uint i = 1; i <= number;i++) {
                
                for (uint i2 = 2 ; i2 < i; i2++){
                    if (number % i == 0| number % 2 == 0) return;
                }
                WriteLine($"{i} is prime!");
            }
        }
        var time = new Stopwatch();
        time.Start();
        is_prime_range(100_000);
        time.Stop();
        WriteLine(time.Elapsed);
         time.Start();
        is_prime_range2(100_000);
        time.Stop();
        WriteLine(time.Elapsed);
        
    }
}
