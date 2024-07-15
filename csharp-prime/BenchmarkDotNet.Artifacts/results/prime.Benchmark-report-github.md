```

BenchmarkDotNet v0.13.12, EndeavourOS
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.106
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method         | Mean    | Error    | StdDev   |
|--------------- |--------:|---------:|---------:|
| is_prime_range | 1.898 s | 0.0054 s | 0.0048 s |
