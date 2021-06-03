using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class ArraySort
    {
        public ArraySort() //конструктор
        {
        }
        public int[] a;
        private static void swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        public void SelectSort(int[] a, ref int sr, ref int obm)
        {
            int max;
            int length = a.Length;
            for (int i = 0; i < length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < length; j++)
                {
                    sr++;
                    if (a[j] > a[max])
                    {
                        max = j;
                     }
                }
                sr++;
                if (max != i)
                {
                    swap(ref a[i], ref a[max]);
                    obm++;
                }
            }
        }
        public void InsertSort(int[] a, ref int sr, ref int obm)
        {
            
            for (int i = 1; i < a.Length; i++)
            {
                int cur = a[i];
                int j = i;
                while (j > 0 && cur > a[j - 1])
                {
                    sr++;
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
            }
            sr++;
        }
        public void BubbleSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    sr++;
                    if (a[j] < a[j + 1])
                    {

                        swap(ref a[j], ref a[j + 1]);
                        obm++;
                    }
                }
            }
        }
        public void RecSelect(int[] arr, int length, ref int sr, ref int obm)
        {
            if (length == 1) { return; }
            int min = 100, index = 0;
            for (int i = 0; i < length - 1; i++)
            {
                sr++;
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                    sr++;
                }
            }
            if (min < arr[length - 1])
            {
                sr++;
                swap(ref arr[index], ref arr[length - 1]);
                obm++;
            }
            RecSelect(arr, length - 1, ref sr, ref obm);
        }
        public void ShellSort(int[] array, ref int sr, ref int obm)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                sr++;
                for (var i = d; i < array.Length; i++)
                {
                    sr++;
                    var j = i;
                    while ((j >= d) && (array[j] > array[j - d]))
                    {
                        sr += 1;
                        swap(ref array[j], ref array[j - d]);
                        j = j - d;
                        obm++;
                    }
                }
                d = d / 2;
            }
        }
        public void RecBubbleSort(int[] a, ref int sr, ref int obm)
        {
            int i = 0;
            for (int j = 0; j < a.Length - i - 1; j++)
            {
                sr++;
                if (a[j] < a[j + 1])
                {
                    sr++;
                    swap(ref a[j], ref a[j + 1]);
                    obm++;
                    i++;
                }
            }
            if (i == 0)
                return;
            else
                RecBubbleSort(a, ref sr, ref obm);
        }
        public void RecInsertSort(int[] a, ref int sr, ref int obm, int i)
        {
            if (i < a.Length)
            {
                sr++;
                int cur = a[i];
                int j = i;
                while (j > 0 && cur > a[j - 1])
                {
                    sr++;
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
                RecInsertSort(a, ref sr, ref obm, i + 1);
            }
            
        }
    }
}