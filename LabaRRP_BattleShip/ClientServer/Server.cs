using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabaRRP_BattleShip.ClientServer
{
    public class Server
    {
        private TcpListener _listener;

        public Server()
        {
            _listener = new TcpListener(IPAddress.Any, 12345);
        }

        public void Start()
        {
            _listener.Start();
            Task.Run(() => AcceptClients());
        }

        private async Task AcceptClients()
        {
            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                HandleClient(client);
            }
        }

        private void HandleClient(TcpClient client)
        {
        }
    }
}
