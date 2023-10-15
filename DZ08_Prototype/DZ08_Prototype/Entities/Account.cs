using DZ08_Prototype.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ08_Prototype.Entities;

public class Account : ICloneable, IMyCloneable<Account>
{
    public Account(int number, string owner)
    {
        Number = number;
        Owner = owner;
    }

    public int Number { get; set; }
    public string Owner { get; set; }


    public object Clone()
        => Copy();

    public virtual Account Copy()
        => (Account)this.MemberwiseClone();

    public override string ToString()
    {
        return $"NAME={Owner} ID={Number} HASH={GetHashCode()}";
    }
}