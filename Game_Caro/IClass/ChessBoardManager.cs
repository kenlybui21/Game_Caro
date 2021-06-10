using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro.Class
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard 
        { 
            get => chessBoard; 
            set => chessBoard = value; 
        }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel _chessboard)
        {
            this.chessBoard = _chessboard;
        }

        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldBTN = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldBTN.Location.X + oldBTN.Width, oldBTN.Location.Y)
                    };
                    chessBoard.Controls.Add(btn);
                    oldBTN = btn;
                }
                oldBTN.Location = new Point(0, oldBTN.Location.Y + Cons.CHESS_HEIGHT);
                oldBTN.Height = 0;
                oldBTN.Width = 0;
            }
        }
        #endregion


    }
}
