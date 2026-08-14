using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsoft_Rewards_Simulator
{
    public partial class Form2 : Form
    {
        private MainWindow mainWindow;

        public Form2(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        public Form2()
        {
            InitializeComponent();
        }

        public int numberPoints;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mainWindow.NumberPoints++;

            labelSearch1.Text = "Points: " + mainWindow.NumberPoints;

            if (mainWindow.NumberPoints >= 150)
            {
                mainWindow.NumberPoints = 150;
                labelSearch1.Text = "You Have Hit The Daily Limit!";
            }
        }

        private void pictureBoxMS_Click(object sender, EventArgs e)
        {

        }
    }
}
