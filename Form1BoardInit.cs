using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSG_LAB5
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Generates white board of size <paramref name="width"/> x <paramref name="height"/>.
        /// </summary>
        /// <param name="width">Width of the board.</param>
        /// <param name="height">Height of the board.</param>
        private void GenerateEmptyBoardOfSize(int width, int height, bool centered=true)
        {
            ClearControls();
            // initialising variables
            XSize = width;
            YSize = height;
            tiles = new GameTile[XSize, YSize];
            rowLabels = new Label[YSize];
            colLabels = new Label[XSize];
            rowStates = new bool[YSize];
            colStates = new bool[XSize];

            RecenterTableLayoutPanel(centered);

            GenerateTiles();

        }

        private Puzzle SavePuzzle(string title, string description)
        {
            string[] rowStrLabels = new string[rowLabels.Length];
            string[] colStrLabels = new string[colLabels.Length];

            for (int i = 0; i < rowLabels.Length; ++i)
                rowStrLabels[i] = rowLabels[i].Text;
            for (int i = 0; i < colLabels.Length; ++i)
                colStrLabels[i] = colLabels[i].Text;

            return new Puzzle(title, description, XSize, YSize, rowStrLabels, colStrLabels);
        }

        private void LoadPuzzle(Puzzle puzzle)
        {
            XSize = puzzle.Width;
            YSize = puzzle.Height;
            tiles = new GameTile[XSize, YSize];
            rowLabels = new Label[YSize];
            colLabels = new Label[XSize];
            rowStates = new bool[YSize];
            colStates = new bool[XSize];

            RecenterTableLayoutPanel();

            GenerateTiles();

            for(int x = 0; x < XSize; ++x)
            {
                colLabels[x].Text = puzzle.ColLabels[x];
            }
            for (int y = 0; y < YSize; ++y)
            {
                rowLabels[y].Text = puzzle.RowLabels[y];
            }
        }

        private void RecenterTableLayoutPanel(bool centered=true)
        {
            // recentering
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowCount = YSize;
            tableLayoutPanel1.ColumnCount = XSize;
            tableLayoutPanel1.Width = tileSize * XSize;
            tableLayoutPanel1.Height = tileSize * YSize;

            foreach (RowStyle row in tableLayoutPanel1.RowStyles)
                row.Height = tileSize;
            foreach (ColumnStyle column in tableLayoutPanel1.ColumnStyles)
                column.Width = tileSize;

            int tableX, tableY;
            if(centered)
            {
                tableX = (this.Size.Width - tableLayoutPanel1.Size.Width) / 2;
                tableY = (this.Size.Height - tableLayoutPanel1.Size.Height) / 2;
            }
            else
            {
                // offset to right
                tableX = (this.Size.Width - tableLayoutPanel1.Size.Width) / 4 * 3;
                tableY = (this.Size.Height - tableLayoutPanel1.Size.Height) / 2;
            }

            tableLayoutPanel1.Location = new Point(tableX, tableY);
        }


        private void GenerateTiles()
        {
            // https://stackoverflow.com/questions/47732560/how-can-i-create-a-button-programmatically-in-c-sharp-window-app
            // generating white tiles
            for (int i = 0; i < XSize; i++)
            {
                for (int j = 0; j < YSize; j++)
                {
                    GameTile tile = new GameTile(tileSize, i, j);
                    tile.MouseDown += new MouseEventHandler(this.tile_MouseDown);
                    tiles[i, j] = tile;
                    // https://stackoverflow.com/questions/42840406/adding-dynamic-controls-to-tablelayoutpanel-in-net-windows-form
                    this.tableLayoutPanel1.Controls.Add(tile, i, j);
                }
            }
        }

        private void CreateLabels(bool[,] board)
        {
            int startX = tableLayoutPanel1.Location.X;
            int startY = tableLayoutPanel1.Location.Y;

            // col
            for (int i = 0; i < XSize; i++)
            {
                const int height = 200;
                Label label = new();
                this.Controls.Add(label);
                label.Text = EvaluateCol(i, board);
                label.TextAlign = ContentAlignment.BottomCenter;
                label.AutoSize = false;
                label.Size = new Size(30, height);
                label.Margin = new Padding(0);
                label.Location = new Point(startX + 30 * i, startY - height);
                colLabels[i] = label;
            }

            // row
            for (int i = 0; i < YSize; i++)
            {
                const int width = 200;
                Label label = new();
                this.Controls.Add(label);
                label.Text = EvaluateRow(i, board);
                label.TextAlign = ContentAlignment.MiddleRight;
                label.AutoSize = false;
                label.Size = new Size(width, 30);
                label.Margin = new Padding(0);
                label.Location = new Point(startX - width, startY + 30 * i);
                rowLabels[i] = label;
            }
        }

        private void ClearControls()
        {
            if(tiles is not null)
                foreach(var tile in tiles)
                {
                    this.tableLayoutPanel1.Controls.Remove(tile);
                }
            if(rowLabels is not null)
                foreach(var row in rowLabels)
                {
                    this.Controls.Remove(row);
                }
            if(colLabels is not null)
                foreach(var col in colLabels)
                { 
                    this.Controls.Remove(col);
                }
        }

        private string EvaluateRow(int rowNo, bool[,] board)
        {
            StringBuilder sb = new();

            int curLen = 0;
            for (int i = 0; i < XSize; i++)
            {
                if (board[i, rowNo])
                {
                    curLen++;
                }
                else if (curLen != 0)
                {
                    if (sb.Length > 0) sb.Append(' ');
                    sb.Append(curLen.ToString());
                    curLen = 0;
                }
            }
            if (curLen > 0)
            {
                if (sb.Length > 0) sb.Append(' ');
                sb.Append(curLen.ToString());
            }

            if (sb.Length == 0)
                return "0";

            return sb.ToString();
        }

        private string EvaluateCol(int colNo, bool[,] board)
        {
            StringBuilder sb = new();

            int curLen = 0;
            for (int i = 0; i < YSize; i++)
            {
                if (board[colNo, i])
                {
                    curLen++;
                }
                else if (curLen != 0)
                {
                    if (sb.Length > 0) sb.Append('\n');
                    sb.Append(curLen.ToString());
                    curLen = 0;
                }
            }
            if (curLen > 0)
            {
                if (sb.Length > 0) sb.Append('\n');
                sb.Append(curLen.ToString());
            }

            if (sb.Length == 0)
                return "0";

            return sb.ToString();
        }
    }
}
