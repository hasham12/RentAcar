using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace chat_application
{
    public partial class Form1 : Form
    {
        private WaveIn waveIn; // Gets an audio from microphone
        private WaveOut waveOut; // Sends audio to speaker
        private BufferedWaveProvider waveProvider; // Gets an audio from stream

        WaveIn obj;

        public Form1()
        {
            obj = new WaveIn();
            InitializeComponent();

         
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            waveOut = new WaveOut();
            waveIn = new WaveIn();
            waveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

            waveOut.Init(waveProvider);

            waveIn.DataAvailable += waveIn_DataAvailable;

            waveOut.Play();
        }

        private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            waveProvider.Read(e.Buffer, 0, e.BytesRecorded);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            obj.StartRecording();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            obj.StartRecording();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
