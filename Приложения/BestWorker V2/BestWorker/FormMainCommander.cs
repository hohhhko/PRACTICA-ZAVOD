using System;
using System.Windows.Forms;

namespace BestWorker
{
    public partial class FormMainCommander : Form
    {
        public FormMainCommander()
        {
            InitializeComponent();
        }
        #region action
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }
        private void FormMainCommander_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonQuestion_Click(object sender, EventArgs e)
        {
            FormCommanderWorker frm = new FormCommanderWorker();
            frm.Show();
            this.Hide();
        }

        private void ButtonTovar_Click(object sender, EventArgs e)
        {
            FormTovar frm = new FormTovar();
            frm.Show();
            this.Hide();
        }

        private void ButtonQuestin_Click(object sender, EventArgs e)
        {
            FormQuestin frm = new FormQuestin();
            frm.Show();
        }
        #endregion
    }
}
