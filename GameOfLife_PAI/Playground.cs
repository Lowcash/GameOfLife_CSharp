using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_PAI
{
    public class Playground
    {
        private int _minPlaygroundSize = Config.minPlaygroundSize;

        private int _maxPlaygroundSize = Config.maxPlaygroundSize;

        private int _width, _height;

        public int Width {
            get {
                return this._width;
            }
            private set {
                this._width = value < _minPlaygroundSize ? _minPlaygroundSize : value;
                this._width = value > _maxPlaygroundSize ? _maxPlaygroundSize : value;
            }
        }

        public int Height {
            get {
                return this._height;
            }
            private set {
                this._height = value < _minPlaygroundSize ? _minPlaygroundSize : value;
                this._height = value > _maxPlaygroundSize ? _maxPlaygroundSize : value;
            }
        }

        public List<Cell> PlaygroundCells { get; private set; } = new List<Cell>();

        public Playground() { }

        public Playground(int pWidth, int pHeight) {
            Width = pWidth;
            Height = pHeight;

            InitCells(Width, Height);
        }

        private void InitCells(int pWidth, int pHeight) {
            PlaygroundCells.Clear();

            for (int y = 0; y < pHeight; y++)
            {
                for (int x = 0; x < pWidth; x++)
                {
                    PlaygroundCells.Add(new Cell(x, y));
                }  
            }    
        }

        public void ResetPlayground()
        {
            PlaygroundCells.ForEach(p => p.SetDead());
        }
    }

    public static class PlaygroundHelper
    {
        public enum NeighborOnDirection { NORTH, EAST, SOUTH, WEST, NORTH_WEST, NORTH_EAST, SOUTH_WEST, SOUTH_EAST }

        public static Cell GetCellFromPlayground(Playground pPlayground, int pPositionX, int pPositionY)
        {
            return pPlayground.PlaygroundCells[(pPlayground.Width * pPositionY) + pPositionX];
        }

        public static Cell GetCellNeighborOnDirectionFromPlayground(Playground pPlayground, Cell pCell, NeighborOnDirection pNeighborOnDirection)
        {
            switch (pNeighborOnDirection)
            {
                case NeighborOnDirection.NORTH:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX, pCell.PositionY - Config.neighborOffset);
                case NeighborOnDirection.EAST:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX + Config.neighborOffset, pCell.PositionY);
                case NeighborOnDirection.SOUTH:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX, pCell.PositionY + Config.neighborOffset);
                case NeighborOnDirection.WEST:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX - Config.neighborOffset, pCell.PositionY);
                case NeighborOnDirection.NORTH_WEST:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX - Config.neighborOffset, pCell.PositionY - Config.neighborOffset);
                case NeighborOnDirection.NORTH_EAST:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX + Config.neighborOffset, pCell.PositionY - Config.neighborOffset);
                case NeighborOnDirection.SOUTH_WEST:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX - Config.neighborOffset, pCell.PositionY + Config.neighborOffset);
                case NeighborOnDirection.SOUTH_EAST:
                    return GetCellFromPlayground(pPlayground, pCell.PositionX + Config.neighborOffset, pCell.PositionY + Config.neighborOffset);
            }

            return null;
        }
    }
}
