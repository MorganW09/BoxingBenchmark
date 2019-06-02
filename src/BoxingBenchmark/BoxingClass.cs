using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingBenchmark
{
    public class BoxingClass
    {
        public int Id { get; set; }
        public UserClass User { get; set; }
        public StatsClass Stats { get; set; }


        public override bool Equals(object obj)
        {
            var item = obj as BoxingClass;

            if (item == null)
                return false;
            return item.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    public class UserClass
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int age { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updateDate { get; set; }
        public string password { get; set; }
        public string profilePic { get; set; }
    }

    public class StatsClass
    {
        public int posts { get; set; }
        public int comments { get; set; }
        public int reads { get; set; }
        public int likes { get; set; }
        public string topPost { get; set; }
        public string worstPost { get; set; }
    }
}
