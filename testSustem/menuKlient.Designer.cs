
namespace testSustem
{
    partial class menuKlient
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
            this.testHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.testsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fullnameFieldLabel = new System.Windows.Forms.Label();
            this.loginFieldLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // testHistoryDataGrid
            // 
            this.testHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.testHistoryDataGrid.Location = new System.Drawing.Point(43, 262);
            this.testHistoryDataGrid.Name = "testHistoryDataGrid";
            this.testHistoryDataGrid.RowHeadersWidth = 51;
            this.testHistoryDataGrid.RowTemplate.Height = 24;
            this.testHistoryDataGrid.Size = new System.Drawing.Size(902, 382);
            this.testHistoryDataGrid.TabIndex = 21;
            this.testHistoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название теста";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Результат";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Затраченное время";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество баллов";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Обновить историю";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "Пройти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // testsComboBox
            // 
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Items.AddRange(new object[] {
            "БД",
            "Математика",
            "Новый тест"});
            this.testsComboBox.Location = new System.Drawing.Point(58, 145);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(887, 24);
            this.testsComboBox.TabIndex = 18;
            this.testsComboBox.SelectedIndexChanged += new System.EventHandler(this.testsComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Изменить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullnameFieldLabel
            // 
            this.fullnameFieldLabel.AutoSize = true;
            this.fullnameFieldLabel.Location = new System.Drawing.Point(628, 49);
            this.fullnameFieldLabel.Name = "fullnameFieldLabel";
            this.fullnameFieldLabel.Size = new System.Drawing.Size(46, 17);
            this.fullnameFieldLabel.TabIndex = 16;
            this.fullnameFieldLabel.Text = "label2";
            // 
            // loginFieldLabel
            // 
            this.loginFieldLabel.AutoSize = true;
            this.loginFieldLabel.Location = new System.Drawing.Point(628, 13);
            this.loginFieldLabel.Name = "loginFieldLabel";
            this.loginFieldLabel.Size = new System.Drawing.Size(54, 17);
            this.loginFieldLabel.TabIndex = 15;
            this.loginFieldLabel.Text = "label11";
            this.loginFieldLabel.Click += new System.EventHandler(this.loginFieldLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ваш логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ваше Ф.И.О:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите тест";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Панель управления";
            // 
            // menuKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 674);
            this.Controls.Add(this.testHistoryDataGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testsComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullnameFieldLabel);
            this.Controls.Add(this.loginFieldLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "menuKlient";
            this.Text = "menuKlient";
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView testHistoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox testsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fullnameFieldLabel;
        private System.Windows.Forms.Label loginFieldLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}