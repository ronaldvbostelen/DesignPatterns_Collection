using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.ProtectionProxy
{
    class PersonBean : IPersonBean
    {
        private int ratingCount;
        private int rating;

        public string Name { get; set; }
        public string Gender { get; set; }
        public IList<string> Interests { get; set; }

        public int HotOrNotRating
        {
            get
            {
                if (ratingCount == 0) return 0;

                return rating / ratingCount;
            }
            set
            {
                rating += value;
                ratingCount++;
            }
        }

    }
}
