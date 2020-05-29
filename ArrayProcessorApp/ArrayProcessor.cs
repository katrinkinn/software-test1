using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessorApp
{
    public class ArrayProcessor
    {
        public ArrayProcessor()
        {

        }
        double[] remove(double[] a)
        {
            var tmp = a.Cast<double>().ToList();
            tmp = tmp.Distinct().ToList();
            var b = tmp.ToArray();
            return b;
        }
        public double[] SortAndFilter(double[] a)
        {
            int n = a.Length;
            double[] T = new double[n];
            for (int i = 0; i < n; i++)
            {
                T[i] = a[i];
                if (T[i] < 0)
                {
                    T[i] = T[i] * (-1);
                }
            }
            Array.Sort(T);
            Array.Reverse(T);
            T = remove(T);
            return T;
        }
    }
}
