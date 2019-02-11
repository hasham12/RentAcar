using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace Server
{
    public partial class Form1 : Form
    {


        public void Add_Event(string MSG1)
        {
            listBox1.Items.Add(MSG1);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; 
        }


        private void Conncet_Click(object sender, System.EventArgs e)
        {
            string MSG2 = ServerChat.Start_Voice_Server(int.Parse(text_Port.Text));
            Add_Event(MSG2);
            Conncet.Enabled = false;
            DisConncet.Enabled = true;
            text_Port.Enabled = false;
        }

        private void DisConncet_Click(object sender, System.EventArgs e)
        {

            try
            {
                string MSG3 = ServerChat.ShutDown();
                Add_Event(MSG3);
            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); }
            DisConncet.Enabled = false;
            Conncet.Enabled = true;
            text_Port.Enabled = true;
        }
    }
}
