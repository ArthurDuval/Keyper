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
    public partial class DataWindow : Form
    {
        private List<Data> ListofData { get; set; }
        private Timer pause = new Timer();

        public DataWindow()
        {
            InitializeComponent();
            ListofData = GetListofData();
            pause.Interval = 2000;
            pause.Tick += pause_Tick;
        }

        private void pause_Tick(object sender, EventArgs e)
        {
            Timer _t = sender as Timer;
            lblRefreshed.Text = "";
            _t.Stop();
        }

        public List<Data> GetListofData()
        {
            string[] lines = File.ReadAllLines(@"Database.txt");
            List<Data> list = new List<Data>();
            for (int i = 3; i + 3 <= lines.Length; i += 3)
            {
                lines[i + 1] = Encryptor.Decrypted(lines[i + 1]);
                Data data = new Data();
                data.PersonId = lines[i];
                data.Password = lines[i + 1];
                data.Description = lines[i + 2];
                list.Add(data);
            }
            return list;
        }

        private void Window2_Load(object sender, EventArgs e)
        {
            List<Data> list = this.ListofData;
            datagrid1.ReadOnly = true;
            datagrid1.DataSource = list;
            datagrid1.Columns[0].Width = 200;
            datagrid1.Columns[1].Width = 200;
            datagrid1.Columns[2].Width = 330;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            bool first_time = false;
            AddWindow addWindow = new AddWindow(first_time);
            addWindow.Show();
        }

        private void DataWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectWindow.ActiveForm.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            datagrid1.DataSource = GetListofData();
            datagrid1.Refresh();
            lblRefreshed.Text = "Refreshed";
            pause.Start();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (datagrid1.SelectedRows.Count > 0)
            {
                string[] txt_file = File.ReadAllLines(@"Database.txt");
                List<string> list = new List<string>(txt_file);
                list.RemoveRange(datagrid1.CurrentCell.RowIndex + 3, 3);
                File.WriteAllText(@"Database.txt", String.Empty);
                foreach(string var in  list)
                {
                    using (StreamWriter writer = File.AppendText(@"Database.txt"))
                    {
                        writer.WriteLine(var);
                    }
                }
            }
        }

        private void btnModifyAccount_Click(object sender, EventArgs e)
        {
            if (datagrid1.SelectedRows.Count > 0)
            {
                ModifyWindow modifyWindow = new ModifyWindow(datagrid1.CurrentCell.RowIndex, datagrid1.CurrentRow.Cells[0].Value.ToString(), datagrid1.CurrentRow.Cells[1].Value.ToString(), datagrid1.CurrentRow.Cells[2].Value.ToString());
                modifyWindow.Show();
            }
        }
    }
}
