using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_App
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set form properties and size adjustments
            int formWidth = this.ClientSize.Width + this.Width - this.ClientSize.Width;
            int formHeight = this.ClientSize.Height + this.Height - this.ClientSize.Height;
            this.Size = new Size(formWidth, formHeight);

            // Optional: Set form properties to make it non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        //ignore    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {     // Srart Button
            Choices choicesForm = new Choices();
            this.Hide();
            choicesForm.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ignore

        }
    }
}
