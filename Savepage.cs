using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Beta_conection_to_sql_server
{
    public partial class Savepage : Form
    {
        private string connectionString;

        public Savepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Replace the placeholders with your actual server, database, username, and password
            
        }



        private void Add_to_database_button_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=QUALITYSERVER3\\HCSS;Initial Catalog=Analysis;Integrated Security=True; Trust Server Certificate = True";
            String sqlQuery = "INSERT INTO Tester_Table (Biditem, Description, Units, Bid_Quantity, Unit_Price) VALUES ('" + Bid_item_textBox.Text + "', '" + Description_textBox.Text + "', '" + Units_textBox.Text + "', '" + Bid_Quantity_textBox.Text + "', '" + Unit_Price_textBox.Text + "')";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            main_page mainpage = new main_page();
            mainpage.Show();
            this.Hide();
        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            Bid_item_textBox.Clear();
            Description_textBox.Clear();
            Units_textBox.Clear();
            Bid_Quantity_textBox.Clear();
            Unit_Price_textBox.Clear();
        }
    }
}