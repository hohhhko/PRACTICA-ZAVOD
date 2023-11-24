
namespace BestWorker
{
    partial class FormCommanderWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommanderWorker));
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridtask = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.TextBoxTask = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ComboBoxWork = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridtask)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridtask
            // 
            this.DataGridtask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridtask.Location = new System.Drawing.Point(1, 2);
            this.DataGridtask.Name = "DataGridtask";
            this.DataGridtask.Size = new System.Drawing.Size(641, 121);
            this.DataGridtask.TabIndex = 1;
            this.DataGridtask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTask_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добваить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TextBoxTask
            // 
            this.TextBoxTask.Location = new System.Drawing.Point(12, 184);
            this.TextBoxTask.Name = "TextBoxTask";
            this.TextBoxTask.Size = new System.Drawing.Size(494, 20);
            this.TextBoxTask.TabIndex = 3;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 145);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(181, 20);
            this.TextBoxName.TabIndex = 4;
            // 
            // ComboBoxWork
            // 
            this.ComboBoxWork.FormattingEnabled = true;
            this.ComboBoxWork.Location = new System.Drawing.Point(324, 144);
            this.ComboBoxWork.Name = "ComboBoxWork";
            this.ComboBoxWork.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxWork.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО Руковдителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Задача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цех";
            // 
            // FormCommanderWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(642, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ComboBoxWork);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxTask);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataGridtask);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommanderWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню Главного по цеху";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCommanderWorker_FormClosed);
            this.Load += new System.EventHandler(this.FormCommanderWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridtask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridtask;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextBoxTask;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.ComboBox ComboBoxWork;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}