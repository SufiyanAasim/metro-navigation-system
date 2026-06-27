using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_App
{
    public class CustomMessageBox : Form
    {
        private CustomMessageBox(string text, string caption)
        {
            this.Text = caption;
            this.Size = new Size(380, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(15, 25, 45); // Deep premium dark blue
            this.ForeColor = Color.White;
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;

            // Text Label
            Label textLabel = new Label();
            textLabel.Text = text;
            textLabel.Location = new Point(20, 20);
            textLabel.Size = new Size(340, 50);
            textLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            textLabel.ForeColor = Color.White;
            textLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(textLabel);

            // OK Button
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            okButton.ForeColor = Color.White;
            okButton.BackColor = Color.FromArgb(13, 148, 136); // Teal
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.Cursor = Cursors.Hand;
            okButton.Size = new Size(110, 34);
            okButton.Location = new Point(135, 85);
            okButton.DialogResult = DialogResult.OK;
            okButton.Click += (s, e) => this.Close();
            this.Controls.Add(okButton);

            this.AcceptButton = okButton;
        }

        public static DialogResult Show(string text, string caption = "Information")
        {
            using (var box = new CustomMessageBox(text, caption))
            {
                return box.ShowDialog();
            }
        }
    }
}
