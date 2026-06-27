using System;
using System.Drawing;
using System.Windows.Forms;
using Metro_App.Backend;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class ReceiptGeneration : Form
    {
        public ReceiptGeneration()
        {
            InitializeComponent();
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
            FormClosing += (s, e) => Application.Exit();
            richTextBox1.Visible = false;
            richTextBox1.ReadOnly = true;
            pictureBoxInnerReport.Visible = false;

            // Hide the next button leading to Developer Credits as requested
            buttonNext.Visible = false;
            buttonNext.Enabled = false;

            // Make sure the window is fixed size to prevent layout stretching
            int formWidth = ClientSize.Width + Width - ClientSize.Width;
            int formHeight = ClientSize.Height + Height - ClientSize.Height;
            Size = new Size(formWidth, formHeight);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Choices());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            string receiptContent = TripHistoryService.ReadLatestReceipt();
            if (string.IsNullOrWhiteSpace(receiptContent))
            {
                CustomMessageBox.Show("No trip data found.", "Error");
                return;
            }

            richTextBox1.Text = receiptContent;
            pictureBoxInnerReport.Visible = true;
            richTextBox1.Visible = true;
            richTextBox1.BringToFront();

            button1.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            buttonPrint.Visible = true;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            CustomMessageBox.Show("Trip receipt printed successfully!", "Print");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new Shortest_Path(false));
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
        }

        private void ReceiptGeneration_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectionLength = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
