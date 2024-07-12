```

BenchmarkDotNet v0.13.12, EndeavourOS
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.106
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method          | Mean         | Error      | StdDev     |
|---------------- |-------------:|-----------:|-----------:|
| PrimeOP         |     47.54 μs |   0.770 μs |   0.643 μs |
| PrimeRange      | 32,661.21 μs | 152.721 μs | 142.856 μs |
| PrimeRangeStepp | 32,612.80 μs | 112.447 μs | 105.183 μs |
