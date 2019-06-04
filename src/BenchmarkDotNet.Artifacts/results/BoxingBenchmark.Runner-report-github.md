``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|    Method |    N |     Mean |    Error |    StdDev |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|---------- |----- |---------:|---------:|----------:|--------:|--------:|--------:|----------:|
| StructKey | 1000 | 235.8 us | 7.507 us |  8.936 us | 52.2461 | 52.2461 | 52.2461 | 326.76 KB |
| ObjectKey | 1000 | 190.6 us | 4.806 us | 13.942 us | 87.8906 |  0.2441 |       - |  271.7 KB |
