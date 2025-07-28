using System;
using System.IO;
using System.Windows.Forms;

namespace Metro_App
{
    public partial class Reciept_generation : Form
    {
        public Reciept_generation()
        {
            InitializeComponent();
            richTextBox1.Visible = false;  // Initially hide the RichTextBox
            richTextBox1.ReadOnly = true;  // Make the RichTextBox uneditable at runtime
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Thank you for visiting Metro App");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string receiptFile = "C:\\Users\\DELL\\source\\repos\\Metro App\\Metro App\\bin\\Debug\\Metro App Travel History\\Receipt.txt";
            if (File.Exists(receiptFile))
            {
                string receiptContent = File.ReadAllText(receiptFile);
                richTextBox1.Text = receiptContent;

                // Show the RichTextBox after reading the content
                richTextBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("No trip data found.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This button functionality can be implemented as needed
        }

        private void Reciept_generation_Load(object sender, EventArgs e)
        {
            // Additional logic for form load can go here
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Implement button4 click logic if needed
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent any key press that would change the content
            e.Handled = true;
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Prevent selection by setting SelectionLength to 0
            richTextBox1.SelectionLength = 0;
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Prevent text selection from being copied
            richTextBox1.SelectionLength = 0;
    
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // You can add logic here if needed. 
            // This event is triggered whenever the text in the RichTextBox changes.
        }


    }

}
