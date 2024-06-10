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
    public partial class Data_View : Form
    {
        private Dictionary<string, List<string>> cityCountiesMap = new Dictionary<string, List<string>>();
        public Data_View()
        {
            InitializeComponent();
            PopulateCityCountiesMap();


            // Populate the CityTowncomboBox
            CityTowncomboBox.DataSource = new BindingSource(cityCountiesMap, null);
            CityTowncomboBox.DisplayMember = "Key";
            CityTowncomboBox.ValueMember = "Key";

            // Add an empty item to the CountycomboBox
            CountycomboBox.Items.Add("");

            // Add an event handler for the SelectedIndexChanged event of the CityTowncomboBox
            CityTowncomboBox.SelectedIndexChanged += CityTowncomboBox_SelectedIndexChanged;
            Search_button.Click += Search_button_Click;
            Clear_button.Click += Clear_button_Click;
            Back_button.Click += Back_button_Click;
        }
        private void PopulateCityCountiesMap()
        {
            AddCityCountyMapping("Ables Springs", "Kaufman County");
            AddCityCountyMapping("Acton", "Hood County");
            AddCityCountyMapping("Addison", "Dallas County");
            AddCityCountyMapping("Allen", "Collin County");
            AddCityCountyMapping("Alma", "Ellis County");
            AddCityCountyMapping("Alvord", "Wise County");
            AddCityCountyMapping("Alvarado", "Johnson County");
            AddCityCountyMapping("Angus", "Navarro County");
            AddCityCountyMapping("Anna", "Collin County");
            AddCityCountyMapping("Argyle", "Denton County");
            AddCityCountyMapping("Arlington", "Tarrant County");
            AddCityCountyMapping("Aubrey", "Denton County");
            AddCityCountyMapping("Azle", "Tarrant County");
            AddCityCountyMapping("Azle", "Parker County");
            AddCityCountyMapping("Balch Springs", "Dallas County");
            AddCityCountyMapping("Bardwell", "Ellis County");
            AddCityCountyMapping("Barry", "Navarro County");
            AddCityCountyMapping("Bartonville", "Denton County");
            AddCityCountyMapping("Becker", "Kaufman County");
            AddCityCountyMapping("Bedford", "Tarrant County");
            AddCityCountyMapping("Bells", "Grayson County");
            AddCityCountyMapping("Benbrook", "Tarrant County");
            AddCityCountyMapping("Blue Mound", "Tarrant County");
            AddCityCountyMapping("Blue Ridge", "Collin County");
            AddCityCountyMapping("Blooming Grove", "Navarro County");
            AddCityCountyMapping("Boyd", "Wise County");
            AddCityCountyMapping("Brazos", "Palo Pinto County");
            AddCityCountyMapping("Briaroaks", "Johnson County");
            AddCityCountyMapping("Bridgeport", "Wise County");
            AddCityCountyMapping("Burleson", "Johnson County");
            AddCityCountyMapping("Burleson", "Tarrant County");
            AddCityCountyMapping("Caddo Mills", "Hunt County");
            AddCityCountyMapping("Campbell", "Hunt County");
            AddCityCountyMapping("Carrollton", "Collin County");
            AddCityCountyMapping("Carrollton", "Dallas County");
            AddCityCountyMapping("Carrollton", "Denton County");
            AddCityCountyMapping("Cartwright", "Kaufman County");
            AddCityCountyMapping("Cedar Grove", "Kaufman County");
            AddCityCountyMapping("Cedar Hill", "Dallas County");
            AddCityCountyMapping("Cedar Hill", "Ellis County");
            AddCityCountyMapping("Cedarvale", "Kaufman County");
            AddCityCountyMapping("Celina", "Collin County");
            AddCityCountyMapping("Celina", "Denton County");
            AddCityCountyMapping("Chico", "Wise County");
            AddCityCountyMapping("Cleburne", "Johnson County");
            AddCityCountyMapping("Cobb", "Kaufman County");
            AddCityCountyMapping("Cockrell Hill", "Dallas County");
            AddCityCountyMapping("Colleyville", "Tarrant County");
            AddCityCountyMapping("Collinsville", "Grayson County");
            AddCityCountyMapping("College Mound", "Kaufman County");
            AddCityCountyMapping("Colquitt", "Kaufman County");
            AddCityCountyMapping("Combine", "Dallas County");
            AddCityCountyMapping("Combine", "Kaufman County");
            AddCityCountyMapping("Commerce", "Hunt County");
            AddCityCountyMapping("Copper Canyon", "Denton County");
            AddCityCountyMapping("Copeville", "Collin County");
            AddCityCountyMapping("Coppell", "Dallas County");
            AddCityCountyMapping("Coppell", "Denton County");
            AddCityCountyMapping("Corinth", "Denton County");
            AddCityCountyMapping("Corsicana", "Navarro County");
            AddCityCountyMapping("Cottonwood", "Kaufman County");
            AddCityCountyMapping("Coyote Flats (city)", "Johnson County");
            AddCityCountyMapping("Crandall", "Kaufman County");
            AddCityCountyMapping("Cresson", "Johnson County");
            AddCityCountyMapping("Crisp", "Ellis County");
            AddCityCountyMapping("Cross Roads", "Denton County");
            AddCityCountyMapping("Cross Timber", "Johnson County");
            AddCityCountyMapping("Crowley", "Johnson County");
            AddCityCountyMapping("Crowley", "Tarrant County");
            AddCityCountyMapping("Dallas", "Collin County");
            AddCityCountyMapping("Dallas", "Dallas County");
            AddCityCountyMapping("Dallas", "Denton County");
            AddCityCountyMapping("Dallas", "Kaufman County");
            AddCityCountyMapping("Dallas", "Rockwall County");
            AddCityCountyMapping("Dalworthington Gardens", "Tarrant County");
            AddCityCountyMapping("Dawson", "Navarro County");
            AddCityCountyMapping("Decatur", "Wise County");
            AddCityCountyMapping("Decordova Bend Estates", "Hood County");
            AddCityCountyMapping("Dennis", "Parker County");
            AddCityCountyMapping("Denison", "Grayson County");
            AddCityCountyMapping("Desoto", "Dallas County");
            AddCityCountyMapping("Dish", "Denton County");
            AddCityCountyMapping("Dorchester", "Grayson County");
            AddCityCountyMapping("Double Oak", "Denton County");
            AddCityCountyMapping("Dublin", "Erath County");
            AddCityCountyMapping("Duncanville", "Dallas County");
            AddCityCountyMapping("Edgecliff Village", "Tarrant County");
            AddCityCountyMapping("Elmo", "Kaufman County");
            AddCityCountyMapping("Emhouse", "Navarro County");
            AddCityCountyMapping("Ennis", "Ellis County");
            AddCityCountyMapping("Euless", "Tarrant County");
            AddCityCountyMapping("Eureka", "Navarro County");
            AddCityCountyMapping("Everman", "Tarrant County");
            AddCityCountyMapping("Fairview", "Collin County");
            AddCityCountyMapping("Farmers Branch", "Dallas County");
            AddCityCountyMapping("Farmersville", "Collin County");
            AddCityCountyMapping("Fate", "Rockwall County");
            AddCityCountyMapping("Ferris", "Dallas County");
            AddCityCountyMapping("Ferris", "Ellis County");
            AddCityCountyMapping("Flower Mound", "Denton County");
            AddCityCountyMapping("Flower Mound", "Tarrant County");
            AddCityCountyMapping("Forest Hill", "Tarrant County");
            AddCityCountyMapping("Forney", "Kaufman County");
            AddCityCountyMapping("Fort Worth", "Denton County");
            AddCityCountyMapping("Fort Worth", "Tarrant County");
            AddCityCountyMapping("Frost", "Navarro County");
            AddCityCountyMapping("Frisco", "Collin County");
            AddCityCountyMapping("Frisco", "Denton County");
            AddCityCountyMapping("Garland", "Collin County");
            AddCityCountyMapping("Garland", "Dallas County");
            AddCityCountyMapping("Garret", "Ellis County");
            AddCityCountyMapping("Georges Creek", "Somervell County");
            AddCityCountyMapping("Glass", "Somervell County");
            AddCityCountyMapping("Glen Rose", "Somervell County");
            AddCityCountyMapping("Glenn Heights", "Dallas County");
            AddCityCountyMapping("Glenn Heights", "Ellis County");
            AddCityCountyMapping("Godley", "Johnson County");
            AddCityCountyMapping("Goodlow Park", "Navarro County");
            AddCityCountyMapping("Gordon", "Palo Pinto County");
            AddCityCountyMapping("Graford", "Palo Pinto County");
            AddCityCountyMapping("Grand Prairie", "Dallas County");
            AddCityCountyMapping("Grand Prairie", "Ellis County");
            AddCityCountyMapping("Grand Prairie", "Tarrant County");
            AddCityCountyMapping("Granbury", "Hood County");
            AddCityCountyMapping("Grandview", "Johnson County");
            AddCityCountyMapping("Grapevine", "Dallas County");
            AddCityCountyMapping("Grapevine", "Denton County");
            AddCityCountyMapping("Grapevine", "Tarrant County");
            AddCityCountyMapping("Grays Prairie", "Kaufman County");
            AddCityCountyMapping("Greenville", "Hunt County");
            AddCityCountyMapping("Greenwood", "Wise County");
            AddCityCountyMapping("Gunter", "Grayson County");
            AddCityCountyMapping("Hackberry", "Denton County");
            AddCityCountyMapping("Haltom City", "Tarrant County");
            AddCityCountyMapping("Haslet", "Tarrant County");
            AddCityCountyMapping("Hawk Cove", "Hunt County");
            AddCityCountyMapping("Heartland", "Kaufman County");
            AddCityCountyMapping("Heath", "Kaufman County");
            AddCityCountyMapping("Heath", "Rockwall County");
            AddCityCountyMapping("Hickory Creek", "Denton County");
            AddCityCountyMapping("Highland Park", "Dallas County");
            AddCityCountyMapping("Highland Village", "Denton County");
            AddCityCountyMapping("Howe", "Grayson County");
            AddCityCountyMapping("Huckabay", "Erath County");
            AddCityCountyMapping("Hutchins", "Dallas County");
            AddCityCountyMapping("Hurst", "Tarrant County");
            AddCityCountyMapping("Ike", "Ellis County");
            AddCityCountyMapping("Irving", "Dallas County");
            AddCityCountyMapping("Italy", "Ellis County");
            AddCityCountyMapping("Joshua", "Johnson County");
            AddCityCountyMapping("Josephine", "Collin County");
            AddCityCountyMapping("Josephine", "Hunt County");
            AddCityCountyMapping("Justin", "Denton County");
            AddCityCountyMapping("Kaufman", "Kaufman County");
            AddCityCountyMapping("Keene", "Johnson County");
            AddCityCountyMapping("Kemp", "Kaufman County");
            AddCityCountyMapping("Kennedale", "Tarrant County");
            AddCityCountyMapping("Kerens", "Navarro County");
            AddCityCountyMapping("Keller", "Tarrant County");
            AddCityCountyMapping("Knollwood", "Grayson County");
            AddCityCountyMapping("Krugerville", "Denton County");
            AddCityCountyMapping("Krum", "Denton County");
            AddCityCountyMapping("Lakeside", "Tarrant County");
            AddCityCountyMapping("Lake Dallas", "Denton County");
            AddCityCountyMapping("Lakewood Village", "Denton County");
            AddCityCountyMapping("Lancaster", "Dallas County");
            AddCityCountyMapping("Lavon", "Collin County");
            AddCityCountyMapping("Lewisville", "Dallas County");
            AddCityCountyMapping("Lewisville", "Denton County");
            AddCityCountyMapping("Lingleville", "Erath County");
            AddCityCountyMapping("Little Elm", "Denton County");
            AddCityCountyMapping("Lone Oak", "Hunt County");
            AddCityCountyMapping("Lowry Crossing", "Collin County");
            AddCityCountyMapping("Lucas", "Collin County");
            AddCityCountyMapping("Mabank", "Kaufman County");
            AddCityCountyMapping("Mansfield", "Ellis County");
            AddCityCountyMapping("Mansfield", "Johnson County");
            AddCityCountyMapping("Mansfield", "Tarrant County");
            AddCityCountyMapping("Maypearl", "Ellis County");
            AddCityCountyMapping("McLendon-Chisholm", "Rockwall County");
            AddCityCountyMapping("McKinney", "Collin County");
            AddCityCountyMapping("Melissa", "Collin County");
            AddCityCountyMapping("Mesquite", "Dallas County");
            AddCityCountyMapping("Mesquite", "Kaufman County");
            AddCityCountyMapping("Mildred", "Navarro County");
            AddCityCountyMapping("Millsap", "Parker County");
            AddCityCountyMapping("Milford", "Ellis County");
            AddCityCountyMapping("Mineral Wells", "Palo Pinto County");
            AddCityCountyMapping("Mingus", "Palo Pinto County");
            AddCityCountyMapping("Mobile City", "Rockwall County");
            AddCityCountyMapping("Murphy", "Collin County");
            AddCityCountyMapping("Mustang", "Navarro County");
            AddCityCountyMapping("Navarro", "Navarro County");
            AddCityCountyMapping("Cross Timber", "Johnson County");
            AddCityCountyMapping("Crowley", "Johnson County");
            AddCityCountyMapping("Crowley", "Tarrant County");
        }

            private void AddCityCountyMapping(string city, string county)
            {
                if (cityCountiesMap.ContainsKey(city))
                {
                    cityCountiesMap[city].Add(county);
                }
                else
                {
                    cityCountiesMap[city] = new List<string> { county };
                }
            }


            private void CityTowncomboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Clear the CountycomboBox
                CountycomboBox.Items.Clear();

                // Get the selected town
                string selectedTown = CityTowncomboBox.SelectedValue?.ToString();

                // If a town is selected, populate the CountycomboBox with the corresponding county
                if (!string.IsNullOrEmpty(selectedTown) && cityCountiesMap.TryGetValue(selectedTown, out List<string> counties))
                {
                    foreach (string county in counties)
                    {
                        CountycomboBox.Items.Add(county);
                    }
                }
                else
                {
                    // Add an empty item to the CountycomboBox
                    CountycomboBox.Items.Add("");
                }
            }







     

        private void Back_button_Click(object sender, EventArgs e)
        {
            main_page mainpage = new main_page();
            mainpage.Show();
            this.Hide();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            
            Biditem_num_textBox.Clear();
            Job_Name_textBox.Clear();
            Description_textBox.Clear();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=QUALITYSERVER3\\HCSS;Initial Catalog=Analysis;Integrated Security=True; Trust Server Certificate = True";
            string query = "SELECT * FROM BidTab2023 WHERE 1=1"; // Start with a base query

            // Add filters based on the input values
           

            if (!string.IsNullOrWhiteSpace(Biditem_num_textBox.Text))
            {
                query += " AND BidItemNo LIKE @BidItemNo";
            }

            if (!string.IsNullOrWhiteSpace(Job_Name_textBox.Text))
            {
                query += " AND JobName LIKE @JobName";
            }

            if (!string.IsNullOrWhiteSpace(Description_textBox.Text))
            {
                query += " AND Description LIKE @Description";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameter values if the corresponding text boxes are not empty
                

                if (!string.IsNullOrWhiteSpace(Biditem_num_textBox.Text))
                    command.Parameters.AddWithValue("@Biditem", "%" + Biditem_num_textBox.Text + "%");

                if (!string.IsNullOrWhiteSpace(Job_Name_textBox.Text))
                    command.Parameters.AddWithValue("@JobName", "%" + Job_Name_textBox.Text + "%");

                if (!string.IsNullOrWhiteSpace(Description_textBox.Text))
                    command.Parameters.AddWithValue("@Description", "%" + Description_textBox.Text + "%");

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Data_View_Load(object sender, EventArgs e)
        {
            Filldatagridview();
        }


        private void Filldatagridview()
        {
            String connectionString = "Data Source=QUALITYSERVER3\\HCSS;Initial Catalog=Analysis;Integrated Security=True; Trust Server Certificate = True";
            String Query = "SELECT * FROM BidTab2023";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Job_Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

