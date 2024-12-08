using BattleShipGame.Core;
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
    public partial class Form1 : Form
    {
        private Game _game;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            _game = new Game();
            //SetupForm setupForm = new SetupForm(_game);
            // setupForm.ShowDialog();
        }
    }
}
