using System;
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
    public partial class TCP_Server : Form
    {
        public TCP_Server()
        {
            InitializeComponent();
        }
        private TcpListener server;
        Socket newSocket;
        int random_port;
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

            int port = Convert.ToInt32(port_box.Value);
            
            try
            {
                server = new TcpListener(adresIP, port);
                server.Start();
                listBox1.Items.Add("Nasłuchiwanie rozpoczęte...");
                listBox1.Update();

                start_button.Enabled = false;
                stop_button.Enabled = true;

                newSocket = await server.AcceptSocketAsync();
                while (newSocket.Connected)
                {
                    NetworkStream ns = new NetworkStream(newSocket);
                    byte[] buf = Encoding.ASCII.GetBytes(comment_box.Text);
                    ns.Write(buf, 0, buf.Length);
                    ns.Flush();
                    ns.Close();
                    listBox1.Items.Add("Komunikat został wysłany!");
                    listBox1.Update();
                    newSocket.Close();
                }
                
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                listBox1.Items.Add("błąd transmisji..");
                listBox1.Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            random_port = random.Next(1023,50000);
            port_box.Value = random_port;
            stop_button.Enabled = false;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
                server.Stop();
                start_button.Enabled = true;
                stop_button.Enabled = false;
                comment_box.Text = String.Empty;
          
        }
    }
}
