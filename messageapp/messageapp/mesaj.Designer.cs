
namespace messageapp
{
    partial class mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mesaj));
            this.Gonderbut = new System.Windows.Forms.Button();
            this.mesajbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CHAT = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mespanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconapp = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.yildizbut = new System.Windows.Forms.Button();
            this.temizlebut = new System.Windows.Forms.Button();
            this.dosyabut = new System.Windows.Forms.Button();
            this.galeribut = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gonderbut
            // 
            this.Gonderbut.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gonderbut.ForeColor = System.Drawing.Color.ForestGreen;
            this.Gonderbut.Location = new System.Drawing.Point(520, 343);
            this.Gonderbut.Name = "Gonderbut";
            this.Gonderbut.Size = new System.Drawing.Size(150, 63);
            this.Gonderbut.TabIndex = 1;
            this.Gonderbut.Text = " Gönder ";
            this.Gonderbut.UseVisualStyleBackColor = true;
            this.Gonderbut.Click += new System.EventHandler(this.Gonderbut_Click);
            // 
            // mesajbox
            // 
            this.mesajbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajbox.Location = new System.Drawing.Point(154, 343);
            this.mesajbox.Multiline = true;
            this.mesajbox.Name = "mesajbox";
            this.mesajbox.Size = new System.Drawing.Size(360, 63);
            this.mesajbox.TabIndex = 2;
            this.mesajbox.TextChanged += new System.EventHandler(this.Mesajbox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.CHAT);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 43);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // CHAT
            // 
            this.CHAT.AutoSize = true;
            this.CHAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CHAT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CHAT.Location = new System.Drawing.Point(285, 4);
            this.CHAT.Name = "CHAT";
            this.CHAT.Size = new System.Drawing.Size(111, 39);
            this.CHAT.TabIndex = 1;
            this.CHAT.Text = "CHAT";
            this.CHAT.Click += new System.EventHandler(this.CHAT_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // mespanel
            // 
            this.mespanel.AutoScroll = true;
            this.mespanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mespanel.Location = new System.Drawing.Point(154, 48);
            this.mespanel.Name = "mespanel";
            this.mespanel.Size = new System.Drawing.Size(515, 289);
            this.mespanel.TabIndex = 3;
            this.mespanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mespanel_Paint_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iconapp);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.yildizbut);
            this.panel1.Controls.Add(this.temizlebut);
            this.panel1.Controls.Add(this.dosyabut);
            this.panel1.Controls.Add(this.galeribut);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 358);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // iconapp
            // 
            this.iconapp.Enabled = false;
            this.iconapp.Image = global::messageapp.Properties.Resources.mesaj_icon;
            this.iconapp.Location = new System.Drawing.Point(3, 3);
            this.iconapp.Name = "iconapp";
            this.iconapp.Size = new System.Drawing.Size(142, 93);
            this.iconapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconapp.TabIndex = 8;
            this.iconapp.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Image = global::messageapp.Properties.Resources.galeri_icon;
            this.pictureBox4.Location = new System.Drawing.Point(10, 107);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Image = global::messageapp.Properties.Resources.cop_icon;
            this.pictureBox2.Location = new System.Drawing.Point(10, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // yildizbut
            // 
            this.yildizbut.BackColor = System.Drawing.Color.Teal;
            this.yildizbut.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildizbut.ForeColor = System.Drawing.SystemColors.Control;
            this.yildizbut.Location = new System.Drawing.Point(3, 293);
            this.yildizbut.Name = "yildizbut";
            this.yildizbut.Size = new System.Drawing.Size(142, 60);
            this.yildizbut.TabIndex = 3;
            this.yildizbut.Text = "     Yıldızlı Mesajlar";
            this.yildizbut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yildizbut.UseVisualStyleBackColor = false;
            this.yildizbut.Click += new System.EventHandler(this.Button4_Click);
            // 
            // temizlebut
            // 
            this.temizlebut.BackColor = System.Drawing.Color.Teal;
            this.temizlebut.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizlebut.ForeColor = System.Drawing.SystemColors.Control;
            this.temizlebut.Location = new System.Drawing.Point(3, 227);
            this.temizlebut.Name = "temizlebut";
            this.temizlebut.Size = new System.Drawing.Size(142, 60);
            this.temizlebut.TabIndex = 2;
            this.temizlebut.Text = "Temizle";
            this.temizlebut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temizlebut.UseVisualStyleBackColor = false;
            this.temizlebut.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // dosyabut
            // 
            this.dosyabut.BackColor = System.Drawing.Color.Teal;
            this.dosyabut.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyabut.ForeColor = System.Drawing.SystemColors.Control;
            this.dosyabut.Location = new System.Drawing.Point(3, 161);
            this.dosyabut.Name = "dosyabut";
            this.dosyabut.Size = new System.Drawing.Size(142, 60);
            this.dosyabut.TabIndex = 1;
            this.dosyabut.Text = "Dosya";
            this.dosyabut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dosyabut.UseVisualStyleBackColor = false;
            this.dosyabut.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // galeribut
            // 
            this.galeribut.BackColor = System.Drawing.Color.Teal;
            this.galeribut.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galeribut.ForeColor = System.Drawing.SystemColors.Control;
            this.galeribut.Location = new System.Drawing.Point(3, 95);
            this.galeribut.Name = "galeribut";
            this.galeribut.Size = new System.Drawing.Size(142, 60);
            this.galeribut.TabIndex = 0;
            this.galeribut.Text = "Galeri";
            this.galeribut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.galeribut.UseVisualStyleBackColor = false;
            this.galeribut.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // mesaj
            // 
            this.AcceptButton = this.Gonderbut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mespanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mesajbox);
            this.Controls.Add(this.Gonderbut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mesaj";
            this.Load += new System.EventHandler(this.Mesaj_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Gonderbut;
        private System.Windows.Forms.TextBox mesajbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CHAT;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel mespanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yildizbut;
        private System.Windows.Forms.Button temizlebut;
        private System.Windows.Forms.Button dosyabut;
        private System.Windows.Forms.Button galeribut;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconapp;
    }
}