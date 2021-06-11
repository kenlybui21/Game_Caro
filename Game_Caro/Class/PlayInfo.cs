using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro.Class
{
    public class PlayInfo
    {
        #region Properties
        private Point point;
        private int currentPlayer;

        public Point Point { get => point; set => point = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        #endregion

        #region Initialize
        public PlayInfo(Point _point, int _currentPlayer)
        {
            this.point = _point;
            this.currentPlayer = _currentPlayer;
        }
        #endregion

    }
}
