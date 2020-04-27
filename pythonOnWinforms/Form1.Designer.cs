namespace pythonOnWinforms
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.argsTextBox = new System.Windows.Forms.TextBox();
            this.cmdLabel = new System.Windows.Forms.Label();
            this.argsLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(732, 328);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(252, 31);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(366, 22);
            this.cmdTextBox.TabIndex = 2;
            // 
            // argsTextBox
            // 
            this.argsTextBox.Location = new System.Drawing.Point(252, 68);
            this.argsTextBox.Name = "argsTextBox";
            this.argsTextBox.Size = new System.Drawing.Size(366, 22);
            this.argsTextBox.TabIndex = 3;
            // 
            // cmdLabel
            // 
            this.cmdLabel.AutoSize = true;
            this.cmdLabel.Location = new System.Drawing.Point(194, 31);
            this.cmdLabel.Name = "cmdLabel";
            this.cmdLabel.Size = new System.Drawing.Size(34, 17);
            this.cmdLabel.TabIndex = 4;
            this.cmdLabel.Text = "cmd";
            // 
            // argsLabel
            // 
            this.argsLabel.AutoSize = true;
            this.argsLabel.Location = new System.Drawing.Point(194, 68);
            this.argsLabel.Name = "argsLabel";
            this.argsLabel.Size = new System.Drawing.Size(37, 17);
            this.argsLabel.TabIndex = 5;
            this.argsLabel.Text = "Args";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResultLabel.Location = new System.Drawing.Point(624, 34);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(134, 34);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Python Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.argsLabel);
            this.Controls.Add(this.cmdLabel);
            this.Controls.Add(this.argsTextBox);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.TextBox argsTextBox;
        private System.Windows.Forms.Label cmdLabel;
        private System.Windows.Forms.Label argsLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

