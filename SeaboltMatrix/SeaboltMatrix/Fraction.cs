//Peyton Seabolt
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaboltMatrix
{
    class Fraction
    {
        int num;
        int den;
        public Fraction(int x, int y) 
        {
            num = x;
            den = y;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den - b.num * a.den, a.den * b.den);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.num, a.den * b.den);
        }
        public String toString()
        {
            return num + "/" + den;
        }
    }
}
