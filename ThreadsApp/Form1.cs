using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsApp
{
    public partial class Form1 : Form
    {
        int[] numsA;
        int[] numsB;
        int[] numsC;
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Int32.Parse(textBox1.Text);
            numsA = new int[len];
            numsB = new int[len];
            numsC = new int[len];
            Gen(numsA);
            Gen(numsB);
            Gen(numsC);
            textBox2.Text = ArrayToString(numsA);
            textBox3.Text = ArrayToString(numsB);
            textBox4.Text = ArrayToString(numsC);
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            button2.Enabled = true;
        }

        string ArrayToString(int[] arr)
        {
            string res = "";
            for(int i = 0; i < arr.Length; i++)
            {
                res += arr[i].ToString() + " ";
            }
            return res;
        }

        void Gen(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IThreadSort sort1 = new BubbleSort(numsA);
            IThreadSort sort2 = new QuickSort(numsB);
            IThreadSort sort3 = new QuickSort(numsC);

            sort1.Sort();
            sort2.Sort();
            sort3.Sort();

            textBox2.Text = ArrayToString(sort1.Nums);
            textBox3.Text = ArrayToString(sort2.Nums);
            textBox4.Text = ArrayToString(sort3.Nums);

            label2.Text = sort1.Time.ToString() + " ms";
            label3.Text = sort2.Time.ToString() + " ms";
            label4.Text = sort3.Time.ToString() + " ms";
        }
    }
}
