using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace demoPractice.AbstractAndInterface
{
    public abstract class Collection : ICollection
    {
        public int Count { get; set; }

        public object SyncRoot { get; set; }

        public bool IsSynchronized { get; set; }

        public void CopyTo(Array array, int index)
        {
        }

        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }
}
