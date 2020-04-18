using System.Collections.Generic;

namespace IteratorPattern
{
    public interface Menu
    {
        IEnumerator<MenuItem> CreateEnumerator();
    }
}