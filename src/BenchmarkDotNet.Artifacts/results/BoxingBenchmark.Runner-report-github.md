``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                 Method |    N |     Mean |    Error |    StdDev |   Median | Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------- |----- |---------:|---------:|----------:|---------:|------:|--------:|--------:|--------:|--------:|----------:|
|             TestStruct | 1000 | 257.9 us | 5.664 us | 15.599 us | 251.3 us |  1.00 |    0.00 | 83.0078 | 83.0078 | 83.0078 | 355.13 KB |
|       TestStructObject | 1000 | 189.7 us | 3.042 us |  2.845 us | 188.5 us |  0.74 |    0.03 | 92.5293 |  0.7324 |       - | 287.32 KB |
|              TestClass | 1000 | 183.4 us | 3.929 us | 10.889 us | 181.7 us |  0.71 |    0.06 | 58.3496 | 27.5879 |       - | 263.88 KB |
| TestStructAndInterface | 1000 | 208.8 us | 4.093 us |  6.838 us | 205.6 us |  0.79 |    0.05 | 81.5430 | 20.0195 |       - | 287.32 KB |
