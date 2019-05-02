using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject
{
    class GenericClass<T, X> where T : struct 
    {
        public void GenMethod(T p1, X p2)
        {
            
        }
    }
}
