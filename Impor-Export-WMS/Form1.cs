using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impor_Export_WMS
{
    public partial class Form1 : Form
    {
        public string connString;
        SqlConnection cnn;
        SqlDataAdapter adpt;
        DataTable dt;

        private string tabbleName;
        string collumnList;
        string tabbleSelected;

        public Form1()
        {
            InitializeComponent();
        }


        
        void connectDB() 
        {
            var datasource = @"LAPTOP-F3H3D206\SQLEXPRESS";
            var database = "HOST_IMPEXP";
            var username = "host";
            var password = "host";
            connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            cnn = new SqlConnection(connString);
            ServerLbl.Text = datasource;
            dbLbl.Text = database;
            using (cnn)
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");

                getTable();

                
            }
        }

        private void connBtn_Click(object sender, EventArgs e)
        {
            connectDB();
        }

        void getTable() 
        {
            using (SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES", cnn))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    tablistDb.Items.Clear();
                    while (reader.Read())
                    {
                        tabbleName = (string)reader["TABLE_NAME"];
                        tablistDb.Items.Add(tabbleName);
                    }
                }
            }
            cnn.Close();

        }

        void getCollumn() 
        {
            cnn = new SqlConnection(connString);
            cnn.Open();
            using (SqlCommand com2 = cnn.CreateCommand())
            {
                com2.CommandText = "select * from [dbo].[" + tabbleSelected + "]";
                using (var reader = com2.ExecuteReader())
                {
                    var columns = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        columns.Add(reader.GetName(i));
                        collumnList = string.Join("\n", columns);
                    }

                }
            }
        }

        void getDatabase() 
        {
            cnn = new SqlConnection(connString);
            cnn.Open();
            using (SqlCommand com3 = cnn.CreateCommand())
            {
                adpt = new SqlDataAdapter("select * from [dbo].[" + tabbleSelected + "]", cnn);
                dt = new DataTable();
                adpt.Fill(dt);
                datagridView.DataSource = dt;
            }
            cnn.Close();
        }

        void deleteDB()
        {

            cnn = new SqlConnection(connString);
            cnn.Open();
            SqlCommand com4 = new SqlCommand("SELECT COUNT(*) FROM " + tabbleSelected, cnn);
            Int32 userCount = (Int32) com4.ExecuteScalar();
            if (userCount > 0)
            {
                SqlCommand com5 = new SqlCommand("DELETE FROM " + tabbleSelected, cnn);
                com5.ExecuteNonQuery();
            }
            else { MessageBox.Show("No Data Exist ! "); }    
        }

        void sendDatabase()
        {
            string ART_OPERAZIONE;
            if (U_artRb.Checked == true) 
            { 
                ART_OPERAZIONE = "I"; 
                D_artRB.Checked = false;
                A_artRB.Checked = false;
            }
            else if (D_artRB.Checked == true)
            { 
                ART_OPERAZIONE = "D";
                U_artRb.Checked = false;
                A_artRB.Checked = false;
            }
            else 
            {
                ART_OPERAZIONE = "A";
                D_artRB.Checked = false;
                U_artRb.Checked = false;

            }

            string ART_ARTICOLO = art_artTb.Text;
            string ART_DES = des_artTb.Text;
            string ART_UMI = umi_artTb.Text;
            string S_tabbleSelected = "IMP_ARTICOLI";
            int ART_SOTTOSCO = int.Parse(sot_artTb.Text);
            cnn = new SqlConnection(connString);
            cnn.Open();
            string query = "INSERT INTO " + S_tabbleSelected + " ("
                    + "ART_OPERAZIONE, "
                    + "ART_ARTICOLO, "
                    + "ART_DES, "
                    + "ART_UMI, "
                    + "ART_SOTTOSCO"
                    + ") VALUES ("
                    + "'" + ART_OPERAZIONE + "', "
                    + "'" + ART_ARTICOLO + "', "
                    + "'" + ART_DES + "', "
                    + "'" + ART_UMI + "', "
                    + "'" + ART_SOTTOSCO + "')";
            SqlCommand com6 = new SqlCommand(query, cnn);
            Console.WriteLine(com6.CommandText);
            com6.ExecuteNonQuery();
            cnn.Close();
        }

        void saveDB_toCSV()
        {

            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.DefaultExt = "csv";
                ofd.AddExtension = true;
                File.WriteAllText(ofd.FileName, sb.ToString());
                Console.WriteLine(ofd.FileName);
            }

        }

        private void tablistDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabbleSelected = tablistDb.Text;
            
            getCollumn();
            richTextBox1.Text = collumnList;
        }

        private void getdbBtn_Click(object sender, EventArgs e)
        {
            getDatabase();
        }

        private void cleardbBtn_Click(object sender, EventArgs e)
        {
            deleteDB();
        }

        private void senddbBtn_Click(object sender, EventArgs e)
        {
            if (art_artTb.Text == "" || des_artTb.Text == "")
            {
                MessageBox.Show("Fill the blank Data!");
            }
            else sendDatabase();
        }

        private void U_artRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
             saveDB_toCSV();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
