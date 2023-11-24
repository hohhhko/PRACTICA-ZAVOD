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

            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT WorkShop FROM {Table_Emplues.main}", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                comboBox1.Items.Add((string)read["WorkShop"]);
            }
            object[] items = comboBox1.Items.OfType<String>().Distinct().ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(items);
            
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
            DataGridWork.DataSource = ds.Tables[0];
        }

        private void ButtonSerach_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter daadtp = new SQLiteDataAdapter($"SELECT * FROM Tasks WHERE Workshop = '{comboBox1.Text}'", DB);
            DataSet dt = new DataSet();

            daadtp.Fill(dt, "Info");
            DataGridWork.DataSource = dt.Tables[0];
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FormQuestin frm = new FormQuestin();
            frm.Show();
            frm.CheckedList.Items.RemoveAt(2);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) 
        {
            DataGridWork.ClearSelection();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            var values = textBox1.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < DataGridWork.RowCount - 1; i++)
            {
                foreach (string value in values)
                {
                    var row = DataGridWork.Rows[i];

                    if (row.Cells["FullNameT"].Value.ToString().Contains(value) || 
                        row.Cells["Task"].Value.ToString().Contains(value))                  
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }
    }
}