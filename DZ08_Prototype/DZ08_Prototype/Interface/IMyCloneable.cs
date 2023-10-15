using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ08_Prototype.Interface;

    public interface IMyCloneable<out T>
    {
        T Copy();
    }

