using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsApp
{
    public interface IThreadSort
    {
        int[] Nums { get; set; }
        int Time { get; set; }
        void Sort();
    }
}
