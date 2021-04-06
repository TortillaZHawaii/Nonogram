using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSG_LAB5
{
    public partial class Form1 : Form
    {
        const int tileSize = 30;
        public int XSize { get; private set; }
        public int YSize { get; private set; }

        private GameTile[,] tiles;

        private Label[] rowLabels;
        private Label[] colLabels;

        public enum GameState
        {
            Running,
            Finnished
        }

        public GameState State { get; private set; }

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
            if (me.Button == MouseButtons.Left)
                tile.IsBlack = !tile.IsBlack;
            else if (me.Button == MouseButtons.Right)
                tile.IsCrossed = !tile.IsCrossed;
            CheckMove(tile.X, tile.Y);
            //Debug.WriteLine(this.State);
            //Debug.WriteLine("rowstates: " + String.Join(",",this.rowStates));
            //Debug.WriteLine("colstates: " + String.Join(",",this.colStates));
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
    }
}


