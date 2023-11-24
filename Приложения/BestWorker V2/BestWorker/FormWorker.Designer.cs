
namespace BestWorker
{
    partial class FormWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ButtonSerach = new System.Windows.Forms.Button();
            this.DataGridWork = new System.Windows.Forms.DataGridView();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonQuestion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWork)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 257);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(89, 33);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ButtonSerach
            // 
            this.ButtonSerach.Location = new System.Drawing.Point(450, 223);
            this.ButtonSerach.Name = "ButtonSerach";
            this.ButtonSerach.Size = new System.Drawing.Size(75, 40);
            this.ButtonSerach.TabIndex = 2;
            this.ButtonSerach.Text = "Найти";
            this.ButtonSerach.UseVisualStyleBackColor = true;
            this.ButtonSerach.Click += new System.EventHandler(this.ButtonSerach_Click);
            // 
            // DataGridWork
            // 
            this.DataGridWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWork.Location = new System.Drawing.Point(115, 1);
            this.DataGridWork.Name = "DataGridWork";
            this.DataGridWork.Size = new System.Drawing.Size(576, 210);
            this.DataGridWork.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(12, 22);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(87, 50);
            this.ButtonUpdate.TabIndex = 4;
            this.ButtonUpdate.Text = "Показать задачи";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonQuestion
            // 
            this.ButtonQuestion.Location = new System.Drawing.Point(596, 236);
            this.ButtonQuestion.Name = "ButtonQuestion";
            this.ButtonQuestion.Size = new System.Drawing.Size(75, 54);
            this.ButtonQuestion.TabIndex = 5;
            this.ButtonQuestion.Text = "Вопросы и события";
            this.ButtonQuestion.UseVisualStyleBackColor = true;
            this.ButtonQuestion.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 270);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск задачи или руководителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цех";
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(693, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonQuestion);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.DataGridWork);
            this.Controls.Add(this.ButtonSerach);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ButtonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню Рабочего";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWorker_FormClosed);
            this.Load += new System.EventHandler(this.FormWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButtonSerach;
        private System.Windows.Forms.DataGridView DataGridWork;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}