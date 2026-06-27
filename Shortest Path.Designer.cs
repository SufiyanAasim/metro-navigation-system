namespace Metro_App
{
    partial class Shortest_Path
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStartStation = new System.Windows.Forms.Button();
            this.buttonEndStation = new System.Windows.Forms.Button();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Metro_App.Properties.Resources.btn_back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(500, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 
            // buttonStartStation
            // 
            this.buttonStartStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStation.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartStation.FlatAppearance.BorderSize = 0;
            this.buttonStartStation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStartStation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStartStation.BackgroundImage = global::Metro_App.Properties.Resources.btn_first_destination;
            this.buttonStartStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartStation.Location = new System.Drawing.Point(50, 15);
            this.buttonStartStation.Name = "buttonStartStation";
            this.buttonStartStation.Size = new System.Drawing.Size(180, 60);
            this.buttonStartStation.TabIndex = 13;
            this.buttonStartStation.Text = "";
            this.buttonStartStation.UseVisualStyleBackColor = false;
            this.buttonStartStation.Click += new System.EventHandler(this.buttonStartStation_Click);
            // 
            // buttonEndStation
            // 
            this.buttonEndStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndStation.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndStation.FlatAppearance.BorderSize = 0;
            this.buttonEndStation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEndStation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEndStation.BackgroundImage = global::Metro_App.Properties.Resources.btn_final_destination;
            this.buttonEndStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEndStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEndStation.Location = new System.Drawing.Point(260, 15);
            this.buttonEndStation.Name = "buttonEndStation";
            this.buttonEndStation.Size = new System.Drawing.Size(180, 60);
            this.buttonEndStation.TabIndex = 14;
            this.buttonEndStation.Text = "";
            this.buttonEndStation.UseVisualStyleBackColor = false;
            this.buttonEndStation.Click += new System.EventHandler(this.buttonEndStation_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.BackColor = System.Drawing.Color.FromArgb(4, 10, 20);
            this.textBoxStart.ForeColor = System.Drawing.Color.White;
            this.textBoxStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStart.Location = new System.Drawing.Point(50, 85);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.ReadOnly = true;
            this.textBoxStart.Size = new System.Drawing.Size(180, 28);
            this.textBoxStart.TabIndex = 20;
            this.textBoxStart.Text = "Not Selected";
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.BackColor = System.Drawing.Color.FromArgb(4, 10, 20);
            this.textBoxEnd.ForeColor = System.Drawing.Color.White;
            this.textBoxEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnd.Location = new System.Drawing.Point(260, 85);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.ReadOnly = true;
            this.textBoxEnd.Size = new System.Drawing.Size(180, 28);
            this.textBoxEnd.TabIndex = 21;
            this.textBoxEnd.Text = "Not Selected";
            this.textBoxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Metro_App.Properties.Resources.btn_find;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(12, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(496, 12);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(274, 22);
            this.progressBarLoading.Step = 5;
            this.progressBarLoading.TabIndex = 17;
            this.progressBarLoading.Tag = "Calculating the Shortest Path";
            this.progressBarLoading.Visible = false;
            this.progressBarLoading.Click += new System.EventHandler(this.progressBarLoading_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(506, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Metro_App.Properties.Resources.metro_map;
            this.pictureBox1.InitialImage = global::Metro_App.Properties.Resources.metro_map;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Metro_App.Properties.Resources.metro_map;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(784, 553);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.BackgroundImage = global::Metro_App.Properties.Resources.btn_next;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.Location = new System.Drawing.Point(640, 500);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 40);
            this.buttonNext.TabIndex = 19;
            this.buttonNext.Text = "";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Shortest_Path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.buttonEndStation);
            this.Controls.Add(this.buttonStartStation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Shortest_Path";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortest Path";
            this.Load += new System.EventHandler(this.Shortest_Path_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStartStation;
        private System.Windows.Forms.Button buttonEndStation;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext;
    }
}