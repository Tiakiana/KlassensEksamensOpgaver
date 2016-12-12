using System.Net.Sockets;
using System.IO;
using System.Threading;
using System;

namespace SocketConsoleServer
{
    internal class ClientHandler
    {
        //Vores forbindelse til den enkelte klient
        private Socket requests;

        private NetworkStream stream;
        private bool _stopped = false;

        //Det vi bruger til at læse og skrive til klienten
        private StreamReader reader;
        private StreamWriter writer;
        public ClientHandler(Socket requests)
        {
            this.requests = requests;
            stream = new NetworkStream(requests);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);


        }

        //køres sammen med vores clients tråd.
        public void RunClient()
        {

            while (!_stopped)
            {
                try
                {
                    /*
                     * Klienten skal kunne bede om at få information, om et 
                     * fil-katalog findes på serveren, idet klienten 
                     * medsender navnet på fil-kataloget.
                     * */

                    //Her læser vi alle beskeder fra vores klient
                    string clientText = reader.ReadLine();
                    // objekt med information for det angive katalognavn
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(clientText);
                    // Tjekker om det directory eksisterer

                    if (dir.Exists)                                                                 
                    {
                        //Denne giver creationtime som opgaven befaler og gemmer det i vores writer buffer

                      writer.WriteLine(dir.CreationTime.ToString() + Environment.NewLine);
                        //Laver et array som holder alle under mapper
                        System.IO.DirectoryInfo[] subDirs = dir.GetDirectories();

                        //kører hvert af disse arraypunkter igennem og konkatinerer navn og filretning.
                        foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                        {

                            writer.WriteLine("Name:<" + dirInfo.Name + "> Extension:<" + dirInfo.Extension + ">" + Environment.NewLine);
                        }
                        //Tømmer bufferen og sender til klienten.
                        writer.Flush();
                    }
                    else
                    {
                        //Giver en fejl besked.
                        writer.WriteLine("The directory you requested does not exist. Please try another.");
                    }
                        //Sørger her for at man begrænser trafikken således man ikke "Spammer" serveren
                        Thread.Sleep(100);
                }
                catch (Exception)
                { throw; }
            }
        }


    }

}