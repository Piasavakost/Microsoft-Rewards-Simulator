namespace Microsoft_Rewards_Simulator;

partial class MainWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        progressBar1 = new ProgressBar();
        labelprosent = new Label();
        labelPoints = new Label();
        taskSearch = new Button();
        label2 = new Label();
        labelGoal = new Label();
        buttonDaily = new Button();
        SavePoints = new Button();
        buttonReset = new Button();
        LoadPoints = new Button();
        SuspendLayout();
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(12, 118);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(539, 23);
        progressBar1.TabIndex = 0;
        // 
        // labelprosent
        // 
        labelprosent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelprosent.Location = new Point(276, 76);
        labelprosent.Name = "labelprosent";
        labelprosent.Size = new Size(100, 39);
        labelprosent.TabIndex = 1;
        labelprosent.Text = "0 %";
        // 
        // labelPoints
        // 
        labelPoints.AutoSize = true;
        labelPoints.Location = new Point(494, 29);
        labelPoints.Name = "labelPoints";
        labelPoints.Size = new Size(52, 15);
        labelPoints.TabIndex = 2;
        labelPoints.Text = "Points: 0";
        // 
        // taskSearch
        // 
        taskSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        taskSearch.Location = new Point(94, 405);
        taskSearch.Name = "taskSearch";
        taskSearch.Size = new Size(177, 81);
        taskSearch.TabIndex = 3;
        taskSearch.Text = "Search";
        taskSearch.UseVisualStyleBackColor = true;
        taskSearch.Click += taskSearch_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(260, 343);
        label2.Name = "label2";
        label2.Size = new Size(46, 21);
        label2.TabIndex = 5;
        label2.Text = "Tasks";
        // 
        // labelGoal
        // 
        labelGoal.AutoSize = true;
        labelGoal.Location = new Point(28, 37);
        labelGoal.Name = "labelGoal";
        labelGoal.Size = new Size(61, 15);
        labelGoal.TabIndex = 6;
        labelGoal.Text = "Goal: 1000";
        // 
        // buttonDaily
        // 
        buttonDaily.Location = new Point(301, 405);
        buttonDaily.Name = "buttonDaily";
        buttonDaily.Size = new Size(169, 81);
        buttonDaily.TabIndex = 7;
        buttonDaily.Text = "Daily Seen";
        buttonDaily.UseVisualStyleBackColor = true;
        buttonDaily.Click += buttonDaily_Click;
        // 
        // SavePoints
        // 
        SavePoints.Location = new Point(231, 157);
        SavePoints.Name = "SavePoints";
        SavePoints.Size = new Size(111, 40);
        SavePoints.TabIndex = 8;
        SavePoints.Text = "Save Points";
        SavePoints.UseVisualStyleBackColor = true;
        SavePoints.Click += SavePoints_Click;
        // 
        // buttonReset
        // 
        buttonReset.Enabled = false;
        buttonReset.Location = new Point(231, 221);
        buttonReset.Name = "buttonReset";
        buttonReset.Size = new Size(111, 23);
        buttonReset.TabIndex = 9;
        buttonReset.Text = "Reset Points";
        buttonReset.UseVisualStyleBackColor = true;
        buttonReset.Visible = false;
        buttonReset.Click += buttonReset_Click;
        // 
        // LoadPoints
        // 
        LoadPoints.Location = new Point(231, 276);
        LoadPoints.Name = "LoadPoints";
        LoadPoints.Size = new Size(111, 38);
        LoadPoints.TabIndex = 10;
        LoadPoints.Text = "Load Points";
        LoadPoints.UseVisualStyleBackColor = true;
        LoadPoints.Click += LoadPoints_Click;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(563, 498);
        Controls.Add(LoadPoints);
        Controls.Add(buttonReset);
        Controls.Add(SavePoints);
        Controls.Add(buttonDaily);
        Controls.Add(labelGoal);
        Controls.Add(label2);
        Controls.Add(taskSearch);
        Controls.Add(labelPoints);
        Controls.Add(labelprosent);
        Controls.Add(progressBar1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainWindow";
        Text = "Microsoft Rewards Simulator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ProgressBar progressBar1;
    private Label labelprosent;
    private Label labelPoints;
    private Button taskSearch;
    private Label label2;
    private Label labelGoal;
    private Button buttonDaily;
    private Button SavePoints;
    private Button buttonReset;
    private Button LoadPoints;
}
