using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Keyper
{
    public partial class ConnectWindow : Form
    {
        public ConnectWindow()
        {
            InitializeComponent();
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"Database.txt");
            if (txtboxUsername.Text == lines[0] && txtboxPassword.Text == Encryptor.Decrypted(lines[1]))
            {
                DataWindow dataWindow = new DataWindow();
                dataWindow.Show();
                Hide();
            }
        }

        private void ConnectWindow_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"Database.txt");
            if (lines.Length == 0)
            {
                bool first_time = true;
                AddWindow first_connection_Window = new AddWindow(first_time);
                first_connection_Window.Show();
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
