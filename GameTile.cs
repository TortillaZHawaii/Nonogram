using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSG_LAB5
{
    public class GameTile : Button
    {
        private static Image CrossedOutImage = null;

        private bool _isBlack;

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }

        public bool IsBlack { 
            get => _isBlack; 
            set
            {
                _isBlack = value;
                if (value)
                {
                    _isCrossed = false;
                    BackColor = Color.Black;
                }
                else BackColor = Color.White;
            }
        }

        private bool _isCrossed;
        public bool IsCrossed
        {
            get => _isCrossed;
            set
            {
                _isCrossed = value;
                if (value)
                {
                    if (_isBlack)
                        _isBlack = false;
                    base.BackgroundImage = CrossedOutImage;
                }
                else
                {
                    base.BackgroundImage = null;
                    IsBlack = false;
                }
            }
        }

        public override Color BackColor { 
            get => base.BackColor;
            set 
            {
                base.BackColor = value;
                if (value == Color.Black)
                    _isBlack = true;
                else _isBlack = false;
            } 
        }


        public GameTile(int tileSize, int i, int j, bool isBlack = false)
        {
            if(CrossedOutImage is null)
            {
                CrossedOutImage = Image.FromFile(@".\PWSG_LAB5\cross.bmp");
            }
            this.X = i;
            this.Y = j;
            this.IsCrossed = false;
            this.IsBlack = isBlack;
            this.Location = new Point(0, 0);
            this.Dock = DockStyle.Fill;
            this.FlatAppearance.BorderColor = Color.Black;
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FlatAppearance.MouseOverBackColor = Color.Silver;
            this.FlatStyle = FlatStyle.Flat;
            this.Margin = new Padding(0);
            this.Name = $"tile: {i},{j}";
            this.Size = new Size(tileSize, tileSize);
            this.TabIndex = 1;
            this.UseVisualStyleBackColor = false;

        }
    }
}
