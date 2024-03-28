using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class FazzyNumber : Pair
    {
        public float Value { get; set; }
        public float Membership { get; set; }

        public FazzyNumber(float value, float membership)
        {
            Value = value;
            Membership = membership;
        }

        public override Pair Add(Pair other)
        {
            if (other is FazzyNumber fuzzyNumber)
            {
                float newVal = Math.Max(Membership, fuzzyNumber.Membership);
                return new FazzyNumber((Value + fuzzyNumber.Value)/2, newVal);
            }

            throw new ArgumentException("Незбіг типів при додаванні");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is FazzyNumber fuzzyNumber)
            {
                float newVal = Math.Max(Membership, fuzzyNumber.Membership);
                return new FazzyNumber((Value - fuzzyNumber.Value) / 2, newVal);
            }

            throw new ArgumentException("Незбіг типів при відніманні");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is FazzyNumber fuzzyNumber)
            {
                float newVal = Math.Max(Membership, fuzzyNumber.Membership);
                return new FazzyNumber((Value * fuzzyNumber.Value), newVal);
            }

            throw new ArgumentException("Незбіг типів при множенні");
        }

        public override Pair Divide(Pair other)
        {
            if (other is FazzyNumber fuzzyNumber)
            {
                if (fuzzyNumber.Value == 0 && fuzzyNumber.Membership == 0)
                {
                    throw new DivideByZeroException("Ділення на нуль");
                }

                float newVal = Math.Max(Membership, 1.0f/ fuzzyNumber.Membership);
                return new FazzyNumber((Value / fuzzyNumber.Value), newVal);
            }

            throw new ArgumentException("Незбіг типів при діленні");
        }

        public override string ToString()
        {
            return $"[{Value}, {Membership}]";
        }
    }
}
