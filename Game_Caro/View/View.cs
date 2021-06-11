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
using Game_Caro.Properties;


namespace Game_Caro
{
    public partial class CaroView : Form
    {
        #region Properties;
        ChessBoardManager ChessBoard1;
        #endregion

        #region Methods
        public CaroView()
        {
            InitializeComponent();

            prcbCoolDown.Step = Cons.COUT_DOWN_STEP;
            prcbCoolDown.Maximum = Cons.COUNT_DOWN_TIME;
            tmCoutDown.Interval = Cons.COUT_DOWN_INTERVAL;
            prcbCoolDown.Value = 0;

            ChessBoard1 = new ChessBoardManager(pnlChessBoard, tbUser, pbPlayerMark);
            ChessBoard1.EndedGame += ChessBoard1_EndedGame;
            ChessBoard1.PlayerMarked += ChessBoard1_PlayerMarked;            
            NewGame();
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

        private void EndGame()
        {
            tmCoutDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("Kết thúc game!\n\nWiner:" + ChessBoard1.Player[ChessBoard1.CurentPlayer].Name, "Thông báo", MessageBoxButtons.OK);
        }

        public void NewGame()
        {
            tmCoutDown.Stop();
            prcbCoolDown.Value = 0;
            undoToolStripMenuItem.Enabled = true;
            ChessBoard1.DrawChessBoard();
        }

        private void QuitGame()
        {
            Application.Exit();
        }

        private void UndoGame()
        {
            ChessBoard1.Undo();
        }

        private void CaroView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        #endregion

        #region ToolScrip

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitGame();
        }

        #endregion

        #region TimerTick

        private void tmCoutDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                ChessBoard1.CurentPlayer = ChessBoard1.CurentPlayer == 1 ? 0 : 1;
                EndGame();
            }
        }

        #endregion
    }



}
