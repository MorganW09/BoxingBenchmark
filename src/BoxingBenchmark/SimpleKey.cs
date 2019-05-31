using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingBenchmark
{
    public class SimpleKey
    {
        public int Key { get; set; }

        public SimpleKey(int Key)
        {
            this.Key = Key;
        }

        public override int GetHashCode()
        {
            return Key;
        }

        public override bool Equals(object obj)
        {
            var item = obj as SimpleKey;

            if (item == null)
                return false;
            return item.Key == this.Key;
        }
    }
}
