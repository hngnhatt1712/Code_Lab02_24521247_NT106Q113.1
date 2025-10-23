namespace Lab02
{
    partial class Bai7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_file = new System.Windows.Forms.PictureBox();
            this.tv_file = new System.Windows.Forms.TreeView();
            this.rtb_file = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_file)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_file);
            this.groupBox1.Controls.Add(this.pb_file);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Content";
            // 
            // pb_file
            // 
            this.pb_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_file.Location = new System.Drawing.Point(3, 23);
            this.pb_file.Name = "pb_file";
            this.pb_file.Size = new System.Drawing.Size(721, 460);
            this.pb_file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_file.TabIndex = 0;
            this.pb_file.TabStop = false;
            // 
            // tv_file
            // 
            this.tv_file.Location = new System.Drawing.Point(13, 32);
            this.tv_file.Name = "tv_file";
            this.tv_file.Size = new System.Drawing.Size(263, 457);
            this.tv_file.TabIndex = 2;
            this.tv_file.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_file_BeforeExpand);
            this.tv_file.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_file_NodeMouseDoubleClick);
            // 
            // rtb_file
            // 
            this.rtb_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_file.Location = new System.Drawing.Point(3, 23);
            this.rtb_file.Name = "rtb_file";
            this.rtb_file.Size = new System.Drawing.Size(721, 460);
            this.rtb_file.TabIndex = 1;
            this.rtb_file.Text = "";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 510);
            this.Controls.Add(this.tv_file);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_file)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_file;
        private System.Windows.Forms.PictureBox pb_file;
        private System.Windows.Forms.RichTextBox rtb_file;
    }
}