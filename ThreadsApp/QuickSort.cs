using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsApp
{
    class QuickSort : IThreadSort
    {
        public int[] Nums { get; set; }
        public int Time { get; set; }
        int partition(int[] array, int start, int end)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }
        void quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);
        }
        public void _sort()
        {
            quicksort(Nums, 0, Nums.Length - 1);
        }
        public void Sort()
        {
            DateTime start = DateTime.Now;
            _sort();
            DateTime end = DateTime.Now;
            Time = Convert.ToInt32((end - start).TotalMilliseconds);
        }
        public QuickSort(int[] data)
        {
            Nums = new int[data.Length];
            data.CopyTo(Nums, 0);
        }
    }
}
