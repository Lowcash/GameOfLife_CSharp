using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_PAI
{
    public static class Shapes
    {
        public enum ShapesType { BLINKER, GLIDER, BEACON, BEEHIVE, LOAF, BOAT, BLOCK, PULSAR }

        public static void SetBlinkerTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 2 && pPlayground.Height > pPositionY + 2)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX, pPositionY + 2).SetLife();
            }
        }

        public static void SetGliderTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 2 && pPlayground.Height > pPositionY + 2)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 2).SetLife();
            }
        }

        public static void SetBeaconTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 3 && pPlayground.Height > pPositionY + 3)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 3).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 3).SetLife();
            }
        }

        public static void SetBeehiveTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 2 && pPlayground.Height > pPositionY + 2)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 2).SetLife();
            }
        }

        public static void SetLoafTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 3 && pPlayground.Height > pPositionY + 3)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 3).SetLife();
            }
        }

        public static void SetBoatTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 2 && pPlayground.Height > pPositionY + 2)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 2).SetLife();
            }          
        }

        public static void SetBlockTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 4 && pPlayground.Height > pPositionY + 4)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 1, pPositionY + 1).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 1).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 4, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 4, pPositionY + 1).SetLife();
            }
        }

        public static void SetPulsarTo(int pPositionX, int pPositionY, Playground pPlayground)
        {
            if (pPlayground.Width > pPositionX + 12 && pPlayground.Height > pPositionY + 12)
            {
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 4, pPositionY + 0).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 8, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 9, pPositionY + 0).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 10, pPositionY + 0).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 12).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 12).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 4, pPositionY + 12).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 8, pPositionY + 12).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 9, pPositionY + 12).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 10, pPositionY + 12).SetLife();

                //--------------------------------------------------------------------------------------------//

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 3).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 4).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 8).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 9).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 0, pPositionY + 10).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 12, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 12, pPositionY + 3).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 12, pPositionY + 4).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 12, pPositionY + 8).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 12, pPositionY + 9).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 12, pPositionY + 10).SetLife();

                //--------------------------------------------------------------------------------------------//

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 5).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 5).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 4, pPositionY + 5).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 8, pPositionY + 5).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 9, pPositionY + 5).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 10, pPositionY + 5).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 2, pPositionY + 7).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 3, pPositionY + 7).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 4, pPositionY + 7).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 8, pPositionY + 7).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 9, pPositionY + 7).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 10, pPositionY + 7).SetLife();

                //--------------------------------------------------------------------------------------------//

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 5, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 5, pPositionY + 3).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 5, pPositionY + 4).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 5, pPositionY + 8).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 5, pPositionY + 9).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 5, pPositionY + 10).SetLife();

                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 7, pPositionY + 2).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 7, pPositionY + 3).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 7, pPositionY + 4).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 7, pPositionY + 8).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 7, pPositionY + 9).SetLife();
                PlaygroundHelper.GetCellFromPlayground(pPlayground, pPositionX + 7, pPositionY + 10).SetLife();
            }
        }
    }
}
