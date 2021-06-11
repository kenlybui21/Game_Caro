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

        private List<List<Button>> Matrix;

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
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
            chessBoard.Enabled = true;

            Matrix = new List<List<Button>>();
            Button oldBTN = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldBTN.Location.X + oldBTN.Width, oldBTN.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;
                    chessBoard.Controls.Add(btn);
                    oldBTN = btn;
                    Matrix[i].Add(btn);
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
            if (playerMarked != null)
            {
                playerMarked(this, new EventArgs());
            }
            if (isEndGame(btn))
            {
                EndGame();
            }           
        }
        private Point GetChessPoint(Button _btn)
        {
            int vertical = Convert.ToInt32(_btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(_btn);
            Point point = new Point(horizontal, vertical);
            return point;
        }
        private bool isEndHorizontal(Button _btn)
        {
            Point point = GetChessPoint(_btn);
            int countLeft = 0;
            for (int i = point.X; i > 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == _btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHESS_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == _btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button _btn)
        {
            Point point = GetChessPoint(_btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == _btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == _btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button _btn)
        {
            Point point = GetChessPoint(_btn);
            int countTop = 0;
            for (int i = 0; i <= Math.Min(point.X,point.Y); i++)
            {
                if (Matrix[point.Y-i][point.X-i].BackgroundImage == _btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i < Math.Min(Cons.BOARD_WIDTH - point.X, Cons.BOARD_HEIGHT - point.Y); i++)
            {
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == _btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button _btn)
        {
            Point point = GetChessPoint(_btn);
            int countTop = 0;
            for (int i = 1; i <= Math.Min(Cons.BOARD_WIDTH - point.X, point.Y); i++)
            {
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == _btn.BackgroundImage)
                {
                    countTop++;
                   // MessageBox.Show("TOP" + countTop.ToString());
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 0; i <= Math.Min(point.X, Cons.BOARD_HEIGHT - point.Y - 1 ); i++)
            {
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == _btn.BackgroundImage)
                {
                    countBottom++;
                   // MessageBox.Show("BOT" + countBottom.ToString());
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        private bool isEndGame(Button _btn)
        {
            return isEndHorizontal(_btn) || isEndVertical(_btn) || isEndPrimary(_btn) || isEndSub(_btn);
        }
        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());            
        }
        #endregion

        
    }
}
