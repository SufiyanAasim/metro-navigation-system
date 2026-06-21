using System;
using System.Windows.Forms;
using Metro_App.Frontend;

namespace Metro_App
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            FormClosing += (s, e) => Application.Exit();
        }

        private void Map_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNavigator.ShowNext(this, new Choices());
        }
    }
}
