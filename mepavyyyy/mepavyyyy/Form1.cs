using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mepavyyyy
{
    public partial class Form1 : Form
    {
        private Server Server;
        public Form1()
        {
            InitializeComponent();
            
            results.Text = "";
            
        }

        private void Server_AddProgress(string obj)
        {
            results.Text += obj + "\n";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Server = new Server(Convert.ToInt32(channelAmount.Text));
            Server.AddProgress += Server_AddProgress;
        }
    }
}
