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
            FormMainCommander frm = new FormMainCommander();
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

        private async void Button3_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter datadapt = new SQLiteDataAdapter("SELECT * FROM Tasks", DB);
            DataSet ds = new DataSet();

            datadapt.Fill(ds, "Info");
            DataGridtask.DataSource = ds.Tables[0];
            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT Workshop FROM {Table_Emplues.main}", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxWork.Items.Add((string)read["Workshop"]);
            }
            object[] items = ComboBoxWork.Items.OfType<String>().Distinct().ToArray();
            ComboBoxWork.Items.Clear();
            ComboBoxWork.Items.AddRange(items);

        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string task = TextBoxTask.Text;
            string role = "Упровляющий по цеху";
            string work = ComboBoxWork.Text;

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

        private async void DataGridTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int id_table = Convert.ToInt32(DataGridtask.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM {Table_Tasks.main} " +
                $"WHERE id = '" + id_table + "' ", DB);
                await commandDelate.ExecuteNonQueryAsync();
                MessageBox.Show("Запись удаелна", "Удалено", MessageBoxButtons.OK);
            }
        }
    }
}
