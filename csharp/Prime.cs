namespace csharp;
using System.Diagnostics;
using static Console;

public static class Prime{
        public static bool is_prime(uint number) {
            for (int i = 2 ; i < number;i++){
                if (number % i == 0) return false;
            }
            return true;
        }

        public static void is_prime_range(uint number) {
            for (uint i = 1; i <= number;i++) {
                bool prime = is_prime(i);
            }
        }

        public static void test(){
            var time = new Stopwatch();
            time.Start();
            is_prime_range(10_000);
            time.Stop();
            WriteLine(time.ElapsedMilliseconds);
        }
}