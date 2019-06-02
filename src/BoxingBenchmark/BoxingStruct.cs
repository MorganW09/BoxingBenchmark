using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingBenchmark
{
    public struct BoxingStruct
    {
        public int Id { get; set; }
        public UserStruct User { get; set; }
        public StatsStruct Stats { get; set; }


        public override bool Equals(object obj)
        {
            if (!(obj is BoxingStruct))
                return false;

            BoxingStruct mys = (BoxingStruct)obj;
            return mys.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }


    public struct UserStruct
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

    public struct StatsStruct
    {
        public int posts { get; set; }
        public int comments { get; set; }
        public int reads { get; set; }
        public int likes { get; set; }
        public string topPost { get; set; }
        public string worstPost { get; set; }
    }
}
