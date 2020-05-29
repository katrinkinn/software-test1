using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquation
{
    public class LinearEquationSystem
    {
        public double[,] coeffs;
        public double[] B;
        public int n;
        public LinearEquationSystem() { }
        public LinearEquationSystem(double[,] coeffs_, double[] B_)
        {
            SetCoefficients(coeffs_, B_);
        }

        public void SetCoefficients(double [,] coeffs_, double[] B_)
        {
            if (coeffs_.GetLength(0) == 2 || coeffs_.GetLength(0) == 3)
            {
                coeffs = coeffs_;
                n = coeffs_.GetLength(0);
                B = B_;
            }
            else
            {
                throw (new System.FormatException());
            }
        }

        double determinant1(double[,] A)
        {
            double det = A[0,0] * A[1,1] * A[2,2] +
           A[0,1] * A[1,2] * A[2,0] +
           A[1,0] * A[2,1] * A[0,2] -
           A[2,0] * A[1,1] * A[0,2] -
           A[1,0] * A[0,1] * A[2,2] -
           A[2,1] * A[1,2] * A[0,0];
            if (det == 0)
            {
                throw new System.ArgumentException();
            }
            else
            {
                return det;
            }
        }
        double determinant2(double[,] A)
        {
            double det = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
            if(det == 0)
            {
                throw new System.ArgumentException();
            }
            else
            {
                return det;
            }        
        }

        public double[] Solve()
        {
            double[] solve = new double[n];
            double det;
            if(n == 2)
            {
                det = determinant2(coeffs);
            }
            else
            {
                det = determinant1(coeffs);
            }
            double[,] T = new double[n,n];
            
            for (int N = 0; N < n; N++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        T[i, j] = coeffs[i, j];
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    T[j, N] = B[j];
                }
                if (n == 2)
                {
                    solve[N] = determinant2(T) / det;
                }
                else
                {
                    solve[N] = determinant1(T) / det;
                }

            }
            
            return solve;
        }
    }
}
