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

namespace foldrajz
{
    public partial class Form_Main : Form
    {
        public static string connStr = "server=localhost;user=root;database=foldrajz";
        MySqlConnection conn = new MySqlConnection(connStr);
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mi MADAGASZKÁR fővárosa?");
            conn.Open();
            string lekerdezes = "SELECT fovaros FROM orszagok WHERE orszag = 'Madagaszkár'; ";
            MySqlCommand feladat1 = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr1 = feladat1.ExecuteReader();
            while (rdr1.Read())
            {
                Col1.Items.Add(rdr1[0]);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik ország fővárosa OUAGADOUGOU?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE fovaros = 'OUAGADOUGOU'; ";
            MySqlCommand feladat1 = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr1 = feladat1.ExecuteReader();
            while (rdr1.Read())
            {
                Col1.Items.Add(rdr1[0]);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik ország autójele a TT?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE autojel = 'TT'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik ország pénzének jele az SGD?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE penzjel = 'SGD';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik ország nemzetközi telefon-hívószáma a 61?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE telefon = '61';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mekkora területű Monaco?");
            conn.Open();
            string lekerdezes = "SELECT terulet FROM orszagok WHERE orszag = 'Monaco';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hányan laknak Máltán?");
            conn.Open();
            string lekerdezes = "SELECT nepesseg * 1000 AS népesség FROM orszagok WHERE orszag = 'Málta';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi Japán népsűrűsége?");
            conn.Open();
            string lekerdezes = "SELECT (nepesseg * 1000 / terulet) AS népsűrűség FROM orszagok WHERE orszag = 'Japán'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány lakosa van a Földnek?");
            conn.Open();
            string lekerdezes = "SELECT SUM(nepesseg * 1000) AS összlakos FROM orszagok;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi az országok területe összesen?");
            conn.Open();
            string lekerdezes = "SELECT SUM(terulet) AS összterület FROM orszagok;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi az országok átlagos népessége?");
            conn.Open();
            string lekerdezes = "SELECT AVG(nepesseg * 1000) AS átlaglakos FROM orszagok;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi az országok átlagos területe?");
            conn.Open();
            string lekerdezes = "SELECT AVG(terulet) AS átlagterület FROM orszagok;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi a Föld népsűrűsége?");
            conn.Open();
            string lekerdezes = "SELECT (SUM(nepesseg * 1000) / SUM(terulet)) AS népsűrűség FROM orszagok; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány 1.000.000 km2-nél nagyobb területű ország van?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE terulet > 1000000; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány 100 km2-nél kisebb területű ország van?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE terulet< 100;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány 20.000 főnél kevesebb lakosú ország van?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE nepesseg *1000 < 20000; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány országra igaz, hogy területe kisebb 100 km2-nél, vagy pedig a lakossága kevesebb 20.000 főnél?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE nepesseg *1000 < 20000 OR terulet< 100; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány ország területe 50.000 és 150.000 km2 közötti?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE terulet BETWEEN 50000 AND 150000; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány ország lakossága 8 és 12 millió közötti?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM `orszagok` WHERE nepesseg *1000 BETWEEN 8000000 AND 12000000; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely fővárosok népesebbek 20 millió főnél?");
            conn.Open();
            string lekerdezes = "SELECT fovaros FROM `orszagok` WHERE nepesseg *1000 > 20000000; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely országok népsűrűsége nagyobb 500 fő / km2 - nél?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE(nepesseg * 1000) / terulet > 500; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány ország államformája köztársaság?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmény FROM orszagok WHERE allamforma = 'köztársaság'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely országok pénzneme a kelet-karib dollár?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE penznem = 'kelet-karib dollár'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány ország nevében van benne az 'ORSZÁG' szó ? ");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) FROM orszagok WHERE orszag LIKE '%ország%';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely országokban korona a hivatalos fizetőeszköz?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE penznem LIKE '%korona%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi Európa területe?");
            conn.Open();
            string lekerdezes = "SELECT SUM(terulet) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%európa%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi Európa lakossága?");
            conn.Open();
            string lekerdezes = "SELECT SUM(nepesseg * 1000) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%európa%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi Európa népsűrűsége?");
            conn.Open();
            string lekerdezes = "SELECT (SUM(nepesseg * 1000) / SUM(terulet)) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%európa%';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány ország van Afrikában?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%afrika%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi Afrika lakossága?");
            conn.Open();
            string lekerdezes = "SELECT SUM(nepesseg * 1000) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%afrika%';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi Afrika népsűrűsége?");
            conn.Open();
            string lekerdezes = "SELECT (SUM(nepesseg * 1000) / SUM(terulet)) AS eredmeny FROM orszagok WHERE foldr_hely LIKE '%afrika%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyek a szigetországok?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE foldr_hely LIKE '%szigetország%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely országok államformája hercegség, vagy királyság?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE allamforma LIKE '%hercegség%' OR allamforma LIKE '%királyság%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány országnak nincs autójelzése?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(orszag) FROM orszagok WHERE autojel = ''; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mennyi a váltószáma az aprópénznek azokban az országokban, ahol nem 100?");
            conn.Open();
            string lekerdezes = "SELECT valtopenz FROM orszagok WHERE valtopenz NOT LIKE '100 %'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hány ország területe kisebb Magyarországénál?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(id) FROM orszagok WHERE terulet< ( SELECT terulet FROM orszagok WHERE orszag LIKE 'Magyarország');";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legnagyobb területű ország, és mennyi a területe?");
            conn.Open();
            string lekerdezes = "SELECT orszag, terulet FROM orszagok ORDER BY terulet DESC LIMIT 1;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legkisebb területű ország, és mennyi a területe?");
            conn.Open();
            string lekerdezes = "SELECT orszag, terulet FROM orszagok ORDER BY terulet ASC LIMIT 1;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legnépesebb ország, és hány lakosa van?");
            conn.Open();
            string lekerdezes = "SELECT orszag, nepesseg * 1000 AS népesség FROM orszagok ORDER BY nepesseg * 1000 DESC LIMIT 1; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legkisebb népességű ország, és hány lakosa van?");
            conn.Open();
            string lekerdezes = "SELECT orszag, nepesseg * 1000 AS népesség FROM orszagok ORDER BY nepesseg * 1000 ASC LIMIT 1; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legsűrűbben lakott ország, és mennyi a népsűrűsége?");
            conn.Open();
            string lekerdezes = "SELECT orszag, ((nepesseg * 1000) / terulet) AS népsűrűség FROM orszagok ORDER BY((nepesseg* 1000) / terulet) DESC LIMIT 1;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legritkábban lakott ország, és mennyi a népsűrűsége?");
            conn.Open();
            string lekerdezes = "SELECT orszag, ((nepesseg * 1000) / terulet) AS népsűrűség FROM orszagok ORDER BY terulet ASC LIMIT 1;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legnagyobb afrikai ország és mekkora?");
            conn.Open();
            string lekerdezes = "SELECT orszag, terulet FROM orszagok WHERE foldr_hely LIKE '%afrika%' ORDER BY terulet DESC LIMIT 1;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a legkisebb amerikai ország és hányan lakják ? ");
            conn.Open();
            string lekerdezes = "SELECT orszag, nepesseg * 1000 FROM orszagok WHERE foldr_hely LIKE '%amerika%' ORDER BY terulet ASC LIMIT 1; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
                Col2.Items.Add(rdr[1]);
            }
            conn.Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik az első három legsűrűbben lakott 'országméretű' ország (tehát nem város- vagy törpeállam)?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE foldr_hely NOT LIKE '%törpeállam%' AND orszag != fovaros ORDER BY((nepesseg* 1000) / terulet) DESC LIMIT 3;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a világ hat legnépesebb fővárosa?");
            conn.Open();
            string lekerdezes = "SELECT fovaros FROM orszagok ORDER BY nep_fovaros DESC LIMIT 6;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik tíz ország egy főre jutó GDP-je a legnagyobb?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok ORDER BY(gdp / nepesseg) DESC LIMIT 10;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik tíz ország össz-GDP-je a legnagyobb?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok ORDER BY gdp DESC LIMIT 10;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik országban a legszegényebbek az emberek?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok ORDER BY(gdp / nepesseg) ASC LIMIT 1;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a 40. legkisebb területű ország?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok ORDER BY terulet ASC LIMIT 1 OFFSET 39;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a 15. legkisebb népsűrűségű ország?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok ORDER BY(nepesseg* 1000) / terulet ASC LIMIT 1 OFFSET 14; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik a 61. legnagyobb népsűrűségű ország?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok ORDER BY(nepesseg* 1000) / terulet DESC LIMIT 1 OFFSET 60;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyik három ország területe hasonlít leginkább Magyaroszág méretéhez?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE orszag != 'Magyarország' GROUP BY orszag ORDER BY ABS((terulet -(SELECT terulet FROM orszagok WHERE orszag = 'Magyarország'))) ASC LIMIT 3;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Az emberek hányadrésze él Ázsiában?");
            conn.Open();
            string lekerdezes = "SELECT SUM(nepesseg) / (SELECT SUM(nepesseg) FROM orszagok) AS eredmény FROM orszagok WHERE foldr_hely LIKE '%ázsia%';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("A szárazföldek mekkora hányadát foglalja el Oroszország?");
            conn.Open();
            string lekerdezes = "SELECT SUM(terulet) / (SELECT SUM(terulet) FROM orszagok) AS eredmény FROM orszagok WHERE orszag = 'oroszország';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Az emberek hány százaléka fizet euroval?");
            conn.Open();
            string lekerdezes = "SELECT SUM(nepesseg) / (SELECT SUM(nepesseg) FROM orszagok) AS eredmény FROM orszagok WHERE penzjel = 'EUR';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hányszorosa a leggazdagabb ország egy főre jutó GDP-je a legszegényebb ország egy főre jutó GDP-jének?");
            conn.Open();
            string lekerdezes = "SELECT (`gdp` / `nepesseg`) / (SELECT `gdp` / `nepesseg` FROM `orszagok` GROUP BY `orszag` ORDER BY `gdp` / `nepesseg` ASC LIMIT 1) FROM `orszagok` WHERE `gdp` > 0 GROUP BY `orszag` ORDER BY(`gdp` / `nepesseg`) DESC LIMIT 1; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("A világ össz-GDP-jének hány százalékát adja az USA?");
            conn.Open();
            string lekerdezes = "SELECT (SUM(gdp) / (SELECT SUM(gdp) FROM orszagok)) * 100 AS eredmény FROM orszagok WHERE orszag = 'Amerikai Egyesült Államok';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("A világ össz-GDP-jének hány százalékát adja az euroövezet?");
            conn.Open();
            string lekerdezes = "SELECT (SUM(gdp) / (SELECT SUM(gdp) FROM orszagok)) * 100 AS eredmény FROM orszagok WHERE penzjel LIKE 'EUR'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Melyek azok az átlagnál gazdagabb országok, amelyek nem az európai vagy az amerikai kontinensen találhatóak?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok WHERE gdp > (SELECT AVG(gdp) FROM orszagok) AND foldr_hely NOT LIKE '%Európa%' AND foldr_hely NOT LIKE '%Amerika%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Milyen államformák léteznek Európában?");
            conn.Open();
            string lekerdezes = "SELECT DISTINCT allamforma FROM orszagok WHERE foldr_hely LIKE '%európa%';";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hányféle államforma létezik a világon?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(DISTINCT allamforma) AS eredmény FROM orszagok;";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Hányféle fizetőeszközt használnak Európában az eurón kívül?");
            conn.Open();
            string lekerdezes = "SELECT COUNT(DISTINCT penzjel) AS eredmény FROM orszagok WHERE penzjel != 'EUR' AND foldr_hely LIKE '%Európa%'; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely pénznemeket használják több országban is? ");
            conn.Open();
            string lekerdezes = "SELECT penznem FROM orszagok GROUP BY penznem HAVING COUNT(orszag) > 1; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Kerdes.Items.Clear();
            Col1.Items.Clear();
            Col2.Items.Clear();
            
            Kerdes.Items.Add("Mely országok államformája egyedi?");
            conn.Open();
            string lekerdezes = "SELECT orszag FROM orszagok GROUP BY allamforma HAVING COUNT(allamforma) = 1; ";
            MySqlCommand feladat = new MySqlCommand(lekerdezes, conn);
            MySqlDataReader rdr = feladat.ExecuteReader();
            while (rdr.Read())
            {
                Col1.Items.Add(rdr[0]);
            }
            conn.Close();
        }
    }
}