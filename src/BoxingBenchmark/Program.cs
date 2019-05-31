using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace BoxingBenchmark
{
    public class Runner
    {
        [Params(1000, 10_000)]
        public int N;

        [Benchmark]
        public void TestSimpleKey()
        {
            var dictionary = new Dictionary<SimpleKey, int>();

            for (int i = 0; i < N; i++)
            {
                var newKey = new SimpleKey(i);
                if (!dictionary.ContainsKey(newKey))
                {
                    dictionary.Add(newKey, i);
                }
            }
        }

        [Benchmark]
        public void TestPerformantKey()
        {
            var dictionary = new Dictionary<PerformantKey, int>();

            for (int i = 0; i < N; i++)
            {
                var newKey = new PerformantKey(i);
                if (!dictionary.ContainsKey(newKey))
                {
                    dictionary.Add(newKey, i);
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Runner>();
        }
    }
}
