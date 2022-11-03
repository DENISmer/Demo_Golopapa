using System;
using System.Windows.Forms;

namespace Demo_Golopapa
{
    public partial class SecondStep : Form
    {
        public SecondStep()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Third_Step Third = new Third_Step();
            Third.Show();
            Hide();
        }

        private void SecondStep_Load(object sender, EventArgs e)
        {

        }
    }
}
