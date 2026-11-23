using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20TaneSayıyıToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0, i = 0;
            while (i < lstSayılar.Items.Count) toplam += Convert.ToInt32(lstSayılar.Items[i++]);
            MessageBox.Show(toplam.ToString());
        }
    }
}
