using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softimize
{
    public interface IPersonComparable
    {
        int comparePerson(IPerson personA, IPerson personB);
    }
}
