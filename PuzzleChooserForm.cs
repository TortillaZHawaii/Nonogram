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

namespace PWSG_LAB5
{
    public partial class PuzzleChooserForm : Form
    {
        public Puzzle ChosenPuzzle { get; private set; }
        private List<Puzzle> LoadedPuzzles { get; set; }

        public PuzzleChooserForm()
        {
            InitializeComponent();
            LoadedPuzzles = new List<Puzzle>();
            PuzzlesListView.FullRowSelect = true;
        }

        private void ChooseDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new();

            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                PathLabel.Text = folderBrowser.SelectedPath;
                RefreshPuzzles();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshPuzzles();
        }

        private void RefreshPuzzles()
        {
            string curPath = PathLabel.Text;
            if(!String.IsNullOrEmpty(curPath))
            {
                PuzzlesListView.Items.Clear();
                LoadedPuzzles.Clear();
                foreach (var fileName in Directory.GetFiles(curPath, "*.json"))
                {
                    Puzzle puzzle = Puzzle.LoadPuzzle(fileName);
                    if (puzzle is not null)
                    {
                        ListViewItem item = new();
                        item.SubItems[0].Text = puzzle.Title;
                        item.SubItems.Add(puzzle.Width.ToString());
                        item.SubItems.Add(puzzle.Height.ToString());
                        item.SubItems.Add(puzzle.Description);
                        
                        PuzzlesListView.Items.Add(item);
                        LoadedPuzzles.Add(puzzle);
                    }
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (PuzzlesListView.SelectedItems.Count == 0)
                return;

            int firstSelectedIndex = PuzzlesListView.SelectedIndices[0];
            this.ChosenPuzzle = LoadedPuzzles[firstSelectedIndex];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
