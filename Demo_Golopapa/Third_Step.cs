using System;
using System.Windows.Forms;

namespace Demo_Golopapa
{
    public partial class Third_Step : Form
    {
        public Third_Step()
        {
            InitializeComponent();
        }

        private void trackBar1_SizeChanged(object sender, EventArgs e)
        {
            label11.Text = trackBar1.Value.ToString();
            label12.Text = trackBar2.Value.ToString();  
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label11.Text = trackBar1.Value.ToString();
            
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label12.Text = trackBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (getData())
            {
                Fourth_Step four = new Fourth_Step();
                four.Show();
                Hide();
            }
            else { 
            var message2 = MessageBox.Show("Error here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public bool getData(bool exit = false)
        {
            try
            {
                UserData.typeOfPit = comboBox1.Text.ToString();
                UserData.hotelStars = Convert.ToSingle(comboBox2.Text);

                if (transfer_checkBox.Checked == true)
                {
                    UserData.transferCheck = "да";
                }
                else {
                    UserData.transferCheck = "нет";
                }
                //UserData.transferCheck = transfer_checkBox.Checked;

                UserData.parkingCheck = parking_checkBox.Checked;

                UserData.costFrom = trackBar1.Value;
                UserData.costTo = trackBar2.Value;

                if ((UserData.typeOfPit == "") || (comboBox2.Text == "")) {
                    var message = MessageBox.Show("!!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return false;
                }

                exit = true;

                return exit;
            }
            catch (System.FormatException)
            {
                exit = false;

                return exit;
            }
        }
    }
}
