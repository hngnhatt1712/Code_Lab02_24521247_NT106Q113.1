using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lab02
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        [Serializable]
        public class SinhVien
        {
            public string HoTen { get; set; } = string.Empty;
            public int MSSV { get; set; }
            public string SDT { get; set; } = string.Empty;
            public float Diem1 { get; set; }
            public float Diem2 { get; set; }
            public float Diem3 { get; set; }
            public float DTB { get; set; }
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        int idx = -1;

        public bool KiemTraHopLe(SinhVien sv, out string loi)
        {
            loi = "";
            if (string.IsNullOrWhiteSpace(sv.HoTen) || string.IsNullOrWhiteSpace(sv.SDT))
            {
                loi = "Họ tên và SĐT không được để trống";
                return false;
            }
            if (sv.SDT.Length != 10 || sv.SDT[0] != '0' || !long.TryParse(sv.SDT, out long num))
            {
                loi = "Số điện thoại phải có 10 số và bắt đầu bằng 0";
                return false;
            }
            if (sv.MSSV.ToString().Length != 8 || sv.MSSV <= 0)
            {
                loi = "Mã số sinh viên phải có đúng 8 chữ số";
                return false;
            }
            if (sv.Diem1 < 0 || sv.Diem1 > 10 || sv.Diem2 < 0 || sv.Diem2 > 10 || sv.Diem3 < 0 || sv.Diem3 > 10)
            {
                loi = "Điểm các môn phải nằm trong khoảng 0 đến 10";
                return false;
            }
            return true;
        }
        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input4.txt"))
                {
                    MessageBox.Show("Không tìm thấy file input4.txt!", "Lỗi");
                    return;
                }
                using (FileStream fs = new FileStream("input4.txt", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    dsSV = (List<SinhVien>)formatter.Deserialize(fs);
                }

                if (dsSV.Count == 0)
                {
                    MessageBox.Show("File rỗng!", "Thông báo");
                    return;
                }
                foreach (var sv in dsSV)
                    sv.DTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3.0f;
                rtb_file.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- DANH SÁCH SINH VIÊN TỪ FILE ---");
                sb.AppendLine($"Tổng số: {dsSV.Count} sinh viên");
                sb.AppendLine("-----------------------------------");
                int stt = 1;
                foreach (var sv in dsSV)
                {
                    sb.AppendLine($"[{stt++}] Họ tên: {sv.HoTen}");
                    sb.AppendLine($"    MSSV: {sv.MSSV}");
                    sb.AppendLine($"    SĐT: {sv.SDT}");
                    sb.AppendLine($"    Điểm: {sv.Diem1}, {sv.Diem2}, {sv.Diem3}");
                    sb.AppendLine($"    ĐTB: {sv.DTB:0.00}");
                    sb.AppendLine("------------------------------");
                }
                rtb_file.Text = sb.ToString();
                idx = 0;
                HienThiSV(idx);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi đọc file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ghi_Click(object sender, EventArgs e)
        {
            if (dsSV.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sinh viên để ghi", "Thông báo");
                return;
            }
            try
            {
                using (FileStream fs = new FileStream("input4.txt", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, dsSV);
                }

                MessageBox.Show($"Đã ghi nhận sinh viên xuống file thành công!", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show($"Lỗi khi ghi file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void HienThiSV(int i)
        {
            if (dsSV == null || dsSV.Count == 0 || idx < 0 || idx >= dsSV.Count) return;
            var sv = dsSV[i];
            tb_name.Text = sv.HoTen;
            tb_id.Text = sv.MSSV.ToString();
            tb_sdt.Text = sv.SDT;
            tb_diem1.Text = sv.Diem1.ToString();
            tb_diem2.Text = sv.Diem2.ToString();
            tb_diem3.Text = sv.Diem3.ToString();
            tb_dtb.Text = sv.DTB.ToString("0.00");
            lb_stt.Text = $"{i + 1} / {dsSV.Count}";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (idx < dsSV.Count - 1)
            {
                idx++;
                HienThiSV(idx);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                idx--;
                HienThiSV(idx);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_id1.Text, out int mssv) || !float.TryParse(tb_d1.Text, out float d1) ||
                !float.TryParse(tb_d2.Text, out float d2) || !float.TryParse(tb_d3.Text, out float d3))
            {
                MessageBox.Show("Vui lòng nhập MSSV và điểm là các giá trị số hợp lệ", "Lỗi Nhập Liệu");
                return;
            }
            SinhVien sv = new SinhVien
            {
                HoTen = tb_name1.Text,
                MSSV = mssv,
                SDT= tb_sdt1.Text,
                Diem1 = d1,
                Diem2 = d2,
                Diem3 = d3
            };
            sv.DTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3.0f;
            if (KiemTraHopLe(sv, out string error))
            {
                dsSV.Add(sv);
                MessageBox.Show($"Đã thêm sinh viên", "Thành công");
                idx = dsSV.Count - 1;
                HienThiSV(idx);
            } else
            {
                MessageBox.Show($"Lỗi ràng buộc: {error}", "Lỗi");
            }
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
