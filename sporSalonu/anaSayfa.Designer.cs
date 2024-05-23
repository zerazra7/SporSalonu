namespace yazilim_proje2
{
    partial class anaSayfa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.odemebtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.uyebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::yazilim_proje2.Properties.Resources._1249959543;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 793);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // odemebtn
            // 
            this.odemebtn.BackColor = System.Drawing.Color.Azure;
            this.odemebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemebtn.Location = new System.Drawing.Point(25, 211);
            this.odemebtn.Name = "odemebtn";
            this.odemebtn.Size = new System.Drawing.Size(200, 59);
            this.odemebtn.TabIndex = 1;
            this.odemebtn.Text = "Ödeme";
            this.odemebtn.UseVisualStyleBackColor = false;
            this.odemebtn.Click += new System.EventHandler(this.odemebtn_Click);
            this.odemebtn.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.odemebtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // guncellebtn
            // 
            this.guncellebtn.BackColor = System.Drawing.Color.Azure;
            this.guncellebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncellebtn.Location = new System.Drawing.Point(25, 81);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(200, 59);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "Güncelle/Sil";
            this.guncellebtn.UseVisualStyleBackColor = false;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            this.guncellebtn.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.guncellebtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // uyebtn
            // 
            this.uyebtn.BackColor = System.Drawing.Color.Azure;
            this.uyebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyebtn.Location = new System.Drawing.Point(25, 16);
            this.uyebtn.Name = "uyebtn";
            this.uyebtn.Size = new System.Drawing.Size(200, 59);
            this.uyebtn.TabIndex = 4;
            this.uyebtn.Text = "Üye ekle";
            this.uyebtn.UseVisualStyleBackColor = false;
            this.uyebtn.Click += new System.EventHandler(this.uyebtn_Click);
            this.uyebtn.MouseHover += new System.EventHandler(this.button4_MouseHover);
            this.uyebtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.uyebtn);
            this.panel1.Controls.Add(this.odemebtn);
            this.panel1.Controls.Add(this.guncellebtn);
            this.panel1.Location = new System.Drawing.Point(910, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 287);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(25, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Üye listesi\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "anaSayfa";
            this.Text = "anaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button odemebtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button uyebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}