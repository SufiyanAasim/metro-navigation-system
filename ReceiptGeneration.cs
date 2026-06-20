using System;
using System.Windows.Forms;
using Metro_App.Backend;

namespace Metro_App
{
    public partial class ReceiptGeneration : Form
    {
        public ReceiptGeneration()
        {
            InitializeComponent();
            richTextBox1.Visible = false;
            richTextBox1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Metro Navigation System.");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receiptContent = TripHistoryService.ReadLatestReceipt();
            if (string.IsNullOrWhiteSpace(receiptContent))
            {
                MessageBox.Show("No trip data found.");
                return;
            }

            richTextBox1.Text = receiptContent;
            richTextBox1.Visible = true;
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
