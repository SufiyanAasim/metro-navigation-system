using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_App
{
    public partial class Choices : Form
    {
        public Choices()
        {
            InitializeComponent();
        }

        private void Choices_Load(object sender, EventArgs e)
        {
            
            // Calculate the total form size including borders and title bar
            int formWidth = this.ClientSize.Width + this.Width - this.ClientSize.Width;
            int formHeight = this.ClientSize.Height + this.Height - this.ClientSize.Height;

            // Set the total form size
            this.Size = new Size(formWidth, formHeight);

            // Optional: Set form properties to make it non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void Choices_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the application when the Choices form is closed
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //show stations button
            
            this.Hide();
            Stations stationsform = new Stations();
            stationsform.Show();
            
        }

        private void metro_map_Click(object sender, EventArgs e)
        {
           //metro map button
            Map meteo_map = new Map();
            meteo_map.Show();
            this.Hide();
        }

        private void sortest_route_Click(object sender, EventArgs e)
        {      
            //shortest path button   
            Shortest_Path shortest_Path  = new Shortest_Path();
            shortest_Path.Show();
            this.Hide();
        }
    }
}
