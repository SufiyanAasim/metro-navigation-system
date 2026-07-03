using System;
using System.Drawing;
using System.Windows.Forms;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formWidth = ClientSize.Width + Width - ClientSize.Width;
            int formHeight = ClientSize.Height + Height - ClientSize.Height;

            Size = new Size(formWidth, formHeight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Choices());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
