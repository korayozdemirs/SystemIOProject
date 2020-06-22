using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(ListBox1Ekle));
            Thread thread2 = new Thread(new ThreadStart(ListBox2Ekle));
            Thread thread3 = new Thread(new ThreadStart(ListBox3Ekle));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            //ListBox1Ekle();
            //ListBox2Ekle();
            //ListBox3Ekle();

        }

        private void ListBox3Ekle()
        {
            for (int i = 0; i < 10000; i++)
            {
                listBox3.Items.Add(i);
                Thread.Sleep(600);
            }
        }

        private void ListBox2Ekle()
        {
            for (int i = 0; i < 10000; i++)
            {
                listBox2.Items.Add(i);
                Thread.Sleep(500);

            }
        }

        private void ListBox1Ekle()
        {
            for (int i = 0; i < 10000; i++)
            {
                listBox1.Items.Add(i);
                Thread.Sleep(700);

            }
        }
    }
}
