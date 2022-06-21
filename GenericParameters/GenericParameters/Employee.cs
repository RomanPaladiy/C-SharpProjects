using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    // Creating a generic class to let different datatypes be passed in.
    public class Employee<T>
    {
        // Generic property to allow different datatypes.
        public List<T> Things { get; set; }

    }
}
