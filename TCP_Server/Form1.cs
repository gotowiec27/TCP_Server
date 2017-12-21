﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TcpListener serwer;
        Socket newSocket;
        private async void start_button_ClickAsync(object sender, EventArgs e)
        {
            IPAddress adresIP;
            
            try
            {
                adresIP = IPAddress.Parse(ip_box.Text);
            }
            catch
            {
                ip_box.Text = String.Empty;
                return;
            }

            int port = Convert.ToInt16(port_box.Value);
            
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();
                listBox1.Items.Add("Nasłuchiwanie rozpoczęte...");
                listBox1.Update();

                start_button.Enabled = false;
                stop_button.Enabled = true;

                newSocket = await serwer.AcceptSocketAsync();  //akceptacja klienta na kanale komunikacyjnym
                if (newSocket.Connected)
                {
                    NetworkStream ns = new NetworkStream(newSocket);
                    byte[] buf = Encoding.ASCII.GetBytes(comment_box.Text); // string zamieniamy na kod ASCII
                    ns.Write(buf, 0, buf.Length);
                    ns.Flush();  //wyzwolenie transmisji
                    ns.Close();
                }
                listBox1.Items.Add("Komunikat został wysłany!");
                listBox1.Update();
                

            }
            catch
            {
                listBox1.Items.Add("błąd transmisji..");
                listBox1.Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            newSocket.Close(); //zrywamy połączenie z klientem
            serwer.Stop();
            start_button.Enabled = true;
            stop_button.Enabled = false;
            comment_box.Text = String.Empty;
        }
    }
}
