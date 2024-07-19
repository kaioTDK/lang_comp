namespace csharp;
using static Console;

public class Fizzbuzz() {
    public void FizzBuzz(uint param){
    for (uint i = 1; i < param; i++ ){
        if (i % 5 == 0 & i % 3 == 0) WriteLine("FizzBuzzz!");
        else if (i % 3 == 0) WriteLine("Fizz!");
        else if (i % 5 == 0) WriteLine("Buzz!");
        else WriteLine($"{i}");

    }
    }
}