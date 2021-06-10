using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Caro.Class;


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


        private List<Player> player;

        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        private int curentPlayer;
        public int CurentPlayer
        {
            get => curentPlayer; 
            set => curentPlayer = value; 
        }

        private TextBox playerName;
        public TextBox PlayerName { get => playerName; set => playerName = value; }

        private PictureBox playerMark;
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel _chessboard, TextBox _playerName, PictureBox _playerMark )
        {
            this.chessBoard = _chessboard;
            this.playerName = _playerName;
            this.playerMark = _playerMark;
            this.player = new List<Player>()
            {
                new Player("Bùi Minh Trí", Image.FromFile(Application.StartupPath + "\\Resources\\1.png")),
                new Player("Kenly Bùi", Image.FromFile(Application.StartupPath + "\\Resources\\2.png")),
            };
            curentPlayer = 0;
            ChangePlayer();
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
                        Location = new Point(oldBTN.Location.X + oldBTN.Width, oldBTN.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn.Click += Btn_Click;
                    chessBoard.Controls.Add(btn);
                    oldBTN = btn;
                }
                oldBTN.Location = new Point(0, oldBTN.Location.Y + Cons.CHESS_HEIGHT);
                oldBTN.Height = 0;
                oldBTN.Width = 0;
            }
        }
        private void ChangePlayer()
        {
            playerName.Text = Player[CurentPlayer].Name;
            playerMark.Image = Player[CurentPlayer].Mark;
        }
        private void ChangeMark(Button _btn)
        {
            _btn.BackgroundImage = Player[CurentPlayer].Mark;
            CurentPlayer = CurentPlayer == 1 ? 0 : 1;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            ChangeMark(btn);
            ChangePlayer();
        }
        #endregion

        
    }
}
