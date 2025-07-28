using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_App
{
    public partial class Shortest_Path : Form
    {
        public Shortest_Path()
        {
            InitializeComponent();
        }

        private int[,] graph = new int[,]
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 },
            { 0, 0, 0, 2, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 6, 4, 0, 0, 0, 0, 3 },
            { 0, 2, 6, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 4, 0, 0, 2, 1, 2, 0, 0 },
            { 0, 0, 0, 1, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 3 },
            { 2, 0, 3, 0, 0, 0, 0, 0, 3, 0 }
        };

        private string[] nodes = { "Millennium Mall", "Numaish", "FTC", "Frere Hall", "KPT Interchange", "Defence Morr", "Indus Hospital", "Shaan Chowrangi", "Singer Chowrangi", "Drigh Road" };

        private void DijkstraAlgorithm(int start, int end)
        {
            int V = 10;
            int[] dist = new int[V];
            bool[] sptSet = new bool[V];
            int[] prev = new int[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
                prev[i] = -1;
            }

            dist[start] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinDistance(dist, sptSet);
                sptSet[u] = true;

                for (int v = 0; v < V; v++)
                {
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        prev[v] = u;
                    }
                }
            }

            if (dist[end] == int.MaxValue)
            {
                MessageBox.Show("No path exists between the selected stations.");
            }
            else
            {
                string path = GetPath(prev, start, end);
                MessageBox.Show($"Shortest path from {nodes[start]} to {nodes[end]}: {path}\nDistance: {dist[end]} km");

                SaveTripInfo(nodes[start], nodes[end], dist[end]);
            }
        }

        private int MinDistance(int[] dist, bool[] sptSet)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < 10; v++)
            {
                if (!sptSet[v] && dist[v] <= min)
                {
                    min = dist[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private string GetPath(int[] prev, int start, int end)
        {
            string path = nodes[end];
            int current = end;
            while (prev[current] != -1)
            {
                path = nodes[prev[current]] + " -> " + path;
                current = prev[current];
            }
            return path;
        }

        private int GetNextTripNumber()
        {
            string tripNumberFile = "C:\\Users\\DELL\\source\\repos\\Metro App\\Metro App\\bin\\Debug\\Metro App Travel History\\TripNumber.txt";

            if (!File.Exists(tripNumberFile))
            {
                File.Create(tripNumberFile).Close();
                return 1;
            }

            string lastTripNumber = File.ReadAllText(tripNumberFile);
            int tripNumber = string.IsNullOrEmpty(lastTripNumber) ? 1 : int.Parse(lastTripNumber);

            tripNumber++;
            File.WriteAllText(tripNumberFile, tripNumber.ToString());

            return tripNumber;
        }

        private void SaveTripInfo(string startStation, string endStation, int distance)
        {
            string receiptFile = "C:\\Users\\DELL\\source\\repos\\Metro App\\Metro App\\bin\\Debug\\Metro App Travel History\\Travel History.txt";
            int tripNumber = GetNextTripNumber();
            string tripInfo = $"Trip {tripNumber}:\nStarting Destination: {startStation}\nFinal Station: {endStation}\nDistance: {distance} km\nTime: {DateTime.Now.ToShortTimeString()}\nDate: {DateTime.Now.ToString("dddd, d MMMM yyyy")}\n\n";

            if (!File.Exists(receiptFile))
            {
                File.Create(receiptFile).Close();
            }

            File.AppendAllText(receiptFile, tripInfo);
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
                MessageBox.Show("Seriously????!!!!!!!!!!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            progressBarLoading.Visible = true;
            label1.Visible = true;
            label1.Text = "Calculating the shortest path... Please wait.";

            for (int i = 0; i <= 100; i += 10)
            {
                progressBarLoading.Value = i;
                await Task.Delay(50);
            }

            progressBarLoading.Visible = false;
            label1.Visible = false;

            DijkstraAlgorithm(startNode, endNode);

            DialogResult result = MessageBox.Show("Ready to go to the next step??", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Reciept_generation reciept_Generation = new Reciept_generation();
                this.Hide();
                reciept_Generation.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
        }

        


// Event handler for pictureBox clicks
private void pictureBox_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void pictureBox8_Click(object sender, EventArgs e) { }
        private void pictureBox9_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }
        private void pictureBox11_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Shortest_Path_Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shortest_Path_Load(object sender, EventArgs e)
        {
            // Populate the ComboBoxes with the station names
            comboBox1.Items.Clear();  /// Clear any of the existing items
            comboBox2.Items.Clear();  /// Clear any of the existing items

            foreach (var station in nodes)
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
            /// logic for handling the key press goes here.
        }

    }
}
