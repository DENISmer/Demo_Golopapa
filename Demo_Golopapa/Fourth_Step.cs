using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Demo_Golopapa
{
    public partial class Fourth_Step : Form
    {
        SqlConnection conn;
        public Fourth_Step()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source = REDISKINK; Database = demoGolopapa007sb1; Integrated Security=true");
        }
        private void update() {
            //"and [Трансфер]=" + UserData.transferCheck.ToString();
            string SQL_Grid2;
            string SQL_Grid;

            if (UserData.parkingCheck == true)
            {
                SQL_Grid2 = "Select * From Отель$ where [Звезды]=" + UserData.hotelStars + "and [Парковок] > 0";
                SqlDataAdapter adapter = new SqlDataAdapter(SQL_Grid2, conn);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else {
                SQL_Grid = "SELECT * FROM Отель$ where [Звезды]=" + UserData.hotelStars;
                SqlDataAdapter adapter = new SqlDataAdapter(SQL_Grid, conn);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void Fourth_Step_Load(object sender, EventArgs e)
        {
            update();
        }
    }
}
