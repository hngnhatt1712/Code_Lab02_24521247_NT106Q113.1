using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void Lab02_Load(object sender, EventArgs e)
        {

        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.Show();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.Show();
        }

        private void btn_bai6_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.Show();
        }

        private void btn_bai7_Click_1(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.Show();
        }
    }
}
