using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro.Class
{
    public class Player
    {
        #region Properties
        private string name; // Ctrl + R + E

        public string Name
        {
            get => name; 
            set => name = value;
        }

        private Image mark;

        public Image Mark
        {
            get => mark;
            set => mark = value; 
        }
        #endregion

        #region Initialize
        public Player(string _name, Image _mark)
        {
            this.name = _name;
            this.mark = _mark;
        }
        #endregion
    }
}
