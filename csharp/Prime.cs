namespace csharp;
using System.Diagnostics;
using static Console;

public static class Prime{
        internal static bool is_prime(uint number) {
            for (int i = 2 ; i < number;i++){
                if (number % i == 0) return false;
            }
            return true;
        }

        internal static void is_prime_range(uint number) {
            var primeNums = new uint[number];
            for (uint i = 1; i <= number;i++) {
                bool isprime = is_prime(i);
                if (isprime) primeNums[i -1] = i;
            }
        }

        public static void test(uint param){
            var time = new Stopwatch();
            time.Start();
            is_prime_range(param);
            time.Stop();
            WriteLine(time.ElapsedMilliseconds);
        }
}