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

            prcbCoolDown.Step = Cons.COUT_DOWN_STEP;
            prcbCoolDown.Maximum = Cons.COUNT_DOWN_TIME;
            tmCoutDown.Interval = Cons.COUT_DOWN_INTERVAL;
            prcbCoolDown.Value = 0;

            ChessBoardManager ChessBoard1 = new ChessBoardManager(pnlChessBoard, tbUser, pbPlayerMark);
            ChessBoard1.DrawChessBoard();
            ChessBoard1.EndedGame += ChessBoard1_EndedGame;
            ChessBoard1.PlayerMarked += ChessBoard1_PlayerMarked;
        }

        private void ChessBoard1_PlayerMarked(object sender, EventArgs e)
        {
            prcbCoolDown.Value = 0;
            tmCoutDown.Start();
        }

        private void ChessBoard1_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tmCoutDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                EndGame();               
            }
        }

        private void EndGame()
        {
            tmCoutDown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc game!\nWiner:");
        }
    }
}
