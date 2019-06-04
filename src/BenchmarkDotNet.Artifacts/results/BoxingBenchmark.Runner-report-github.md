``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|           Method |    N |     Mean |    Error |   StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------- |----- |---------:|---------:|---------:|------:|--------:|--------:|--------:|----------:|
|       TestStruct | 1000 | 245.0 us | 4.232 us | 3.752 us |  1.00 | 83.0078 | 83.0078 | 83.0078 | 355.13 KB |
| TestStructObject | 1000 | 181.6 us | 2.732 us | 2.556 us |  0.74 | 92.5293 |  0.7324 |       - | 287.32 KB |
