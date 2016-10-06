namespace Latihan_2_1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
<<<<<<< HEAD
            this.LblTanggal = new System.Windows.Forms.Label();
            this.LblBulan = new System.Windows.Forms.Label();
            this.NuPTanggal = new System.Windows.Forms.NumericUpDown();
            this.NuPBulan = new System.Windows.Forms.NumericUpDown();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NuPTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuPBulan)).BeginInit();
=======
            this.tgl = new System.Windows.Forms.NumericUpDown();
            this.bln = new System.Windows.Forms.ComboBox();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tgl)).BeginInit();
>>>>>>> 6b800d95021d81e0f2f0d810d2534d8ef36927f8
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
<<<<<<< HEAD
            this.monthCalendar1.Location = new System.Drawing.Point(10, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 4;
            this.monthCalendar1.TabIndex = 4;
            // 
            // LblTanggal
            // 
            this.LblTanggal.AutoSize = true;
            this.LblTanggal.Location = new System.Drawing.Point(12, 14);
            this.LblTanggal.Name = "LblTanggal";
            this.LblTanggal.Size = new System.Drawing.Size(52, 13);
            this.LblTanggal.TabIndex = 5;
            this.LblTanggal.Text = "Tanggal :";
            // 
            // LblBulan
            // 
            this.LblBulan.AutoSize = true;
            this.LblBulan.Location = new System.Drawing.Point(134, 12);
            this.LblBulan.Name = "LblBulan";
            this.LblBulan.Size = new System.Drawing.Size(43, 13);
            this.LblBulan.TabIndex = 6;
            this.LblBulan.Text = "Bulan  :";
            // 
            // NuPTanggal
            // 
            this.NuPTanggal.Location = new System.Drawing.Point(70, 14);
            this.NuPTanggal.Maximum = new decimal(new int[] {
=======
            this.monthCalendar1.Location = new System.Drawing.Point(28, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(91, 6);
            this.tgl.Maximum = new decimal(new int[] {
>>>>>>> 6b800d95021d81e0f2f0d810d2534d8ef36927f8
            31,
            0,
            0,
            0});
<<<<<<< HEAD
            this.NuPTanggal.Name = "NuPTanggal";
            this.NuPTanggal.Size = new System.Drawing.Size(39, 20);
            this.NuPTanggal.TabIndex = 7;
            // 
            // NuPBulan
            // 
            this.NuPBulan.Location = new System.Drawing.Point(183, 14);
            this.NuPBulan.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NuPBulan.Name = "NuPBulan";
            this.NuPBulan.Size = new System.Drawing.Size(39, 20);
            this.NuPBulan.TabIndex = 8;
            this.NuPBulan.ValueChanged += new System.EventHandler(this.NuPBulan_ValueChanged);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(253, 7);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(96, 23);
            this.BtnTambah.TabIndex = 9;
            this.BtnTambah.Text = "Add Libur";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(253, 36);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(96, 23);
            this.BtnHapus.TabIndex = 10;
            this.BtnHapus.Text = "Delete Libur";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
=======
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(121, 20);
            this.tgl.TabIndex = 1;
            // 
            // bln
            // 
            this.bln.FormattingEnabled = true;
            this.bln.Items.AddRange(new object[] {
            "Januari",
            "Febuari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.bln.Location = new System.Drawing.Point(91, 32);
            this.bln.Name = "bln";
            this.bln.Size = new System.Drawing.Size(121, 21);
            this.bln.TabIndex = 2;
            this.bln.SelectedIndexChanged += new System.EventHandler(this.bln_SelectedIndexChanged);
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(277, 9);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 23);
            this.tambah.TabIndex = 3;
            this.tambah.Text = "Add";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(277, 38);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 4;
            this.hapus.Text = "Delete";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bulan";
>>>>>>> 6b800d95021d81e0f2f0d810d2534d8ef36927f8
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(479, 400);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.NuPBulan);
            this.Controls.Add(this.NuPTanggal);
            this.Controls.Add(this.LblBulan);
            this.Controls.Add(this.LblTanggal);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NuPTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuPBulan)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(548, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.bln);
            this.Controls.Add(this.tgl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tgl)).EndInit();
>>>>>>> 6b800d95021d81e0f2f0d810d2534d8ef36927f8
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
<<<<<<< HEAD
        private System.Windows.Forms.Label LblTanggal;
        private System.Windows.Forms.Label LblBulan;
        private System.Windows.Forms.NumericUpDown NuPTanggal;
        private System.Windows.Forms.NumericUpDown NuPBulan;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnHapus;
=======
        private System.Windows.Forms.NumericUpDown tgl;
        private System.Windows.Forms.ComboBox bln;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
>>>>>>> 6b800d95021d81e0f2f0d810d2534d8ef36927f8
    }
}

