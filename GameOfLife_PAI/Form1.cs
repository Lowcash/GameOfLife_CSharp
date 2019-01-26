using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_PAI
{
    public partial class GameOfLife : Form
    {
        private Playground _mainPlayground = null;
        private Playground _temporaryPlayground = null;

        private Bitmap _mainPlaygroundBitmap = null;

        private bool _isSingleThreadRun = false;
        private bool _isParallelThreadRun = false;

        private bool _isGameRun = false;

        private int _numOfThreads = 1;

        private Thread _gameThread = null;

        public GameOfLife()
        {
            InitializeComponent();

            InitGame();

            CreateNewGame();

            Redraw();

            StartGame();
        }

        private void CreateNewGame()
        {
            InitPlayground(ref _mainPlayground, (int)numeric_numOfCols.Value, (int)numeric_numOfRows.Value);
            InitPlayground(ref _temporaryPlayground, (int)numeric_numOfCols.Value, (int)numeric_numOfRows.Value);

            InitPlaygroundBitmap(ref _mainPlaygroundBitmap, (int)numeric_numOfCols.Value, (int)numeric_numOfRows.Value);

            GeneratePlayground(ref _mainPlayground);
            PlaygroundToBitmap(_mainPlayground, ref _mainPlaygroundBitmap);
        }

        private void InitGame()
        {
            _gameThread = new Thread(RunGame);
        }

        private void StartGame()
        {
            _gameThread.Start();
        }

        private void InitPlayground(ref Playground pPlayground, int pWidth, int pHeight)
        {
            pPlayground = new Playground(pWidth, pHeight);
        }

        private void InitPlaygroundBitmap(ref Bitmap pBitmap, int pWidth, int pHeight)
        {
            pBitmap = new Bitmap(pWidth, pHeight);
        }

        private void GeneratePlayground(ref Playground pPlayground)
        {
            pPlayground.ResetPlayground();

            var rnd = new Random();

            foreach (var cell in pPlayground.PlaygroundCells)
            {
                if (rnd.NextDouble() < (float)numeric_probability.Value)
                {
                    switch (rnd.Next(Enum.GetNames(typeof(Shapes.ShapesType)).Length))
                    {
                        case (int)Shapes.ShapesType.BEACON: Shapes.SetBeaconTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.BEEHIVE: Shapes.SetBeehiveTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.BLINKER: Shapes.SetBlinkerTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.BLOCK: Shapes.SetBlockTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.BOAT: Shapes.SetBoatTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.GLIDER: Shapes.SetGliderTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.LOAF: Shapes.SetLoafTo(cell.PositionX, cell.PositionY, pPlayground); break;
                        case (int)Shapes.ShapesType.PULSAR: Shapes.SetPulsarTo(cell.PositionX, cell.PositionY, pPlayground); break;
                    }
                }
            }
        }

        private void PlaygroundToBitmap(Playground pPlayground, ref Bitmap pBitmap)
        {
            for (int x = 0; x < pPlayground.Width; x++)
            {
                for (int y = 0; y < pPlayground.Height; y++)
                {
                    pBitmap.SetPixel(x, y, GetCellColor(PlaygroundHelper.GetCellFromPlayground(pPlayground, x, y)));
                }
            }
        }

        private Color GetCellColor(Cell pCell)
        {
            return pCell.IsLife ? Config.liveCellColor : Config.deadCellColor;
        }

        private void Redraw()
        {
            picture_playground.Image = new Bitmap(_mainPlaygroundBitmap, picture_playground.Width, picture_playground.Height);
        }

        private void numeric_numOfRows_ValueChanged(object sender, EventArgs e)
        {
            CreateNewGame();

            Redraw();
        }

        private void numeric_numOfCols_ValueChanged(object sender, EventArgs e)
        {
            CreateNewGame();

            Redraw();
        }

        private void numeric_probability_ValueChanged(object sender, EventArgs e)
        {
            CreateNewGame();

            Redraw();
        }

        private void button_startSingleThread_Click(object sender, EventArgs e)
        {
            _isSingleThreadRun = !_isSingleThreadRun;

            button_startParallelThreads.Enabled = !_isSingleThreadRun;
            numeric_numOfCols.Enabled = !_isSingleThreadRun;
            numeric_numOfRows.Enabled = !_isSingleThreadRun;
            numeric_numOfThreads.Enabled = !_isSingleThreadRun;
            numeric_probability.Enabled = !_isSingleThreadRun;

            button_startSingleThread.Text = _isSingleThreadRun ? "Stop Single Thread" : "Start Single Thread";

            _numOfThreads = 1;

            _isGameRun = _isSingleThreadRun;
        }

        private void button_startParallelThreads_Click(object sender, EventArgs e)
        {
            _isParallelThreadRun = !_isParallelThreadRun;

            button_startSingleThread.Enabled = !_isParallelThreadRun;
            numeric_numOfCols.Enabled = !_isParallelThreadRun;
            numeric_numOfRows.Enabled = !_isParallelThreadRun;
            numeric_numOfThreads.Enabled = !_isParallelThreadRun;
            numeric_probability.Enabled = !_isParallelThreadRun;

            button_startParallelThreads.Text = _isParallelThreadRun ? "Stop Parallel Threads" : "Start Parallel Threads";

            _numOfThreads = (int)numeric_numOfThreads.Value;

            _isGameRun = _isParallelThreadRun;
        }

        private void RunGame()
        {
            while (true)
            {
                if (_isGameRun)
                {
                    Parallel.For(0, _mainPlayground.PlaygroundCells.Count, new ParallelOptions { MaxDegreeOfParallelism = _numOfThreads }, p =>
                    {
                        var cell = _mainPlayground.PlaygroundCells[p];

                        int numCellNeigbors = GetNumCellNeigbors(cell);

                        if (cell.IsLife)
                        {
                            _temporaryPlayground.PlaygroundCells[p].SetLife();

                            if (numCellNeigbors < 2 || numCellNeigbors > 3)
                            {
                                _temporaryPlayground.PlaygroundCells[p].SetDead();
                            }
                        }
                        else
                        {
                            _temporaryPlayground.PlaygroundCells[p].SetDead();

                            if (numCellNeigbors == 3)
                            {
                                _temporaryPlayground.PlaygroundCells[p].SetLife();
                            }
                        }
                    });


                    SwapAndClearPlaygrounds(ref _mainPlayground, ref _temporaryPlayground);
                    PlaygroundToBitmap(_mainPlayground, ref _mainPlaygroundBitmap);

                    Redraw();

                    Thread.Sleep(1);
                }
            }
        }

        private void SwapAndClearPlaygrounds(ref Playground pPlaygroundResult, ref Playground pPlaygroundToSwap)
        {
            var playgroundResult = pPlaygroundResult;
            var playgroundToSwap = pPlaygroundToSwap;

            Parallel.For(0, playgroundResult.PlaygroundCells.Count, new ParallelOptions { MaxDegreeOfParallelism = _numOfThreads }, p =>
            {
                var cell = playgroundResult.PlaygroundCells[p];

                if (playgroundToSwap.PlaygroundCells[p].IsLife)
                {
                    cell.SetLife();
                }
                else
                {
                    cell.SetDead();
                }

                playgroundToSwap.PlaygroundCells[p].SetDead();
            });
        }

        private int GetNumCellNeigbors(Cell pCell)
        {
            int counter = 0;

            if ((pCell.PositionX < _mainPlayground.Width - 1) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.EAST).IsLife) counter++;
            if ((pCell.PositionY < _mainPlayground.Height - 1) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.SOUTH).IsLife) counter++;
            if ((pCell.PositionY > 0) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.NORTH).IsLife) counter++;
            if ((pCell.PositionX > 0) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.WEST).IsLife) counter++;
            if ((pCell.PositionY > 0 && pCell.PositionX < _mainPlayground.Width - 1) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.NORTH_EAST).IsLife)
                counter++;
            if ((pCell.PositionY > 0 && pCell.PositionX > 0) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.NORTH_WEST).IsLife)
                counter++;
            if ((pCell.PositionY < _mainPlayground.Height - 1 && pCell.PositionX < _mainPlayground.Width - 1) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.SOUTH_EAST).IsLife)
                counter++;
            if ((pCell.PositionY < _mainPlayground.Height - 1 && pCell.PositionX > 0) && PlaygroundHelper.GetCellNeighborOnDirectionFromPlayground(_mainPlayground, pCell, PlaygroundHelper.NeighborOnDirection.SOUTH_WEST).IsLife)
                counter++;

            return counter;
        }

        private void GameOfLife_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(Environment.ExitCode);
            } catch (Exception) {
                Console.WriteLine(string.Format("Application was not terminated correctly!"));
            }
        }
    }
}
