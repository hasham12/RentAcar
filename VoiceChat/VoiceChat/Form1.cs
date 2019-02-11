using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Networks;

namespace VoiceChat
{
    public partial class Form1 : Form
    {
        private Socket ClientSocket;
        private DirectSoundHelper sound;
        private byte[] buffer = new byte[2205];
        private Thread th;


        public Form1()
        {
            InitializeComponent();
        }

        void Connect(string ServerIP, int Port)
        {
            try
            {
                if (ClientSocket != null && ClientSocket.Connected)
                {
                    ClientSocket.Shutdown(SocketShutdown.Both);
                    System.Threading.Thread.Sleep(10);
                    ClientSocket.Close();
                }

                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint Server_EndPoint = new IPEndPoint(IPAddress.Parse(ServerIP), Port);
                ClientSocket.Blocking = false;

                ClientSocket.BeginConnect(Server_EndPoint, new AsyncCallback(IsConnect), ClientSocket);

                th = new Thread(new ThreadStart(sound.StartCapturing));
                th.IsBackground = true;
                th.Start();
            }
            catch (Exception) { }
        }

        //Client Come Auto
        public void IsConnect(IAsyncResult ar)
        {
            Socket socker = (Socket)ar.AsyncState;

            try
            {
                if (socker.Connected)
                {
                    CallbackRecieveSetup(socker);
                    JoinBTN.Enabled = false;
                    StartTalkingBTN.Enabled = true;
                }
                else
                {
                    Disconncet();
                    JoinBTN.Enabled = true;
                    StartTalkingBTN.Enabled = false;
                    MessageBox.Show("Connection Failed");
                }
            }
            catch (Exception) { }
        }

        void BufferSender(byte[] buffer)
        {
            ClientSocket.Send(buffer, SocketFlags.None);
        }

        public void OnDataRecieved(IAsyncResult res)
        {
            Socket sock = (Socket)res.AsyncState;

            try
            { //store state and any user define data
                int RecByte = sock.EndReceive(res);
                if (RecByte > 0)
                {
                    sound.PlayReceivedVoice(buffer);

                    CallbackRecieveSetup(sock);
                }
                else
                {
                    sock.Shutdown(SocketShutdown.Both);
                    sock.Close();
                }
            }
            catch (Exception) { }
        }

        public void CallbackRecieveSetup(Socket sock)
        {
            try
            {
                AsyncCallback RcvData = new AsyncCallback(OnDataRecieved);
                sock.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, RcvData, sock);
            }
            catch (Exception) { }
        }

        void Disconncet()
        {
            try
            {
                if (ClientSocket != null & ClientSocket.Connected)
                {
                    ClientSocket.Close();
                }
            }
            catch (Exception) { }
        }

        private void JoinBTN_Click(object sender, EventArgs e)
        {
            Connect(ServerIPTXT.Text, 5000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sound = new DirectSoundHelper();
            sound.OnBufferFulfill += new EventHandler(SendVoiceBuffer);
        }

        void SendVoiceBuffer(object VoiceBuffer, EventArgs e)
        {
            byte[] Buffer = (byte[])VoiceBuffer;

            BufferSender(Buffer);

        }

        private void StartTalkingBTN_Click(object sender, EventArgs e)
        {
            sound.StopLoop = false;

            StartTalkingBTN.Enabled = false;
            StopTalkingBTN.Enabled = true;
        }

        private void StopTalkingBTN_Click(object sender, EventArgs e)
        {
            sound.StopLoop = true;

            StartTalkingBTN.Enabled = true;
            StopTalkingBTN.Enabled = false;
        }

    }
}
