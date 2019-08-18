namespace TestApp
{
    partial class TestForm
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
            this.buttonProcess = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxlabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProbability = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonProcess.FlatAppearance.BorderSize = 4;
            this.buttonProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcess.Font = new System.Drawing.Font("Arial Black", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(602, 27);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(230, 88);
            this.buttonProcess.TabIndex = 2;
            this.buttonProcess.Text = "Predict";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 600);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(836, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.RestoreDirectory = true;
            // 
            // textBoxlabel
            // 
            this.textBoxlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxlabel.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlabel.Location = new System.Drawing.Point(602, 210);
            this.textBoxlabel.Multiline = true;
            this.textBoxlabel.Name = "textBoxlabel";
            this.textBoxlabel.ReadOnly = true;
            this.textBoxlabel.Size = new System.Drawing.Size(230, 212);
            this.textBoxlabel.TabIndex = 12;
            this.textBoxlabel.Text = "staffordshire_bull_terrier";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "Label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProbability
            // 
            this.textBoxProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProbability.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProbability.Location = new System.Drawing.Point(602, 515);
            this.textBoxProbability.Name = "textBoxProbability";
            this.textBoxProbability.ReadOnly = true;
            this.textBoxProbability.Size = new System.Drawing.Size(230, 81);
            this.textBoxProbability.TabIndex = 14;
            this.textBoxProbability.Text = "24%";
            this.textBoxProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "Probability:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProbability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxlabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonProcess);
            this.MinimumSize = new System.Drawing.Size(852, 638);
            this.Name = "TestForm";
            this.Text = "DogOrCat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProbability;
        private System.Windows.Forms.Label label2;
    }
}

