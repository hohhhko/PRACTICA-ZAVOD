using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BestWorker
{
    public partial class FormWorker : Form
    {
        private SQLiteConnection DB;
        public FormWorker()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private async void FormWorker_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnetctionString);
            await DB.OpenAsync();
        }

        private void FormWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter datadapt = new SQLiteDataAdapter("SELECT * FROM Tasks", DB);
            DataSet ds = new DataSet();

            datadapt.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ButtonSerach_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter daadtp = new SQLiteDataAdapter($"SELECT * FROM Tasks WHERE Workshop = '{comboBox1.Text}'", DB);
            DataSet dt = new DataSet();

            daadtp.Fill(dt, "Info");
            dataGridView1.DataSource = dt.Tables[0];
        }
    }
}
