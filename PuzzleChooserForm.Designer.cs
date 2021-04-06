
namespace PWSG_LAB5
{
    partial class PuzzleChooserForm
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
            this.ChooseDirectoryButton = new System.Windows.Forms.Button();
            this.PuzzlesListView = new System.Windows.Forms.ListView();
            this.TitleHeader = new System.Windows.Forms.ColumnHeader();
            this.WidthHeader = new System.Windows.Forms.ColumnHeader();
            this.HeightHeader = new System.Windows.Forms.ColumnHeader();
            this.DifficultyHeader = new System.Windows.Forms.ColumnHeader();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseDirectoryButton
            // 
            this.ChooseDirectoryButton.AutoSize = true;
            this.ChooseDirectoryButton.Location = new System.Drawing.Point(465, 10);
            this.ChooseDirectoryButton.Name = "ChooseDirectoryButton";
            this.ChooseDirectoryButton.Size = new System.Drawing.Size(107, 25);
            this.ChooseDirectoryButton.TabIndex = 1;
            this.ChooseDirectoryButton.Text = "Choose directory";
            this.ChooseDirectoryButton.UseVisualStyleBackColor = true;
            this.ChooseDirectoryButton.Click += new System.EventHandler(this.ChooseDirectoryButton_Click);
            // 
            // PuzzlesListView
            // 
            this.PuzzlesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleHeader,
            this.WidthHeader,
            this.HeightHeader,
            this.DifficultyHeader});
            this.PuzzlesListView.HideSelection = false;
            this.PuzzlesListView.Location = new System.Drawing.Point(12, 49);
            this.PuzzlesListView.MultiSelect = false;
            this.PuzzlesListView.Name = "PuzzlesListView";
            this.PuzzlesListView.Size = new System.Drawing.Size(560, 259);
            this.PuzzlesListView.TabIndex = 2;
            this.PuzzlesListView.UseCompatibleStateImageBehavior = false;
            this.PuzzlesListView.View = System.Windows.Forms.View.Details;
            // 
            // TitleHeader
            // 
            this.TitleHeader.Text = "Title";
            this.TitleHeader.Width = 180;
            // 
            // WidthHeader
            // 
            this.WidthHeader.Text = "Width";
            // 
            // HeightHeader
            // 
            this.HeightHeader.Text = "Height";
            // 
            // DifficultyHeader
            // 
            this.DifficultyHeader.Text = "Difficulty";
            this.DifficultyHeader.Width = 80;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(13, 324);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.AutoSize = true;
            this.LoadButton.Location = new System.Drawing.Point(493, 324);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(79, 25);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load Puzzle";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathLabel.Location = new System.Drawing.Point(12, 12);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(446, 23);
            this.PathLabel.TabIndex = 5;
            this.PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PuzzleChooserForm
            // 
            this.AcceptButton = this.LoadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.PuzzlesListView);
            this.Controls.Add(this.ChooseDirectoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PuzzleChooserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose one of the puzzles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChooseDirectoryButton;
        private System.Windows.Forms.ListView PuzzlesListView;
        private System.Windows.Forms.ColumnHeader TitleHeader;
        private System.Windows.Forms.ColumnHeader WidthHeader;
        private System.Windows.Forms.ColumnHeader HeightHeader;
        private System.Windows.Forms.ColumnHeader DifficultyHeader;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label PathLabel;
    }
}