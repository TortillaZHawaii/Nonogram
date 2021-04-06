
namespace PWSG_LAB5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoosePuzzleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPuzzleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatePuzzleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DifficultyTextBox = new System.Windows.Forms.TextBox();
            this.PuzzleTitleTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.PuzzleTitleLabel = new System.Windows.Forms.Label();
            this.CongratulationsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuItem,
            this.CreateMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewGameMenuItem
            // 
            this.NewGameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomMenuItem,
            this.ChoosePuzzleMenuItem,
            this.LoadPuzzleMenuItem});
            this.NewGameMenuItem.Name = "NewGameMenuItem";
            this.NewGameMenuItem.Size = new System.Drawing.Size(77, 20);
            this.NewGameMenuItem.Text = "New Game";
            // 
            // RandomMenuItem
            // 
            this.RandomMenuItem.Name = "RandomMenuItem";
            this.RandomMenuItem.Size = new System.Drawing.Size(159, 22);
            this.RandomMenuItem.Text = "Random";
            this.RandomMenuItem.Click += new System.EventHandler(this.RandomMenuItem_Click);
            // 
            // ChoosePuzzleMenuItem
            // 
            this.ChoosePuzzleMenuItem.Name = "ChoosePuzzleMenuItem";
            this.ChoosePuzzleMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ChoosePuzzleMenuItem.Text = "Choose puzzle...";
            this.ChoosePuzzleMenuItem.Click += new System.EventHandler(this.ChoosePuzzleMenuItem_Click);
            // 
            // LoadPuzzleMenuItem
            // 
            this.LoadPuzzleMenuItem.Name = "LoadPuzzleMenuItem";
            this.LoadPuzzleMenuItem.Size = new System.Drawing.Size(159, 22);
            this.LoadPuzzleMenuItem.Text = "Load puzzle";
            this.LoadPuzzleMenuItem.Click += new System.EventHandler(this.LoadPuzzleMenuItem_Click);
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatePuzzleMenuItem});
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(62, 20);
            this.CreateMenuItem.Text = "Create...";
            // 
            // CreatePuzzleMenuItem
            // 
            this.CreatePuzzleMenuItem.Name = "CreatePuzzleMenuItem";
            this.CreatePuzzleMenuItem.Size = new System.Drawing.Size(144, 22);
            this.CreatePuzzleMenuItem.Text = "Create puzzle";
            this.CreatePuzzleMenuItem.Click += new System.EventHandler(this.CreatePuzzleMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(350, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 296);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.SaveButton);
            this.SettingsGroupBox.Controls.Add(this.DifficultyTextBox);
            this.SettingsGroupBox.Controls.Add(this.PuzzleTitleTextBox);
            this.SettingsGroupBox.Controls.Add(this.DifficultyLabel);
            this.SettingsGroupBox.Controls.Add(this.PuzzleTitleLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(200, 115);
            this.SettingsGroupBox.TabIndex = 2;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Puzzle Settings";
            this.SettingsGroupBox.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(119, 82);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.Location = new System.Drawing.Point(94, 53);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.Size = new System.Drawing.Size(100, 23);
            this.DifficultyTextBox.TabIndex = 3;
            // 
            // PuzzleTitleTextBox
            // 
            this.PuzzleTitleTextBox.Location = new System.Drawing.Point(94, 20);
            this.PuzzleTitleTextBox.Name = "PuzzleTitleTextBox";
            this.PuzzleTitleTextBox.Size = new System.Drawing.Size(100, 23);
            this.PuzzleTitleTextBox.TabIndex = 2;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(6, 56);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(55, 15);
            this.DifficultyLabel.TabIndex = 1;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // PuzzleTitleLabel
            // 
            this.PuzzleTitleLabel.AutoSize = true;
            this.PuzzleTitleLabel.Location = new System.Drawing.Point(7, 23);
            this.PuzzleTitleLabel.Name = "PuzzleTitleLabel";
            this.PuzzleTitleLabel.Size = new System.Drawing.Size(65, 15);
            this.PuzzleTitleLabel.TabIndex = 0;
            this.PuzzleTitleLabel.Text = "Puzzle Title";
            // 
            // CongratulationsLabel
            // 
            this.CongratulationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CongratulationsLabel.AutoSize = true;
            this.CongratulationsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CongratulationsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CongratulationsLabel.Location = new System.Drawing.Point(373, 709);
            this.CongratulationsLabel.Name = "CongratulationsLabel";
            this.CongratulationsLabel.Size = new System.Drawing.Size(233, 37);
            this.CongratulationsLabel.TabIndex = 3;
            this.CongratulationsLabel.Text = "Congratulations!";
            this.CongratulationsLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 757);
            this.Controls.Add(this.CongratulationsLabel);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nonogram";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChoosePuzzleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadPuzzleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreatePuzzleMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox PuzzleSettingsGroupBox;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DifficultyTextBox;
        private System.Windows.Forms.TextBox PuzzleTitleTextBox;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label PuzzleTitleLabel;
        private System.Windows.Forms.Label CongratulationsLabel;
    }
}

