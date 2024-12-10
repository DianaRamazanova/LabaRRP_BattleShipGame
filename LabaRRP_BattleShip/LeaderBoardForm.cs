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
    public partial class LeaderBoardForm : Form
    {
        public LeaderBoardForm()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            // Load leaderboard from file
            Leaderboard leaderboard = new Leaderboard();
            var topPlayers = leaderboard.GetTopPlayers();
            lstLeaderboard.Items.Clear();
            foreach (var player in topPlayers)
            {
                lstLeaderboard.Items.Add($"{player.Name} - {player.Score}");
            }
        }
    }
}
