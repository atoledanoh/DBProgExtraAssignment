using System;

namespace ExtraAssignment
{
    public class NorthwindFactory
    {
        public static Func<NorthwindRepo> NorthwindRepoFuc { private get; set; }
        public static NorthwindRepo CreateRepo()
        {
            return NorthwindRepoFuc();
        }
    }
}
