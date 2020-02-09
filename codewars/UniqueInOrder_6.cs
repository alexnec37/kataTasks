using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars
{
    public class UniqueInOrder_6
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T item, last = default(T);
            var list = new List<T>();

            using (var enumerator = iterable.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    last = enumerator.Current;
                    list.Add(last);
                }
                
                while(enumerator.MoveNext())
                {
                    item = enumerator.Current;
                    if (item.Equals(last))
                    {
                        continue;
                    }

                    list.Add(item);
                    last = item;
                }
            }

            return list;
        }
    }
}
