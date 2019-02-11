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
  internal  class SocketClient
    {
     

            private Socket New_Socket;
            private byte[] buffer = null;

            public SocketClient(Socket ForwardSock)
            {
                New_Socket = ForwardSock;
            }

            public Socket ReadOnlySocket
            {
                get { return New_Socket; }
            }

            public void RecieveCallSetup()
            {
                try
                {
                    buffer = new byte[4205];
                    AsyncCallback recieveData = new AsyncCallback(ServerChat.Recieved_on_Data);
                    New_Socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, recieveData, this);
                }
                catch (Exception)
                {
                }
            }
            public  byte[] GetRecievedData(IAsyncResult res)
            {
                int RcvByte = 0;
                try
                {
                    RcvByte = New_Socket.EndReceive(res);
                }
                catch { }
                byte[] byReturn = new byte[RcvByte];
                Array.Copy(buffer, byReturn, RcvByte);
                return byReturn;
            }
    }
}
