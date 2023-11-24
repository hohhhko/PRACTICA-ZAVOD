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
    public partial class FormCommanderWorker : Form
    {
        private SQLiteConnection DB;
        public FormCommanderWorker()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private async void FormCommanderWorker_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnetctionString);
            await DB.OpenAsync();
        }

        private void FormCommanderWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter datadapt = new SQLiteDataAdapter("SELECT * FROM Tasks", DB);
            DataSet ds = new DataSet();

            datadapt.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string task = textBox1.Text;
            string role = comboBox2.Text;
            string work = comboBox1.Text;

            if (name !="" && task !="" && role !="" && work !="")
            {
                SQLiteCommand ComIns = new SQLiteCommand($"INSERT INTO {Table_Tasks.main}(FullNameT,Task,Rolue,Workshop) " +
                    $"VALUES (@FullNameT,@Task,@Rolue,@Workshop)",DB);
                ComIns.Parameters.AddWithValue("FullNameT", name);
                ComIns.Parameters.AddWithValue("Task", task);
                ComIns.Parameters.AddWithValue("Rolue", role);
                ComIns.Parameters.AddWithValue("Workshop", work);
                await ComIns.ExecuteNonQueryAsync();

                MessageBox.Show("Добавлено");
            }
        }
    }
}
