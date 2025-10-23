using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string nd = sr.ReadToEnd();
                    rtb_file.Text = nd;
                    tb_name.Text = ofd.SafeFileName.ToString();
                    FileInfo fi = new FileInfo(fs.Name);
                    tb_size.Text = fi.Length.ToString() + " bytes";
                    tb_url.Text = fs.Name.ToString();
                    int lines = nd.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
                    tb_line.Text = lines.ToString();
                    char[] splits = new char[] {' ', '\r', '\n', '\t', '.', ',', '?', '!', ';', ':'};
                    int words = nd.Split(splits, StringSplitOptions.RemoveEmptyEntries).Length;
                    tb_word.Text = words.ToString();
                    tb_character.Text = nd.Length.ToString();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
