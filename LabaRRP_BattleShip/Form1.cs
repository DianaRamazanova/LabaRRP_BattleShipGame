using System;
using LabaRRP_BattleShip.ClientServer;
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
    public partial class Form1 : Form
    {
        private Client _client;
        private Game _game;
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            _client = new Client();
            _game = new Game();
            SetupForm setupForm = new SetupForm(_game);
            setupForm.ShowDialog();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            _client.Connect(txtIPAddress.Text);
            _game = new Game();
            SetupForm setupForm = new SetupForm(_game);
            setupForm.ShowDialog();
        }

        private void BtnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderBoardForm leaderboardForm = new LeaderBoardForm();
            leaderboardForm.ShowDialog();
        }
    }
}
