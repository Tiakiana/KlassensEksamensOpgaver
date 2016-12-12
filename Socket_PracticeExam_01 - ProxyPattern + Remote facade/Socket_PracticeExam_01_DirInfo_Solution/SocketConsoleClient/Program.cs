using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client("localhost", 8000);
            client.Connect();
        }
    }
}
