using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guldkortet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            Thread thread = new Thread(new ThreadStart(server.listen));
            thread.Start();
            button1.BackColor = Color.Green;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}
