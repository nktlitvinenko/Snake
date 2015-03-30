using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Snake
{
    public partial class MainForm : Form
    {
        private Bitmap _buffer;
        Graphics _buffGraph;

        private GameField _gameField;
        private Graphics _graphics;
        private Snake _snake;
        private Fruit _fruit;

        private SoundPlayer _hrum;
        private int _score = 0;

        private StartForm _sf;
        public MainForm(StartForm sf)
        {
            InitializeComponent();
            InitializeEnvironment();

            _sf = sf;

            this.Text = "Score: " + _score;
           
            ClientSize = new Size(
                Configuration.Width * Configuration.Scale, 
                Configuration.Height * Configuration.Scale);
           
            pbGameField.Refresh();

            Ticker.Start();
        }

        private void InitializeEnvironment()
        {
            _gameField = new GameField();
            _graphics = pbGameField.CreateGraphics();
            _snake = new Snake();
            _fruit = new Fruit();

            _buffer = new Bitmap(Configuration.Width*Configuration.Scale,
                Configuration.Height*Configuration.Scale);
            _buffGraph = Graphics.FromImage(_buffer);

            _hrum = new SoundPlayer(Properties.Resources.hrum);
        }
        private void RenderScene()
        {
            _buffGraph.Clear(Color.White);

            _gameField.Draw(_buffGraph);

            _fruit.Draw(_buffGraph);
            _snake.Draw(_buffGraph);

            _graphics.DrawImage(_buffer, 0, 0);
        }
        private void GameOver()
        {
            Ticker.Stop();
            MessageBox.Show("Game over!");
            _sf.Show();
            this.Close();
        }

        private void pbGameField_Paint(object sender, PaintEventArgs e)
        {
            _gameField.Draw(_buffGraph);
            _snake.Draw(_buffGraph);
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            _snake.Move();

            RenderScene();

            if (_snake.Segments[0].X == -1 ||
                _snake.Segments[0].X == 20 ||
                _snake.Segments[0].Y == -1 ||
                _snake.Segments[0].Y == 20)
            {
                GameOver();
            }
            if (_snake.Segments[0].X == _fruit.X && _snake.Segments[0].Y == _fruit.Y)
            {
                _hrum.Play();
                _snake.EatFruit();
                this.Text = "Score: " + ++_score;
                _fruit = new Fruit();
            }
            for (int i = 1; i < _snake.Segments.Count; i++)
            {
                if (_snake.Segments[0].X == _snake.Segments[i].X &&
                    _snake.Segments[0].Y == _snake.Segments[i].Y)
                {
                    GameOver();
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch ((int)e.KeyCode)
            {
                case 37:
                    if (_snake.Direction == 1) { }
                    else
                        _snake.Direction = 3;
                    break;
                case 38:
                    if (_snake.Direction == 2) { }
                    else
                        _snake.Direction = 0;
                    break;
                case 39:
                    if (_snake.Direction == 3) { }
                    else
                        _snake.Direction = 1;
                    break;
                case 40:
                    if (_snake.Direction == 0) { }
                    else
                        _snake.Direction = 2;
                    break;
                default:
                    break;
            }
        }
    }
}
