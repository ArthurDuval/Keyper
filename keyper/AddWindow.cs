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
    public partial class AddWindow : Form
    {
        public AddWindow(bool first_time)
        {
            InitializeComponent();
            if(first_time)
            {
                this.Text = "1st Time";
                lblPersonId.Text = "Username";
                lblDescription.Hide();
                txtboxDescription.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtboxPersonId.Text != String.Empty && txtboxPassword.Text != String.Empty)
            {
                if(txtboxDescription.Text == String.Empty)
                {
                    txtboxDescription.Text = " ";
                }
                string[] tab_string = { txtboxPersonId.Text, txtboxPassword.Text, txtboxDescription.Text };
                using (StreamWriter writer = File.AppendText(@"Database.txt"))
                {
                    for(int i = 0; i < 3; i++)
                    {
                        if(i % 3 == 1)
                        {
                            writer.WriteLine(Encryptor.Encrypt(tab_string[i]));
                        }
                        else
                        {
                            writer.WriteLine(tab_string[i]);
                        }
                    }
                    Close();
                }
            }
        }
    }
}
