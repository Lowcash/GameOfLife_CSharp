using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_PAI
{
    public class Cell
    {
        public bool IsLife { get; private set; } = false;

        public int PositionX { get; private set; }

        public int PositionY { get; private set; }

        public Cell() { }

        public Cell(int pPositionX, int pPositionY)
        {
            PositionX = pPositionX;
            PositionY = pPositionY;
        }

        public void SetLife()
        {
            IsLife = true;
        }

        public void SetDead()
        {
            IsLife = false;
        }
    }
}
