using System;
using System.Collections.Generic;
using System.Text;

namespace LibAvif
{
    public readonly struct Fraction
    {
        public uint Numerator { get; }
        public uint Denominator { get; }

        public Fraction(uint numerator, uint denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
    }
}
