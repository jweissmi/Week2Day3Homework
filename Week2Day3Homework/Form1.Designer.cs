namespace Week2Day3Homework
{
    partial class MainForm
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
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.HumanButton = new System.Windows.Forms.Button();
            this.DogButton = new System.Windows.Forms.Button();
            this.SnakeButton = new System.Windows.Forms.Button();
            this.LizardButton = new System.Windows.Forms.Button();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.HumanDesignPanel = new System.Windows.Forms.Panel();
            this.labelHumanName = new System.Windows.Forms.Label();
            this.textBoxHumanName = new System.Windows.Forms.TextBox();
            this.labelHumanSpecies = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ButtonPanel.SuspendLayout();
            this.SelectionPanel.SuspendLayout();
            this.HumanDesignPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoSize = true;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.LizardButton);
            this.ButtonPanel.Controls.Add(this.SnakeButton);
            this.ButtonPanel.Controls.Add(this.DogButton);
            this.ButtonPanel.Controls.Add(this.HumanButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(280, 693);
            this.ButtonPanel.TabIndex = 0;
            // 
            // Splitter
            // 
            this.Splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Splitter.Location = new System.Drawing.Point(280, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(6, 693);
            this.Splitter.TabIndex = 1;
            this.Splitter.TabStop = false;
            // 
            // HumanButton
            // 
            this.HumanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HumanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanButton.Location = new System.Drawing.Point(21, 58);
            this.HumanButton.Name = "HumanButton";
            this.HumanButton.Size = new System.Drawing.Size(237, 64);
            this.HumanButton.TabIndex = 0;
            this.HumanButton.Text = "Human";
            this.HumanButton.UseVisualStyleBackColor = true;
            // 
            // DogButton
            // 
            this.DogButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DogButton.Location = new System.Drawing.Point(21, 161);
            this.DogButton.Name = "DogButton";
            this.DogButton.Size = new System.Drawing.Size(237, 64);
            this.DogButton.TabIndex = 1;
            this.DogButton.Text = "Dog";
            this.DogButton.UseVisualStyleBackColor = true;
            // 
            // SnakeButton
            // 
            this.SnakeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnakeButton.Location = new System.Drawing.Point(21, 257);
            this.SnakeButton.Name = "SnakeButton";
            this.SnakeButton.Size = new System.Drawing.Size(237, 64);
            this.SnakeButton.TabIndex = 2;
            this.SnakeButton.Text = "Snake";
            this.SnakeButton.UseVisualStyleBackColor = true;
            // 
            // LizardButton
            // 
            this.LizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LizardButton.Location = new System.Drawing.Point(21, 354);
            this.LizardButton.Name = "LizardButton";
            this.LizardButton.Size = new System.Drawing.Size(237, 64);
            this.LizardButton.TabIndex = 3;
            this.LizardButton.Text = "Lizard";
            this.LizardButton.UseVisualStyleBackColor = true;
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectionPanel.Controls.Add(this.HumanDesignPanel);
            this.SelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectionPanel.Location = new System.Drawing.Point(286, 0);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(556, 693);
            this.SelectionPanel.TabIndex = 2;
            // 
            // ListPanel
            // 
            this.ListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListPanel.Location = new System.Drawing.Point(286, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(556, 322);
            this.ListPanel.TabIndex = 3;
            // 
            // HumanDesignPanel
            // 
            this.HumanDesignPanel.Controls.Add(this.textBox5);
            this.HumanDesignPanel.Controls.Add(this.textBox4);
            this.HumanDesignPanel.Controls.Add(this.textBox3);
            this.HumanDesignPanel.Controls.Add(this.textBox2);
            this.HumanDesignPanel.Controls.Add(this.textBox1);
            this.HumanDesignPanel.Controls.Add(this.label5);
            this.HumanDesignPanel.Controls.Add(this.label4);
            this.HumanDesignPanel.Controls.Add(this.label3);
            this.HumanDesignPanel.Controls.Add(this.label2);
            this.HumanDesignPanel.Controls.Add(this.labelHumanSpecies);
            this.HumanDesignPanel.Controls.Add(this.textBoxHumanName);
            this.HumanDesignPanel.Controls.Add(this.labelHumanName);
            this.HumanDesignPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HumanDesignPanel.Location = new System.Drawing.Point(0, 0);
            this.HumanDesignPanel.Name = "HumanDesignPanel";
            this.HumanDesignPanel.Size = new System.Drawing.Size(554, 691);
            this.HumanDesignPanel.TabIndex = 0;
            // 
            // labelHumanName
            // 
            this.labelHumanName.AutoSize = true;
            this.labelHumanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumanName.Location = new System.Drawing.Point(161, 354);
            this.labelHumanName.Name = "labelHumanName";
            this.labelHumanName.Size = new System.Drawing.Size(65, 24);
            this.labelHumanName.TabIndex = 0;
            this.labelHumanName.Text = "Name";
            this.labelHumanName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxHumanName
            // 
            this.textBoxHumanName.Location = new System.Drawing.Point(238, 353);
            this.textBoxHumanName.Name = "textBoxHumanName";
            this.textBoxHumanName.Size = new System.Drawing.Size(294, 22);
            this.textBoxHumanName.TabIndex = 1;
            // 
            // labelHumanSpecies
            // 
            this.labelHumanSpecies.AutoSize = true;
            this.labelHumanSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumanSpecies.Location = new System.Drawing.Point(139, 393);
            this.labelHumanSpecies.Name = "labelHumanSpecies";
            this.labelHumanSpecies.Size = new System.Drawing.Size(85, 24);
            this.labelHumanSpecies.TabIndex = 2;
            this.labelHumanSpecies.Text = "Species";
            this.labelHumanSpecies.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "External Covering";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Legs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Avg. Num of Offspring";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hair Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 438);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(294, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 480);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(238, 517);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(238, 557);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 22);
            this.textBox5.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 693);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.SelectionPanel);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.ButtonPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ButtonPanel.ResumeLayout(false);
            this.SelectionPanel.ResumeLayout(false);
            this.HumanDesignPanel.ResumeLayout(false);
            this.HumanDesignPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.Button LizardButton;
        private System.Windows.Forms.Button SnakeButton;
        private System.Windows.Forms.Button DogButton;
        private System.Windows.Forms.Button HumanButton;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel HumanDesignPanel;
        private System.Windows.Forms.Label labelHumanName;
        private System.Windows.Forms.TextBox textBoxHumanName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHumanSpecies;
    }
}

