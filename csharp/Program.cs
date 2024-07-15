namespace prime;
using static System.Console;
using System.Diagnostics;
using BenchmarkDotNet.Running;
class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmark>();

       return;
        bool is_prime(uint number) {
            for (int i = 2 ; i < number;i++){
                if (number % i == 0 & i != 1 | number % 2 == 0 | number % 3 == 0) return false;
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
        WriteLine(time.Elapsed);
        
    }
}
