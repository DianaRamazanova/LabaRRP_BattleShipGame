using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaRRP_BattleShip
{
    public partial class SetupForm : Form
    {
        private Game _game;
        public SetupForm(Game game)
        {
            InitializeComponent();
            _game = game;
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
            _game.Player1.PlaceShip(new Ship(4), cell.X, cell.Y, true);
            btn.BackColor = Color.Blue;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
