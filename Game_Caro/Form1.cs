using Game_Caro.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game_Caro
{
    public partial class CaroView : Form
    {
        #region Properties;
        #endregion
        public CaroView()
        {
            InitializeComponent();
            ChessBoardManager ChessBoard1 = new ChessBoardManager(pnlChessBoard, tbUser, pbPlayerMark);
            ChessBoard1.DrawChessBoard();
        }
       
    }
}
