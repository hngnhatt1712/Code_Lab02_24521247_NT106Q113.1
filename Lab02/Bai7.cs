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
using static System.Windows.Forms.LinkLabel;

namespace Lab02
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo odia in DriveInfo.GetDrives())
            {
                if (!odia.IsReady) continue;

                TreeNode node = new TreeNode(odia.Name);
                node.Tag = odia.RootDirectory.FullName;
                node.Nodes.Add("...");
                tv_file.Nodes.Add(node);
            }
        }

        private void tv_file_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode nodeOpen = e.Node;
            string link = nodeOpen.Tag.ToString();
            nodeOpen.Nodes.Clear();
            try
            {
                foreach (string tm in Directory.GetDirectories(link))
                {
                    TreeNode n = new TreeNode(Path.GetFileName(tm));
                    n.Tag = tm;
                    n.Nodes.Add("...");
                    nodeOpen.Nodes.Add(n);
                }
                foreach (string tep in Directory.GetFiles(link))
                {
                    TreeNode n = new TreeNode(Path.GetFileName(tep));
                    n.Tag = tep;
                    nodeOpen.Nodes.Add(n);
                }
            }
            catch (Exception)
            {
            }
        }

        private void tv_file_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            if (Directory.Exists(path))
            {
                e.Node.Expand();
            }
            else if (File.Exists(path))
            {
                try
                {
                    string ext = Path.GetExtension(path).ToLower();
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                    {
                        rtb_file.Visible = false; 
                        pb_file.Visible = true;  
                        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        {
                            pb_file.Image = Image.FromStream(fs);
                        }
                    }
                    else if (ext == ".txt" || ext == ".ini" || ext == ".log" || ext == ".cs" || ext == ".xml")
                    {
                        pb_file.Visible = false; 
                        pb_file.Image = null;   
                        rtb_file.Visible = true; 
                        rtb_file.Text = File.ReadAllText(path);
                    }
                    else
                    {
                        pb_file.Visible = false; 
                        rtb_file.Visible = true;
                        pb_file.Image = null;
                        rtb_file.Text = $"Không hỗ trợ xem trước cho file: {Path.GetFileName(path)}";
                    }
                }
                catch (Exception ex)
                {
                    pb_file.Visible = false;
                    rtb_file.Visible = true;
                    rtb_file.Text = $"Lỗi khi đọc file: {ex.Message}";
                }
            }
        }
    }
}
