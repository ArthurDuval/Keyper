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
    public partial class ModifyWindow : Form
    {
        private int row_selected;
        public ModifyWindow(int a, string i, string p, string d)
        {
            InitializeComponent();
            if(a == 0)
            {
                a = 1;
            }
            row_selected = a;
            txtboxPersonId.Text = i;
            txtboxPassword.Text = p;
            txtboxDescription.Text = d;
        }

        public void btnModify_Click(object sender, EventArgs e)
        {
            if (txtboxPersonId.Text != String.Empty && txtboxPassword.Text != String.Empty)
            {
                if (txtboxDescription.Text == String.Empty)
                {
                    txtboxDescription.Text = " ";
                }
                txtboxPassword.Text = Encryptor.Encrypt(txtboxPassword.Text);
                string[] txt_file = File.ReadAllLines(@"Database.txt");
                txt_file[row_selected * 3] = txtboxPersonId.Text;
                txt_file[row_selected * 3 + 1] = txtboxPassword.Text;
                txt_file[row_selected * 3 + 2] = txtboxDescription.Text;
                File.WriteAllText(@"Database.txt", String.Empty);
                foreach (string var in txt_file)
                {
                    using (StreamWriter writer = File.AppendText(@"Database.txt"))
                    {
                        writer.WriteLine(var);
                    }
                }
                Close();
            }
        }
    }
}
