namespace Lab02
{
    partial class Bai1
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
            this.btn_doc = new System.Windows.Forms.Button();
            this.btn_ghi = new System.Windows.Forms.Button();
            this.rtb_file = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_doc
            // 
            this.btn_doc.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doc.Location = new System.Drawing.Point(84, 146);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Size = new System.Drawing.Size(117, 54);
            this.btn_doc.TabIndex = 0;
            this.btn_doc.Text = "Đọc File";
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // btn_ghi
            // 
            this.btn_ghi.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghi.Location = new System.Drawing.Point(84, 253);
            this.btn_ghi.Name = "btn_ghi";
            this.btn_ghi.Size = new System.Drawing.Size(117, 54);
            this.btn_ghi.TabIndex = 1;
            this.btn_ghi.Text = "Ghi File";
            this.btn_ghi.UseVisualStyleBackColor = true;
            this.btn_ghi.Click += new System.EventHandler(this.btn_ghi_Click);
            // 
            // rtb_file
            // 
            this.rtb_file.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_file.Location = new System.Drawing.Point(251, 33);
            this.rtb_file.Name = "rtb_file";
            this.rtb_file.Size = new System.Drawing.Size(500, 345);
            this.rtb_file.TabIndex = 2;
            this.rtb_file.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_file);
            this.Controls.Add(this.btn_ghi);
            this.Controls.Add(this.btn_doc);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Button btn_ghi;
        private System.Windows.Forms.RichTextBox rtb_file;
    }
}