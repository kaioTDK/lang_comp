using System;
using BenchmarkDotNet.Attributes;
using System.Collections;
using Perfolizer.Mathematics.Selectors;
public class Benchmark{


public static bool IsPrime(uint number) {
    for (int i = 1; i < number; i += 2)
    {
        if (number % i == 0 & i != 1){
            return false;
        }
         if (number+1 % i == 0 & i != 1){
            return false;
        }
    }
    return true;
}

/*
public static uint IsPrimeNum(uint number) {
    for (int i = 1; i < number; i += 2)
    {
        if (number % i == 0 & i != 1){
            return false;
        }
         if (number+1 % i == 0 & i != 1){
            return false;
        }
    }
    return true;
}
*/
[Benchmark]
public static void PrimeOP(){
    List<uint> primes = new List<uint>();
    IsPrimeNum(10_000);
    void IsPrimeNum(uint number) 
    {
        for (int i = 1; i < number; i += 2)
        {
            if (number % i == 0 & i != 1){return;}
            else {primes.Add(number);}
            if (number+1 % i == 0 & i != 1){return; }
            else{primes.Add(number+1);}
            
        }
    }
    primes.ForEach(x => Console.WriteLine(x));
}

[Benchmark]
public void PrimeRange() {
    for(uint i = 1; i < 10_000;i++){
        IsPrime(i);       
        }
    }
[Benchmark]
public void PrimeRangeStepp() {
    for(uint i = 1; i < 10_000;i = i + 4){
        IsPrime(i);
        IsPrime(i+1);
        IsPrime(i+2);
        IsPrime(i+3);
        }
    }
}