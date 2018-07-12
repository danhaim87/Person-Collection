using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softimize
{
    public interface IPerson
    {
        int id { get; }
        
        string FirstName { get; }

        string LastName { get; }

        DateTime DateOfBirth { get; }

        int Height { get; }
    }
}
