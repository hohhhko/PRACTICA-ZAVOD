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
    public partial class FormTovar : Form
    {
        private SQLiteConnection DB;
        public FormTovar()
        {
            InitializeComponent();
        }

        private void ButtonUP_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM Tovar", DB);
            DataSet ds = new DataSet();

            adpt.Fill(ds, "Info");
            DataGridTovar.DataSource = ds.Tables[0];
        }

        private async void FormTovar_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnetctionString);
            await DB.OpenAsync();

            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT NameTovar FROM {Table_Tovar.main}", DB);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            while (await read.ReadAsync())
            {
                ComboBoxTovat.Items.Add((string)read["NameTovar"]);
            }

            object[] items = ComboBoxTovat.Items.OfType<String>().Distinct().ToArray();
            ComboBoxTovat.Items.Clear();
            ComboBoxTovat.Items.AddRange(items);
        }

        private void FormTovar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormMainCommander frm = new FormMainCommander();
            frm.Show();
            this.Hide();
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string status = ComboBoxStatus.Text;
            string tovar = ComboBoxTovat.Text;

            SQLiteCommand CommUp = new SQLiteCommand($"UPDATE Tovar " +
            $"SET Status = '{status}' " +
            $"WHERE NameTovar = '{tovar}'",DB);
            await CommUp.ExecuteNonQueryAsync();
            MessageBox.Show("Статус изменнен","Обнавлено",MessageBoxButtons.OK);

            ComboBoxTovat.Text = "";
            ComboBoxStatus.Text = "";
        }

        private async void ButtonInsert_Click(object sender, EventArgs e)
        {
            string name = TextBoxNameTovar.Text;
            string date = DateTimePic.Text;

            SQLiteCommand ComIns = new SQLiteCommand($"INSERT INTO {Table_Tovar.main}(NameTovar,DateOfMake,Status) " +
            $"VALUES (@NameTovar,@DateOfMake,@Status)",DB);
            ComIns.Parameters.AddWithValue("NameTovar", name);
            ComIns.Parameters.AddWithValue("DateOfMake", date);
            ComIns.Parameters.AddWithValue("Status", "Произвдоится");
            await ComIns.ExecuteNonQueryAsync();

            MessageBox.Show("Добвалено", "Успех", MessageBoxButtons.OK);

            TextBoxNameTovar.Text = "";
        }

        private async void DataGridTovar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int id_table = Convert.ToInt32(DataGridTovar.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM {Table_Tovar.main} " +
                $"WHERE id = '" + id_table + "' ", DB);
                await commandDelate.ExecuteNonQueryAsync();
                MessageBox.Show("Запись удаелна", "Удалено", MessageBoxButtons.OK);
            }
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT count(*) FROM Tovar " +
            "WHERE Status = 'Произвдоится'", DB);
            DataSet ds = new DataSet();

            adpt.Fill(ds, "Info");
            DataGridTovar.DataSource = ds.Tables[0];
        }
    }
}