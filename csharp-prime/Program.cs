namespace prime;
using static System.Console;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        bool is_prime(uint number) {
            for (int i = 1; i < number;i++){
                if (number % i == 0 & i != 1) return false;
            }
            return true;
        }

        void is_prime_range(uint number) {
            for (uint i = 1; i <= number;i++) {
                bool prime = is_prime(i);
            }
        }
        var time = new Stopwatch();
        time.Start();
        is_prime_range(100_000);
        time.Stop();
        WriteLine(time.ElapsedMilliseconds);
        
    }
}
