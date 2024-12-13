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
    public partial class GameOverForm : Form
    {
        private readonly Player _player;

        public GameOverForm(string result, Player player)
        {
            InitializeComponent();
            _player = player;

        }
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.AddPlayer(_player);

            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
