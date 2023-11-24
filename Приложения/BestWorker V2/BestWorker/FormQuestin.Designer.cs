
namespace BestWorker
{
    partial class FormQuestin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestin));
            this.DataGridQuest = new System.Windows.Forms.DataGridView();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonAnswer = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxAnswer = new System.Windows.Forms.TextBox();
            this.TextBoxEvent = new System.Windows.Forms.TextBox();
            this.ButtonEvent = new System.Windows.Forms.Button();
            this.ButtonInsrt = new System.Windows.Forms.Button();
            this.TextBoxInsert = new System.Windows.Forms.TextBox();
            this.CheckedList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridQuest
            // 
            this.DataGridQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridQuest.Location = new System.Drawing.Point(22, 12);
            this.DataGridQuest.Name = "DataGridQuest";
            this.DataGridQuest.Size = new System.Drawing.Size(567, 217);
            this.DataGridQuest.TabIndex = 1;
            this.DataGridQuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridQuest_CellContentClick);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(595, 12);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(81, 39);
            this.ButtonUpdate.TabIndex = 2;
            this.ButtonUpdate.Text = "Обновить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonAnswer
            // 
            this.ButtonAnswer.Location = new System.Drawing.Point(345, 247);
            this.ButtonAnswer.Name = "ButtonAnswer";
            this.ButtonAnswer.Size = new System.Drawing.Size(84, 50);
            this.ButtonAnswer.TabIndex = 3;
            this.ButtonAnswer.Text = "Ответить";
            this.ButtonAnswer.UseVisualStyleBackColor = true;
            this.ButtonAnswer.Click += new System.EventHandler(this.ButtonAnswer_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(49, 266);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(119, 20);
            this.TextBoxName.TabIndex = 4;
            // 
            // TextBoxAnswer
            // 
            this.TextBoxAnswer.Location = new System.Drawing.Point(184, 266);
            this.TextBoxAnswer.MaxLength = 100;
            this.TextBoxAnswer.Name = "TextBoxAnswer";
            this.TextBoxAnswer.Size = new System.Drawing.Size(123, 20);
            this.TextBoxAnswer.TabIndex = 5;
            // 
            // TextBoxEvent
            // 
            this.TextBoxEvent.Location = new System.Drawing.Point(184, 266);
            this.TextBoxEvent.MaxLength = 100;
            this.TextBoxEvent.Name = "TextBoxEvent";
            this.TextBoxEvent.Size = new System.Drawing.Size(123, 20);
            this.TextBoxEvent.TabIndex = 7;
            // 
            // ButtonEvent
            // 
            this.ButtonEvent.Location = new System.Drawing.Point(345, 247);
            this.ButtonEvent.Name = "ButtonEvent";
            this.ButtonEvent.Size = new System.Drawing.Size(84, 51);
            this.ButtonEvent.TabIndex = 8;
            this.ButtonEvent.Text = "Обявить";
            this.ButtonEvent.UseVisualStyleBackColor = true;
            this.ButtonEvent.Click += new System.EventHandler(this.ButtonEvent_Click);
            // 
            // ButtonInsrt
            // 
            this.ButtonInsrt.Location = new System.Drawing.Point(345, 247);
            this.ButtonInsrt.Name = "ButtonInsrt";
            this.ButtonInsrt.Size = new System.Drawing.Size(84, 51);
            this.ButtonInsrt.TabIndex = 9;
            this.ButtonInsrt.Text = "Задать вопрос";
            this.ButtonInsrt.UseVisualStyleBackColor = true;
            this.ButtonInsrt.Click += new System.EventHandler(this.ButtonInsrt_Click);
            // 
            // TextBoxInsert
            // 
            this.TextBoxInsert.Location = new System.Drawing.Point(184, 266);
            this.TextBoxInsert.MaxLength = 100;
            this.TextBoxInsert.Name = "TextBoxInsert";
            this.TextBoxInsert.Size = new System.Drawing.Size(123, 20);
            this.TextBoxInsert.TabIndex = 10;
            // 
            // CheckedList
            // 
            this.CheckedList.CheckOnClick = true;
            this.CheckedList.FormattingEnabled = true;
            this.CheckedList.Items.AddRange(new object[] {
            "Ответить",
            "Задать вопрос",
            "Обявить событие"});
            this.CheckedList.Location = new System.Drawing.Point(451, 242);
            this.CheckedList.Name = "CheckedList";
            this.CheckedList.Size = new System.Drawing.Size(126, 49);
            this.CheckedList.TabIndex = 11;
            this.CheckedList.SelectedIndexChanged += new System.EventHandler(this.CheckedList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя с фамилией";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Требуемый текс";
            // 
            // FormQuestin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(688, 310);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckedList);
            this.Controls.Add(this.TextBoxInsert);
            this.Controls.Add(this.ButtonInsrt);
            this.Controls.Add(this.ButtonEvent);
            this.Controls.Add(this.TextBoxEvent);
            this.Controls.Add(this.TextBoxAnswer);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonAnswer);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.DataGridQuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuestin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вопросы и события";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuestin_FormClosed);
            this.Load += new System.EventHandler(this.FormQuestin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridQuest;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonAnswer;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxAnswer;
        private System.Windows.Forms.TextBox TextBoxEvent;
        private System.Windows.Forms.Button ButtonEvent;
        private System.Windows.Forms.Button ButtonInsrt;
        private System.Windows.Forms.TextBox TextBoxInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckedListBox CheckedList;
    }
}