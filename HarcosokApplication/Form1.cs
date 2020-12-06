using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = " ";
            sb.Database = "cs_harcosok";
            sb.CharacterSet = "utf8";
            
            conn = new MySqlConnection(sb.ToString());
            
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
                sql.CommandText = File.ReadAllText("tablak.sql");
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message,"Kapcsolodási HIBA");
                conn.Close();
                return;
            }
           
            Harcosok_feltolt();
            comboBox_feltolt();
             
        }


        private void Harcosok_feltolt()
        {
            listBox_harcosok.Items.Clear();
            sql.CommandText = "select id, nev, letrehozas from harcosok";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    listBox_harcosok.Items.Add(new Harcosok(dr.GetInt32("id"), dr.GetString("nev"),dr.GetDateTime("letrehozas")));
                }
            }
        }

        private void Kepessegek_feltolt()
        {
            listBox_kepessegek.Items.Clear();
            sql.CommandText = "select id, nev, leiras,harcosok_id from kepessegek";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
               while (dr.Read())
               {
                   listBox_kepessegek.Items.Add(new Kepessegek(dr.GetInt32("id"),dr.GetString("nev"),dr.GetString("leiras"),dr.GetInt32("harcosok_id")));
               }
            }
        }

        private void comboBox_feltolt() 
        {
            comboBox_hasznalo.Items.Clear();
            sql.CommandText = "select id,nev,letrehozas from harcosok";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                   comboBox_hasznalo.Items.Add(new Harcosok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDateTime("letrehozas")));
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_letrehoz_Click(object sender, EventArgs e)
        {
            if (textBox_hnev.Text == ((Harcosok)listBox_harcosok.SelectedItem).Nev)
            {
                MessageBox.Show("Ez a név már foglalt, kérem írjon be egy másikat.");
                textBox_hnev.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(textBox_hnev.Text))
            {
                MessageBox.Show("A név megadása kötelező");
                return;
            }
            string nev = textBox_hnev.Text;
            DateTime aktualisdatum = DateTime.Today;
            sql.CommandText = "insert into `harcosok`(`nev`,`letrehozas`) VALUES("+nev+","+aktualisdatum+")";
            listBox_harcosok.Refresh();
            comboBox_hasznalo.Refresh();
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_knev.Text))
            {
                MessageBox.Show("A név megadása kötelező");
                return;
            }
            
            string kepesseg =  textBox_knev.Text;
            int harcosId = ((Harcosok)comboBox_hasznalo.SelectedItem).Id;
            sql.CommandText = "insert into `kepessegek`(`nev`,`harcosok_id`) VALUES(" + kepesseg + "," + harcosId + ")";
        }

        private void listBox_kepessegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kepessegleiras = "";
            if (listBox_kepessegek.SelectedIndex > 0)
            {
                
            }
        }

        private void listBox_harcosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kepessegek_feltolt();
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            if (listBox_kepessegek.SelectedIndex<0)
            {
                MessageBox.Show("HIBA, válaszzon egy képességet !");
                listBox_kepessegek.Focus();
                return;
            }
            int kepessegId = ((Kepessegek)listBox_kepessegek.SelectedItem).Id;
            sql.CommandText="delete from `kepessegek` where `id` =" + kepessegId;
            try
            {
                sql.ExecuteNonQuery();
                MessageBox.Show("sikeres törlés!");
                listBox_kepessegek.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modosit_Click(object sender, EventArgs e)
        {
            if (listBox_kepessegek.SelectedIndex < 0)
            {
                MessageBox.Show("HIBA, válaszzon egy képességet !");
                listBox_kepessegek.Focus();
                return;
            }
            string kepessegNev = ((Kepessegek)listBox_kepessegek.SelectedItem).Nev;
            sql.CommandText = "update `kepessegek` set `leiras`='masik leiras' where `nev` = "+kepessegNev;
            try
            {
                sql.ExecuteNonQuery();
                MessageBox.Show("sikeres modosítas!");
                listBox_kepessegek.Refresh();
                richTextBox_kepessegLeiras.Refresh();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
