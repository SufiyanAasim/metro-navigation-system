using System;
using System.Windows.Forms;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class Stations : Form
    {
        private bool _cameFromChoices;

        public Stations(bool cameFromChoices = false)
        {
            InitializeComponent();
            _cameFromChoices = cameFromChoices;
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
            FormClosing += (s, e) => Application.Exit();

            // Set parent to pictureBox1 for correct transparency over the map
            button1.Parent = pictureBox1;
            button2.Parent = pictureBox1;
            buttonNext.Parent = pictureBox1;

            radioButton1.Parent = pictureBox1;
            radioButton2.Parent = pictureBox1;
            radioButton3.Parent = pictureBox1;
            radioButton4.Parent = pictureBox1;
            radioButton5.Parent = pictureBox1;
            radioButton6.Parent = pictureBox1;
            radioButton7.Parent = pictureBox1;
            radioButton8.Parent = pictureBox1;
            radioButton9.Parent = pictureBox1;
            radioButton10.Parent = pictureBox1;

            // Ensure radio buttons have transparent backgrounds to blend with the map
            radioButton1.BackColor = System.Drawing.Color.Transparent;
            radioButton2.BackColor = System.Drawing.Color.Transparent;
            radioButton3.BackColor = System.Drawing.Color.Transparent;
            radioButton4.BackColor = System.Drawing.Color.Transparent;
            radioButton5.BackColor = System.Drawing.Color.Transparent;
            radioButton6.BackColor = System.Drawing.Color.Transparent;
            radioButton7.BackColor = System.Drawing.Color.Transparent;
            radioButton8.BackColor = System.Drawing.Color.Transparent;
            radioButton9.BackColor = System.Drawing.Color.Transparent;
            radioButton10.BackColor = System.Drawing.Color.Transparent;

            // Make sure the window is fixed size to prevent layout stretching
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            if (_cameFromChoices)
            {
                FormNavigator.ShowNext(this, new Choices());
            }
            else
            {
                FormNavigator.ShowNext(this, new Map(false));
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Shortest_Path(false));
        }



        private void Stations_Load(object sender, EventArgs e)
        {
            SetStationMarkersVisible(false);
            button2.Text = ""; // Keep text empty to use only the pre-rendered button image text
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            bool areMarkersVisible = AreStationMarkersVisible();
            SetStationMarkersVisible(!areMarkersVisible);
            button2.Text = ""; // Keep text empty to use only the pre-rendered button image text
        }

        private bool AreStationMarkersVisible()
        {
            foreach (Control control in pictureBox1.Controls)
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
            foreach (Control control in pictureBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Visible = isVisible;
                }
            }
        }
    }
}
