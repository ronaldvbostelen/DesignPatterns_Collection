using System.Collections.Generic;

namespace ProxyPattern.ProtectionProxy
{
    public interface IPersonBean
    {
        string Name { get; set; }
        string Gender { get; set; }
        IList<string> Interests { get; set; }
        int HotOrNotRating { get; set; }
    }
}