using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Projet_GRX_RxTx_Hedia_CSharp
{
    public partial class EcranPrincipal : Form
    {
        private SerialPort port;

        public EcranPrincipal()
        {
            InitializeComponent();
            string[] S_ports = SerialPort.GetPortNames(); //récupère la liste de ports lors de l'ouverture de l'appli et le stock dans la combobox
            foreach(string port in S_ports)
            {
                CB_serialport.Items.Add(port);
            }
        }

        private void CB_serialport_SelectedIndexChanged(object sender, EventArgs e)
        {
            B_valider.Enabled = true;
        }

        private void B_valider_Click(object sender, EventArgs e)
        {
            try
            {
                port = new SerialPort(CB_serialport.SelectedItem.ToString(), int.Parse(TB_bauds.Text), Parity.None, 8, StopBits.One); //port + baudrate + pas de parité + nombre de bit par caractères +  stopbit (selon ce que j'ai vu de l'exemple du prof)
                port.Open();

                if (port.IsOpen == false)
                {
                    MessageBox.Show("Problème lors de l'ouverture du Port :" + CB_serialport.SelectedItem.ToString(),"Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); // https://www.codegrepper.com/code-examples/csharp/c%23+error+message+box
                }
                else
                {
                    B_valider.Enabled = false;
                    B_close.Enabled = true;
                    B_envoi.Enabled = true;
                    timer.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (port.IsOpen) { TB_RX.Text += port.ReadExisting(); }
        }

        private void B_close_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Close();
                    B_valider.Enabled = true;
                    B_close.Enabled = false;
                    B_envoi.Enabled = false;
                    timer.Stop();
                    CB_serialport.Items.Clear();
                    string[] S_ports = SerialPort.GetPortNames(); //récupère la liste de ports lors de l'ouverture de l'appli et le stock dans la combobox
                    foreach (string port in S_ports)
                    {
                        CB_serialport.Items.Add(port);
                    }
                    CB_serialport.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void B_envoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Write(TB_TX.Text);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_clear_Click(object sender, EventArgs e)
        {
            TB_TX.Text = "";
            TB_RX.Text = "";
        }
    }
}
