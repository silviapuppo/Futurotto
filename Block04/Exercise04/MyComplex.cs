﻿using System;

namespace Exercise04
{
    public class MyComplex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public MyComplex(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public MyComplex() : this(0, 0)
        {
        }

        public void SetValue(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public override string ToString()
        {
            return Real.ToString() + (Imag < 0 ? " " : " +") + Imag.ToString() + 'i';
        }

        public bool IsReal()
        {
            if (Imag == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsImaginary()
        {
            if (Real == 0 && Imag != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(double real, double imag)
        {
            if (Real == real && Imag == imag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(MyComplex another)
        {
            if (another.Real == Real && another.Imag == Imag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Magnitude()
        {
            return Math.Sqrt(Real * Real + Imag * Imag);
        }

        public double Argument()
        {
            if (Real == 0 && Imag > 0)
            {
                return Math.PI / 2;
            }
            else if (Real == 0 && Imag < 0)
            {
                return -Math.PI / 2;
            }
            else if (Real == 0 && Imag == 0)
            {
                return double.NaN;
            }
            else if (Real > 0)
            {
                return Math.Atan(Imag / Real);
            }
            else if (Real < 0 && Imag >= 0)
            {
                return Math.Atan(Imag / Real) + Math.PI;
            }
            else
            {
                return Math.Atan(Imag / Real) - Math.PI;
            }
        }

        public MyComplex Add(MyComplex right)
        {
            Real = Real + right.Real;
            Imag = Imag + right.Imag;
            return new MyComplex(Real, Imag);
        }

        public MyComplex Sub(MyComplex right)
        {
            Real = Real - right.Real;
            Imag = Imag - right.Imag;
            return new MyComplex(Real, Imag);
        }

        public MyComplex Multiply(MyComplex right)
        {
            double tempReal;
            tempReal = Real * right.Real - Imag * right.Imag;
            Imag = Imag * right.Real + Real * right.Imag;

            Real = tempReal;

            return new MyComplex(Real, Imag);
        }

        public MyComplex Divide(MyComplex right)
        {
            if (right.Real == 0 && right.Imag == 0)
            {
                return new MyComplex(double.NaN, double.NaN);
            }

            double tempReal = (Real * right.Real - Imag * right.Imag) / (right.Real * right.Real + right.Imag * right.Imag);
            double tempImag = (Imag * right.Real + Real * right.Imag) / (right.Real * right.Real + right.Imag * right.Imag);

            Real = tempReal;
            Imag = tempImag;

            return new MyComplex(Real, Imag);
        }

        public MyComplex Conjugate()
        {
            Imag = -Imag;

            return new MyComplex(Real, Imag);
        }
    }
}
