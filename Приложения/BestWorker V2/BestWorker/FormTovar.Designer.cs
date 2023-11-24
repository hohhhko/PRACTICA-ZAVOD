
namespace BestWorker
{
    partial class FormTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTovar));
            this.DataGridTovar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.TextBoxNameTovar = new System.Windows.Forms.TextBox();
            this.DateTimePic = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxTovat = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridTovar
            // 
            this.DataGridTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTovar.Location = new System.Drawing.Point(132, 12);
            this.DataGridTovar.Name = "DataGridTovar";
            this.DataGridTovar.Size = new System.Drawing.Size(572, 183);
            this.DataGridTovar.TabIndex = 0;
            this.DataGridTovar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTovar_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonUP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "Произвдоится",
            "Произвдтсво приостановлено",
            "Остановлено до дальнейших распорежений",
            "Снят с производтсва"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(430, 220);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxStatus.TabIndex = 8;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(589, 212);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(86, 37);
            this.ButtonUpdate.TabIndex = 9;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(589, 276);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(86, 40);
            this.ButtonInsert.TabIndex = 11;
            this.ButtonInsert.Text = "Добавить";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // TextBoxNameTovar
            // 
            this.TextBoxNameTovar.Location = new System.Drawing.Point(217, 284);
            this.TextBoxNameTovar.MaxLength = 40;
            this.TextBoxNameTovar.Name = "TextBoxNameTovar";
            this.TextBoxNameTovar.Size = new System.Drawing.Size(148, 20);
            this.TextBoxNameTovar.TabIndex = 12;
            // 
            // DateTimePic
            // 
            this.DateTimePic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePic.Location = new System.Drawing.Point(414, 284);
            this.DateTimePic.Name = "DateTimePic";
            this.DateTimePic.Size = new System.Drawing.Size(137, 20);
            this.DateTimePic.TabIndex = 13;
            // 
            // ComboBoxTovat
            // 
            this.ComboBoxTovat.FormattingEnabled = true;
            this.ComboBoxTovat.Location = new System.Drawing.Point(217, 221);
            this.ComboBoxTovat.Name = "ComboBoxTovat";
            this.ComboBoxTovat.Size = new System.Drawing.Size(161, 21);
            this.ComboBoxTovat.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 64);
            this.button3.TabIndex = 15;
            this.button3.Text = "Количство производимого товара";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название нового товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Дата начала производтсва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Статус товара";
            // 
            // FormTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(716, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ComboBoxTovat);
            this.Controls.Add(this.DateTimePic);
            this.Controls.Add(this.TextBoxNameTovar);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ComboBoxStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridTovar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Производимый Товар";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTovar_FormClosed);
            this.Load += new System.EventHandler(this.FormTovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridTovar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.TextBox TextBoxNameTovar;
        private System.Windows.Forms.DateTimePicker DateTimePic;
        private System.Windows.Forms.ComboBox ComboBoxTovat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}