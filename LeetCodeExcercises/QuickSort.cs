using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExcercises
{
    public class QuickSort
    {
        public static void QuickSortStart()
        {
            var a = new int[] { 5, 1, 6, 4 };
            var a1 = new int[] { 4, 1, 6, 5 };
            int[] b = new int[a.Length + a1.Length];

            int k = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
                b[k] = a1[i];
                k++;
            }

            QuickSortMethod(0, b.Length - 1, b);
        }
        public static void QuickSortMethod(int l, int r, int[] a)
        {
            int i = l;
            int j = r;
            int pivot = a[l];

            while (i <= j)
            {
                while (a[i] < pivot)
                {
                    i++;
                }
                while (a[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                QuickSortMethod(l, j, a);
            }
            if (i < r)
            {
                QuickSortMethod(i, r, a);
            }
        }
    }
}
