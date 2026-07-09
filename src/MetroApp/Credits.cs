using System;
using System.Drawing;
using System.Windows.Forms;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
            FormClosing += (s, e) => Application.Exit();

            // Hide the next button on developer credits screen as requested
            buttonNext.Visible = false;
            buttonNext.Enabled = false;
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            int formWidth = ClientSize.Width + Width - ClientSize.Width;
            int formHeight = ClientSize.Height + Height - ClientSize.Height;

            Size = new Size(formWidth, formHeight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            this.BackgroundImage = global::Metro_App.Properties.Resources.developer_credits_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Dynamically set correct app version from AssemblyInfo (e.g. 1.0.0)
            versionLabel.Text = "App Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            versionLabel.Left = (this.ClientSize.Width - versionLabel.Width) / 2;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Choices());
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
        }

        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:sufiyanaasim@outlook.com");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Unable to open mail client: " + ex.Message, "Error");
            }
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/SufiyanAasim");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Unable to open web browser: " + ex.Message, "Error");
            }
        }

        private void linkContributorEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:fahadabbasi17025@gmail.com");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Unable to open mail client: " + ex.Message, "Error");
            }
        }

        private void linkContributorGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/FahadBinNasir");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Unable to open web browser: " + ex.Message, "Error");
            }
        }
    }
}

