using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaRRP_BattleShip.ClientServer
{
      public class Message
      {
            public string Type { get; set; }
            public string Data { get; set; }

            public Message(string type, string data)
            {
                Type = type;
                Data = data;
            }

            public override string ToString()
            {
                return $"{Type}:{Data}";
            }
      }
    
}
