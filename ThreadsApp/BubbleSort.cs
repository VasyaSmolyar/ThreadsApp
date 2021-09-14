using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsApp
{
    class BubbleSort : IThreadSort
    {
        public int[] Nums { get; set; }
        public int Time { get; set; }
        public void _sort()
        {
            int temp;
            for (int i = 0; i < Nums.Length - 1; i++)
            {
                for (int j = i + 1; j < Nums.Length; j++)
                {
                    if (Nums[i] > Nums[j])
                    {
                        temp = Nums[i];
                        Nums[i] = Nums[j];
                        Nums[j] = temp;
                    }
                }
            }
        }
        public void Sort()
        {
            _sort();
        }
        public BubbleSort(int[] data)
        {
            Nums = new int[data.Length];
            data.CopyTo(Nums, 0);
        }
    }
}
