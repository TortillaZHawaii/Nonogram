using System;
using System.Collections.Generic;
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
        /// Checks and updates State
        /// </summary>
        void CheckGameState()
        {
            foreach (bool st in rowStates)
                if (!st)
                {
                    State = GameState.Running;
                    return;
                }
            foreach (bool st in colStates)
                if (!st)
                {
                    State = GameState.Running;
                    return;
                }
            State = GameState.Finnished;
        }

        /// <summary>
        /// Checks GameState for the board
        /// </summary>
        void CheckBoard()
        {
            for (int y = 0; y < rowStates.Length; ++y)
                rowStates[y] = CheckRow(y) == rowLabels[y].Text;
            for (int x = 0; x < colStates.Length; ++x)
                colStates[x] = CheckCol(x) == colLabels[x].Text;

            CheckGameState();
        }

        /// <summary>
        /// Checks GameState after single move
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void CheckMove(int x, int y)
        {
            rowStates[y] = CheckRow(y) == rowLabels[y].Text;
            string test = CheckCol(x);
            colStates[x] = test == colLabels[x].Text;
            CheckGameState();
        }
        
        /// <summary>
        /// Generates text of the current <paramref name="rowNo"/> based on color
        /// </summary>
        /// <param name="rowNo">Row number starting from 0</param>
        /// <returns>Nonogram text of row</returns>
        private string CheckRow(int rowNo)
        {
            StringBuilder sb = new();

            int curLen = 0;
            for (int i = 0; i < XSize; i++)
            {
                if (tiles[i, rowNo].IsBlack)
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

        /// <summary>
        /// Generates text of the current <paramref name="colNo"/> based on color
        /// </summary>
        /// <param name="colNo">Column number starting at 0</param>
        /// <returns>Nonogram text of column</returns>
        private string CheckCol(int colNo)
        {
            StringBuilder sb = new();

            int curLen = 0;
            for (int i = 0; i < YSize; i++)
            {
                if (tiles[colNo, i].IsBlack)
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

            string test = sb.ToString();
            return test;
        }

    }
}
