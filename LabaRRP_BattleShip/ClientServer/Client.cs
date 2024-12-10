using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LabaRRP_BattleShip.ClientServer
{
    public class Client
    {
        private TcpClient _client;

        public void Connect(string ipAddress)
        {
            _client = new TcpClient(ipAddress, 12345);
        }

        public void SendMessage(string message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            _client.GetStream().Write(data, 0, data.Length);
        }

        public string ReceiveMessage()
        {
            var buffer = new byte[256];
            var bytes = _client.GetStream().Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytes);
        }
    }
}
