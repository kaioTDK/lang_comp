using System;
using BenchmarkDotNet.Attributes;
public static class SearchPrime{

public static bool IsPrime(uint number) {
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0 & i != 1){
            return false;
        }
    }
    return true;
}

public static void PrimeRange(uint number) {
    for(uint i = 1; i < number;i++){
        if (IsPrime(i)){
            Console.WriteLine(i);
        }
    }
}
public static void PrimeRangeStepp(uint number) {
    for(uint i = 1; i < number;i = i + 4){
        if (IsPrime(i)){
            Console.WriteLine(i);
        }
        if (IsPrime(i+1)){
            Console.WriteLine(i);
        }
        if (IsPrime(i+2)){
            Console.WriteLine(i);
        }
        if (IsPrime(i+3)){
            Console.WriteLine(i);
        }



    }
}


}
