using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Microsoft_Rewards_Simulator;

public partial class MainWindow : Form
{
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int NumberPoints { get; set; } = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void taskSearch_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2(this);
        form2.Show();

        NumberPoints += 1;

        labelPoints.Text = "Points: " + NumberPoints.ToString();
    }

    private void buttonDaily_Click(object sender, EventArgs e)
    {
        NumberPoints += 10;

        Form3 form3 = new Form3();
        form3.Show();

        labelPoints.Text = "Points: " + NumberPoints.ToString();
        progressBar1.Value = NumberPoints / 10;
        labelprosent.Text = (NumberPoints / 10).ToString() + " %";
    }

    private void SavePoints_Click(object sender, EventArgs e)
    {
        File.WriteAllText("Saves/SavePoints.txt", NumberPoints.ToString());
    }

    private void buttonReset_Click(object sender, EventArgs e)
    {

    }

    private void LoadPoints_Click(object sender, EventArgs e)
    {
        int NumberPoints = int.Parse(File.ReadAllText("Saves/SavePoints.txt"));
        labelPoints.Text = "Points: " + File.ReadAllText("Saves/SavePoints.txt");
        progressBar1.Value = int.Parse(File.ReadAllText("Saves/SavePoints.txt")) / 10;
        labelprosent.Text = File.ReadAllText("Saves/SavePoints.txt") + " %";
    }
}