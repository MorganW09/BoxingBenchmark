using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingBenchmark
{
    public class PerformantKey : IEquatable<PerformantKey>
    {
        public int Key { get; set; }

        public PerformantKey(int Key)
        {
            this.Key = Key;
        }

        public override int GetHashCode()
        {
            return Key;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PerformantKey);
        }

        public bool Equals(PerformantKey other)
        {
            return other != null && other.Key == this.Key;
        }
    }
}
