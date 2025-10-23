using Microsoft.Data.Sqlite;
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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            DataSQLite.InitializeDatabase();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            SetupListViews();
            ListMonAn();
            ListNCC();
        }
        private void SetupListViews()
        {

            lv_monan.View = View.Details;
            lv_monan.Columns.Clear(); 
            lv_monan.Columns.Add("ID", 50);
            lv_monan.Columns.Add("Tên Món Ăn", 180);
            lv_monan.Columns.Add("Hình Ảnh", 120);
            lv_monan.Columns.Add("ID NCC", 60);
            lv_monan.Columns.Add("Tên NCC", 150);
            lv_ncc.View = View.Details; 
            lv_ncc.Columns.Clear(); 
            lv_ncc.Columns.Add("ID", 50);
            lv_ncc.Columns.Add("Họ Tên", 180);
            lv_ncc.Columns.Add("Quyền Hạn", 120);
        }
        private void ListMonAn()
        {
            using (var connection = new SqliteConnection(DataSQLite.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT m.IDMA, m.TenMonAn, m.HinhAnh, m.IDNCC, n.HoTen
                        FROM MonAn m
                        JOIN NguoiDung n ON m.IDNCC = n.IDNCC";

                    var cmd = new SqliteCommand(query, connection);
                    using (var reader = cmd.ExecuteReader())
                    {
                        lv_monan.Items.Clear();
                        while (reader.Read())
                        {
                            var listItem = new ListViewItem(reader.GetInt64(0).ToString()); 
                            listItem.SubItems.Add(reader.GetString(1));
                            listItem.SubItems.Add(reader.GetString(2));
                            listItem.SubItems.Add(reader.GetInt64(3).ToString()); 
                            listItem.SubItems.Add(reader.GetString(4));
                            lv_monan.Items.Add(listItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi tải danh sách món ăn: {ex.Message}", "Lỗi");
                }
            }
        }

        private void ListNCC()
        {
            using (var connection = new SqliteConnection(DataSQLite.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqliteCommand("SELECT IDNCC, HoTen, QuyenHan FROM NguoiDung", connection);
                    using (var reader = cmd.ExecuteReader())
                    {
                        lv_ncc.Items.Clear();
                        while (reader.Read())
                        {
                            var listItem = new ListViewItem(reader.GetInt64(0).ToString()); 
                            listItem.SubItems.Add(reader.GetString(1));
                            listItem.SubItems.Add(reader.GetString(2)); 
                            lv_ncc.Items.Add(listItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi tải danh sách người đóng góp: {ex.Message}", "Lỗi");
                }
            }
        }

        private readonly Random random = new Random();

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (lv_monan.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn rỗng", "Thông báo");
                return;
            }
            int idx = random.Next(0, lv_monan.Items.Count);
            ListViewItem selectedItem = lv_monan.Items[idx];
            string tenMonAn = selectedItem.SubItems[1].Text;
            string hinhAnhPath = selectedItem.SubItems[2].Text;
            string tenNCC = selectedItem.SubItems[4].Text;
            tb_monan.Text = tenMonAn;
            tb_ncc.Text = tenNCC;

            try
            {
                string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                string fullPath = Path.Combine(imageFolder, hinhAnhPath.Trim());

                if (File.Exists(fullPath))
                {
                    pb_monan.Image = Image.FromFile(fullPath);
                }
                else
                {
                    pb_monan.Image = null;
                    MessageBox.Show($"Không tìm thấy file ảnh tại: {fullPath}", "Cảnh báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hiển thị ảnh: {ex.Message}", "Lỗi");
            }
        }

        private void btn_listmonan_Click(object sender, EventArgs e)
        {
            ListMonAn();
        }

        private void btn_listncc_Click(object sender, EventArgs e)
        {
            ListNCC();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
