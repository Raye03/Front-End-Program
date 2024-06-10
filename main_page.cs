using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_conection_to_sql_server
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Page_button_Click(object sender, EventArgs e)
        {
            Savepage Save_page = new Savepage();
            Save_page.Show();
            this.Hide();
        }

        private void Databaseview_page_button_Click(object sender, EventArgs e)
        {

            Data_View Dataview = new Data_View();
            Dataview.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
