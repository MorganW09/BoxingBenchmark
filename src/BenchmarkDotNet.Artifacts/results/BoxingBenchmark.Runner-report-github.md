``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.503 (1809/October2018Update/Redstone5)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.300
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                 Method |     N |       Mean |      Error |      StdDev | Ratio | RatioSD |    Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
|----------------------- |------ |-----------:|-----------:|------------:|------:|--------:|---------:|---------:|---------:|-----------:|
|             **TestStruct** |  **1000** |   **295.7 us** |  **5.3124 us** |   **4.9692 us** |  **1.00** |    **0.00** | **104.9805** | **104.9805** | **104.9805** |  **440.23 KB** |
|       TestStructObject |  1000 |   205.0 us |  0.7688 us |   0.7191 us |  0.69 |    0.01 | 108.1543 |   0.2441 |        - |   334.2 KB |
|              TestClass |  1000 |   170.8 us |  2.4989 us |   2.3375 us |  0.58 |    0.01 |  57.6172 |  27.8320 |        - |  263.88 KB |
| TestStructAndInterface |  1000 |   210.5 us |  1.1342 us |   0.8855 us |  0.71 |    0.01 | 108.1543 |   0.2441 |        - |   334.2 KB |
|                        |       |            |            |             |       |         |          |          |          |            |
|             **TestStruct** | **10000** | **3,161.2 us** | **52.0295 us** |  **48.6685 us** |  **1.00** |    **0.00** | **996.0938** | **996.0938** | **996.0938** | **4071.62 KB** |
|       TestStructObject | 10000 | 3,908.1 us | 44.7725 us |  41.8802 us |  1.24 |    0.02 | 460.9375 | 242.1875 | 218.7500 | 3263.68 KB |
|              TestClass | 10000 | 2,886.6 us | 64.9533 us | 132.6825 us |  0.95 |    0.06 | 441.4063 | 218.7500 | 218.7500 | 2560.55 KB |
| TestStructAndInterface | 10000 | 3,953.8 us | 81.0260 us | 159.9374 us |  1.27 |    0.07 | 464.8438 | 242.1875 | 218.7500 | 3263.68 KB |
