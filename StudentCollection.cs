using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    delegate TKey KeySelector<TKey>(Student st);
    class StudentCollection<TKey>
    {
        private Dictionary<TKey, Student> collection = new Dictionary<TKey, Student>();
        private KeySelector<TKey> ks;
        public StudentCollection(KeySelector<TKey> _ks)
        {
            ks = _ks;
        }
    }
}
