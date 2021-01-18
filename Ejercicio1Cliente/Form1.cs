using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Cliente
{
    public partial class Form1 : Form
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public string Msg { get; set; }
        public Socket Server { get; set; }
        public IPEndPoint Ie { get; set; }
        public NetworkStream Ns { get; set; }
        public StreamReader Sr { get; set; }
        public StreamWriter Sw { get; set; }
        public bool ConnectionState { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Ip = "127.0.0.1";
            this.Port = 31416;
            InitConnection();
           
        }

        public void InitConnection() 
        {
            this.Ie = new IPEndPoint(IPAddress.Parse(this.Ip), this.Port);
            this.Server = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            try
            {
                this.Server.Connect(this.Ie);
                this.ConnectionState = true;
            }
            catch (SocketException e)
            {
                Console.WriteLine("Error connection: {0}\nError code: {1}({2})",
                e.Message, (SocketError)e.ErrorCode, e.ErrorCode);
                               return;
            }
            this.Ns = new NetworkStream(this.Server);
            this.Sr = new StreamReader(Ns);
            this.Sw = new StreamWriter(Ns);
            Msg = this.Sr.ReadLine();
            this.txtRespuesta.Text = Msg;
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            SendCommands("HORA");
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            SendCommands("FECHA");
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            SendCommands("TODO");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            SendCommands("APAGAR");
        }

        public void SendCommands(string command)
        {
            if (ConnectionState)
            {
                this.Sw.WriteLine(command);
                this.Sw.Flush();
                Msg = this.Sr.ReadLine();
                this.txtRespuesta.Text = Msg;
               
                   // EndConnection();
               
            }
        }
        public void EndConnection() 
        {
            this.txtRespuesta.Text = "Ending Connection";
            this.Sr.Close();
            this.Sw.Close();
            this.Ns.Close();
            this.Server.Close();
            ConnectionState = false;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult dialogResult = form2.ShowDialog();
            if (dialogResult == DialogResult.OK) 
            {
                this.Ip = form2.txtInternetProtocol.Text;
                this.Port = int.Parse(form2.txtPort.Text);

                this.txtRespuesta.Text = "";
               InitConnection();
               
            }
        }
    }
}
