using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metro_App.Backend;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class Shortest_Path : Form
    {
        private readonly string[] nodes = MetroNetwork.Stations;

        private bool _cameFromChoices;

        public Shortest_Path(bool cameFromChoices = false)
        {
            InitializeComponent();
            _cameFromChoices = cameFromChoices;
            this.Icon = global::Metro_App.Properties.Resources.metro_app_icon;
            FormClosing += (s, e) => Application.Exit();

            // Set parent to pictureBox2 for correct transparency over the map
            button1.Parent = pictureBox2;
            buttonNext.Parent = pictureBox2;
            button2.Parent = pictureBox2;
            label1.Parent = pictureBox2;
            progressBarLoading.Parent = pictureBox2;
            buttonStartStation.Parent = pictureBox2;
            buttonEndStation.Parent = pictureBox2;
            textBoxStart.Parent = pictureBox2;
            textBoxEnd.Parent = pictureBox2;

            // Make sure the window is fixed size to prevent layout stretching
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private int _startStationIndex = -1;
        private int _endStationIndex = -1;

        private void ShowStationMenu(Control sourceControl, Action<int> onSelect)
        {
            var menu = new ContextMenuStrip();
            menu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            menu.BackColor = System.Drawing.Color.FromArgb(15, 25, 45);
            menu.ForeColor = System.Drawing.Color.White;
            menu.ShowImageMargin = false;

            for (int i = 0; i < nodes.Length; i++)
            {
                int index = i;
                var item = new ToolStripMenuItem(nodes[i]);
                item.ForeColor = System.Drawing.Color.White;
                item.Click += (sender, e) => onSelect(index);
                menu.Items.Add(item);
            }

            menu.Show(sourceControl, new System.Drawing.Point(0, sourceControl.Height));
        }

        private void buttonStartStation_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            ShowStationMenu(buttonStartStation, (index) =>
            {
                _startStationIndex = index;
                textBoxStart.Text = nodes[index];
            });
        }

        private void buttonEndStation_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            ShowStationMenu(buttonEndStation, (index) =>
            {
                _endStationIndex = index;
                textBoxEnd.Text = nodes[index];
            });
        }

        private bool ShowShortestRoute(int start, int end)
        {
            RouteResult route = MetroNetwork.FindShortestRoute(start, end);
            if (route == null)
            {
                CustomMessageBox.Show("No path exists between the selected stations.", "Error");
                return false;
            }

            TripHistoryService.SaveTrip(nodes[start], nodes[end], route.Distance);
            CustomMessageBox.Show(
                $"Shortest path from {nodes[start]} to {nodes[end]}: {route.DisplayPath}{Environment.NewLine}Distance: {route.Distance} km",
                "Shortest Route");

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            if (_cameFromChoices)
            {
                FormNavigator.ShowNext(this, new Choices());
            }
            else
            {
                FormNavigator.ShowNext(this, new Stations(false));
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            FormNavigator.ShowNext(this, new ReceiptGeneration());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            SoundHelper.PlayTap();
            if (_startStationIndex == -1 || _endStationIndex == -1)
            {
                CustomMessageBox.Show("Please select both start and end stations.", "Missing Selection");
                return;
            }

            int startNode = _startStationIndex;
            int endNode = _endStationIndex;

            if (startNode == endNode)
            {
                CustomMessageBox.Show("Please choose two different stations.", "Invalid Selection");
                return;
            }

            progressBarLoading.Visible = true;
            label1.Visible = true;
            label1.Text = "Calculating the shortest path...";

            for (int i = 0; i <= 100; i += 10)
            {
                progressBarLoading.Value = i;
                await Task.Delay(50);
            }

            progressBarLoading.Visible = false;
            label1.Visible = false;

            if (!ShowShortestRoute(startNode, endNode))
            {
                return;
            }

            FormNavigator.ShowNext(this, new ReceiptGeneration());
        }

        private void Shortest_Path_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }

        private void radioButtonSingerChowrangi_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonShaanChowrangi_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonIndusHospital_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonRahatPark_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonDefenceMorr_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonFTC_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonFrereHall_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonNumaish_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonDrighRoad1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonMillenniumMall_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void progressBarLoading_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
