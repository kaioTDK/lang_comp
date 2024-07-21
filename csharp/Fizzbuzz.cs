namespace csharp;
using static Console;
using System.Diagnostics;

public static class Fizzbuzz {
    internal static void FizzBuzzz(uint param){
        var nums = new string[param];
        for (uint i = 1; i <= param; i++ ){
            if (i % 5 == 0 & i % 3 == 0) nums[i -1] = "FizzBuzzz!";
            else if (i % 3 == 0)  nums[i -1] = "Fizz!";
            else if (i % 5 == 0)  nums[i -1] = "Buzz!";
            else  nums[i -1] = $"{i}";
        }
    }

    public static void testFizzB(uint param) {
        var time = new Stopwatch();
        time.Start();
        FizzBuzzz(param);
        time.Stop();
        WriteLine(time.ElapsedMilliseconds);
    }
}