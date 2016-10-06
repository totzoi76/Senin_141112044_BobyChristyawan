using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime SetTahunAwal = new DateTime(2016, 1, 1);
            for (int i = SetTahunAwal.DayOfYear; i <=SetTahunAwal.DayOfYear; i++)
            {
                if (SetTahunAwal.DayOfWeek.ToString() == "Sunday" || SetTahunAwal.DayOfWeek.ToString() == "Saturday")
                {
                    monthCalendar1.AddBoldedDate(SetTahunAwal);
                    
                }

                SetTahunAwal = SetTahunAwal.AddDays(1);
            }
            DateTime TanggalLahir = new DateTime(1996, 6, 7);
            monthCalendar1.AddAnnuallyBoldedDate(TanggalLahir);
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if ((int)NuPBulan.Value == 0 || (int)NuPTanggal.Value == 0)
            {
                MessageBox.Show("Inputan Tidak Valid");

            }
            else
            {
                DateTime Tanggal = new DateTime(2016, (int)NuPBulan.Value, (int)NuPTanggal.Value);
                monthCalendar1.AddBoldedDate(Tanggal);
            }
            
        }

        private void NuPBulan_ValueChanged(object sender, EventArgs e)
        {
            if ((int)NuPBulan.Value == 1)
            { LblBulan.Text = "Januari"; }
            else if ((int)NuPBulan.Value == 2)
            { LblBulan.Text = "Februari"; }
            else if ((int)NuPBulan.Value == 3)
            { LblBulan.Text = "Maret"; }
            else if ((int)NuPBulan.Value == 4)
            { LblBulan.Text = "April"; }
            else if ((int)NuPBulan.Value == 5)
            { LblBulan.Text = "Mei"; }
            else if ((int)NuPBulan.Value == 6)
            { LblBulan.Text = "Juni"; }
            else if ((int)NuPBulan.Value == 7)
            { LblBulan.Text = "Juli"; }
            else if ((int)NuPBulan.Value == 8)
            { LblBulan.Text = "Agustus"; }
            else if ((int)NuPBulan.Value == 9)
            { LblBulan.Text = "September"; }
            else if ((int)NuPBulan.Value == 10)
            { LblBulan.Text = "Oktober"; }
            else if ((int)NuPBulan.Value == 11)
            { LblBulan.Text = "November"; }
            else if ((int)NuPBulan.Value == 12)
            { LblBulan.Text = "Desember"; }
            else
            { LblBulan.Text = "Bulan"; }
            NuPTanggal.Maximum = DateTime.DaysInMonth(2016, (int)NuPBulan.Value);
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DateTime Tanggal = new DateTime(2016, (int)NuPBulan.Value, (int)NuPTanggal.Value);
            monthCalendar1.RemoveBoldedDate(Tanggal);
        }

       
=======
            DateTime my = new DateTime(2016, 6, 7);
            monthCalendar1.AddAnnuallyBoldedDate(my);
            
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            int bln1=0;

            if (bln.Text == "Januari")
                bln1 = 1;
            else if (bln.Text == "Febuari")
                bln1 = 2;
            else if (bln.Text == "Maret")
                bln1 = 3;
            else if (bln.Text == "April")
                bln1 = 4;
            else if (bln.Text == "Mei")
                bln1 = 5;
            else if (bln.Text == "Juni")
                bln1 = 6;
            else if (bln.Text == "Juli")
                bln1 = 7;
            else if (bln.Text == "Agustus")
                bln1 = 8;
            else if (bln.Text == "September")
                bln1 = 9;
            else if (bln.Text == "Oktober")
                bln1 = 10;
            else if (bln.Text == "November")
                bln1 = 11;
            else if (bln.Text == "Desember")
                bln1 = 12;
            else
                bln1 = 0;
            DateTime my = new DateTime(2016, bln1, (int)tgl.Value);
            monthCalendar1.AddAnnuallyBoldedDate(my);
            
            
        }

        private void bln_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            int bln1 = 0;

            if (bln.Text == "Januari")
                bln1 = 1;
            else if (bln.Text == "Febuari")
                bln1 = 2;
            else if (bln.Text == "Maret")
                bln1 = 3;
            else if (bln.Text == "April")
                bln1 = 4;
            else if (bln.Text == "Mei")
                bln1 = 5;
            else if (bln.Text == "Juni")
                bln1 = 6;
            else if (bln.Text == "Juli")
                bln1 = 7;
            else if (bln.Text == "Agustus")
                bln1 = 8;
            else if (bln.Text == "September")
                bln1 = 9;
            else if (bln.Text == "Oktober")
                bln1 = 10;
            else if (bln.Text == "November")
                bln1 = 11;
            else if (bln.Text == "Desember")
                bln1 = 12;
            else
                bln1 = 0;
            DateTime mo = new DateTime(2016, bln1, (int)tgl.Value);
            monthCalendar1.RemoveAnnuallyBoldedDate(mo);
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
>>>>>>> 6b800d95021d81e0f2f0d810d2534d8ef36927f8
    }
}
