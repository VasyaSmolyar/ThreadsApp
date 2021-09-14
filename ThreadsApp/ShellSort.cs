using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsApp
{
    class ShellSort : IThreadSort
    {
        public int[] Nums { get; set; }
        public int Time { get; set; }
        public void _sort()
        {
            int step = Nums.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < Nums.Length; i++)
                {
                    int value = Nums[i];
                    for (j = i - step; (j >= 0) && (Nums[j] > value); j -= step)
                        Nums[j + step] = Nums[j];
                    Nums[j + step] = value;
                }
                step /= 2;
            }
        }
        public void Sort()
        {
            _sort();
        }
        public ShellSort(int[] data)
        {
            Nums = new int[data.Length];
            data.CopyTo(Nums, 0);
        }
    }
}
