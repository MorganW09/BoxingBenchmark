``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|            Method |     N |      Mean |      Error |     StdDev |    Median |
|------------------ |------ |----------:|-----------:|-----------:|----------:|
|     **TestSimpleKey** |  **1000** |  **47.73 us** |  **0.3556 us** |  **0.3153 us** |  **47.63 us** |
| TestPerformantKey |  1000 |  48.63 us |  1.0683 us |  2.0325 us |  47.87 us |
|     **TestSimpleKey** | **10000** | **651.54 us** |  **6.8154 us** |  **6.3751 us** | **652.13 us** |
| TestPerformantKey | 10000 | 671.34 us | 13.8145 us | 31.1815 us | 657.32 us |
