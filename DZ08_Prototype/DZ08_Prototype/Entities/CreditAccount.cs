using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ08_Prototype.Entities;

public class CreditAccount : Account
{
    public CreditAccount(int number, string owner, int creditLimit) : base(number, owner)
    {
        CreditLimit = creditLimit;
    }

    public int CreditLimit { get; set; }

    public override CreditAccount Copy()
        => new CreditAccount(Number + 10, Owner, CreditLimit);

    public override string ToString()
    {
        return $"{base.ToString()} LIMIT = {CreditLimit}";
    }
}