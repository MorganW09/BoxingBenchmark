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
        [Benchmark]
        public void StructKey()
        {
            var dictionary = new Dictionary<BoxingStruct, int>();
            for (int i = 0; i < N; i++)
            {
                var boxingStruct = MakeBoxingStruct(i);
                if (!dictionary.ContainsKey(boxingStruct))
                    dictionary.Add(boxingStruct, i);
            }
        }
        [Benchmark]
        public void ObjectKey()
        {
            var dictionary = new Dictionary<object, int>();
            for (int i = 0; i < N; i++)
            {
                var boxingStruct = MakeBoxingStruct(i);
                if (!dictionary.ContainsKey(boxingStruct))
                    dictionary.Add(boxingStruct, i);
            }
        }

        public BoxingStruct MakeBoxingStruct(int id)
        {
            var boxingStruct = new BoxingStruct()
            {
                Id = id,
                User = new UserStruct()
                {
                    name = "Test User",
                    email = "testemail@gmail.com",
                    phone = "8293839283",
                    age = 11110,
                    //createdDate = DateTime.UtcNow,
                    //updateDate = DateTime.UtcNow,
                    //password = "password1",
                    //profilePic = "profilePic.jpg"
                }
            };
            return boxingStruct;
        }
    }
    public struct BoxingStruct : IEqualityComparer<BoxingStruct>, IEquatable<BoxingStruct>
    {
        public int Id { get; set; }
        public UserStruct User { get; set; }
        public override bool Equals(object obj)
        {
            if (!(obj is BoxingStruct))
                return false;

            BoxingStruct mys = (BoxingStruct)obj;
            return Equals(mys);
        }

        public bool Equals(BoxingStruct x, BoxingStruct y)
        {
            return x.Id == y.Id;
        }

        public bool Equals(BoxingStruct other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public int GetHashCode(BoxingStruct obj)
        {
            return obj.Id;
        }
    }
    public struct UserStruct
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int age { get; set; }
        //public DateTime createdDate { get; set; }
        //public DateTime updateDate { get; set; }
        //public string password { get; set; }
        //public string profilePic { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Runner>();
        }
    }
}
