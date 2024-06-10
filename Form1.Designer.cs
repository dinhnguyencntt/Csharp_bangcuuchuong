namespace Csharp_bangcuuchuong
{
    partial class Form1
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtso
            // 
            this.txtso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso.Location = new System.Drawing.Point(52, 163);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(360, 47);
            this.txtso.TabIndex = 0;
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(52, 257);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(679, 160);
            this.lbsketqua.TabIndex = 1;
            this.lbsketqua.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn muốn hiển thị bảng cửu chương mấy?";
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(551, 147);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(180, 73);
            this.btnxem.TabIndex = 4;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.txtso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.ListBox lbsketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxem;
    }
}

