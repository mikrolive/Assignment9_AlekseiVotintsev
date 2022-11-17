using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Assignment_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostcommonletter_Click(object sender, EventArgs e)
        {
            String str = word.Text.ToString();
            int[] Count = new int[256];
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                Count[str[i]]++;
            }
            int max = -1;
            char common = ' ';
            for (int i = 0; i < length; i++)
            {
                if (max < Count[str[i]])
                {
                    max = Count[str[i]];
                    common = str[i];
                }
            }
            MessageBox.Show("Most common character is " + common + ", it appears " + max + " times");
        }

        private void word_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
