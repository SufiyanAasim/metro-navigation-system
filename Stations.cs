using System;
using System.Windows.Forms;
using Metro_App.Frontend;

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
            FormNavigator.ShowNext(this, new Choices());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Stations_Load(object sender, EventArgs e)
        {
            SetStationMarkersVisible(false);
            button2.Text = "Show stations on map";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool areMarkersVisible = AreStationMarkersVisible();
            SetStationMarkersVisible(!areMarkersVisible);
            button2.Text = areMarkersVisible ? "Show stations on map" : "Hide stations from map";
        }

        private bool AreStationMarkersVisible()
        {
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton)
                {
                    return radioButton.Visible;
                }
            }

            return false;
        }

        private void SetStationMarkersVisible(bool isVisible)
        {
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Visible = isVisible;
                }
            }
        }
    }
}
