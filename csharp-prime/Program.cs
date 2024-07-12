using static SearchPrime;
using static System.Console;
using BenchmarkDotNet.Running;

//BenchmarkRunner.Run<Benchmark>();
Benchmark.PrimeOP();

return;
Console.WriteLine("Hello, World!");

uint numvar = 999983;
bool isprime = IsPrime(numvar);

if (isprime){
    WriteLine($"{numvar} é primo!");
}else{
WriteLine($"{numvar} não é primo!");}

//PrimeRange(1_000_000);
PrimeRangeStepp(1_000_000);