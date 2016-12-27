using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class Regcust : Form
    {
        
        public Regcust()
        {
            InitializeComponent();
        }

        

        private void Regcust_Load(object sender, EventArgs e)
        {
            FormAwal form = (FormAwal)MdiParent;
            conn = new MySqlConnection(myConnectionString);
        }


        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            FormAwal form = (FormAwal)MdiParent;
            //pictureBox1.Show();
            form.Show();
            this.Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            String NoCus = TxtNoCus.Text;
            String NamCus = TxtNamCus.Text;
            String Almt = TxtAlmt.Text;
            String NoHp = TxtNoHp.Text;
            String Emil = TxtEmil.Text;

            if (isNumber(TxtNoCus.Text) == -1)
            {
                MessageBox.Show("Nomor Customer Harus Angka !");
                NoCus = "";
                return;
            }
            else if (TxtNamCus.Text == "")
            {
                MessageBox.Show("Nama Customer Harus diisi");
                NamCus = "";
                return;
            }
            else if (TxtAlmt.Text == "")
            {
                MessageBox.Show("Alamat Harus Diisi!");
                return;
            }

            else if (isNumber(NoCus.Text) == -1)
            {
                MessageBox.Show("Nomor HP Harus Angka!");
                NoCus = "";
                return;
            }

            else if (TxtEmil.Text == "")
            {
                MessageBox.Show("Email Harus Diisi");
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrls in this.Controlss)
            {
                if (ctrls is TextBox)
                {
                    ctrls.Text = "";
                }
            }
        }
    }
 }
