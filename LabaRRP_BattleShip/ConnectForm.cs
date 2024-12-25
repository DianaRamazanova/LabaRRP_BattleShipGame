using LabaRRP_BattleShip.ClientServer;
using System;
using System.Windows.Forms;

namespace LabaRRP_BattleShip
{
    public partial class ConnectForm : Form
    {
        private Client _client;

        public ConnectForm(Client client)
        {
            InitializeComponent();
            _client = client;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPAddress.Text;
            _client.Connect(ipAddress);
            this.Close();
        }
    }
}