using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_App
{
    public partial class Stations : Form
    {
        public Stations()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back button
            this.Hide();
            Choices choicesform = new Choices();
            choicesform.Show();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox
        }

        private void Stations_Load(object sender, EventArgs e)
        {
            // Set all RadioButtons to not be visible initially
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Visible = false;
                }
            }

            // Set initial text for the button
            button2.Text = "Show stations on map";
        }


        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //limting combobox from editing
            e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ignore

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check the current visibility of the first radio button (or any one radio button)
            bool areRadioButtonsVisible = false;

            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    areRadioButtonsVisible = radioButton.Visible;
                    break;
                }
            }

            // Toggle visibility of all RadioButtons
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Visible = !areRadioButtonsVisible;
                }
            }

            // Change button text based on the visibility
            button2.Text = areRadioButtonsVisible ? "Show stations on map" : "Hide stations from map";
        }

    }
}
