namespace Lab02
{
    partial class Bai2
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
            this.rtb_file = new System.Windows.Forms.RichTextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_line = new System.Windows.Forms.TextBox();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.tb_character = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_file
            // 
            this.rtb_file.Location = new System.Drawing.Point(361, 21);
            this.rtb_file.Name = "rtb_file";
            this.rtb_file.Size = new System.Drawing.Size(416, 407);
            this.rtb_file.TabIndex = 0;
            this.rtb_file.Text = "";
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(12, 21);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(322, 28);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Đọc từ File";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên File";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(91, 67);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(243, 29);
            this.tb_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kích cỡ";
            // 
            // tb_size
            // 
            this.tb_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_size.Location = new System.Drawing.Point(91, 122);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(243, 29);
            this.tb_size.TabIndex = 5;
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(91, 179);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(243, 29);
            this.tb_url.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số dòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số kí tự";
            // 
            // tb_line
            // 
            this.tb_line.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_line.Location = new System.Drawing.Point(91, 234);
            this.tb_line.Name = "tb_line";
            this.tb_line.Size = new System.Drawing.Size(243, 29);
            this.tb_line.TabIndex = 11;
            // 
            // tb_word
            // 
            this.tb_word.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_word.Location = new System.Drawing.Point(91, 291);
            this.tb_word.Name = "tb_word";
            this.tb_word.Size = new System.Drawing.Size(243, 29);
            this.tb_word.TabIndex = 12;
            // 
            // tb_character
            // 
            this.tb_character.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_character.Location = new System.Drawing.Point(91, 345);
            this.tb_character.Name = "tb_character";
            this.tb_character.Size = new System.Drawing.Size(243, 29);
            this.tb_character.TabIndex = 13;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(11, 400);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(322, 28);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.tb_character);
            this.Controls.Add(this.tb_word);
            this.Controls.Add(this.tb_line);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.rtb_file);
            this.Name = "Bai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_file;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_line;
        private System.Windows.Forms.TextBox tb_word;
        private System.Windows.Forms.TextBox tb_character;
        private System.Windows.Forms.Button btn_thoat;
    }
}