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
    public partial class FormAwal : Form
    {
        //koneksi
        String myConnectionString = "Server=localhost;Database=database_project;Uid=root;Pwd='';";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public FormAwal()
        {
            InitializeComponent();
        }
        FormRegistrationBarang FormRegis;
        FormAwal FormUtama;
        Regcust formcus;
        

        private void FormAwal_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(myConnectionString);
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            //FormRegistrationBarang form = new FormRegistrationBarang();
            //form.ShowDialog();
            if (FormRegis == null || !FormRegis.IsHandleCreated)
            {
                FormRegis = new FormRegistrationBarang();
                FormRegis.MdiParent = this;
                FormRegis.Show();
                //pictureBox1.Hide();
                //FormRegis.Show();
                
                
            }
            else
            {
                FormRegis.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            if (formcus == null || !formcus.IsHandleCreated)
            {
                formcus = new Regcust();
                formcus.MdiParent = this;
                formcus.Show();
                //pictureBox1.Hide();
                //FormRegis.Show();


            }
            else
            {
                formcus.Show();
            }
        }
    }
}
