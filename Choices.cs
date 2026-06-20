using System;
using System.Drawing;
using System.Windows.Forms;
using Metro_App.Frontend;

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
            int formWidth = ClientSize.Width + Width - ClientSize.Width;
            int formHeight = ClientSize.Height + Height - ClientSize.Height;

            Size = new Size(formWidth, formHeight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void Choices_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            FormNavigator.ShowNext(this, new Stations());
        }

        private void metro_map_Click(object sender, EventArgs e)
        {
            FormNavigator.ShowNext(this, new Map());
        }

        private void sortest_route_Click(object sender, EventArgs e)
        {
            FormNavigator.ShowNext(this, new Shortest_Path());
        }
    }
}
