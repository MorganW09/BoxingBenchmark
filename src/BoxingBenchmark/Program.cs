using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace BoxingBenchmark
{
    [MemoryDiagnoser]
    public class Runner
    {
        [Params(1000)]
        public int N;

        //[Benchmark(Baseline = true)]
        //public void TestNormal()
        //{
        //    var dictionary = new Dictionary<int, int>();

        //    for (int i = 0; i < N; i++)
        //    {
        //        if (!dictionary.ContainsKey(i))
        //        {
        //            dictionary.Add(i, i);
        //        }
        //    }
        //}

        //[Benchmark]
        //public void TestBoxing()
        //{
        //    var dictionary = new Dictionary<object, int>();

        //    for (int i = 0; i < N; i++)
        //    {
        //        if (!dictionary.ContainsKey(i))
        //        {
        //            dictionary.Add(i, i);
        //        }
        //    }
        //}

        //[Benchmark]
        //public void TestBoxingAndInterface()
        //{
        //    IDictionary<object, int> dictionary = new Dictionary<object, int>();

        //    for (int i = 0; i < N; i++)
        //    {
        //        if (!dictionary.ContainsKey(i))
        //        {
        //            dictionary.Add(i, i);
        //        }
        //    }
        //}

        [Benchmark(Baseline = true)]
        public void TestStruct()
        {
            var dictionary = new Dictionary<BoxingStruct, int>();

            for (int i = 0; i < N; i++)
            {
                var boxingStruct = MakeBoxingStruct(i);
                if (!dictionary.ContainsKey(boxingStruct))
                {
                    dictionary.Add(boxingStruct, i);
                }
            }
        }

        [Benchmark]
        public void TestStructObject()
        {
            var dictionary = new Dictionary<object, int>();

            for (int i = 0; i < N; i++)
            {
                var boxingStruct = MakeBoxingStruct(i);
                if (!dictionary.ContainsKey(boxingStruct))
                {
                    dictionary.Add(boxingStruct, i);
                }
            }
        }

        [Benchmark]
        public void TestClass()
        {
            var dictionary = new Dictionary<object, int>();

            for (int i = 0; i < N; i++)
            {
                var boxingClass = MakeBoxingClass(i);
                if (!dictionary.ContainsKey(boxingClass))
                {
                    dictionary.Add(boxingClass, i);
                }
            }
        }

        [Benchmark]
        public void TestStructAndInterface()
        {
            IDictionary<object, int> dictionary = new Dictionary<object, int>();

            for (int i = 0; i < N; i++)
            {
                var boxingStruct = MakeBoxingStruct(i);
                if (!dictionary.ContainsKey(boxingStruct))
                {
                    dictionary.Add(boxingStruct, i);
                }
            }
        }

        public BoxingStruct MakeBoxingStruct(int id)
        {
            var boxingStruct = new BoxingStruct()
            {
                Id = id,
                Name = "Test User",
                User = new UserStruct()
                {
                    name = "Test User",
                    email = "testemail@gmail.com",
                    phone = "8293839283",
                    age = 11110,
                    createdDate = DateTime.UtcNow,
                    updateDate = DateTime.UtcNow,
                    password = "password1",
                    profilePic = "profilePic.jpg"
                },
                //Stats = new StatsStruct()
                //{
                //    posts = 10000,
                //    comments = 12000,
                //    reads = 100000,
                //    likes = -11000,
                //    topPost = "http://topPost",
                //    worstPost = "http://worstPost"
                //}
            };

            return boxingStruct;
        }

        public BoxingClass MakeBoxingClass(int id)
        {
            var boxingClass = new BoxingClass()
            {
                Id = id,
                User = new UserClass()
                {
                    name = "Test User",
                    email = "testemail@gmail.com",
                    phone = "8293839283",
                    age = 11110,
                    createdDate = DateTime.UtcNow,
                    updateDate = DateTime.UtcNow,
                    password = "password1",
                    profilePic = "profilePic.jpg"
                },
                Stats = new StatsClass()
                {
                    posts = 10000,
                    comments = 12000,
                    reads = 100000,
                    likes = -11000,
                    topPost = "http://topPost",
                    worstPost = "http://worstPost"
                }
            };

            return boxingClass;
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
