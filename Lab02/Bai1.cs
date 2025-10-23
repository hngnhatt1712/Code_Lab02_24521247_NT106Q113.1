using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Lab02
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("input1.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string doc = sr.ReadToEnd();
                rtb_file.Text = doc;
                fs.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi khi đọc file ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtb_file.Text))
            {
                MessageBox.Show("Mời nhập nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            try
            {
                string chuHoa = rtb_file.Text.ToUpper();
                StreamWriter sw = new StreamWriter("output1.txt");
                sw.Write(chuHoa);
                sw.Close();
                MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
