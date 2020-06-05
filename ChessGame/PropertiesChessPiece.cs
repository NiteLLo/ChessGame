using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public class PropertiesChessPiece
    {
        public PropertiesChessPiece(int _positionX, int _positionY)
        {
            positionX = _positionX;
            positionY = _positionY;
        }

        public int positionX { get; set; }
        public int positionY { get; set; }
    }
}
