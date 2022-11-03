using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Demo_Golopapa
{   
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            conn = new SqlConnection(@"Data Source = REDISKINK; Database = demoGolopapa007sb1; Integrated Security=true");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getData())
            {
                this.Hide();
                SecondStep Second = new SecondStep();
                Second.Show();
            }
            else {
                var result = MessageBox.Show("ошибка заполнения данных", "Form Closing",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void fistFormDataQuery() {
            conn.Open();
            string Sql = "Select";
            SqlCommand db = new SqlCommand(Sql,conn);
            
        }
        public bool getData(bool exit=false) {
            try
            {
                UserData.startDateTime = dateTimePicker1.Value;
                UserData.endDateTime = dateTimePicker2.Value;

                UserData.dayValue = Convert.ToSingle(textBox3.Text);
                UserData.peopleValue = Convert.ToSingle(textBox4.Text);

                UserData.childrenValue = checkBox1.Checked;


                
                exit = true;
                
                return exit;
            }
            catch (System.FormatException) {
                exit = false;

                return exit;
            }
        }
    }
}
