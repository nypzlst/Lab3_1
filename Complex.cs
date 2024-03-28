using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Complex :Pair
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public Complex(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }
        public override Pair Add(Pair other)
        {
            if (other is Complex complexNumber)
            {
                return new Complex(RealPart + complexNumber.RealPart, ImaginaryPart + complexNumber.ImaginaryPart);
            }

            throw new ArgumentException("Незбіг типів при додаванні");
        }
        public override Pair Subtract(Pair other)
        {
            if (other is Complex complexNumber)
            {
                return new Complex(RealPart - complexNumber.RealPart, ImaginaryPart - complexNumber.ImaginaryPart);
            }

            throw new ArgumentException("Незбіг типів при відніманні");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is Complex complexNumber)
            {
                return new Complex(
                    RealPart * complexNumber.RealPart - ImaginaryPart * complexNumber.ImaginaryPart,
                    RealPart * complexNumber.ImaginaryPart + ImaginaryPart * complexNumber.RealPart);
            }

            throw new ArgumentException("Незбіг типів при множенні");
        }

        public override Pair Divide(Pair other)
        {
            if (other is Complex complexNumber)
            {
                if (complexNumber.RealPart == 0 && complexNumber.ImaginaryPart == 0)
                {
                    throw new DivideByZeroException("Ділення на нуль");
                }

                double denominator = complexNumber.RealPart * complexNumber.RealPart + complexNumber.ImaginaryPart * complexNumber.ImaginaryPart;

                return new Complex(
                    (RealPart * complexNumber.RealPart + ImaginaryPart * complexNumber.ImaginaryPart) / denominator,
                    (ImaginaryPart * complexNumber.RealPart - RealPart * complexNumber.ImaginaryPart) / denominator);
            }

            throw new ArgumentException("Незбіг типів при діленні");
        }

        public override string ToString()
        {
            if (ImaginaryPart == 0)
            {
                return RealPart.ToString();
            }
            else if (ImaginaryPart > 0)
            {
                return $"{RealPart} + {ImaginaryPart}i";
            }
            else
            {
                return $"{RealPart} - {-ImaginaryPart}i";
            }
        }

    }
}
