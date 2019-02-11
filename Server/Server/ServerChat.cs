using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Server
{
    class ServerChat
    {
        static ArrayList ClientsList = new ArrayList();
        static Socket Listener_Socket;
        static SocketClient Newclient;
      

        public static string Start_Voice_Server(int Port)
        {
            try
            {
                IPAddress[] AddressAr = null;
                String ServerHostName = "";
                try
                {
                    ServerHostName = Dns.GetHostName();
                    IPHostEntry ipEntry = Dns.GetHostByName(ServerHostName);
                    AddressAr = ipEntry.AddressList;
                }
                catch (Exception) { }

                if (AddressAr == null || AddressAr.Length < 1)
                {
                    return "Cannot get local address ...There is a Error";
                }

                Listener_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                Listener_Socket.Bind(new IPEndPoint(IPAddress.Any, Port));
                Listener_Socket.Listen(10);

                Listener_Socket.BeginAccept(new AsyncCallback(EndPointAccept), Listener_Socket);

                return ("I am Listening On Port " + Port + "... OK");

            }
            catch (Exception ex) { return ex.Message; }
        }

        
        private static void EndPointAccept(IAsyncResult result)
        {
            try
            {
                Listener_Socket = (Socket)result.AsyncState;
                AddListClient(Listener_Socket.EndAccept(result));
                Listener_Socket.BeginAccept(new AsyncCallback(EndPointAccept), Listener_Socket);
            }
            catch (Exception) { }
        }
      
        private static void AddListClient(Socket sockClient)
        {
            Newclient = new SocketClient(sockClient);
            ClientsList.Add(Newclient);

            
            Newclient.RecieveCallSetup();
        }

      
        public static void Recieved_on_Data(IAsyncResult rec)
        {
            SocketClient client = (SocketClient)rec.AsyncState;
            byte[] BytRec = client.GetRecievedData(rec);

            if (BytRec.Length < 1)
            {
         
                client.ReadOnlySocket.Close();
                ClientsList.Remove(client);
                return;
            }
            foreach (SocketClient clientSend in ClientsList)
            {
                if (client != clientSend)
                    try
                    {
                        clientSend.ReadOnlySocket.Send(BytRec);
                    }
                    catch
                    {
                        clientSend.ReadOnlySocket.Close();
                        ClientsList.Remove(client);
                        return;
                    }
            }
            client.RecieveCallSetup();
        }

        public static string ShutDown()
        {
            try
            {
                Listener_Socket.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return ("Shutdown ... OK");
            }
            catch (Exception ex) { return (ex.Message); }

        }
    }
}
