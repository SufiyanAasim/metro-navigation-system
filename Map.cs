using System;
using System.Windows.Forms;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class Map : Form
    {
        private bool _cameFromChoices;

        public Map(bool cameFromChoices = false)
        {
            InitializeComponent();
            _cameFromChoices = cameFromChoices;
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
            FormClosing += (s, e) => Application.Exit();

            // Set parent to pictureBox1 for correct transparency over the map
            button2.Parent = pictureBox1;
            buttonNext.Parent = pictureBox1;

            // Make sure the window is fixed size to prevent layout stretching
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void Map_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            if (_cameFromChoices)
            {
                FormNavigator.ShowNext(this, new Choices());
            }
            else
            {
                FormNavigator.ShowNext(this, new Stations());
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Shortest_Path(false));
        }
    }
}
