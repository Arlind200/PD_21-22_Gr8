﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                // You can start any process, HelloWorld is a do-nothing example.
                myProcess.StartInfo.FileName = "C:\\Users\\HP\\source\\repos\\DetyraSemestrale\\UDPaudio\\MicSend\\MicSend\\bin\\Debug\\MicRecieveUDP.exe";
                myProcess.StartInfo.CreateNoWindow = false;
                myProcess.Start();
                // This code assumes the process you are starting will terminate itself.
                // Given that is is started without a window so you cannot terminate it
                // on the desktop, it must terminate itself or you can do it programmatically
                // from this application using the Kill method.

            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }

        }

        private void Client_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                // You can start any process, HelloWorld is a do-nothing example.
                myProcess.StartInfo.FileName = "C:\\Users\\HP\\source\\repos\\DetyraSemestrale\\UDPaudio\\MicReciever\\MicReciever\\bin\\Debug\\MicSendUDP.exe";
                myProcess.StartInfo.CreateNoWindow = false;
                myProcess.Start();
                // This code assumes the process you are starting will terminate itself.
                // Given that is is started without a window so you cannot terminate it
                // on the desktop, it must terminate itself or you can do it programmatically
                // from this application using the Kill method.

            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }
    }
}
