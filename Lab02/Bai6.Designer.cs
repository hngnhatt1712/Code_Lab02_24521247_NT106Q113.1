namespace Lab02
{
    partial class Bai6
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
            this.pb_monan = new System.Windows.Forms.PictureBox();
            this.tb_ncc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_monan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_ncc = new System.Windows.Forms.ListView();
            this.lv_monan = new System.Windows.Forms.ListView();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_listncc = new System.Windows.Forms.Button();
            this.btn_listmonan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_monan)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_monan
            // 
            this.pb_monan.Location = new System.Drawing.Point(268, 215);
            this.pb_monan.Name = "pb_monan";
            this.pb_monan.Size = new System.Drawing.Size(479, 283);
            this.pb_monan.TabIndex = 22;
            this.pb_monan.TabStop = false;
            // 
            // tb_ncc
            // 
            this.tb_ncc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ncc.Location = new System.Drawing.Point(36, 364);
            this.tb_ncc.Name = "tb_ncc";
            this.tb_ncc.Size = new System.Drawing.Size(212, 27);
            this.tb_ncc.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Người Cung Cấp";
            // 
            // tb_monan
            // 
            this.tb_monan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_monan.Location = new System.Drawing.Point(36, 271);
            this.tb_monan.Name = "tb_monan";
            this.tb_monan.Size = new System.Drawing.Size(212, 27);
            this.tb_monan.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Món Ăn";
            // 
            // lv_ncc
            // 
            this.lv_ncc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ncc.HideSelection = false;
            this.lv_ncc.Location = new System.Drawing.Point(553, 62);
            this.lv_ncc.Name = "lv_ncc";
            this.lv_ncc.Size = new System.Drawing.Size(463, 137);
            this.lv_ncc.TabIndex = 17;
            this.lv_ncc.UseCompatibleStateImageBehavior = false;
            // 
            // lv_monan
            // 
            this.lv_monan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_monan.HideSelection = false;
            this.lv_monan.Location = new System.Drawing.Point(12, 62);
            this.lv_monan.Name = "lv_monan";
            this.lv_monan.Size = new System.Drawing.Size(508, 137);
            this.lv_monan.TabIndex = 16;
            this.lv_monan.UseCompatibleStateImageBehavior = false;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(36, 439);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(81, 41);
            this.btn_tim.TabIndex = 15;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(167, 439);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 39);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_listncc
            // 
            this.btn_listncc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listncc.Location = new System.Drawing.Point(665, 26);
            this.btn_listncc.Name = "btn_listncc";
            this.btn_listncc.Size = new System.Drawing.Size(205, 30);
            this.btn_listncc.TabIndex = 13;
            this.btn_listncc.Text = "DS Người Cung Cấp";
            this.btn_listncc.UseVisualStyleBackColor = true;
            this.btn_listncc.Click += new System.EventHandler(this.btn_listncc_Click);
            // 
            // btn_listmonan
            // 
            this.btn_listmonan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listmonan.Location = new System.Drawing.Point(140, 26);
            this.btn_listmonan.Name = "btn_listmonan";
            this.btn_listmonan.Size = new System.Drawing.Size(212, 27);
            this.btn_listmonan.TabIndex = 12;
            this.btn_listmonan.Text = "DS Món Ăn";
            this.btn_listmonan.UseVisualStyleBackColor = true;
            this.btn_listmonan.Click += new System.EventHandler(this.btn_listmonan_Click);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 509);
            this.Controls.Add(this.pb_monan);
            this.Controls.Add(this.tb_ncc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_monan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_ncc);
            this.Controls.Add(this.lv_monan);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_listncc);
            this.Controls.Add(this.btn_listmonan);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_monan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_monan;
        private System.Windows.Forms.TextBox tb_ncc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_monan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_ncc;
        private System.Windows.Forms.ListView lv_monan;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_listncc;
        private System.Windows.Forms.Button btn_listmonan;
    }
}