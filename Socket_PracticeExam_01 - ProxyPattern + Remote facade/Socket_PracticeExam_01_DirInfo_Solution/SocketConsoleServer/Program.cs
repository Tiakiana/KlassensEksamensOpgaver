using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SocketConsoleServer
{
    class Program
    {

        static void Main(string[] args)
        {
            //instantierer serveren
            Server server = new Server("localhost",8000);
            //Starter det whileloop, som håndterer klienter.
            server.StartServer();
       

        }
    }
}
