namespace Microsoft_Rewards_Simulator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            labelSearch1 = new Label();
            pictureBoxMS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMS).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelSearch1
            // 
            labelSearch1.AutoSize = true;
            labelSearch1.Location = new Point(146, 132);
            labelSearch1.Name = "labelSearch1";
            labelSearch1.Size = new Size(35, 15);
            labelSearch1.TabIndex = 1;
            labelSearch1.Text = "Hello";
            // 
            // pictureBoxMS
            // 
            pictureBoxMS.Image = (Image)resources.GetObject("pictureBoxMS.Image");
            pictureBoxMS.Location = new Point(79, 67);
            pictureBoxMS.Name = "pictureBoxMS";
            pictureBoxMS.Size = new Size(170, 62);
            pictureBoxMS.TabIndex = 2;
            pictureBoxMS.TabStop = false;
            pictureBoxMS.Click += pictureBoxMS_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 450);
            Controls.Add(pictureBoxMS);
            Controls.Add(labelSearch1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Microsoft Search";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label labelSearch1;
        private PictureBox pictureBoxMS;
    }
}