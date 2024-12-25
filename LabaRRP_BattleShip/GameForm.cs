using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabaRRP_BattleShip
{
    public partial class GameForm : Form
    {
        private Game _game;
        private bool _isPlayer1;

        public GameForm(Game game, bool isPlayer1)
        {
            InitializeComponent();
            _game = game;
            _isPlayer1 = isPlayer1;
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(i * 30, j * 30);
                    btn.Tag = new Point(i, j);
                    btn.Click += Btn_Click;
                    pnlGrid.Controls.Add(btn);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Point cell = (Point)btn.Tag;

            if (_game.IsPlayer1Turn == _isPlayer1)
            {
                _game.MakeMove(cell.X, cell.Y);
                btn.Enabled = false;
                btn.BackColor = _game.Player2.CheckHit(cell.X, cell.Y) ? Color.Red : Color.Black;
            }
        }
    }
}