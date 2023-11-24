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
    public partial class FormMain : Form
    {
        private SQLiteConnection DB;
        public FormMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnetctionString);
            await DB.OpenAsync();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBoxName.Text;
            string Sur = TextBoxSurname.Text;

            SQLiteDataReader read;
            SQLiteCommand commandRead = new SQLiteCommand($"SELECT * FROM {Table_Emplues.main} WHERE {Table_Emplues.Login} =@Login AND {Table_Emplues.Pass} = @Pass",DB);
            commandRead.Parameters.AddWithValue("Login", Name);
            commandRead.Parameters.AddWithValue("Pass", Sur);
            read = (SQLiteDataReader)await commandRead.ExecuteReaderAsync();
            if (await read.ReadAsync())
            {
                if (read[$"{Table_Emplues.Rolue}"].ToString() == "Рабочий")
                {
                    FormWorker frm = new FormWorker();
                    frm.Show();
                    this.Hide();
                }
                else if (read[$"{Table_Emplues.Rolue}"].ToString() == "Упровляющий по цеху")
                {
                    FormMainCommander frn = new FormMainCommander();
                    frn.Show();
                    this.Hide();
                }
                read.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Рукодтсво пользователя.docx");
        }
    }
}