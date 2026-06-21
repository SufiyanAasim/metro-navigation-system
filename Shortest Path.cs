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

        public Shortest_Path()
        {
            InitializeComponent();
            FormClosing += (s, e) => Application.Exit();
        }

        private bool ShowShortestRoute(int start, int end)
        {
            RouteResult route = MetroNetwork.FindShortestRoute(start, end);
            if (route == null)
            {
                MessageBox.Show("No path exists between the selected stations.");
                return false;
            }

            TripHistoryService.SaveTrip(nodes[start], nodes[end], route.Distance);
            MessageBox.Show(
                $"Shortest path from {nodes[start]} to {nodes[end]}: {route.DisplayPath}{Environment.NewLine}Distance: {route.Distance} km",
                "Shortest Route",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both start and end stations.");
                return;
            }

            int startNode = comboBox1.SelectedIndex;
            int endNode = comboBox2.SelectedIndex;

            if (startNode == endNode)
            {
                MessageBox.Show("Please choose two different stations.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            DialogResult result = MessageBox.Show("Would you like to view the receipt?", "Receipt", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormNavigator.ShowNext(this, new ReceiptGeneration());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Shortest_Path_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            foreach (string station in nodes)
            {
                comboBox1.Items.Add(station);
                comboBox2.Items.Add(station);
            }
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
