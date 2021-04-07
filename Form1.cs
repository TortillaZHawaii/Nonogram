using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSG_LAB5
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Tile size in pixels
        /// </summary>
        const int tileSize = 30;
        
        /// <summary>
        /// Board width
        /// </summary>
        public int XSize { get; private set; }

        /// <summary>
        /// Board height
        /// </summary>
        public int YSize { get; private set; }

        private GameTile[,] tiles;

        private Label[] rowLabels;
        private Label[] colLabels;

        public enum GameState
        {
            Running,
            Finnished,
            Creating
        }

        private GameState _state;
        public GameState State 
        { 
            get => _state;
            private set 
            {
                if (value == GameState.Finnished)
                    CongratulationsLabel.Visible = true;
                else CongratulationsLabel.Visible = false;
                _state = value;
            } 
        }

        private bool[] rowStates;
        private bool[] colStates;

        public Form1()
        {
            InitializeComponent();
            StartRandomGame(10, 10);
        }

        // https://stackoverflow.com/questions/19448346/how-to-get-a-right-click-mouse-event-changing-eventargs-to-mouseeventargs-cause
        private void tile_MouseDown(object sender, MouseEventArgs me)
        {
            GameTile tile = (GameTile)sender;
            if (State != GameState.Finnished)
            {
                if (me.Button == MouseButtons.Left)
                    tile.IsBlack = !tile.IsBlack;
                else if (me.Button == MouseButtons.Right)
                    tile.IsCrossed = !tile.IsCrossed;
            }
            if(State == GameState.Running)
                CheckMove(tile.X, tile.Y);
            if(State == GameState.Creating)
            {
                rowLabels[tile.Y].Text = CheckRow(tile.Y);
                colLabels[tile.X].Text = CheckCol(tile.X);
            }
            Debug.WriteLine(this.State);
            Debug.WriteLine("rowstates: " + String.Join(",", this.rowStates));
            Debug.WriteLine("colstates: " + String.Join(",", this.colStates));
        }


        private void RandomMenuItem_Click(object sender, EventArgs e)
        {
            PickSizeDialog pickSizeDialog = new("New Random Game");

            DialogResult result = pickSizeDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                StartRandomGame(pickSizeDialog.GameWidth, pickSizeDialog.GameHeight);
            }
        }

        private void StartRandomGame(int width, int height)
        {
            GenerateEmptyBoardOfSize(width, height);
            CreateLabels(Board.RandomBoard(width, height));
            CheckBoard();
        }

        private void StartGameCreating(int width, int height)
        {
            DifficultyTextBox.Text = "";
            PuzzleTitleTextBox.Text = "";
            GenerateEmptyBoardOfSize(width, height, false);
            CreateLabels(Board.EmptyBoard(width, height));
        }

        private void CreatePuzzleMenuItem_Click(object sender, EventArgs e)
        {
            PickSizeDialog pickSizeDialog = new("Create your Nonogram puzzle");

            DialogResult result = pickSizeDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                StartGameCreating(pickSizeDialog.GameWidth, pickSizeDialog.GameHeight);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Puzzle puzzle = GeneratePuzzle(this.PuzzleTitleTextBox.Text, this.DifficultyTextBox.Text);

            //https://docs.microsoft.com/pl-pl/dotnet/api/system.windows.forms.savefiledialog?view=net-5.0
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Puzzle.SavePuzzle(Path.GetFullPath(saveFileDialog.FileName), puzzle);
            }
        }

        private void LoadPuzzleMenuItem_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/pl-pl/dotnet/api/system.windows.forms.openfiledialog?view=net-5.0
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadPuzzle(Puzzle.LoadPuzzle(Path.GetFullPath(openFileDialog.FileName)));
                }

            }

        }

        private void ChoosePuzzleMenuItem_Click(object sender, EventArgs e)
        {
            PuzzleChooserForm puzzleChooserForm = new();
            
            if(puzzleChooserForm.ShowDialog() == DialogResult.OK)
            {
                this.LoadPuzzle(puzzleChooserForm.ChosenPuzzle);
            }
        }

        
    }
}


