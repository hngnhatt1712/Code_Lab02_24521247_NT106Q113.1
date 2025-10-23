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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = "input3.txt";
                if (!File.Exists(ip))
                {
                    MessageBox.Show("Không tìm thấy file!");
                    return;
                }
                rtb_file.Text = File.ReadAllText(ip);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi đọc file");
            }
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            string ip = "input3.txt";
            string op = "output3.txt";
            try
            {
                if (!File.Exists(ip))
                {
                    MessageBox.Show("Không tìm thấy file!");
                    return;
                }

                var ipLines = File.ReadAllLines(ip);
                List<string> opLines = new List<string>();
                foreach (var l in ipLines)
                {
                    string cal = l.Trim();
                    if (string.IsNullOrEmpty(cal)) continue;

                    try
                    {
                        decimal res = Calculator(cal); 
                        opLines.Add($"{cal} = {res}");
                    }
                    catch (Exception ex)
                    {
                        opLines.Add($"{cal} = LỖI ({ex.Message})");
                    }
                }
                File.WriteAllLines(op, opLines);
                rtb_file.Clear();
                rtb_file.Lines = opLines.ToArray();
                MessageBox.Show("Đã xuất file thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }
        private decimal Calculator(string cal)
        {
            cal = cal.Replace(" ", "");
            if (!(cal.Contains('+') || cal.Contains('-') || cal.Contains('*') || cal.Contains('/')))
            {
                if (decimal.TryParse(cal, out decimal result))
                    return result;
                throw new ArgumentException("Không phải là biểu thức hợp lệ");
            }
            List<decimal> num = new List<decimal>();
            List<char> operators = new List<char>();
            StringBuilder numBuilder = new StringBuilder();

            foreach (char c in cal)
            {
                if (char.IsDigit(c) || c == '.') numBuilder.Append(c);
                else if ("+-*/".Contains(c))
                {
                    if (numBuilder.Length == 0)
                        throw new ArgumentException("Lỗi thiếu toán hạng trước toán tử");
                    num.Add(decimal.Parse(numBuilder.ToString()));
                    numBuilder.Clear();
                    operators.Add(c);
                }
            }
            if (numBuilder.Length > 0)
                num.Add(decimal.Parse(numBuilder.ToString()));

            if (num.Count != operators.Count + 1)
                throw new ArgumentException("Số lượng toán hạng và toán tử không khớp");
            for (int j = 0; j < operators.Count; j++)
            {
                if (operators[j] == '*' || operators[j] == '/')
                {
                    decimal left = num[j];
                    decimal right = num[j + 1];
                    decimal res;

                    if (operators[j] == '*') res = left * right;
                    else
                    {
                        if (right == 0)
                            throw new DivideByZeroException("Lỗi chia cho 0");
                        res = left / right;
                    }
                    num[j] = res;
                    num.RemoveAt(j + 1);
                    operators.RemoveAt(j);
                    j--;
                }
            }
            decimal finalRes = num[0];
            for (int j = 0; j < operators.Count; j++)
            {
                if (operators[j] == '+')
                    finalRes += num[j + 1];
                else if (operators[j] == '-')
                    finalRes -= num[j + 1];
            }
            return finalRes;
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
