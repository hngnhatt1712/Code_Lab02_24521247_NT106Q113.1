using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Lab02
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            cbb_phim.Items.AddRange(phims.Select(m => m.Ten).ToArray());
            this.cbb_phim.SelectedIndexChanged += new System.EventHandler(this.cbb_phim_SelectedIndexChanged);
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            DocFile();
            TaoGhe();
            if (cbb_phim.Items.Count > 0)
            {
                cbb_phim.SelectedIndex = 0;
            }
        }
        public class Phim
        {
            public string Ten { get; set; }
            public double Gia { get; set; }
            public List<int> Phong { get; set; }
            public int SoVeBan { get; set; } = 0;
            public double DoanhThu { get; set; } = 0;
            public int SoVeTon => TongSucChua - SoVeBan;
            public double TiLeBan => TongSucChua == 0 ? 0 : SoVeBan * 100.0 / TongSucChua;
            public int TongSucChua => Phong.Count * tongGhe;
        }

        private List<Phim> phims = new List<Phim>
        {
            new Phim {Ten = "Đào, phở và piano", Gia = 45000, Phong = new List<int>{1, 2, 3 }},
            new Phim {Ten = "Mai", Gia = 100000, Phong = new List<int> {2, 3}},
            new Phim {Ten = "Gặp lại chị bầu", Gia = 70000, Phong = new List<int>{1}},
            new Phim {Ten = "Tarot", Gia = 90000, Phong = new List<int>{3}}
        };
        public enum LoaiGhe { Vot, Thuong, VIP }
        private const int tongGhe = 15;
        private HashSet<string> gheDaBan = new HashSet<string>();

        private Dictionary<string, LoaiGhe> seatTypeMap = new Dictionary<string, LoaiGhe>
        {
            {"A1", LoaiGhe.Vot}, {"A5", LoaiGhe.Vot}, {"C1", LoaiGhe.Vot}, {"C5", LoaiGhe.Vot},
            {"A2", LoaiGhe.Thuong}, {"A3", LoaiGhe.Thuong}, {"A4", LoaiGhe.Thuong},
            {"C2", LoaiGhe.Thuong}, {"C3", LoaiGhe.Thuong}, {"C4", LoaiGhe.Thuong},
            {"B2", LoaiGhe.VIP}, {"B3", LoaiGhe.VIP}, {"B4", LoaiGhe.VIP}
        };

        private void DocFile(string file = "input5.txt")
        {
            try
            {
                string[] lines = File.ReadAllLines(file).Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();
                if (lines.Length % 3 != 0)
                {
                    MessageBox.Show("Lỗi định dạng", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 0; i < lines.Length; i += 3)
                {
                    if (i + 2 >= lines.Length) break;

                    string ten = lines[i].Trim();
                    string gia = lines[i + 1].Trim();
                    string phong = lines[i + 2].Trim();

                    if (!long.TryParse(gia, out long giaVe) || giaVe <= 0) continue;
                    List<int> phongList = new List<int>();
                    string[] phongParts = phong.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string p in phongParts)
                    {
                        if (int.TryParse(p.Trim(), out int roomNum) && roomNum > 0)
                        {
                            phongList.Add(roomNum);
                        }
                    }

                    if (phongList.Any())
                    {
                        phims.Add(new Phim
                        {
                            Ten = ten,
                            Gia = giaVe,
                            Phong = phongList.Distinct().ToList()
                        });
                    }
                }
                if (!phims.Any())
                {
                    MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Lỗi khi đọc file", "Lỗi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbb_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_phong.Items.Clear();
            Phim phim = phims[cbb_phim.SelectedIndex];
            Console.WriteLine(cbb_phim.SelectedIndex);
            foreach (int p in phim.Phong)
            {
                cbb_phong.Items.Add(p.ToString());
            }
            if (cbb_phong.Items.Count > 0)
                cbb_phong.SelectedIndex = 0;
        }
        private void TaoGhe()
        {
            pn_ghe.Controls.Clear();
            string[] hang = { "A", "B", "C" };
            int cot = 5;
            int x = 10, y = 10;
            int dx = 60, dy = 40;

            for (int i = 0; i < hang.Length; i++)
            {
                for (int j = 1; j <= cot; j++)
                {
                    string tenGhe = hang[i] + j.ToString();
                    CheckBox cb = new CheckBox();
                    cb.Text = tenGhe;
                    cb.Name = tenGhe;
                    cb.Width = 50;
                    cb.Location = new System.Drawing.Point(x + (j - 1) * dx, y + i * dy);
                    pn_ghe.Controls.Add(cb);
                }
            }
        }
        private void btn_mua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ten.Text) || cbb_phim.SelectedIndex < 0 || cbb_phong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu");
                return;
            }
            var phim = phims[cbb_phim.SelectedIndex];
            var chonGhe = pn_ghe.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text).ToList();

            if (!chonGhe.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            var gheTrung = chonGhe.Where(g => gheDaBan.Contains(g)).ToList();
            if (gheTrung.Any())
            {
                MessageBox.Show($"Ghế đã được bán", "Lỗi Mua Vé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double TinhGiaGhe(string ghe)
            {
                var loai = seatTypeMap.ContainsKey(ghe) ? seatTypeMap[ghe] : LoaiGhe.Thuong;
                switch (loai)
                {
                    case LoaiGhe.VIP:
                        return phim.Gia * 2;
                    case LoaiGhe.Thuong:
                        return phim.Gia;
                    case LoaiGhe.Vot:
                        return phim.Gia / 4;
                    default:
                        return phim.Gia;
                }
            }
            double tong = 0;
            foreach (var ghe in chonGhe)
            {
                tong += TinhGiaGhe(ghe);
                phim.SoVeBan++;
                phim.DoanhThu += TinhGiaGhe(ghe);
                var cb = pn_ghe.Controls.OfType<CheckBox>().FirstOrDefault(x => x.Text == ghe);
                gheDaBan.Add(ghe);
                if (cb != null)
                {
                    cb.Enabled = false;
                    cb.Checked = false;
                }
            }
            MessageBox.Show($"Khách hàng: {tb_ten.Text}\n" + $"Phim: {phim.Ten}\n" +
                $"Phòng: {cbb_phong.SelectedItem}\n" + $"Ghế: {string.Join(", ", chonGhe)}\n" +
                $"Tổng tiền: {tong:N0} VND", "Mua vé thành công!"
            );
        }

        private async void btn_xuat_Click(object sender, EventArgs e)
        {
            prb_xuat.Visible = true;
            prb_xuat.Minimum = 0;
            prb_xuat.Maximum = phims.Count;
            btn_xuat.Enabled = false;
            var result = await Task.Run(() =>
            {
                var ketQuaSapXep = phims.OrderByDescending(p => p.DoanhThu).ToList();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- THỐNG KÊ DOANH THU PHÒNG VÉ ---");

                string header = string.Format("{0,-5} | {1,-25} | {2,-10} | {3,-10} | {4,-10} | {5,-20}",
                                    "Hạng", "Tên Phim", "Vé Bán", "Vé Tồn", "Tỉ lệ (%)", "Doanh Thu");
                sb.AppendLine(header);
                sb.AppendLine("---------------------------------------------------------------------------------------------------");

                for (int i = 0; i < ketQuaSapXep.Count; i++)
                {
                    var phim = ketQuaSapXep[i];
                    int hang = i + 1;
                    sb.AppendLine(string.Format("{0,-5} | {1,-25} | {2,-10} | {3,-10} | {4,-10:F2} | {5,-20:N0} VND",
                                                hang,
                                                phim.Ten,
                                                phim.SoVeBan,
                                                phim.SoVeTon,
                                                phim.TiLeBan,
                                                phim.DoanhThu));
                    this.Invoke((MethodInvoker)delegate
                    {
                        prb_xuat.Value = i + 1;
                    });
                }
                return sb.ToString();
            });
            MessageBox.Show(result, "Báo Cáo Thống Kê Doanh Thu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prb_xuat.Visible = false;
            btn_xuat.Enabled = true;
        }
    }
}
