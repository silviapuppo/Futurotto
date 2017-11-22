using System;

namespace Exercise06
{
    public class MyPolynomial
    {
        private double[] coeffs;

        public double[] Coeffs
        {
            get
            {
                return coeffs;
            }
            set
            {
                coeffs = value;
            }
        }

        public MyPolynomial(params double[] coeffs)
        {
            Coeffs = coeffs;
        }

        public int GetDegree()
        {
            return Coeffs.Length - 1;
        }

        public override string ToString()
        {
            string poly = null;

            for (int i = Coeffs.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (Coeffs[i] == 0)
                    {

                    }
                    else
                    {
                        poly += coeffs[i].ToString("+0.####;-0.####") + ' ';
                    }
                }
                else if (i == 1)
                {
                    if (Coeffs[i] == 0)
                    {

                    }
                    else
                    {
                        poly += coeffs[i].ToString("+0.####;-0.####") + "x ";
                    }
                }
                else
                {
                    if (Coeffs[i] == 0)
                    {

                    }
                    else
                    {
                        poly += coeffs[i].ToString("+0.####;-0.####") + "x^" + i + ' ';
                    }
                }
            }

            return poly;
        }

        public double Evaluate(double x)
        {
            double result = 0;

            for (int i = 0; i < Coeffs.Length; i++)
            {
                result += Math.Pow(x, i) * Coeffs[i];
            }

            return result;
        }

        public MyPolynomial Add(MyPolynomial another)
        {
            double[] coeffsfResult = new double[another.GetDegree() > GetDegree() ? another.GetDegree() + 1 : GetDegree() + 1];
            int i;

            for (i = 0; i < (another.GetDegree() < GetDegree() ? another.GetDegree() + 1 : GetDegree() + 1); i++)
            {
                coeffsfResult[i] = Coeffs[i] + another.Coeffs[i];
            }

            while (i < (another.GetDegree() > GetDegree() ? another.GetDegree() + 1 : GetDegree() + 1))
            {
                coeffsfResult[i] = (another.GetDegree() > GetDegree() ? another.Coeffs[i] : Coeffs[i]);
                i++;
            }

            return new MyPolynomial(coeffsfResult);
        }

        public MyPolynomial Multiply(MyPolynomial another)
        {
            double[] coeffsResult = new double[GetDegree() + 1 + another.GetDegree() + 1];

            for (int i = 0; i < GetDegree() + 1; i++)
            {
                for (int j = 0; j < another.GetDegree() + 1; j++)
                {
                    coeffsResult[i + j] += Coeffs[i] * another.Coeffs[j];
                }
            }

            return new MyPolynomial(coeffsResult);
        }
    }
}
