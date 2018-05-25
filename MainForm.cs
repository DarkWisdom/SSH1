using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SSH
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ipdbDataSet3.ip". При необходимости она может быть перемещена или удалена.
            this.ipTableAdapter1.Fill(this.ipdbDataSet3.ip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ipdbDataSet2.ip". При необходимости она может быть перемещена или удалена.
            this.ipTableAdapter.Fill(this.ipdbDataSet2.ip);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ipdbDataSet3.ip;
                ipTableAdapter1.Update(ipdbDataSet3);
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }

            ipTableAdapter1.Update(ipdbDataSet3);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            //      DataSet ds = new DataSet();
            //      DataView dv;
            //     dv = new DataView(ds.Tables[0], "type = '+"comboBox1.Text' ", "type Desc", DataViewRowState.CurrentRows);
            //     dataGridView1.DataSource = dv;


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            List<string> ip = new List<string>();
            List<string> list = new List<string>();
            List<string> pass = new List<string>();
            List<string> log = new List<string>();
            list.Add(richTextBox1.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if ((Convert.ToBoolean(row.Cells[0].Value)) == true)
                {

                    ip.Add(Convert.ToString(row.Cells[4].Value));
                    log.Add(Convert.ToString(row.Cells[5].Value));
                    pass.Add(Convert.ToString(row.Cells[6].Value));

                    //File.WriteAllText("C:/" + Convert.ToString(row.Cells[4].Value) + ".txt", Convert.ToString(row.Cells[4].Value), Encoding.UTF8);
                }

            }

            var path = "";
            

            // foreach (string ipadd in ip)
            // {
            //     File.WriteAllText("C:/" + ipadd + ".txt", ipadd, Encoding.UTF8);

            //  {"sh sw"};
            //   SshHelper ssh = new SshHelper();
           //  ssh.ExecSSH(ip, "skrebnev","E2E4knx9",list);
            ThreadHelper thr = new ThreadHelper();
           thr.ExecThread(ip, log, pass, list, path);
           // thr.

         //   }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SshHelper v 0.1");
        }
    }
}
