using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_App
{
    public partial class Map : Form
    {
        
        public Map()
        {
            InitializeComponent();
                    }

        private void Map_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choices choices = new Choices();
            choices.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add functionality for other buttons here if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add functionality for other buttons here if needed
        }
    }
}
