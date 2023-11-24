using System;
using System.Data;
using System.Drawing;
using Tulpep.NotificationWindow;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BestWorker
{
    public partial class FormQuestin : Form
    {
        private SQLiteConnection DB;
        public FormQuestin()
        {
            InitializeComponent();
        }
        private async void FormQuestin_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnetctionString);
            await DB.OpenAsync();
        }

        private void FormQuestin_FormClosed(object sender, FormClosedEventArgs e)
        {
            string lis = "Обявить событие";

            this.Hide();
            CheckedList.Items.Add(lis);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM QuestionAndEvents", DB);
            DataSet ds = new DataSet();

            adpt.Fill(ds, "Info");
            DataGridQuest.DataSource = ds.Tables[0];
        }

        private void CheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelctedIndex();
        }

        private async void ButtonInsrt_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string instr = TextBoxInsert.Text;

            if (name != "" && instr != "")
            {
                SQLiteCommand inst = new SQLiteCommand($"INSERT INTO {Table_QuestionAndEvents.main} (FullNameQ,Question,Answer,Event) " +
                $"VALUES (@FullNameQ,@Question,@Answer,@Event)", DB);
                inst.Parameters.AddWithValue("FullNameQ", name);
                inst.Parameters.AddWithValue("Question", instr);
                inst.Parameters.AddWithValue("Answer", "-");
                inst.Parameters.AddWithValue("Event", "-");
                await inst.ExecuteNonQueryAsync();

                MessageBox.Show("Добвалено", "Успех", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Не все поля завполнены", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private async void ButtonAnswer_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string answ = TextBoxAnswer.Text;

            if (name != "" && answ != "")
            {
                SQLiteCommand Update = new SQLiteCommand($"UPDATE QuestionAndEvents " +
                 $"SET Answer = '{answ}' " +
                 $"WHERE FullNameQ = '{name}'", DB);
                await Update.ExecuteNonQueryAsync();

                MessageBox.Show("Ответ отпрвален", "Успех", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Не все поля завполнены или такого человека нет", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private async void ButtonEvent_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string evet = TextBoxEvent.Text;

            if (name  !="" && evet !="")
            {
                SQLiteCommand inst = new SQLiteCommand($"INSERT INTO {Table_QuestionAndEvents.main} (FullNameQ,Question,Answer,Event) " +
               $"VALUES (@FullNameQ,@Question,@Answer,@Event)", DB);
                inst.Parameters.AddWithValue("FullNameQ", name);
                inst.Parameters.AddWithValue("Question", "-");
                inst.Parameters.AddWithValue("Answer", "-");
                inst.Parameters.AddWithValue("Event", evet);
                await inst.ExecuteNonQueryAsync();

                popuo();
            }
            else
            {
                MessageBox.Show("Не все поля завполнены", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private async void DataGridQuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                int id_table = Convert.ToInt32(DataGridQuest.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM {Table_QuestionAndEvents.main} " +
                $"WHERE id = '" + id_table + "' ", DB);
                await commandDelate.ExecuteNonQueryAsync();
                MessageBox.Show("Запись удаелна", "Удалено", MessageBoxButtons.OK);
            }
        }
        #region viod
        private void SelctedIndex()
        {
            if (CheckedList.SelectedIndex == 0)
            {
                TextBoxAnswer.Visible = true;
                ButtonAnswer.Visible = true;

                TextBoxInsert.Visible = false;
                ButtonInsrt.Visible = false;

                TextBoxEvent.Visible = false;
                ButtonEvent.Visible = false;
            }
            else if (CheckedList.SelectedIndex == 1)
            {
                TextBoxAnswer.Visible = false;
                ButtonAnswer.Visible = false;

                TextBoxInsert.Visible = true;
                ButtonInsrt.Visible = true;

                TextBoxEvent.Visible = false;
                ButtonEvent.Visible = false;
            }
            else if (CheckedList.SelectedIndex == 2)
            {
                TextBoxAnswer.Visible = false;
                ButtonAnswer.Visible = false;

                TextBoxInsert.Visible = false;
                ButtonInsrt.Visible = false;

                TextBoxEvent.Visible = true;
                ButtonEvent.Visible = true;
            }
        }
        private void popuo()
        {
            string name = TextBoxName.Text;
            string evet = TextBoxEvent.Text;

            PopupNotifier popup = new PopupNotifier
            {
                TitleColor = Color.Red,
                BodyColor = Color.DarkSeaGreen,
                TitleText = $"ОБЬЯВЛЕНИЕ от {name}",
                ContentText = $"{evet} "
            };
            popup.Popup();
        }
        #endregion
    }
}