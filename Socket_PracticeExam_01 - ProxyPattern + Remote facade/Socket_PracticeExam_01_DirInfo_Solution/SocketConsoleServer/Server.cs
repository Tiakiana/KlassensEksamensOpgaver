using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace SocketConsoleServer
{
   
    class Server
    {
        private TcpListener _server;
        private List<StreamWriter> _clients = new List<StreamWriter>();
        private bool _stopped = false;
        public Server(string ipAddress, int port) {

            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
           
        }
        //Skal kaldes i Programklassen.
        public void StartServer() {
            while (!_stopped)
            {
                //Sørger for at der ikke hele tiden pinges og i stedet kun pinger hver 50' milisekund
                Thread.Sleep(50);

                // Venter på at der kommer nye kald til serveren
                Socket requests = _server.AcceptSocket();

                //Vores Klasse som sørger for at håndtere klienterne
                //For at den ved hvilken socket den skal skrive til og fra.
                ClientHandler ch = new ClientHandler(requests);

                //Vi skaber en ny tråd for at have forskellige klienter kørende
                Thread t = new Thread(ch.RunClient);
                //Starter tråden
                t.Start();
            }

        }


    }


}
