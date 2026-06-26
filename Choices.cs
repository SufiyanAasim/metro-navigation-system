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
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
        }

        private void Choices_Load(object sender, EventArgs e)
        {
            int formWidth = ClientSize.Width + Width - ClientSize.Width;
            int formHeight = ClientSize.Height + Height - ClientSize.Height;

            Size = new Size(formWidth, formHeight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            // Enforce white and bold text for descriptions to make them clearly visible on dark background
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void Choices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Welcome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
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
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Stations());
        }

        private void metro_map_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Map(true));
        }

        private void sortest_route_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Shortest_Path(true));
        }

        private void developer_credits_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Credits());
        }
    }
}
