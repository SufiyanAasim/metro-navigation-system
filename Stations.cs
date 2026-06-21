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
            FormClosing += (s, e) => Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNavigator.ShowNext(this, new Choices());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            string selectedStation = comboBox1.SelectedItem.ToString();
            RadioButton targetRadioButton = null;

            switch (selectedStation)
            {
                case "Singer Chowrangi":
                    targetRadioButton = radioButton1;
                    break;
                case "Shaan Chowrangi":
                    targetRadioButton = radioButton2;
                    break;
                case "Indus Hospital":
                    targetRadioButton = radioButton3;
                    break;
                case "Rahat Park":
                case "KPT Interchange":
                    targetRadioButton = radioButton4;
                    break;
                case "Defence Morr":
                    targetRadioButton = radioButton5;
                    break;
                case "FTC":
                    targetRadioButton = radioButton6;
                    break;
                case "Frere Hall":
                    targetRadioButton = radioButton7;
                    break;
                case "Numaish":
                    targetRadioButton = radioButton8;
                    break;
                case "Drigh Road":
                    targetRadioButton = radioButton9;
                    break;
                case "Millennium Mall":
                    targetRadioButton = radioButton10;
                    break;
            }

            if (targetRadioButton != null)
            {
                SetStationMarkersVisible(true);
                button2.Text = "Hide stations from map";
                targetRadioButton.Checked = true;
            }
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
